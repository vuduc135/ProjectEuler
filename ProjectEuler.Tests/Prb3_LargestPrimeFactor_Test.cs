using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Prb3_LargestPrimeFactor_Test
    {
        // Method for testing a number is a prime
        [Test]
        [TestCase(1,false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, true)]
        [TestCase(5, true)]
        [TestCase(6, true)]
        [TestCase(100, true)]
        [TestCase(101, true)]
        [TestCase(13195, true)]
        public void Is_Prime_Number_TestMethod(int number, bool expectedResult)
        {
            var lpf = new Prb3_LargestPrimeFactor();
            //var number = 2;
            var isPrimeNumber = lpf.Is_Prime_Number(number);
            Assert.AreEqual(isPrimeNumber, expectedResult, "This number is not a prime number");
        }

        [Test]
        [TestCase(5,new[] {5})]
        [TestCase(2, new[] { 2 })]
        [TestCase(3, new[] { 3 })]
        [TestCase(4, new[] { 4 })]
        [TestCase(6, new[] { 2,3 })]
        [TestCase(7, new[] { 7 })]
        [TestCase(8, new[] { 2 })]
        [TestCase(9, new[] { 3 })]
        [TestCase(10, new[] { 2,5 })]
        [TestCase(12, new[] { 2,3 })]
        [TestCase(13195, new[] { 2, 3 })]
        [TestCase(600851475143, new long[] {2,3})]
        public void Prime_Factor_TestMethod(long number, long[] expectedPrimesFactor)
        {           
            var lpf = new Prb3_LargestPrimeFactor();
            var primesFactor = lpf.Find_Prime_Factor(number);
            //var expectedPrimesFactor = new List<int> { 5, 7 };

            Assert.AreEqual(primesFactor.ToArray(),expectedPrimesFactor.ToArray(),"Function returned different values");
        }

        [Test]
        [TestCase(8, 2)]        
        [TestCase(9, 3)]
        [TestCase(10, 5)]
        [TestCase(13195, 29)]
        [TestCase(600851475143, 6857)]
        public void Largest_Prime_Factor_TestMethod(long number, long expectedLargestPrimesFactor)
        {
            var lpf = new Prb3_LargestPrimeFactor();
            long largestPrimesFactor = lpf.Find_Prime_Factor(number).Last();

            Assert.AreEqual(largestPrimesFactor, expectedLargestPrimesFactor, "Function returned a different value");
        }
    }
}
