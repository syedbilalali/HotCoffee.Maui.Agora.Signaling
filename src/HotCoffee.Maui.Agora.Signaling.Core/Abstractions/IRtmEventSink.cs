using HotCoffee.Maui.Agora.Signaling.Core.Models;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    public interface IRtmEventSink
    {
        void OnMessageReceived(RtmMessage message);
        void OnConnectionStateChanged(
            RtmConnectionState current,
            RtmConnectionState previous);
        void OnPresenceEvent(RtmPresenceEvent presence);
        void OnError(RtmError error);
    }
}