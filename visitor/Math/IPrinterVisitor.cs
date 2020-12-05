namespace visitor.Math
{
    public interface IPrinterVisitor
    {
        string PrintSum(Sum sum);
        string PrintSubtraction(Subtraction subtraction);
        string PrintNumber(Number number);
    }
}