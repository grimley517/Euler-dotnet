using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace euler1.tests
{
    [TestClass]
    public class Euler1tests
    {
        [TestMethod]
        public void TestStatedAnswer()
        {
            int expected = 23;
            var prob = new Problem1(10);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToTwenty()
        {
            // threes: 3,6,9,12,15, 18 => 63
            // fives: 5, 10, 15 => 30
            // Subtotal => 93
            // Remove 15 counted twice => 78
            int expected = 78; 
            var prob = new Problem1(20);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestToThirty()
        {
            // threes: 3,6,9,12,15, 18, 21, 24, 27 => 135
            // fives: 5, 10, 15, 20, 25,=> 75
            // Subtotal => 210
            // Remove 15 counted twice => 195
            int expected = 195; 
            var prob = new Problem1(30);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }

                [TestMethod]
        public void TestToThousand()
        {
            //Problem spec
            int expected = 233168; 
            var prob = new Problem1(1000);
            int actual = (int) prob.Resolve();
            Assert.AreEqual(expected, actual);
        }
    }
}
