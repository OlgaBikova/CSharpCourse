using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharpSyntax
{
    class Program
    {
        static void IsMatch()
        {
            string[] numbers =
            {
                "123-555-0190",
                "444-234-22450",
                "690-555-0178",
                "146-893-232",
                "146-555-0122",
                "4007-555-0111",
                "407-555-0111",
                "407-2-5555",
            };

            string sPattern = "^\\d{3}-\\d{3}-\\d{4}$";

            foreach (string s in numbers)
            {
                Console.Write(s);

                if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
                {
                    Console.WriteLine(" - valid");
                }
                else
                {
                    Console.WriteLine(" - invalid");
                }
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void Replace()
        {
            string s = "Hello        world";
            string pattern = @"\s+";
            string target = " ";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
            string result = regex.Replace(s, target);
            Console.WriteLine(result);
        }

        static void Matches()
        {
            string s = "Can you can a can as a canner can can a can?";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"can(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("No matches is found");
            }

            Console.ReadKey();
        }

        static string StringFormatMatch(string emailAddress)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            while (true)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(emailAddress, pattern, RegexOptions.IgnoreCase))
                {
                    return "Email is valid";
                }
                else
                {
                    return "Email is not valid";
                }
            }
        }


        static void Main()
        {
            IsMatch();
            Matches();
            Replace();
            Console.WriteLine("test@inbox.lv@: {0}", StringFormatMatch("test@inbox.lv@"));
            Console.WriteLine("test@inbox.lv: {0}", StringFormatMatch("test@inbox.lv"));
            Console.WriteLine("test@inbox.domen.lv: {0}", StringFormatMatch("test@inbox.domen.lv"));
            Console.WriteLine("test.test@inbox.domen.lv: {0}", StringFormatMatch("test.test@inbox.domen.lv"));
            Console.WriteLine("test.test@inbox.lv: {0}", StringFormatMatch("test.test@inbox.lv"));
            Console.WriteLine("test@test@inbox.lv: {0}", StringFormatMatch("test@test@inbox.lv"));
            Console.WriteLine("test_test@inbox.lv: {0}", StringFormatMatch("test_test@inbox.lv"));
            Console.WriteLine("test^test@inbox.lv: {0}", StringFormatMatch("test^test@inbox.lv"));
            Console.WriteLine("test%test@inbox.lv: {0}", StringFormatMatch("test%test@inbox.lv"));
            Console.WriteLine("1234@inbox.lv: {0}", StringFormatMatch("12345@inbox.lv"));
            Console.WriteLine("1234@1212.lv: {0}", StringFormatMatch("12345@1212.lv"));
            Console.ReadKey();
        }
    }
}
