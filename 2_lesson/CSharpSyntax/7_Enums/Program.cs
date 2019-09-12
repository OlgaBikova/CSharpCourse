using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        enum Season
        {
            Winter = 2, // every next element will be increased by 1
            Spring, // has value 3
            Summer = 7,
            Autumn  //has value 8
        }

        ////You cant use string as value for enums
        //enum Cars
        //{
        //    Mazda = "MX5",
        //    Renault = "Koleos",
        //    Bmw = "M5"
        //}

        //Display attribute

        enum Cars
        {
            [Display(Name = "Mazda MX5")]
            Mazda = 1,
            [Display(Name = "Renault Koleos")]
            Renault = 2,
            [Display(Name = "BMW M5")]
            Bmw = 3
        }

        enum Colors { Red, Green, Blue, Yellow };

        enum Status { Active, Inactive, Draft }

        static void Main(string[] args)
        {
            //Days WeekdayStart = Days.Mon;
            //int WeekdayEnd = (int)Days.Fri;

            //Console.WriteLine("Monday: {0}", WeekdayStart);
            //Console.WriteLine("Friday: {0}", WeekdayEnd);
            //Console.WriteLine("");

            //int winter = (int)Season.Winter;
            //int spring = (int)Season.Spring;
            //int summer = (int)Season.Summer;
            //int autumn = (int)Season.Autumn;

            //Console.WriteLine("winter: {0}", winter);
            //Console.WriteLine("spring: {0}", spring);
            //Console.WriteLine("summer: {0}", summer);
            //Console.WriteLine("autumn: {0}", autumn);
            //Console.WriteLine("");
            //int operationEnum;

            //Console.WriteLine("Add: {0}", operationEnum = (int)OperationEnum.Add);
            //Console.WriteLine("Substract: {0}", operationEnum = (int)OperationEnum.Subtract);
            //Console.WriteLine("None: {0}", operationEnum = (int)OperationEnum.None);
            //Console.WriteLine("Percentage: {0}", operationEnum = (int)OperationEnum.divide);
            //Console.WriteLine("");
            //MathOperations.MathOp(5, 7, OperationEnum.None);

            //Get Enum String values
            Console.WriteLine("Enum to string {0}", Cars.Bmw.ToString());
            Console.WriteLine("Enum display value {0}", EnumHelper<Cars>.GetDisplayValue(Cars.Mazda));

            var displayedValue = EnumHelper<Cars>.GetDisplayValue(Cars.Mazda);
            Console.WriteLine("Enum value from decsription {0}", EnumHelper<Cars>.GetValueFromDescription<Cars>(displayedValue));


            //Enum Parse
            string carName = "Mazda";
            int carNumber = 9; //try with 9
            Console.WriteLine("Enum parsing {0}", Enum.Parse(typeof(Cars), carName));
            Console.WriteLine("Enum parsing {0}", Enum.Parse(typeof(Cars), carNumber.ToString())); //int should be converted to string

            string carName2 = "RENAULT";
            Console.WriteLine("Enum parsing ignoring case {0}", Enum.Parse(typeof(Cars), carName2, true));
            //Console.WriteLine("Enum parsing using case{0}", Enum.Parse(typeof(Cars), carName2, false));

            //Enum.GetValues
            Console.WriteLine("Car values:");

            foreach (var carValue in Enum.GetValues(typeof(Cars)))
            {
                Console.WriteLine((int)carValue);

            }

            //Enum GetName
            Console.WriteLine("The 4th value of the Colors Enum is {0}", Enum.GetName(typeof(Colors), 3));

            //Enum GetNames
            Console.WriteLine("List of statuses:");

            foreach (var status in Enum.GetNames(typeof(Status)))
            {
                Console.WriteLine(status);

            }
            
            Console.ReadKey();
        }
    }
}
