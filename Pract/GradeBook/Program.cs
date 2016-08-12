using MyLibrary;
using System;
using System.Collections.Generic;

namespace GradeBooks
{
    class Program
    {

        public static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.oldValue, args.newValue);
        }
        private static void AnotherMethod(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Another subscriber");
        }
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("John") { Grades = new List<double> { 45, 55, 66 } };
            GradeBook book2 = new GradeBook("Smith") { Grades = new List<double> { 45, 55, 66 } };

            book.StoreGrade(12.45);
            book.StoreGrade(34.12);
            book.StoreGrade(1);
            book.StoreGrade(-5);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine();
            WriteAsBytes.WriteBytes(stats.AverageGrade);
            int num = 5;
            double num2 = 5;
            double num3 = 20;
            WriteAsBytes.WriteBytes(num, num2, num3);
            WriteAsBytes.WriteBytes(num);
            WriteAsBytes.WriteBytes(num2);
            WriteAsBytes.WriteBytes();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += AnotherMethod;
            book.NameChanged -= OnNameChanged;
            book2.NameChanged += OnNameChanged;

            Console.WriteLine("Book name is: {0}",book.Name);
            book.EnterBookName();

            book.Name = "Aaron";
            Console.WriteLine("Book name is: {0}", book.Name);
            Console.WriteLine();
            Console.WriteLine("Book2 name is: {0}",book2.Name);
            book2.Name = "Caira";
            Console.WriteLine("Book2 name is: {0}", book2.Name);
        }
    }
}
