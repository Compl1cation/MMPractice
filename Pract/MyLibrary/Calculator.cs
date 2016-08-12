using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;


namespace MyLibrary
{

        [XmlRoot("calc")]
        public class Calculator
        {
        [XmlElement("sum", DataType = "double")]
        public double Sum { get; set; }
        public static int UsageCount { get; private set; }
        public void Add(double a)
        {
            ++UsageCount;
            Sum += a;
        }
        private double sum;
        public Calculator(double value)
        {
            sum = value;
        }
        public Calculator() :this(0)
        {
        }
        public double Add(double a, double b)
            {
                return a + b;
            }
        public double ComputePi(int numDecimalPlaces, out TimeSpan duration)
        {
            duration = TimeSpan.FromSeconds(20);
            return 3.14;
        }
        public double AddTheseNumbers(params double[] array)
        {
            double sum = 0.0;
            foreach (double element in array)
            {
                sum += element;
            }
            Console.WriteLine("Array sum = {0}", sum);
            return sum;
        }
    }
}
