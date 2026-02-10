using HotCoffee.Maui.Agora.Signaling.Core.Models;
using Org.W3c.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
