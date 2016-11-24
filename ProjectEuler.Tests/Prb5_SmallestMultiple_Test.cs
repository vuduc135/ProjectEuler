using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Prb5_SmallestMultiple_Test
    {
        [Test]
        public void SmallestMultiple_TestMethod(int exclusive, int expected)
        {
            var slm = new Prb5_SmallestMultiple();
            var result = slm.GetSmallestMultiple(exclusive);
            
            Assert.AreEqual(result, expected, "Function rerturned a different value");
        }
    }
}
