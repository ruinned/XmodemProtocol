﻿using System;

namespace XModemProtocol {
    public class CRCException : ApplicationException {
        public CRCException(string message ) : base(message) { }
    }
}