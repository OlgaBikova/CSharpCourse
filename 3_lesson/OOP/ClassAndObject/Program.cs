using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassAndObject.Person;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
           Person client; //variable type Person

           //var employee = new PrivateInfo();   //we cannot create object of private class

            client = new Person();     //new instance of Person class, ie new object
            client.Name = "John";
            client.Surname = "Doe";
            var surname = client.SetSurname("Doe");

            //client.MiddleName = "Simon";
            client.MiddleName = "NotSimon";
            //client.Age = 21;

            Console.WriteLine("Object 'boy' Name is {0}", client.Name);
            Console.WriteLine("Object 'boy' SurName is {0}", client.Surname);
            Console.WriteLine("Object 'boy' MiddleName is {0}", client.MiddleName);
            Console.WriteLine("Object 'boy' FullName is {0}", client.GetFullName());
            //  var privatePerson = client.GetPrivatePersonData();  // not possible to get private info

            var publicPerson = new Person.PublicInfo();
            publicPerson.Name = "Billy";
            publicPerson.Surname = "Gates";

            Console.WriteLine("Object 'publicPerson' Name is {0}", publicPerson.Name);
            Console.WriteLine("Object 'publicPerson' SurName is {0}", publicPerson.Surname);
            //   Console.WriteLine("Object 'publicPerson' MiddleName is {0}", publicPerson.MiddleName);
            Console.WriteLine("");

            var anotherPublicPerson = new Person.PublicInfo("John");

            Console.WriteLine("Object 'anotherPublicPerson' Name is {0}", anotherPublicPerson.Name);
            Console.WriteLine("Object 'anotherPublicPerson' SurName is {0}", anotherPublicPerson.Surname);
            Console.WriteLine("");


            Console.ReadLine();
        }
    }
}
