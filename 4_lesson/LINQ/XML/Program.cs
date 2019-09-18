using System;
using System.Collections.Generic;
using System.Xml;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User { Name = "Bill", Age = 43, Company = "Microsoft" };
            User user2 = new User { Name = "Tom", Age = 33, Company = "Google" };

            List<User> userList = new List<User> { user1, user2 };

            //List<User> userList = new List<User>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"..\..\User.xml");

            XmlElement root = xmlDocument.DocumentElement;

            foreach (XmlNode xnode in root)
            {
                User user = new User();
                
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");

                    if (attr != null)
                    {
                        user.Name = attr.Value;
                    }
                }

                foreach (XmlNode childNode in xnode.ChildNodes)
                {
                    if (childNode.Name == "company")
                    {
                        user.Company = childNode.InnerText;
                    }

                    if (childNode.Name == "age")
                    {
                        user.Age = int.Parse(childNode.InnerText);
                        
                    }
                }

                userList.Add(user);
            }

            Console.Read();

        }


    }
}
