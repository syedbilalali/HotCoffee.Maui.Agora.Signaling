using HotCoffee.Maui.Agora.Signaling.Core.Models;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    public interface IRtmResultCallback
    {
        void OnFailure(RtmError error);
        void OnSuccess(System.Object? responseInfo);

    }
}
