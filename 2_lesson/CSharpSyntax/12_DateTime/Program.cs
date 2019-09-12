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
            var dateTime = new DateTime(2018, 7, 20, 18, 30, 25); //set date with time

            Console.WriteLine("Date time");
            DateTime();

            Console.WriteLine("");
            Console.WriteLine("Date time methods");
            DateTimeMethods(dateTime);


            Console.WriteLine("");
            Console.WriteLine("Date time Format");
            DateTimeFormat();


            Console.WriteLine("");
            Console.WriteLine("Date time Format Options");
            DateTimeFormatOptions();


            Console.WriteLine("");
            Console.WriteLine("Convert string to DateTime");
            ConvertStringToDateTime();

            Console.WriteLine("");
            Console.WriteLine("Convert DateTime to stirng");
            ConvertDateTimeToString();

            Console.ReadKey();
        }

        static void DateTime()
        {
            DateTime date = new DateTime();
            Console.WriteLine(date); // 01.01.0001 0:00:00

            Console.WriteLine(System.DateTime.MinValue);

            Console.WriteLine(System.DateTime.MaxValue);

            var dateTime = new DateTime(123456781234567121); //ticks
            Console.WriteLine(dateTime);

            var dateTime1 = new DateTime(2018, 2, 18);  //set date only
            Console.WriteLine(dateTime1);

            var dateTime2 = new DateTime(2018, 7, 20, 18, 30, 25); //set date with time
            Console.WriteLine(dateTime2);

            Console.WriteLine(System.DateTime.Now); //local system
            Console.WriteLine(System.DateTime.UtcNow); //GMT
            Console.WriteLine(System.DateTime.Today);
        }

        static void DateTimeMethods(DateTime dateTime2)
        {
            Console.WriteLine(dateTime2.Add(new TimeSpan(21323123)));
            Console.WriteLine(dateTime2.AddDays(3));
            Console.WriteLine(dateTime2.AddHours(3));
            Console.WriteLine(dateTime2.AddMinutes(3));
            Console.WriteLine(dateTime2.AddMonths(3));
            Console.WriteLine(dateTime2.AddYears(3));
            Console.WriteLine(dateTime2.Subtract(System.DateTime.Now));
        }

        static void DateTimeFormat()
        {
            System.DateTime date1 = new DateTime(2017, 7, 20, 18, 30, 25);
            Console.WriteLine(date1.ToLocalTime()); //convert UTC time to local time
            Console.WriteLine(date1.ToUniversalTime());  //convert local time to UTC time
            Console.WriteLine(date1.ToLongDateString());
            Console.WriteLine(date1.ToShortDateString());
            Console.WriteLine(date1.ToLongTimeString());
            Console.WriteLine(date1.ToShortTimeString());
        }

        static void ConvertStringToDateTime()
        {
            string dateTime = "01/08/2008 14:50:50.42";
            var dt = Convert.ToDateTime(dateTime);

            Console.WriteLine(dt);

            Console.WriteLine(
                "Year: {0}, Month: {1}, Day: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
                dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);

            // Specify exactly how to interpret the string.  
            IFormatProvider culture = new System.Globalization.CultureInfo("en-US", true);

            // Alternate choice: If the string has been input by an end user, you might    
            // want to format it according to the current culture:   
            // IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;  
            DateTime dt2 = System.DateTime.Parse(dateTime, culture);

            Console.WriteLine(dt2);

            Console.WriteLine(
                "Year: {0}, Month: {1}, Day: {2}, Hour: {3}, Minute: {4}, Second: {5}, Millisecond: {6}",
                dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second, dt2.Millisecond);
        }

        static void ConvertDateTimeToString()
        {
            System.DateTime now = System.DateTime.Now;
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd.MM.yyyy"));

            var test = now.ToString("hh:mm:ss");
        }

        static void DateTimeFormatOptions()
        {
            System.DateTime now = System.DateTime.Now;
            Console.WriteLine("D: " + now.ToString("D"));
            Console.WriteLine("d: " + now.ToString("d"));
            Console.WriteLine("F: " + now.ToString("F"));
            Console.WriteLine("f: {0:f}", now);
            Console.WriteLine("G: {0:G}", now);
            Console.WriteLine("g: {0:g}", now);
            Console.WriteLine("M: {0:M}", now);
            Console.WriteLine("O: {0:O}", now);
            Console.WriteLine("o: {0:o}", now);
            Console.WriteLine("R: {0:R}", now);
            Console.WriteLine("s: {0:s}", now);
            Console.WriteLine("T: {0:T}", now);
            Console.WriteLine("t: {0:t}", now);
            Console.WriteLine("U: {0:U}", now);
            Console.WriteLine("u: {0:u}", now);
            Console.WriteLine("Y: {0:Y}", now);
        }
    }
}
