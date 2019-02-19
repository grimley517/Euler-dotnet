using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerMath;
using System.Collections.Generic;

namespace Math.tests
{
    [TestClass]
    public class MathAlgorithmTests
    {
        [TestMethod]
        public void TestSumOfSequenceTo10()
        {
            int expected = 55;
            int calculated = (int)Algorithms.SumSequence(10);
            Assert.AreEqual(expected, calculated);
        }

        [TestMethod]
        public void TestKnownFiboNumbers(){
            Dictionary<int, int> TestDict = new Dictionary<int, int>{
                {0, 1},
                {1, 2},
                {2, 3},
                {3, 5},
                {4, 8},
                {5, 13}

            };
            foreach (var item in TestDict)
            {
                int expected = item.Value;
                int actual = Algorithms.Fibo(item.Key);
                Assert.AreEqual(expected, actual);
            }

        }
    }
}
