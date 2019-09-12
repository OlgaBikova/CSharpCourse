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
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "apple");
            dictionary.Add(5, "horse");
            dictionary.Add(4, "horse");
            dictionary.Add(3, "horse");


            // See whether Dictionary contains this string.
            if (dictionary.ContainsKey(1))
            {
                string value = dictionary[1];
                Console.WriteLine(value);
            }

            // See whether it contains this string.
            if (!dictionary.ContainsKey(2))
            {
                Console.WriteLine(false);
            }

            // See whether it contains this string.
            if (dictionary.ContainsValue("horse"))
            {
                int key = dictionary.FirstOrDefault(x => x.Value == "horse").Key;
                Console.WriteLine(key);
            }
        }
    }
}
