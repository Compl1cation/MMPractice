using System;
using MyLibrary;
using System.Drawing;

namespace Pract
{
    delegate int NumberChanger(int n);
    class Program
    {
        static void PrintCarInfo(ICar car)
        {
            Console.WriteLine("Here is a {0},{1},{2},{3}",
                car.Color.Name, car.Year, car.Make, car.Model);
        }
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultiNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void ShowArray(int [] arr)
        {
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double result = calc.Add(4, 5);
            Console.WriteLine("4+5={0}", result);
            Calculator calc2 = calc;
            calc2.Add(3, 1);
            int[] array = new int[5] { 3, 6, 7, 8, 1 };
            ShowArray(array);
            Console.WriteLine();
 
            int d = 0;
            do {
                Console.WriteLine(array[d]);
                d++;
                }
            while (d < array.Length);
            Console.WriteLine();

            TimeSpan foo = new TimeSpan();
            double pi = calc.ComputePi(1000, out foo);
            Console.WriteLine("{0} was computed in {1} seconds", pi, foo.TotalSeconds);
            Console.WriteLine();

            Console.WriteLine(calc.AddTheseNumbers(1.1, 2.2, 3.3, 4.4));
            Console.WriteLine();

            calc.Add(42);
            Console.WriteLine("Usage count is {0}", Calculator.UsageCount);
            Console.WriteLine("Sum is {0}",calc.Sum);
            calc.Add(42);
            Console.WriteLine("Usage count is {0}", Calculator.UsageCount);
            Console.WriteLine("Sum is {0}", calc.Sum);
            Console.WriteLine();

            ICar [] cars = { new M3 (),
            new Hooptie{ Color = Color.Brown},
            };

            foreach (ICar car in cars)
            {
                PrintCarInfo(car);
                car.Start();
                car.PressAcellerator(2);
                car.PressAcellerator(10);
                car.PressBrake(2);
                car.PressBrake(10);
            }
            Console.WriteLine();

            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiNum);
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.WriteLine();

            QuitTracker bob = new QuitTracker { Name = "Bob" };
            QuitTracker sandy = new QuitTracker { Name = "Sandy" };
            KeyStrokeHandler keystrokeHandler = new KeyStrokeHandler();
            keystrokeHandler.OnKey += GotKey;
            keystrokeHandler.OnQuitting += bob.QuitHandler;
            keystrokeHandler.OnQuitting += sandy.QuitHandler;
            keystrokeHandler.OnQuitting += OnQuit;
            keystrokeHandler.Run();
            Console.WriteLine();

            ICar bmw = new M3();

            bmw.CarStopped += new EventHandler(OnCarStopped);
            
            bmw.Start();
            bmw.PressAcellerator(10);
            bmw.PressBrake(10);
        }
        private static void OnCarStopped(object sender, EventArgs e)
        {
            Console.WriteLine("Car stopped");
        }
        static void GotKey(char key)
        {
            Console.WriteLine("Got a key: {0}", key);
        }
        static void OnQuit()
        {
            Console.WriteLine("QUitting!");
        }
    }
}
