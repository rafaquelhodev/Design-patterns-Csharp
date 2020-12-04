namespace visitor.Math
{
    public class Number : IExpression
    {
        public int _Number { get; set; }

        public Number(int _number)
        {
            _Number = _number;
        }

        public int Evaluate()
        {
            return _Number;
        }
    }

}