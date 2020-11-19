namespace states
{
    public class EmAprovacao : IEstadoOrcamento
    {
        public void AplicaDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.95;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}