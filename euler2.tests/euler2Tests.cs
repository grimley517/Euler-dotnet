using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace euler1.tests
{
    [TestClass]
    public class Euler2tests
    {
        [TestMethod]
        public void TestTo10()
        {
            int expected = 10;
            var prob = new Problem2(10);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTo100()
        {
            //Next term will be even, checks for out by one error
            int expected = 44; 
            var prob = new Problem2(100);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTo4Mil()
        {
            //Problem as per spec
            int expected = 4613732; 
            var prob = new Problem2(4000000);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }
    }
}
