using Android.Service.Autofill;
using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using Java.Lang;
using System.Diagnostics;

namespace HotCoffee.Maui.Agora.Signaling.EventListeners
{
    public class RtmEventListener : Java.Lang.Object, IRtmEventListener, IDisposable
    {
        private readonly IRtmEventSink? eventSink = default(IRtmEventSink);
        public RtmEventListener(IRtmEventSink? rtmEventSink)
        {

            eventSink = rtmEventSink;
        }

        void IRtmEventListener.OnPresenceEvent(PresenceEvent? e)
        {
            eventSink?.OnPresenceEvent( new Core.Models.RtmPresenceEvent( "",e?.EventType.Name()));
            Debug.WriteLine("IRtmEventListener.OnPresenceEvent invoked" + e?.EventType);
        }

        [Override]
        void IRtmEventListener.OnMessageEvent(MessageEvent? e)
        {
            eventSink.OnMessageReceived(new Core.Models.RtmMessage(e.ChannelName, e.PublisherId, e.Message.ToString()));
            Debug.WriteLine("IRtmEventListener.OnMessageEvent invoked" + e?.ChannelName);
        }
        void IRtmEventListener.OnConnectionStateChanged(string? channelName, RtmConstants.RtmConnectionState? state, RtmConstants.RtmConnectionChangeReason? reason)
        {
          
        }

        void IRtmEventListener.OnStorageEvent(StorageEvent? e)
        {
            Debug.WriteLine("IRtmEventListener.OnStorageEvent invoked" + e?.ChannelType);
        }

        void IRtmEventListener.OnLinkStateEvent(LinkStateEvent? e)
        {
            Debug.WriteLine("IRtmEventListener.OnMessageEvent invoked" + e?.CurrentState);
        }
    }
}
