using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    interface IAirplane
    {
        void CalculateRemainingFuel(int timeElapsed);
        string Name { get; }
        double Weight { get; }
        double FuelCapacity{ get; }
        double FuelRemaining { get; set; }
        int MaxPassangers { get; }
        double FuelConsumptionPerHour { get; }
        int LandingTime { get; }
        void OnLowFuel();
        void Land();

        event EventHandler LowFuel;
    }
}
