using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
    interface IControlTower
    {
        IAirplane GetLowestFuelPlane(List<IAirplane> planes);
        void LandPlane();
        void RecalculateRemainingFuel(int timeElapsed);
        List<IAirplane> Airplanes { get; }
        IAirplane LowestFuelPlane { get; }
        int TimeElapsed { get; }
        void Redirect(object sender, LowFuelEventArgs args);
      }
}
