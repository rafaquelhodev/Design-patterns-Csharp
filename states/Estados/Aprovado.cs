using System;

namespace states
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicaDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * 0.98;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento já está aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento já está aprovado, não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}