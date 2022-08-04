using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCase;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private AdditionNum program = new AdditionNum();
        [TestMethod]
        public void TestMethod1()
        {
            program = new AdditionNum();
            var result = program.Add(5, 10);
            Assert.AreEqual(15, result);
        }
    }
}