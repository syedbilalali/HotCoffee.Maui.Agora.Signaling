using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;

namespace HotCoffee.Maui.Agora.Signaling
{
    sealed partial class RtmManager
    {
        const string notSupportedMessage = "RtmManger is only supported on net-ios and net-android";
        private partial void PlatformInit(string appId, string userId, IRtmEventSink eventSink) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task<bool> PlatformLoginAsync(string token, IRtmResultCallback resultCallback) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task<bool> PlatformSubscribe(string channelName, IRtmResultCallback resultCallback) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial void PlatformDispose() => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task PlatformLogout(IRtmResultCallback resultCallback) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task PlatformUnsubscribe(string channelName, IRtmResultCallback resultCallback) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task PlatformSendMessageAsync(string channel, string message, IRtmResultCallback resultCallback) => throw new FeatureNotSupportedException(notSupportedMessage);

    }
}