using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;

namespace GradeBooks
{
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
    public class GradeBook
    {
        private static readonly double  minGrade = 0;
        private static readonly double  maxGrade = 100;
        private string _name;
        public GradeBook(string name = "There is no name")
        {
        Grades = new List<double>();
        Name = name;
        }
        public event NameChangedDelegate NameChanged;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                    string oldValue = _name;
                    _name = value;
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.oldValue = oldValue;
                    args.newValue = value;
                    NameChanged?.Invoke(this, args);
                }
            }

        protected List<double> _grades;
        public List<double> Grades { get; set; }

        public void StoreGrade(double grade)
        {   if (grade > minGrade && grade <= maxGrade)
            Grades.Add(grade);
        }
        public GradeStatistics ComputeStatistics()
        {
            double gradeSum = 0;
            GradeStatistics stats = new GradeStatistics();

            stats.HighestGrade = Grades.Max();
            Console.WriteLine("Highest grade is {0}", stats.HighestGrade);

            stats.LowestGrade = Grades.Min();
            Console.WriteLine("Lowest grade is {0}", stats.LowestGrade);

            foreach (double grade in Grades)
            {
                gradeSum += grade;
            }
            stats.AverageGrade = Math.Round((gradeSum / Grades.Count),2);
            Console.WriteLine("Average grade is {0}", stats.AverageGrade);

            return stats;
        }
        public void EnterBookName()
        {
            string value = null;
            do
            {
                Console.WriteLine("Please enter a book Name");
                value = Console.ReadLine();
                if (!BookNameIsValid(value))
                {

                }
            } while (!BookNameIsValid(value));
            //    try
            //    {
            //        Console.WriteLine("Please enter a book Name");
            //        string value = Console.ReadLine();
            //        BookNameIsValid(value);
            //        Name = value;
            //    }
            //    catch (ArgumentNullException ex)
            //    {
            //        Console.WriteLine("Name can't be null or empty", ex);
            //        EnterBookName();
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine("Book name can't be under 3 symbols", ex);
            //        EnterBookName();
            //    }
            }
        public bool BookNameIsValid (string name)
        {
            //if (String.IsNullOrEmpty(name))
            //   throw new ArgumentNullException();
            //if (name.Length < 3)
            //    throw new ArgumentException();

            return !string.IsNullOrEmpty(name) && name.Length > 3;
        }
    }
}

