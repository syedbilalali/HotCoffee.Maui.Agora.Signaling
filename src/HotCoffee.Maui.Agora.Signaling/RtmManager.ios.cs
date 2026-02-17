using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;


namespace HotCoffee.Maui.Agora.Signaling
{
    public partial class RtmManager
    {
        private partial void PlatformInit(string appId, string userId, IRtmEventSink eventSink)
        {

        }
        private partial Task<bool> PlatformLoginAsync(string token, IRtmResultCallback resultCallback)
        {
            return Task.FromResult(false);
        }
        private partial Task<bool> PlatformSubscribe(string channelName, IRtmResultCallback resultCallback)
        {
            return Task.FromResult(false);
        }
        private partial void PlatformDispose()
        {

        }
        private partial Task PlatformLogout(IRtmResultCallback resultCallback)
        {
            return Task.FromResult(false);
        }
        private partial Task PlatformUnsubscribe(string channelName, IRtmResultCallback resultCallback)
        {
            return Task.FromResult(false);
        }
        private partial Task PlatformSendMessageAsync(string channel, string message, IRtmResultCallback resultCallback) { return Task.FromResult(false); }

    }
}
