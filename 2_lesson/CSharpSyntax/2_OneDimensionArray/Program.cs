using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
            int[] a = new int[n] { 3, 12, 5, -9, 8, -4};

            Console.WriteLine("Initial Array:");

            for (int i = 0; i < n; ++i)
            {
                Console.Write("\t" + a[i]);
            }

            Console.WriteLine();

            long sum = 0;              // Sum of negative numbers
            int num = 0;              // Negative numbers count
            for (int i = 0; i < n; ++i)
            {
                if (a[i] < 0)
                {
                    sum += a[i];
                    ++num;
                }
            }

            Console.WriteLine("Sum of negative numbers = " + sum);
            Console.WriteLine("Negative numbers count = " + num);

            int max = a[0];             // max element
            for (int i = 1; i < n; ++i)
            {
                if (a[i] > max) max = a[i];
            }


            Console.WriteLine("maximal element = " + max);
            Console.ReadKey();
        }
    }
}
