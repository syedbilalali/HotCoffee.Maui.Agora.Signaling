using HotCoffee.Maui.Agora.Signaling.Primitives;

namespace HotCoffee.Maui.Agora.Signaling
{
    public sealed partial class RtmManager
    {

        const string appIdEmptyMessage = "You must pass the appId to initialise the RtmManager";
        public void Init(string appId, string userId)
        {
            if (string.IsNullOrEmpty(appId)) throw new RtmException(appIdEmptyMessage);

            PlatformInit(appId, userId);
        }

        private partial void PlatformInit(string appId, string userId);
    }
}
