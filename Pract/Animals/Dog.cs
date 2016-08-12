using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog()
        {
            NumberOfLegs = 4;
        }

        public Dog(int legs, string name)
        {
            NumberOfLegs = legs;
            Name = name;
        }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public enum Dogs { None = 0, Lassie, Spike, Snoopy }
        public void DogGreet()
        {
            Dogs doggies;
            Console.WriteLine("Call a dog by name and see if it responds: ");
            string dog = Console.ReadLine();
            Enum.TryParse(dog, out doggies);
            switch (doggies)
            {
                case Dogs.Lassie:
                case Dogs.Snoopy:
                    Console.WriteLine("Bark");
                    break;
                case Dogs.Spike:
                    Console.WriteLine("Bark, Bark, Bark");
                    break;
                default:
                    Console.WriteLine("Doggie not found");
                    break;
            }
        }
    }
 }
