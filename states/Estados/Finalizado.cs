using System;

namespace states
{
    public class Finalizado : IEstadoOrcamento
    {
        public void AplicaDesconto(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento finalizado não pode ser aprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new ApplicationException("Orçamento já está finalizado");
        }
    }
}