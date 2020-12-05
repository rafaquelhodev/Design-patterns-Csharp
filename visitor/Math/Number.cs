namespace visitor.Math
{
    public class Number : IExpression
    {
        public int Value { get; set; }
        public IPrinterVisitor Printer { get; set; }

        public Number(int _value)
        {
            Value = _value;
        }

        public int Evaluate()
        {
            return Value;
        }

        public void Accepts(IPrinterVisitor printer)
        {
            Printer = printer;
        }

        public string Print()
        {
            return Printer.PrintNumber(this);
        }
    }

}