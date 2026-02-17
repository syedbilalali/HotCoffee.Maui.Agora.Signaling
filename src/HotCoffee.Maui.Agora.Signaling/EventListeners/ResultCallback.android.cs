using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using Java.Lang;
using System.Diagnostics;

namespace HotCoffee.Maui.Agora.Signaling.EventListeners
{
    internal class ResultCallback : Java.Lang.Object, IResultCallback, IDisposable
    {
        private readonly IRtmResultCallback _callback;
        public ResultCallback(IRtmResultCallback resultCallback)
        {
            _callback = resultCallback;
        }

        public void OnFailure(ErrorInfo? errorInfo)
        {
            _callback?.OnFailure(new Core.Models.RtmError(errorInfo.ErrorCode.Ordinal(), errorInfo.ErrorReason));
            Debug.WriteLine("ResultCallback.OnFailure Invoked");
        }

        [Override]
        public void OnSuccess(global::Java.Lang.Object? responseInfo)
        {
            _callback.OnSuccess(responseInfo?.ToNetObject<System.Object>());
            Debug.WriteLine("ResultCallback.OnSuccess Invoked");
        }
    }
    
}