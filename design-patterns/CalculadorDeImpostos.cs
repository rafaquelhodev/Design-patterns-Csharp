using System;

namespace design_patterns
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            return valor;

        }
    }
}
