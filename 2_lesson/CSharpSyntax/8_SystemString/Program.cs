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
            //from string literal and string concatenation
            string firstName, surname;
            firstName = "John";
            surname = "Doe";

            string fullname = firstName + " " + surname;
            Console.WriteLine("Full Name: {0}", fullname);

            //by using string constructor 
            char[] charArray = new char[] { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(charArray);
            string greetings2 = new string(new char[] { 'w', 'o', 'r', 'l', 'd' });
            Console.WriteLine("Greetings: {0}", greetings);
            Console.WriteLine("Greetings: {0}", greetings2);

            string someString = new String('a', 6);

            //methods returning string 
            string message = String.Join(" ", "Some", "Text", "Is", "Written", "Here");
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2018, 02, 17, 12, 23, 32);

            string someTexte = "aasasa";
            string chat = String.Format("Message sent at {0:t} on {0:D} {1}", waiting, someTexte);
            Console.WriteLine("Message: {0}", chat);

            string someText = "someText";
            var secondLetter = someText[1]; //second letter in someText is o
            Console.WriteLine(secondLetter);

            Console.ReadKey();
        }
    }
}
