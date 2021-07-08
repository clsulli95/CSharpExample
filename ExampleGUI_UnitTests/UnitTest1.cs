using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleEngine;

namespace ExampleGUI_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IEngine engine = new MyEngineAdapter();
            Assert.IsTrue(engine.StartApplication());
        }

        [TestMethod]
        public void TestMethod2()
        {
            IEngine engine = new MyEngineAdapter();
            Assert.IsTrue(engine.QuitApplication());
        }
    }
}
