using HotCoffee.Maui.Agora.Signaling.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    public interface IRtmClient
    {
        Task InitializeAsync(RtmOptions options, CancellationToken ct = default);

        Task LoginAsync(CancellationToken ct = default);

        Task LogoutAsync(CancellationToken ct = default);

        Task SendMessageAsync(
            string channel,
            string message,
            CancellationToken ct = default);

        event EventHandler<RtmMessage>? MessageReceived;
        event EventHandler<RtmConnectionStateChanged>? ConnectionStateChanged;
        event EventHandler<RtmPresenceEvent>? PresenceReceived;
    }
}
