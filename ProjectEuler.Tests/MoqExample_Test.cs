using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class MoqExample_Test
    {        
        [Test]
        public void IVehicle_Move()
        {
            var moqExample = new MoqExample();
            var vehicle = moqExample.Vehicle;
            //int wheels = vehicle.Object.Wheels;

            //Assert.IsTrue(wheels == 0);

            vehicle.Setup(t => t.Wheels).Returns(4);
            vehicle.Setup(t => t.Move()).Callback(() => Console.WriteLine("Move was called"));

            int wheels = vehicle.Object.Wheels;

            Assert.IsTrue(wheels == 0);
            vehicle.Verify(t => t.Move(), Times.Exactly(1));
        }        

        [Test]
        public void Vehicle_Move()
        {
            Mock vehicle = new Mock();
            int wheels = vehicle.Object.Wheels;
            Assert.IsTrue(wheels == 0 );
        }

        [Test]
        public void Vehicle_WhoYouGonnaCall()
        {
            Mock vehicle = new Mock();

            string gonnaCall = vehicle.Object.WhoYouGonnaCall;

            Assert.AreEqual(gonnaCall, "Ghostbusters");
        }
    }
}
