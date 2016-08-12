using System;
using System.Drawing;

namespace MyLibrary
{
    public interface ICar
    {
        void Start();
        void PressAcellerator(double howFar);
        void PressBrake(double pressure);
        string Make { get; }
        string Model { get; }
        int Year { get; }
        Color Color { get; }

        event EventHandler CarStopped;
    }
}
