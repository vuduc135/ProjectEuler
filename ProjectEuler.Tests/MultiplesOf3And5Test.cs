using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class MultiplesOf3And5Test
    {
        [Test]
        [TestCase(10,23)]
        [TestCase(10, 22)]
        [TestCase(10, 24)]
        [TestCase(100, 280)]
        [TestCase(1000, 2318)]
        [TestCase(1000, 233168)]
        public void Sum_Of_Multiples_TestMethod(int exclusiveUpper, int expectedSum)
        {                       
            // value from function 
            var actual = new MultiplesOf3And5();
            int sum = actual.Sum_Of_Multiples(exclusiveUpper);
                        
            Assert.AreEqual(sum, expectedSum, "The Sum function returned a different value");

        }
    }
}
