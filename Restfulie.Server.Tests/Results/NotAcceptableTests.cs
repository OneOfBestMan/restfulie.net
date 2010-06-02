﻿using NUnit.Framework;
using Restfulie.Server.Results;

namespace Restfulie.Server.Tests.Results
{
    [TestFixture]
    public class NotAcceptableTests
    {

        [Test]
        public void ShouldReturnStatusCode406()
        {
            var result = new NotAcceptable();

            Assert.AreEqual((int)StatusCodes.NotAcceptable, result.StatusCode);
        }
    }
}
