using System;
using System.Collections.Generic;

namespace design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var itens = new List<Item>();
            var orcamento = new Orcamento(500, itens);

            var iss = new ISS();
            var icms = new ICMS();

            var valorIss = new CalculadorDeImpostos().RealizaCalculo(orcamento, iss);
            var valorIcms = new CalculadorDeImpostos().RealizaCalculo(orcamento, icms);
            Console.WriteLine(valorIss);
            Console.WriteLine(valorIcms);

        }
    }
}
