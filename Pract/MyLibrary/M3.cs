using System;
using System.Drawing;

namespace MyLibrary
{
    public class M3 : Car
    {
        public M3() : base("BMW", "M3", 2008, Color.Sienna)
        {
        }
        public override void PressAcellerator(double howFar)
        {
            Console.WriteLine("Car accelerating");
        }

        public override void PressBrake(double pressure)
        {
            Console.WriteLine("Car slowing down");
            FireCarstoppedEvent();
        }

        public override void Start()
        {
            Console.WriteLine("Car started");
        }
    }
}
