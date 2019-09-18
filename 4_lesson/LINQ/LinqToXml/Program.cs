using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
           // CreateLongXml();
            CreateShortXml();
            //ModifyXml();
            CreatePhoneClass();
            
            Console.Read();
        }

        private static void CreatePhoneClass()
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            var items = from xe in xdoc.Element("phones").Elements("phone")
                        where xe.Element("company").Value == "Samsung"
                        select new Phone
                        {
                            Name = xe.Attribute("name").Value,
                            Price = xe.Element("price").Value
                        };

            foreach (var item in items)
            {
                Console.WriteLine("Name {0}, Price {1}", item.Name, item.Price);
            }

        }

        private static void ModifyXml()
        {
            XDocument xdoc = XDocument.Load("phones.xml");

            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute != null && companyElement != null && priceElement != null)
                {
                    Console.WriteLine("Phone : {0}", nameAttribute.Value);
                    Console.WriteLine("Produced by Company {0}", companyElement.Value);
                    Console.WriteLine("You need to spend {0}", priceElement.Value);
                }

            }

        }


        private static void CreateShortXml()
        {
            XDocument xdoc1 = new XDocument(new XElement("phones",
                new XElement("phone",
                    new XAttribute("name", "iPhone 6"),
                    new XElement("company", "Apple"),
                    new XElement("price", "4000")),
                new XElement("phone",
                    new XAttribute("name", "Samsung Galaxy S8"),
                    new XElement("company", "Samsung"),
                    new XElement("price", "1000"))));

            xdoc1.Save(@"c:\temp\phones3.xml");
        }

        private static void CreateLongXml()
        {
            XDocument xdoc = new XDocument();

            XElement iphone6 = new XElement("phone");
            XAttribute attributeName = new XAttribute("name", "iPhone 6");
            XElement iphoneCompanyName = new XElement("company", "Apple");
            XElement iphonePrice = new XElement("price", "4000");

            iphone6.Add(attributeName);
            iphone6.Add(iphoneCompanyName);
            iphone6.Add(iphonePrice);

            //iphone6.Add(attributeName, iphoneCompanyName, iphonePrice);

            XElement galaxy = new XElement("phone");
            XAttribute galaxyAttributeName = new XAttribute("name", "Samsung Galaxy s8333");
            XElement galaxyCompanyName = new XElement("company", "Samsung");
            XElement galaxyPrice = new XElement("price", "1000");

            galaxy.Add(galaxyAttributeName);
            galaxy.Add(galaxyCompanyName);
            galaxy.Add(galaxyPrice);

            XElement phones = new XElement("phones");

            phones.Add(iphone6);
            phones.Add(galaxy);

            xdoc.Add(phones);
            xdoc.Save(@"c:\temp\phones2.xml");
        }
    }
}
