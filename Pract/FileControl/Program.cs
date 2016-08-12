using System;


namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Console.WriteLine(folder);
            Console.WriteLine("Loading settings");
            MySettings settings = MySettings.Load();

            Console.WriteLine("MyNumber = {0}", settings.MyNumber);
            Console.WriteLine("MyString = {0}", settings.MyString);

            Console.WriteLine("Updating settings and saving");

            settings.MyNumber++;
            settings.MyString = DateTime.Now.ToString();

            settings.Save();
            Console.WriteLine("Done");
        }
    }
}
