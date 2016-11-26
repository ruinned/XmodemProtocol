﻿namespace XModemProtocol.Communication {
    using System.Collections.Generic;
    using System.Linq;
    using System.IO.Ports;
    public class Communicator : ICommunicator {

        SerialPort _port;

        public Communicator(SerialPort port) {
            _port = port;
        }

        public virtual int BytesInReadBuffer => _port.BytesToRead;

        public virtual void Flush() {
            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
        }

        public virtual List<byte> ReadAllBytes() {
            List<byte> byteList = new List<byte>();
            byte[] byteArray;
            do {
                int bytesToRead = _port.BytesToRead;
                byteArray = new byte[bytesToRead];
                _port.Read(byteArray, 0, bytesToRead);
                byteList.AddRange(byteArray);
                System.Threading.Tasks.Task.Delay(10); 
            } while (_port.BytesToRead > 0);
            return byteList;
        }

        public virtual void Write(IEnumerable<byte> buffer) {
            byte[] bufferArray = buffer.ToArray();
            _port.Write(bufferArray, 0, bufferArray.Length);
        }

        public virtual void Write(byte buffer) {
            _port.Write(new byte[] { buffer }, 0, 1);
        }

        public virtual byte ReadSingleByte() {
            return (byte) _port.ReadByte();
        }
    }
}