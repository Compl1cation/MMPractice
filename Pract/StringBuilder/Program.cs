using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringBuil
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.AppendLine("This is the original first line");
            sb.AppendLine("This is another line");

            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat("Inserting line with loop index {0,5} on {1,9:d} {2}", i, DateTime.Now.ToShortTimeString(), Environment.NewLine);
            }

            sb.Replace("index", "counter");

            var newLine = string.Format("This is a new first line {0}", Environment.NewLine);
            sb.Insert(0, newLine);

            Console.WriteLine(sb);

            var pattern = @"\b\w+\b";
            var matches = Regex.Matches(newLine, pattern);
            var value = matches[4].Value;
            Console.WriteLine(value);

            pattern = "(This )(.+)( first)";
            var groups = Regex.Match(newLine, pattern).Groups;
            foreach (Group match in groups)
            {
                Console.WriteLine("Match is {0}", match);
            }
        }
    }
}
