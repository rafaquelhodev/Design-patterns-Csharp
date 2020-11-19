using System;

namespace states
{
    public class Reprovado : IEstadoOrcamento
    {
        public void AplicaDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento reprovado não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}