using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffee.Maui.Agora.Signaling.Core.Models
{
    public sealed record RtmPresenceEvent(
    string UserId,
    string EventType
    );
}
