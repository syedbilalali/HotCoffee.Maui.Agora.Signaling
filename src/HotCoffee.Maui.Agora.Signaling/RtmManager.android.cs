using HotCoffee.Maui.Agora.Signaling.Primitives;

namespace HotCoffee.Maui.Agora.Signaling
{
    sealed partial class RtmManager
    {
        private partial void PlatformInit(string appId, string userId)
        {
            RtmConfig? config = new RtmConfig.Builder(appId, userId).Build();

            config.Log
        }
    }
}
