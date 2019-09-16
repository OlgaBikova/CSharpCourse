using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Draw();
            
            Shape shape = new Rectangle();

            shape.Draw();
            shape.Show();

            Rectangle shape1 = new Rectangle();

            shape1.Draw();
            shape1.Show();

            Console.ReadKey();
        }
    }
}
