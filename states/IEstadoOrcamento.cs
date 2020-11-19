namespace states
{
    public interface IEstadoOrcamento
    {
        void AplicaDesconto(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);
    }
}