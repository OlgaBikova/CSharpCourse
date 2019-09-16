using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHero = new SuperHero();
            superHero.Name = "Batman";
            superHero.Age = 30;

            var superHero2 = new SuperHero {
                Name = "Spiderman",
                Age = 20
            };

            Console.WriteLine("My super hero name is {0}", superHero.Name);


            Person person = new Person { FirstName = "John", LastName = "Doe"};
            person.Display();

            var employee = new Employee { FirstName = "Vasja", LastName = "Pupkin" };
            
            //employee.Age = 21;
            employee.Display();
            employee.Display2();

            Person employedPerson = new Employee {FirstName = "Billy", LastName = "Gates", Id = 7}; // var type Person can create object type Employee
            employedPerson.Display();
            
            Console.Read();
        }
    }
}
