using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using HotCoffee.Maui.Agora.Signaling.Core.Models;
using HotCoffee.Maui.Agora.Signaling.Primitives;

namespace HotCoffee.Maui.Agora.Signaling
{
    public sealed partial class RtmManager : IRtmPlatformStrategy, IDisposable
    {
        #region Fields 
        const string appIdEmptyMessage = "You must pass the appId to initialise the RtmManager";
        #endregion

        #region Platform Declarations Methods
        private partial void PlatformInit(string appId, string userId, IRtmEventSink eventSink);
        private partial Task<bool> PlatformLoginAsync(string token, IRtmResultCallback resultCallback);
        private partial Task<bool> PlatformSubscribe(string channelName, IRtmResultCallback resultCallback);
        private partial Task PlatformUnsubscribe(string channelName, IRtmResultCallback resultCallback);
        private partial Task PlatformLogout(IRtmResultCallback resultCallback);
        private partial Task PlatformSendMessageAsync(string channel, string message, IRtmResultCallback resultCallback);
        private partial void PlatformDispose();
        #endregion

        #region Interface Implementation Methods
        public Task InitializeAsync(RtmOptions options, IRtmEventSink sink)
        {
            if (string.IsNullOrEmpty(options.AppId)) throw new RtmException(appIdEmptyMessage);
            PlatformInit(options.AppId, options.UserId, sink);

            return Task.CompletedTask;
        }
        public Task SendMessageAsync(string channel, string message, IRtmResultCallback resultCallback) => PlatformSendMessageAsync(channel, message, resultCallback);
        public Task LoginAsync(string token, IRtmResultCallback resultCallback) =>  PlatformLoginAsync(token, resultCallback);
        public Task LogoutAsync(IRtmResultCallback resultCallback) => PlatformLogout(resultCallback);
        public Task Subscribe(string channelName, IRtmResultCallback resultCallback) => PlatformSubscribe(channelName, resultCallback);
        public Task Unsubscribe(string channelName, IRtmResultCallback resultCallback) => PlatformUnsubscribe(channelName, resultCallback);
        public void Dispose() => PlatformDispose();
        #endregion
    }
}
