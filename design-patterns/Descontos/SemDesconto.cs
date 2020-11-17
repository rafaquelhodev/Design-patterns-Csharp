namespace design_patterns.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            return 0.0;
        }

    }
}