using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Shape
    {
        public virtual void Draw()  
        {
            Console.WriteLine("Shape Draw called");
        }

        public  void Show()  
        {
            Console.WriteLine("Shape Show called");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()   
        {
            Console.WriteLine("Rectangle Draw called");
        }

        public  void Show()  
        {
            Console.WriteLine("Rectangle Show called");
        }
    }
}
