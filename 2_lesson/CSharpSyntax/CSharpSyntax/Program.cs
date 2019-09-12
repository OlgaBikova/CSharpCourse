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
            int number = 10;
            switch (number)
            {
                case 1:                  
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                    //case 5:
                    //    Console.WriteLine("case 6");
                    //    break;
                    //default:
                    //    Console.WriteLine("default");
                    //    break;
            }

            string name = "nAME";
            switch (name)
            {
                case "Name":
                    Console.WriteLine("Name");
                    break;
                case "name":
                    Console.WriteLine("name");
                   break;
                case "NaMe":
                    Console.WriteLine("NaMe");
                    break;
                //case 1:
                //    Console.WriteLine("NaMe");
                //    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
