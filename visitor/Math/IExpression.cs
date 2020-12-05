namespace visitor.Math
{
    public interface IExpression
    {
        int Evaluate();
        void Accepts(IPrinterVisitor printer);
        string Print();
    }

}