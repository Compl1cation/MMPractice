using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircrafts
{
   public class LowFuelEventArgs : EventArgs
    {
     public  Airplane plane { get; set; }
    }
}
