using System;

namespace Aircrafts
{
    public delegate void EventHandler(object sender, LowFuelEventArgs args);

    public abstract class Airplane : IAirplane
    {  
        public Airplane(string name, double weight, double fuelConsumptionPerHour, int landingTime, double fuelCapacity, int maxPassangers )
        {
            Name = name;
            Weight = weight;
            FuelConsumptionPerHour = fuelConsumptionPerHour;
            LandingTime = landingTime;
            FuelCapacity = fuelCapacity;
            MaxPassangers = maxPassangers;
        }
        public Airplane()
        {
        }
        public virtual void CalculateRemainingFuel(int timeElapsed)
        {
            FuelRemaining -= Math.Round(((timeElapsed / 60.0) * FuelConsumptionPerHour),2);
        }

        public virtual void Land(int _landingTime)
        {
            Console.WriteLine("Plane {0} Recieved Land Request, will take {1} minutes", Name, _landingTime);
        }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public double FuelCapacity { get; private set; }
        public double FuelRemaining { get; set; }
        public double FuelConsumptionPerHour { get; private set; }
        public int MaxPassangers { get; private set; }
        public int LandingTime { get; private set; }

        public virtual void OnLowFuel()
        {
            if (FuelRemaining <= (FuelCapacity / 10.0))
            {
                Console.WriteLine();
                Console.WriteLine("{0} is reporting low fuel to ControlTower", Name);
                FireLowFuelEvent();
            }
        }
        public virtual event EventHandler LowFuel;
        protected void FireLowFuelEvent()
        {
            LowFuel?.Invoke(this, new LowFuelEventArgs() { plane = this});
        }

    }
}
