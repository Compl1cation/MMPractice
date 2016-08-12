using System;
using System.Drawing;

namespace MyLibrary
{
    public class Hooptie : Car
    {
        public Hooptie():base("Cadillac", "Coupe deVille", 1958, Color.Yellow)
        {
        }
        public static double minPressureToStart = 9;
        public static double minPressureToStop = 5;
        public override void PressAcellerator(double howFar)
        {
            if (howFar < minPressureToStart)
                Console.WriteLine("Nothing happens");
            else Console.WriteLine("Cough!");
        }

        public override void PressBrake(double pressure)
        {
            if (pressure < minPressureToStop)
                Console.WriteLine("Squeek");
            else Console.WriteLine("Grrriiiinnnddd");
        }

        public override void Start()
        {
            Console.WriteLine("Click click click");
        }
    }
}
