using HotCoffee.Maui.Agora.Signaling.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffee.Maui.Agora.Signaling.Core.Abstractions
{
    public interface IRtmPlatformStrategy
    {
        Task InitializeAsync(RtmOptions options, IRtmEventSink sink);
        Task LoginAsync();
        Task LogoutAsync();
        Task SendMessageAsync(string channel, string message);
    }
}
