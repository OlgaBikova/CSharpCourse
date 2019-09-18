using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static string[] countries = {
            "Latvia",
            "Spain",
            "England",
            "Sweden",
            "Finland",
            "Lithuania"
        };

        static void Main(string[] args)
        {
            Array(countries);
            LinqQuery(countries);
            LinqMethod(countries);
            LinqFiltering();
            LinqAdvancedFiltering();
            LinqSelect();
            LinqVariety();
            LinqGroup();

            Console.Read();
        }

        private static void Array(string[] countries)
        {
            var selectedCountries = new List<string>();

            foreach (var country in countries)
            {
                if (country.ToUpper().StartsWith("L"))
                {
                    selectedCountries.Add(country);
                }
            }

            selectedCountries.Sort();

            foreach (var selectedCountry in selectedCountries)
            {
                Console.WriteLine(selectedCountry);
            }
        }

        private static void LinqQuery(string[] countries)
        {
            var selectedCountries = from country in countries
                                    where country.ToUpper().StartsWith("L")
                                    orderby country
                                    select country;

            foreach (var selectedCountry in selectedCountries)
            {
                Console.WriteLine(selectedCountry);
            }
        }

        private static void LinqMethod(string[] countries)
        {
            var selectedCountries = countries
                .Where(c => c.ToUpper().StartsWith("L"))
                .OrderBy(c => c);

            foreach (var selectedCountry in selectedCountries)
            {
                Console.WriteLine(selectedCountry);
            }
        }

        private static void LinqFiltering()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 10, 34, 55, 66, 77, 88 };

            IEnumerable<int> result1 = from n in numbers
                                       where n % 2 == 0 && n > 10
                                       select n;

            foreach (var res in result1)
            {
                Console.WriteLine(res);
            }

            var result2 = numbers.Where(n => n % 2 == 0 && n > 10);

            foreach (var res in result2)
            {
                Console.WriteLine(res);
            }
        }

        private static void LinqAdvancedFiltering()
        {
            List<User> userList = new List<User>
            {
                new User{ Name="Bob", Age=33, Languages={ "english", "french"} },
                new User{ Name="Tom", Age=27, Languages={ "english", "latvian"} },
                new User{ Name="John", Age=29, Languages={ "english", "spanish"} },
                new User{ Name="Elis", Age=45, Languages={ "spanish", "french"} }
            };

            var selectedUsers = userList.SelectMany(u => u.Languages,
                (u, l) => new { User = u, Language = l });

            var result1 = selectedUsers
                .Where(u => u.Language == "english" && u.User.Age < 28)
                .Select(u => u.User);

            var res = userList.Where(x => x.Languages.Contains("english") && x.Age < 28);
        }

        private static void LinqSelect()
        {
            List<User> userList = new List<User>
            {
                new User{ Name="Bob", Age=33, Languages={ "english", "french"} },
                new User{ Name="Tom", Age=27, Languages={ "english", "latvian"} },
                new User{ Name="John", Age=29, Languages={ "english", "spanish"} },
                new User{ Name="Elis", Age=45, Languages={ "spanish", "french"} }
            };

            var nameList = userList.Select(u => u.Name);

            var result = userList.Select(u => new
            {
                FirstName = u.Name,
                YearOfBirth = DateTime.Now.Year - u.Age
            });
        }

        private static void LinqVariety()
        {
            string[] software = {"Microsoft", "Google", "Apple"};
            string[] hardware = {"Apple", "IBM", "Samsung"};

            var result = software.Except(hardware);
            var result1 = hardware.Except(software);

            var result2 = software.Intersect(hardware);

            var result3 = software.Union(hardware);
            var result4 = software.Concat(hardware);
            var result5 = software.Concat(hardware).Distinct();
        }

        private static void LinqGroup()
        {
            var phoneList = new List<Phone>
            {
                new Phone { Name = "Lumia 430", Company="Microsoft"},
                new Phone { Name = "Mi 5", Company="Xiaomi"},
                new Phone { Name = "LG 3", Company="LG"},
                new Phone { Name = "iPhone 5", Company="Apple"},
                new Phone { Name = "Lumia 930", Company="Microsoft"},
                new Phone { Name = "LG 5", Company="LG"},
                new Phone { Name = "iPhone 7", Company="Apple"},
                new Phone { Name = "Lumia 630", Company="Microsoft"}
            };

            var phoneGroup = phoneList.GroupBy(p => p.Company)
                .Select(g => new { Name = g.Key, Count = g.Count() });

            var phoneGroup1 = phoneList.GroupBy(p => p.Company)
                .Select(g => new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Phones = g.Select(p => p)
                });

            foreach (var group in phoneGroup1)
            {
                Console.WriteLine($"{group.Name} has {group.Count} phones");

                foreach (var phone in group.Phones)
                {
                    Console.WriteLine($"Phone: {phone.Name}");
                }
            }
        }

    }
}
