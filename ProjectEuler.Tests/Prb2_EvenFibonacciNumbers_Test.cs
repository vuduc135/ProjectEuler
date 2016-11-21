using System.Linq;
using System.Linq.Expressions;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Prb2_EvenFibonacciNumbers_Test
    {
        [Test]
        [TestCase(3,2)]
        [TestCase(4, 6)]
        [TestCase(10, 19)]
        [TestCase(4000000, 3382)]
        public void Sum_Of_Even_Valued_Terms_TestMethod(int exclusiveUpper, int expectedSum)
        {
            var efn = new Prb2_EvenFibonacciNumbers(); // Call to even fibonacci numbers
            int sum = efn.Sum_Of_Even_Valued_Terms(exclusiveUpper);
            
            //return expectedSum;
            Assert.AreEqual(sum, expectedSum, "The Function returned a different value.");
        }

        [Test]
        [TestCase(2,new[] {1,2} )]
        [TestCase(3, new[] {1,2,3} )]
        [TestCase(4, new[] { 1, 2, 3 })]
        [TestCase(5, new[] { 1, 2, 3, 5 })]
        [TestCase(10, new[] { 1,2,3,5,8 })]
        public void Find_Fibonacci_Sequence_TestMethod(int inclusive, int[] expectedItem)
        {
            var efn = new Prb2_EvenFibonacciNumbers();
            var items = efn.Find_Fibonacci_Sequence(inclusive);

            CollectionAssert.AreEqual(items.ToArray(),expectedItem.ToArray(), "The Function returned a different values.");
        }
    }
}
