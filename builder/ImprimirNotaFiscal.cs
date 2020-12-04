using System;

namespace builder
{
    public class ImprimirNotaFiscal : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("imprime nota fiscal");
        }
    }
}