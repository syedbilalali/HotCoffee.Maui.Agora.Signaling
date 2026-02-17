using HotCoffee.Maui.Agora.Signaling.Core.Models;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    /// <summary>
    /// It provides a unified contract for initializing the RTM client, authenticating users, managing channel subscriptions, and sending messages.
    /// </summary>
    public interface IRtmPlatformStrategy : IDisposable
    {   
        Task InitializeAsync(RtmOptions options, IRtmEventSink sink);
        Task LoginAsync(string token, IRtmResultCallback resultCallback);
        Task LogoutAsync(IRtmResultCallback resultCallback);
        Task SendMessageAsync(string channel, string message, IRtmResultCallback resultCallback);
        Task Subscribe(string channelName , IRtmResultCallback resultCallback);
        Task Unsubscribe(string channelName , IRtmResultCallback resultCallback);
    }
}
