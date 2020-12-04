using System;

namespace builder
{
    public class EnviarEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("enviando email");
        }
    }
}