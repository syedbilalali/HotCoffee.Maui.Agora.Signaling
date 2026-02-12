using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using HotCoffee.Maui.Agora.Signaling.Core.Models;
using HotCoffee.Maui.Agora.Signaling.Primitives;

namespace HotCoffee.Maui.Agora.Signaling
{
    public sealed partial class RtmManager : IRtmPlatformStrategy, IDisposable
    {
        const string appIdEmptyMessage = "You must pass the appId to initialise the RtmManager";
        public Task InitializeAsync(RtmOptions options, IRtmEventSink sink)
        {
            if (string.IsNullOrEmpty(options.AppId)) throw new RtmException(appIdEmptyMessage);
            PlatformInit(options.AppId, options.UserId);

            return Task.CompletedTask;
        }

        public Task LoginAsync()
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task SendMessageAsync(string channel, string message)
        {
            throw new NotImplementedException();
        }

        private partial void PlatformInit(string appId, string userId);

        private partial Task<bool> PlatformLoginAsync(string token);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
