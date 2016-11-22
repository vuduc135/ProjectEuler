using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Prb4_LargestPalindromeProduct_Test
    {
        [Test]
        [TestCase(9009, true)]
        [TestCase(9019, false)]
        [TestCase(90109, true)]
        public void IsPalindromeNumber_TestMethod(int number, bool expectedResult)
        {
            var lpd = new Prb4_LargestPalindromeProduct();
            var result = lpd.IsPalindromeNumber(number);            
            Assert.AreEqual(result,expectedResult, "Function returned a different value");
        }

        [Test]
        [TestCase(1,99)]
        [TestCase(2,9009)]
        [TestCase(3, 9009)]
        public void PalindromeNumbersList_TestMethod(int digit, int palindromeNumberExpected)
        {
            var lpd = new Prb4_LargestPalindromeProduct();
            var result = lpd.PalindromeNumbersList(digit);
            Assert.AreEqual(result, palindromeNumberExpected, "Function returned a different value");
        }
    }
}
