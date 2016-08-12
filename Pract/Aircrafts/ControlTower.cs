using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
 sealed class ControlTower
    {
        private static volatile ControlTower _instance;
        private static object syncRoot = new Object();
        private ControlTower() { }
        public static ControlTower Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new ControlTower();
                    }
                }
                return _instance;
            }
        }
        public IAirplane GetLowestFuelPlane(List<IAirplane> planes)
        {
            LowestFuelPlane = planes.Aggregate((i1, i2) => i1.FuelRemaining < i2.FuelRemaining ? i1 : i2);
            Console.WriteLine();
            Console.WriteLine("Plane with lowest fuel is:{0}", LowestFuelPlane.Name);
            return LowestFuelPlane;
        }
        public void LandPlane(IAirplane plane)
        {
            TimeElapsed = plane.LandingTime;
            Airplanes.Remove(plane);
            Console.WriteLine("LANDED Airplane {0}, TimeElapsed= {1}", plane, TimeElapsed);
        }

        public void RecalculateRemainingFuel(int timeElapsed)
        {
            timeElapsed = TimeElapsed;
            foreach (IAirplane plane in Airplanes)
            {
                plane.CalculateRemainingFuel(timeElapsed);
                Console.WriteLine("Plane {0} new remaining fuel: {1} Liters, after {2} minutes elapsed", plane.Name, plane.FuelRemaining, timeElapsed);
            }
        }
        public List<IAirplane> Airplanes { get; set; }
        public IAirplane LowestFuelPlane { get; set; }
        public int TimeElapsed { get; set; }

        public void Redirect(object sender, LowFuelEventArgs args)
        {
            Console.WriteLine("Recieved low fuel alert from airplane {0}, Redirecting and removing form list", args.plane);
            Airplanes.Remove(args.plane);
        }
    }
}
