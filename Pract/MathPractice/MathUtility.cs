using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice
{
    public static class MathUtility
    {

        public static int FindSumOfMulty3and5(int limit)
        {
            int sum = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine("{0} is a multiple of 3 or 5, adding", i);
                }
            }
            Console.WriteLine("The Total sum is: {0}", sum);
            return sum;
        }

        public static int FibSum(int limit)
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            int sum = 2;
            do
            {
                a = b;
                b = c;
                c = a + b;
                if (c % 2 == 0)
                    sum += c;
            }
            while (b < limit);
            Console.WriteLine("The sum of all even Fib numbers to {0} is {1}", limit, sum);
            return sum;
        }

        public static void FindLargestThreeDigitPolyndrome()
        {
            int start = 600;
            int limit = 1000;
            int i, j, poly;
            int maxPoly = 0;

            for (i = start; i < limit; i++)
            {
                for (j = start; j < limit; j++)
                {
                    poly = (i * j);
                    string polyString = poly.ToString();

                    char[] normal = polyString.ToCharArray();
                    char[] rev = polyString.ToCharArray();
                    Array.Reverse(rev);
                    if (ArrayCompare(normal, rev))
                        if (poly > maxPoly)
                            maxPoly = poly;
                }
                //Console.WriteLine("Max Poly is: {0}", maxPoly);
            }
            Console.WriteLine("Max Poly is: {0}", maxPoly);
        }

        public static bool ArrayCompare(char[] a, char[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void SmallestMultiple(long testNumLim)
        {
            List<long> nums = new List<long>();

            for (int i = 0; i < testNumLim; i=i+20)
            {
                if (IsDivisableTo20(i))
                {
                    nums.Add(i);
                    Console.WriteLine("The number {0} is divisable from 1 to 20", i);
                }
              }
            Console.WriteLine("Smallest multiple is {0}", nums.Min());
        }

        public static bool IsDivisableTo20(int n)
        {
            int start = 11;
            int end = 20;
            for (int j = start; j <= end; j++)
            {
                if (n % j != 0)
                    return false;
            }
            return true;
        }

}
}
