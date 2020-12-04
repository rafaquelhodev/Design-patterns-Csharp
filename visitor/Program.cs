using System;
using visitor.Math;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum sum = new Sum(new Number(1), new Number(2));
            Subtraction subtraction = new Subtraction(new Number(1), new Number(2));

            Console.WriteLine(sum.Evaluate());
            Console.WriteLine(subtraction.Evaluate());
        }
    }
}
