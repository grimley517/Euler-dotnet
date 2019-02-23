using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerMath;
using System.Collections.Generic;
using System.IO;
using System;
using System.Diagnostics;

namespace Math.tests
{
    [TestClass]
    public class MathAlgorithmPrimeTests
    {
        List<int> LowPrimes {get; set; } = new List<int>{1,2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89, 97, };

        [TestMethod]
        public void CompositeNumbersUnder10ShowHighestPrimeFactor(){
            Dictionary<int, int> TestDict = new Dictionary<int, int>{
                {4, 2},
                {6, 3},
                {8, 2},
                {9, 3},
                {10, 5}
            };
            foreach (var pair in TestDict){
                int highestFactor = (int)Algorithms.HighestPrimeFactor(pair.Key);
                Assert.AreEqual(pair.Value, highestFactor, $"{pair.Key} should have highest prime factor {pair.Value}, but {highestFactor} was found");
            }
            
        }

        [TestMethod]
        public void PrimeNumbersUnder10ShowHighestPrimeFactor(){
            Dictionary<int, int> TestDict = new Dictionary<int, int>{
                {2, 1},
                {3, 1},
                {5, 1},
                {7, 1}
            };
            foreach (var pair in TestDict){
                int highestFactor = (int)Algorithms.HighestPrimeFactor(pair.Key);
                Assert.AreEqual(pair.Value, highestFactor, $"{pair.Key} should have highest prime factor {pair.Value}, but {highestFactor} was found");
            }
            
        }

        [TestMethod]
        public void NumbersUnder100AllHavePredicableNumbers(){
            for (long i=2; i< 200; i++){
                long highestFactor = Algorithms.HighestPrimeFactor(i);
                Assert.IsTrue(LowPrimes.Contains((int)highestFactor), $"The number {i} has a highest primefactor that is not in the list -> {highestFactor}");
            }            
        }

    }
}