using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    class Person //can be private on this level
    {      

        public string Name; //class member - Field
        public string Surname { get;  set; } //class property - differs from members by get and set accessors 

        public string SetSurname(string surname)
        {
            Surname = surname;
            return "Your Surname is " + Surname;
        }
        
        private string _middleName;

        public string MiddleName
        {
            get { return _middleName; }
            set {
                if (value == "Simon")
                {
                    _middleName = value;
                }
            }
        }

        private int Age;

        public string GetFullName()
        {
            return Name + " " + Surname;
        }

        //public PrivateInfo GetPrivatePersonData()
        //{
        //    var privatePerson = new PrivateInfo();
        //    privatePerson.SetAge();
        //    return privatePerson;
        //}

        private class  PrivateInfo
        {
            public int Age { get; private set; }
            public int Salary { get; set; }

            public void SetAge()
            {
               Age = 18;
            }
        }

        public class PublicInfo
        {
            public PublicInfo() { }

            public PublicInfo(string name)
            {
                Name = name;
            }


            public PublicInfo(string name, string surname) //constructor with parameters
            {
                Name = name;
                Surname = surname;
            }

            public string Name { get; set; }
            public string Surname { get; set; }
        }
    }
}
