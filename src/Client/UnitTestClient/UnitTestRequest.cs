using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestClient
{
    [TestClass]
    public class UnitTestRequest
    {
        [TestMethod]
        public void TestRequest()
        {
            Microservices_Client.UserRequest testRequest = new Microservices_Client.UserRequest();
            string res = testRequest.SendRequest("user", "12345", 1, 2);
            Assert.AreEqual(res, "Hi: user. Your service from: 1 to: 2 was received. You will get a message to: 12345;");
        }
    }
}
