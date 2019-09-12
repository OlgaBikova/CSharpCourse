using System;

namespace CSharpSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 10.67M;

            var str = string.Format(new System.Globalization.CultureInfo("en-GB"), "{0:N}", amount);
            var str2 = string.Format(new System.Globalization.CultureInfo("da-DK"), "{0:N}", amount);
            var str3 = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:N}", amount);

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine("");

            str = string.Format(new System.Globalization.CultureInfo("en-GB"), "{0:C}", amount);
            str2 = string.Format(new System.Globalization.CultureInfo("da-DK"), "{0:C}", amount);
            str3 = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:C}", amount);

            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            Console.ReadLine();
        }
    }
}
