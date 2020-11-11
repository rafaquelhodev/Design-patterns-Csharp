using System;

namespace design_patterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, string imposto)
        {
            if ("ICMS".Equals(imposto))
            {
                double icms = new ICMS().CalculaICMS(orcamento);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }

        }
    }
}
