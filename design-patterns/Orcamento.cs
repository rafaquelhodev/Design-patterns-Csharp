using System;
using System.Collections.Generic;

namespace design_patterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(double valor, List<Item> itens)
        {
            this.Valor = valor;
            this.Itens = itens;
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}