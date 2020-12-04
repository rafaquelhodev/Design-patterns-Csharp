namespace visitor.Math
{
    public class Subtraction : IExpression
    {
        public IExpression Left { get; set; }
        public IExpression Right { get; set; }

        public Subtraction(IExpression left, IExpression right)
        {
            Left = left;
            Right = right;
        }

        public int Evaluate()
        {
            var leftResult = Left.Evaluate();
            var rightResult = Right.Evaluate();
            return leftResult - rightResult;
        }
    }
}