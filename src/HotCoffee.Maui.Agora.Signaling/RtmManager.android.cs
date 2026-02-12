
using HotCoffee.Maui.Agora.Signaling.EventListeners;
using System.Diagnostics.Tracing;

namespace HotCoffee.Maui.Agora.Signaling
{
    sealed partial class RtmManager
    {
        private static RtmClient? client;
        private partial void PlatformInit(string appId, string userId)
        {
            System.Diagnostics.Debug.Write(" Android Init ");
            try
            {
                RtmConfig? config = new RtmConfig.Builder(appId, userId)
                        ?.EventListener(new RtmEvenListener())
                        ?.Build();

                client = RtmClient.Create(config);
            }
            catch (Exception ex)
            {
                
            }
        }

        private partial Task<bool> PlatformLoginAsync(string token)
        {
            client.Login(token , );


            return Task.FromResult(false);
        }
    }
}
