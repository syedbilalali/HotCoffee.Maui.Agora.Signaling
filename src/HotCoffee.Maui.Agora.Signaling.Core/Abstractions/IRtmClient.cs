using HotCoffee.Maui.Agora.Signaling.Core.Models;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    public interface IRtmClient
    {
        Task InitializeAsync(RtmOptions options, CancellationToken ct = default);

        Task LoginAsync(string token,IRtmResultCallback resultCallback,CancellationToken ct = default);

        Task LogoutAsync(IRtmResultCallback resultCallback ,CancellationToken ct = default);

        Task SendMessageAsync(
            string channel,
            string message,
            IRtmResultCallback resultCallback,CancellationToken ct = default);

        event EventHandler<RtmMessage>? MessageReceived;
        event EventHandler<RtmConnectionStateChanged>? ConnectionStateChanged;
        event EventHandler<RtmPresenceEvent>? PresenceReceived;

        Task Subscribe(string channelName, IRtmResultCallback resultCallback);
        Task Unsubscribe(string channelName, IRtmResultCallback resultCallback);
    }
}
