﻿using MaxLifx.Payload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLifx.Payload
{
    public class GetLabelPayload : IPayload
    {
        private byte[] _messageType = new byte[2] { 23, 0 };
        public byte[] MessageType { get { return _messageType; } }

        public byte[] GetPayload()
        {
            return new byte[0];
        }
    }
}
