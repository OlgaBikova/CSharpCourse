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
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello World!");
            Console.WriteLine(sb);
            Console.WriteLine("Length of string: {0}", sb.Length);
            Console.WriteLine("Capacity of string: {0}", sb.Capacity);

            sb.Append("Today is a good day");
            Console.WriteLine(sb);
            Console.WriteLine("Length of string: {0}", sb.Length);
            Console.WriteLine("Capacity of string: {0}", sb.Capacity);

            sb.Append(" so you can party!");
            Console.WriteLine(sb);
            Console.WriteLine("Length of string: {0}", sb.Length);
            Console.WriteLine("Capacity of string: {0}", sb.Capacity);

            sb.Append(" Yo!");
            Console.WriteLine(sb);
            Console.WriteLine("Length of string: {0}", sb.Length);
            Console.WriteLine("Capacity of string: {0}", sb.Capacity);



            System.Text.StringBuilder sb2 = new System.Text.StringBuilder("Hello World");
            sb2.Append("!");
            sb2.Insert(6, "wonderful ");
            Console.WriteLine(sb2);

            //replace word World to friend
            sb2.Replace("World", "friend");
            Console.WriteLine(sb2);

            // remove 13 simbols starting from 7
            sb2.Remove(6, 10);
            Console.WriteLine(sb2);

            // convert stringbuilder to stirng
            string s = sb2.ToString();
            Console.WriteLine(sb2);


            Console.ReadKey();
        }
    }
}
