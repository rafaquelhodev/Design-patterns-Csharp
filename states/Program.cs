using System;

namespace states
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(500.0);

            orcamento.Aprova();
            orcamento.AplicaDesconto();

            Console.WriteLine(orcamento.Valor);
        }
    }
}
