
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerMath;

namespace Euler3.tests
{
    [TestClass]
    public class Euler3Tests
    {
        [TestMethod]
        public void TestResult()
        {
            long expected = 6857;
            long actual = Algorithms.HighestPrimeFactor(600851475143 );
            Assert.AreEqual(expected, actual);
        }
    }
}
