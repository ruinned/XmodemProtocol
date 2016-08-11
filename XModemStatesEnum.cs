﻿namespace XModemProtocol {
    /// <summary>
    /// The enumeration that represents the internal state of the XModemCommunicator instance.
    /// </summary>
    public enum XModemStates {
        /// <summary>
        /// The default state.
        /// </summary>
        Idle,
        /// <summary>
        /// Notes that XModemCommunicator has begun initializing.
        /// </summary>
        Initializaing,
        /// <summary>
        /// The instance is in the Sender role. Awaiting initialization from Receiver.
        /// </summary>
        SenderAwaitingInitializationFromReceiver,
        /// <summary>
        /// The instance is in the Sender role. Actively sending packets.
        /// </summary>
        SenderPacketsBeingSent,
        /// <summary>
        /// The instance is in the Sender role. EOT has been sent. Awaiting acknowledgment.
        /// </summary>
        SenderAwaitingFinalACKFromReceiver,
    }
}