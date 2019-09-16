using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Car
    {
        //private is access modificator
        private string _model;  // for private field naming it is better to use _
        private string _color;


        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Color
        {
            get { return _color;}

            private set //encapsulation
            {
                if (value == "Red")
                {
                    _color = value;
                }
                else
                {
                    _color = "Green";
                }
            }
        }

        public Car() { }
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

    }
}
