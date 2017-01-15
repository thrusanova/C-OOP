﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadio.Exceptions
{
   public class InvalidSongLengthException:InvalidSongException
    { 
        public new const string Message = "Invalid song length.";
        public InvalidSongLengthException() : base(Message)
        {
        }
        public InvalidSongLengthException(string message) : base(message)
        {
        }
    }
}
