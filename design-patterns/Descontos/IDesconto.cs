namespace design_patterns.Descontos
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Calcula(Orcamento orcamento);
    }
}