using System;

namespace MyLibrary
{
    public class QuitTracker
    {
        public string Name { get; set; }
        public void QuitHandler()
        {
            Console.WriteLine("My name is {0} and i just got a quit notification", Name);
        }
    }
}
