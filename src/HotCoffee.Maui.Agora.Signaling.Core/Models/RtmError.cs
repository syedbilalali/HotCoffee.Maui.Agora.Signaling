namespace HotCoffee.Maui.Agora.Signaling.Core.Models
{
    /// <summary>
    /// Represents an error occurred in the RTM SDK.
    /// </summary>
    public sealed class RtmError
    {
        public RtmError(int code, string? message = null)
        {
            Code = code;
            Message = message ?? "Unknown error";
        }

        /// <summary>
        /// Numeric error code.
        /// </summary>
        public int Code { get; }

        /// <summary>
        /// Optional human-readable error message.
        /// </summary>
        public string Message { get; }

        public override string ToString() => $"[{Code}] {Message}";
    }
}
