using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
   public class Husky : Dog
    {
        public string Groomer { get; set; }
        public string Growls()
        {
            string growl = "Growlll";
            Console.WriteLine(growl);
            return growl;
        }
    }
}
