namespace design_patterns.Descontos
{
    public class DescontoEntreCincoEDezItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Itens.Count >= 5 && orcamento.Itens.Count <= 10)
                return orcamento.Valor * 0.2;

            return Proximo.Calcula(orcamento);

        }

    }
}