﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class InvalidTokenException : Exception
    {
        public InvalidTokenException() { 
        }

        public InvalidTokenException(string message) : base(message) { }
    }
}
