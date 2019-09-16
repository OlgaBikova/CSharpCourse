using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            // When we set some value, set block is working 
            // Mazda is passed to value
            car.Model = "Mazda";

            // We can get Model value and set it to variable - get block is working
            string carModel = car.Model;

            Console.WriteLine("We could get car model: {0}", carModel);

            var newCar = new Car("BWM", "Grey");
            Console.WriteLine("New car model is: {0}, color {1}", newCar.Model, newCar.Color);

            //newCar.Color = "Red";    // not possible to set value for color since it has private set accessor



            Console.ReadLine();


        }
    }
}
