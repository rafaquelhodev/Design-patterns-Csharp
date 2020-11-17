namespace design_patterns.Descontos
{
    public class DescontoEntreZeroECincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count < 5)
                return orcamento.Valor * 0.1;

            return Proximo.Calcula(orcamento);

        }

    }
}