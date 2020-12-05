namespace visitor.Math
{
    public class Printer : IPrinterVisitor
    {
        public string PrintNumber(Number number)
        {
            return number.Value.ToString();
        }

        public string PrintSubtraction(Subtraction subtraction)
        {
            subtraction.Left.Accepts(this);
            subtraction.Right.Accepts(this);

            string expression = "( ";
            expression += subtraction.Left.Print();
            expression += " - ";
            expression += subtraction.Right.Print();
            expression += " )";

            return expression;
        }

        public string PrintSum(Sum sum)
        {
            sum.Left.Accepts(this);
            sum.Right.Accepts(this);

            string expression = "( ";
            expression += sum.Left.Print();
            expression += " + ";
            expression += sum.Right.Print();
            expression += " )";

            return expression;

        }
    }
}