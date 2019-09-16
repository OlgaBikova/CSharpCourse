using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPolymorphism
{
    class Program
    {
        void CalculateArea(int a)
        {
            Console.WriteLine("Area of square is : {0}", a * a);
        }
        
        void CalculateArea(int a, int b)
        {
            Console.WriteLine("Area of rectangle is : {0}",  a * b);
        }

        void CalculateArea(string a, string b)
        {
            Console.WriteLine("We cant get area from texts {0} and {1}", a, b);
        }

        //int CalculateArea(int b) //not possible to create one more method with same name and same parameterss
        //{
        //    Console.WriteLine("Your passed parameter is : {0}", b);
        //    return b;
        //}

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.CalculateArea(5);
            obj.CalculateArea(5, 10);
            obj.CalculateArea("Hello", "World");

            Console.ReadLine();
        }
    }
}
