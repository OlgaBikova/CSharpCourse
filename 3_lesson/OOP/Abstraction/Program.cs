using System;

namespace Abstraction
{
    class Program
    {
        abstract class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(string name, string surname)
            {
                FirstName = name;
                LastName = surname;
            }

            public void Display()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
        }

        class Client : Person
        {
            public int Sum { get; set; }    // money amount on the account

            public Client(string name, string surname, int sum)
                : base(name, surname)
            {
                Sum = sum;
            }
        }

        class Employee : Person
        {
            public string Position { get; set; } 

            public Employee(string name, string surname, string position)
                : base(name, surname)
            {
                Position = position;
            }
        }
        
        static void Main(string[] args)
        {
           // Person human = new Person();  //we cannot create instance of abstract class

            Client client = new Client("Tom", "Smith", 500);
            Employee employee = new Employee("Bob", "Tompson", "Securitys");

            client.Display();
            employee.Display();

            Person client1 = new Client("Tom", "Smith", 500);
            Person employee1 = new Employee("Bob", "Tompson", "Accounter");

            client1.Display();
            employee1.Display();


            Console.ReadKey();
        }
    }
}
