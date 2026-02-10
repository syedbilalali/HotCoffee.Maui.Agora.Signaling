using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCoffee.Maui.Agora.Signaling.Core.Models
{
    /// <summary>
    /// Event arguments for connection state changes.
    /// </summary>
    public sealed class RtmConnectionStateChanged
    {
        public RtmConnectionStateChanged(
            RtmConnectionState currentState,
            RtmConnectionState previousState)
        {
            CurrentState = currentState;
            PreviousState = previousState;
        }

        /// <summary>
        /// The current connection state.
        /// </summary>
        public RtmConnectionState CurrentState { get; }

        /// <summary>
        /// The previous connection state.
        /// </summary>
        public RtmConnectionState PreviousState { get; }
    }
}
