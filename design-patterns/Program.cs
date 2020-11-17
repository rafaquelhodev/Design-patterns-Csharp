using System;
using System.Collections.Generic;
using design_patterns.Descontos;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var itens = new List<Item>
            {
                new Item("lápis", 10.0),
                new Item("borracha", 20.0),
                new Item("caneta", 20.0),
                new Item("régua", 20.0),
                new Item("carteira", 20.0),
            };

            var orcamento = new Orcamento(500, itens);

            var iss = new ISS();
            var icms = new ICMS();

            var valorIss = new CalculadorDeImpostos().RealizaCalculo(orcamento, iss);
            var valorIcms = new CalculadorDeImpostos().RealizaCalculo(orcamento, icms);
            Console.WriteLine(valorIss);
            Console.WriteLine(valorIcms);

            var valorDesconto = new CalculadorDeDescontos().RealizaCalculo(orcamento);
            Console.WriteLine(valorDesconto);

        }
    }
}
