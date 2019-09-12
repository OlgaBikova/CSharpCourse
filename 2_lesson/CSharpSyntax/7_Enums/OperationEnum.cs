using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    public enum OperationEnum
    {
        Add,
        Subtract,
        Multiply,
        None = 0,
        divide
    }
    public static class MathOperations
    {
        public static void MathOp(double y, double x, OperationEnum op)
        {
            double result = 0.0;

            switch (op)
            {
                case OperationEnum.Add:
                    result = x + y;
                    break;
                case OperationEnum.Subtract:
                    result = x - y;
                    break;
                case OperationEnum.Multiply:
                    result = x * y;
                    break;
                //case OperationEnum.divide:
                //    result = x / y;
                //    break;
            }

            Console.WriteLine("Operation result is equal to {0}", result);
        }
    }
}
