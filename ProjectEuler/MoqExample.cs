using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEuler
{
    public class MoqExample
    {
        public interface IVehicle
        {
            int BHP { get; set; }
            bool HasWheels { get; }
            int Wheels { get; }

            bool Move();
        }

        public abstract class Vehicle : IVehicle
        {
            public int BHP { get; set; }

            public bool HasWheels
            {
                get { return Wheels > 0; }
            }

            public abstract int Wheels { get; }

            public string WhoYouGonnaCall
            {
                get { return "Ghostbusters"; }
            }

            public abstract bool Move();
        }
    }
}