using System;
using visitor.Math;

namespace visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterVisitor printer = new Printer();

            Sum sum = new Sum(new Number(1), new Number(2));
            sum.Accepts(printer);
            Console.WriteLine($"{sum.Print()} = {sum.Evaluate()}");

            Subtraction subtraction = new Subtraction(new Number(1), new Number(2));
            subtraction.Accepts(printer);
            Console.WriteLine($"{subtraction.Print()} = {subtraction.Evaluate()}");

            Sum sumAndSubraction = new Sum(new Sum(new Number(1), new Number(2)), new Subtraction(new Number(4), new Number(10)));
            sumAndSubraction.Accepts(printer);
            Console.WriteLine($"{sumAndSubraction.Print()} = {sumAndSubraction.Evaluate()}");

        }
    }
}
