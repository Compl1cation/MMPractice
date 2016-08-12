using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower ct = ControlTower.Instance;
            ct.Airplanes = new List<IAirplane>(){ new Boeing_737() { FuelRemaining = 90 },
                new Boeing_737() { FuelRemaining = 140},
                new Canadair_CRJ700() {FuelRemaining = 100 },
                new Cessna_560XL() {FuelRemaining = 75},
                new Boeing_747() {FuelRemaining= 300},
                new Cessna_560XL() {FuelRemaining= 10}
            };

            foreach (IAirplane plane in ct.Airplanes)
            {
                plane.LowFuel += new EventHandler(ct.Redirect);
            }
            
            while (ct.Airplanes.Any())
            {
                for (int i = 0; i < ct.Airplanes.Count; i++)
                {
                    ct.Airplanes[i].OnLowFuel();
                }
                ct.GetLowestFuelPlane(ct.Airplanes);
                ct.LandPlane();
                ct.RecalculateRemainingFuel(ct.TimeElapsed);
                Console.WriteLine();
            }
        }
    }
}
