using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Animals
{
    class Program
    {

        static void Main(string[] args)
        {

            Dog.Dogs las = Dog.Dogs.Lassie;
            Console.WriteLine("Type of Lassie is: {0}", las.GetType());
            Console.WriteLine("Lassie to string is: {0}", las.ToString());

            Dog dog = new Dog() { Name = las.ToString()};
            //dog.DogGreet();

            var animal = new Animal();
            var husky = Activator.CreateInstance<Husky>();
            Console.WriteLine("Type of Husky is: {0}", husky.GetType());

            Animal a = dog as Animal;
            Console.WriteLine("Type of a is: {0}", a.GetType());
            a = dog; 
            Console.WriteLine("Type of a is: {0}", a.GetType());
            Console.WriteLine("Type of dog is: {0}", dog.GetType());

            var typeAn = typeof(Animal);
            Console.WriteLine("Full name of Animal is: {0}", typeAn.FullName);

            if (a is Dog && a is Animal)
            {
                a.Temp = 15;
                Console.WriteLine("a.Temp is {0}",a.Temp);
            }

            var type = husky.GetType();
            var method = type.GetMethod("Growls");
            var value = (string)method.Invoke(husky, null);
            Console.WriteLine("Husky is of type {0}, has a method {1}, with value {2}", type, method, value);

            Console.WriteLine("Dog has {0} legs",dog.NumberOfLegs);
            PropertyInfo[] properties = typeof(Dog).GetProperties();
            PropertyInfo numberOfLegsProperty = null;
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (propertyInfo.Name.Equals("NumberOfLegs", StringComparison.InvariantCulture))
                 {
                    numberOfLegsProperty = propertyInfo;
                }
            }

            numberOfLegsProperty.SetValue(dog, 3, null);
            Console.WriteLine("Dog has {0} legs", dog.NumberOfLegs);

            var defaultConstructor = typeof(Dog).GetConstructor(new Type[0]);
            var legConstructor = typeof(Dog).GetConstructor(new[] { typeof (int), typeof (string)});

            var defaultDog = (Dog)defaultConstructor.Invoke(null);
            Console.WriteLine("Legs default {0}",defaultDog.NumberOfLegs);

            var legDog = (Dog)legConstructor.Invoke(new object[] { 5, "Sparky" });
            Console.WriteLine("Name {0}, Legs {1}",legDog.Name, legDog.NumberOfLegs);
        }
    }
}


