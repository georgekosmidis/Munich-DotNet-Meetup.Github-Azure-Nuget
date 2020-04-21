using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace meetup.tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void SayHelloTest()
        {
            var result = HelloWorld.SayHello();
            Assert.AreEqual("Hello World!", result);
        }
    }
}
