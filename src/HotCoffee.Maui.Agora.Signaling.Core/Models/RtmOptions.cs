using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffee.Maui.Agora.Signaling.Core.Models
{
    public sealed class RtmOptions
    {
        public required string AppId { get; init; }
        public required string UserId { get; init; }
        public string? Token { get; init; }
        public bool EnableLogging { get; init; } = false;
    }
}
