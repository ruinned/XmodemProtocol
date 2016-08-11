﻿using System;
using System.Collections.Generic;

namespace XModemProtocol {
    /// <summary>
    /// The event data for the PacketsBuilt event.
    /// </summary>
    public class PacketsBuiltEventArgs : EventArgs {
        /// <summary>
        /// The new count of packets.
        /// </summary>
        public List<List<byte>> Packets { get; private set; }

        public PacketsBuiltEventArgs(List<List<byte>> packets) {
            Packets = new List<List<byte>>(packets);
        }
    }
}