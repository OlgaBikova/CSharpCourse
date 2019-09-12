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
            //FOR
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            //FOREACH
            int[] intArray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            foreach (int element in intArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            //WHILE
            /* local variable definition */
            int a = 10;
            int b,c;

            /* while loop execution */
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                c = a++; //value first, then increment
                b = ++a; //increment first, then value
            }

            //WHILE DO
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

            } while (a < 20);

            Console.ReadLine();
        }
    }
}
