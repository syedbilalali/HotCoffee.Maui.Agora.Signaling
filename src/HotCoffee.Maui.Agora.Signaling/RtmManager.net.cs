using HotCoffee.Maui.Agora.Signaling.Primitives;

namespace HotCoffee.Maui.Agora.Signaling
{
    sealed partial class RtmManager
    {
        const string notSupportedMessage = "RtmManger is only supported on net-ios and net-android";
        private partial void PlatformInit(string appId, string userId) => throw new FeatureNotSupportedException(notSupportedMessage);

        private partial Task<bool> PlatformLoginAsync(string token) => throw new FeatureNotSupportedException(notSupportedMessage);
    }
}
