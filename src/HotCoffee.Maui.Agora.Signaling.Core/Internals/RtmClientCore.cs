using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using HotCoffee.Maui.Agora.Signaling.Core.Models;

namespace HotCoffee.Maui.Agora.Signaling.Core.Internals
{
    internal sealed class RtmClientCore : IRtmClient, IRtmEventSink
    {

        private readonly IRtmPlatformStrategy _platform;

        public RtmClientCore(IRtmPlatformStrategy platform)
        {
            _platform = platform;
        }
        public event EventHandler<RtmMessage>? MessageReceived;
        public event EventHandler<RtmConnectionStateChanged>? ConnectionStateChanged;
        public event EventHandler<RtmPresenceEvent>? PresenceReceived;

        public Task InitializeAsync(RtmOptions options, CancellationToken ct = default)
        => _platform.InitializeAsync(options, this);

        public Task LoginAsync(CancellationToken ct = default)
        => _platform.LoginAsync();

        public Task LogoutAsync(CancellationToken ct = default)
        => _platform.LogoutAsync();

        public void OnConnectionStateChanged(RtmConnectionState current, RtmConnectionState previous)
         => ConnectionStateChanged?.Invoke(
            this,
            new(current, previous));


        public void OnError(RtmError error)
        {
            throw new NotImplementedException();
        }

        public void OnMessageReceived(RtmMessage message)
       => MessageReceived?.Invoke(this, message);

        public void OnPresenceEvent(RtmPresenceEvent presence)
          => PresenceReceived?.Invoke(this, presence);

        public Task SendMessageAsync(string channel, string message, CancellationToken ct = default)
        => _platform.SendMessageAsync(channel, message);
    }
}
