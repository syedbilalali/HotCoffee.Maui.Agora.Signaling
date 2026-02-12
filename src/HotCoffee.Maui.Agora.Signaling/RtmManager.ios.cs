using System.Diagnostics;


namespace HotCoffee.Maui.Agora.Signaling
{
    public partial class RtmManager
    {
        private  partial void PlatformInit(string appId, string userId)
        {
            Debug.Write(" IOS Init ");

        }
        private partial Task<bool> PlatformLoginAsync(string token)
        {
            return Task.FromResult(false);
        }
    }
}
