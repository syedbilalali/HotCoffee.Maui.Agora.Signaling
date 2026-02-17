
using HotCoffee.Maui.Agora.Signaling.Core.Abstractions;
using HotCoffee.Maui.Agora.Signaling.EventListeners;

namespace HotCoffee.Maui.Agora.Signaling
{
    sealed partial class RtmManager
    {
        private static RtmClient? client;
        private partial void PlatformInit(string appId, string userId, IRtmEventSink eventSink)
        {
            try
            {
                RtmConfig? config = new RtmConfig.Builder(appId, userId)
                        .UseStringUserId(true)
                        ?.EventListener(new RtmEventListener(eventSink))
                        ?.Build();

                client = RtmClient.Create(config);

                client?.CreateStreamChannel("hello");

             //   client.Presence.GetOnlineUsers("",)



            }
            catch (Exception ex)
            {

            }
        }

        private partial Task<bool> PlatformLoginAsync(string token, IRtmResultCallback resultCallback)
        {
            client?.Login(token, new ResultCallback(resultCallback));
            return Task.FromResult(true);
        }

        private partial Task<bool> PlatformSubscribe(string channelName, IRtmResultCallback resultCallback)
        {
            var tcs = new TaskCompletionSource<bool>();
            try
            {
                SubscribeOptions options = new SubscribeOptions();
                options.WithMessage = true;
                options.WithPresence = true;
                options.WithMetadata = true;
             //   options.WithLock = true;
                client?.Subscribe(channelName, options, new ResultCallback(resultCallback));
                tcs.SetResult(true);
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }
            return tcs.Task;
        }
        private partial void PlatformDispose() => client?.Dispose();
        private partial Task PlatformLogout(IRtmResultCallback resultCallback)
        {
            if (client == null)
                return Task.FromResult(false);

            client.Logout(new ResultCallback(resultCallback));

            client.Dispose();

            return Task.FromResult(true);
        }
        private partial Task PlatformUnsubscribe(string channelName, IRtmResultCallback resultCallback)
        {
            if (client == null)
                return Task.FromResult(false);

            client.Unsubscribe(channelName, new ResultCallback(resultCallback));

            return Task.FromResult(true);
        }

        private partial Task PlatformSendMessageAsync(string channel, string message, IRtmResultCallback resultCallback)
        {   
            PublishOptions publishOptions = new PublishOptions();
            publishOptions.SetChannelType(RtmConstants.RtmChannelType.User);
            publishOptions.CustomType = string.Empty;

            client?.Publish(channel, message, publishOptions, new ResultCallback(resultCallback));
            return Task.FromResult(false);
        }
    }
}
