using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Celsius to Fahrenheit conversion
            //Formula (0 °C × 9/5) + 32 = 32 °F

            //Convert 37° to Fahrenheit
            float celsius = 37;

            float F1 = 9 * celsius / 5 + 32;
            float F = 9 / 5 * celsius + 32;

            Console.WriteLine(@"F1 equals to {0}", F1);
            Console.WriteLine(@"F equals to {0}", F);
            Console.ReadKey();
        }
    }
}
