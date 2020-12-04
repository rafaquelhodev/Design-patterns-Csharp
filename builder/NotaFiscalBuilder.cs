using System;
using System.Collections.Generic;

namespace builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial;
        public string Cnpj;
        public DateTime DataEmissao;
        public double ValorTotal;
        public double Impostos;
        public List<ItemDaNota> Itens;
        public string Observacoes;
        public List<AcaoAposGerarNota> AcoesAposGerarNota;

        public NotaFiscalBuilder()
        {
            Itens = new List<ItemDaNota>();
            AcoesAposGerarNota = new List<AcaoAposGerarNota>();
        }

        public NotaFiscalBuilder ParaRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ParaCnpj(string Cnpj)
        {
            this.Cnpj = Cnpj;
            return this;
        }

        public NotaFiscalBuilder ParaDataEmissao()
        {
            this.DataEmissao = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ParaItem(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorTotal += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ParaObservacoes(string Observacoes)
        {
            this.Observacoes = Observacoes;
            return this;
        }

        public NotaFiscalBuilder ParaAcoesAposGerarNota(AcaoAposGerarNota acao)
        {
            this.AcoesAposGerarNota.Add(acao);
            return this;
        }

        public NotaFiscal Constroi()
        {
            var notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, DataEmissao, ValorTotal, Impostos, Itens, Observacoes);

            foreach (AcaoAposGerarNota acao in AcoesAposGerarNota)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }

    }
}