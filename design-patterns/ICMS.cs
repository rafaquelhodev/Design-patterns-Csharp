using System;

namespace design_patterns
{
    public class ICMS
    {
        public double CalculaICMS(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

    }

}