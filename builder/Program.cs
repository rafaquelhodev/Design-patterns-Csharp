using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaFiscalBuilder = new NotaFiscalBuilder();

            NotaFiscal notaFiscal = notaFiscalBuilder.ParaRazaoSocial("razao social")
                            .ParaCnpj("12.345.678/0001-12")
                            .ParaDataEmissao()
                            .ParaItem(new ItemDaNota("item 1", 100.0))
                            .ParaItem(new ItemDaNota("item 2", 200.0))
                            .ParaObservacoes("observacao")
                            .ParaAcoesAposGerarNota(new EnviarEmail())
                            .ParaAcoesAposGerarNota(new ImprimirNotaFiscal())
                            .Constroi();

            Console.WriteLine(notaFiscal);
        }
    }
}
