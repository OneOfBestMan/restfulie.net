﻿using System;

namespace Restfulie.Server.Results
{
    public class UnsupportedMediaType : RestfulieResult
    {
        public UnsupportedMediaType() {}
        public UnsupportedMediaType(string message) : base(message) {}

        public override int StatusCode
        {
            get { return (int) StatusCodes.UnsupportedMediaType; }
        }
    }
}
