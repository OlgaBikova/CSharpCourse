using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person   //not possible to  inherit from sealed class Director
    {
        public int Id { get; set; } 
        public void Display2()
        {
            Console.WriteLine("Call method from employee");
        }
    }
}








//Add into class later
//public void Display()
//{
//    //Console.WriteLine(_firstName);
//    //Console.WriteLine(FirstName);
//}


//After constructor is added
//public string Company { get; set; }

//public Employee(string firstName, string lastName, string comp)
//: base(firstName, lastName)
//{
//Company = comp;
//}