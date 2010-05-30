﻿namespace Restfulie.Server.Results
{
    public class PreConditionFailed : RestfulieResult
    {
        public PreConditionFailed() {}
        public PreConditionFailed(string message) : base(message){}

        protected override int StatusCode
        {
            get { return (int) StatusCodes.PreConditionFailed; }
        }
    }
}
