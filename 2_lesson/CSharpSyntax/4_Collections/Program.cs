using System;
using System.Collections;
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
            //int array
            int[] testArray2 = new int[5];

            for (int i = 0; i < testArray2.Length; i++)
            {
                testArray2[i] = i + 5; //Add values to each array index
            }

            // non-generic ArrayList
            //can add and remove items from it and it automatically deals with allocating space
            //not type-safe
            ArrayList objectList = new ArrayList() { 1, 2, "string", 'c', 2.0f };

            object obj = 45.8;

            objectList.Add(obj);
            objectList.Add("string2");
            objectList.RemoveAt(0); // remove first element

            foreach (object o in objectList)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("overall element count in array: {0}", objectList.Count);

            // generic collection List
            //type-safe version of ArrayList.
            List<string> countries = new List<string>(){ "Latvia", "Germany", "UK", "China" };


            countries.Add("Belgium");
            countries.Add(1.ToString());
            countries.RemoveAt(1); // remove second element 

            foreach (string s in countries)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
