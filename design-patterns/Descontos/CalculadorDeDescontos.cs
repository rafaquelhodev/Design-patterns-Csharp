
namespace design_patterns.Descontos
{
    public class CalculadorDeDescontos
    {
        public double RealizaCalculo(Orcamento orcamento)
        {
            var descontoEntreZeroECincoItens = new DescontoEntreZeroECincoItens();
            var descontoEntreCincoEDezItens = new DescontoEntreCincoEDezItens();
            var semDesconto = new SemDesconto();

            descontoEntreZeroECincoItens.Proximo = descontoEntreCincoEDezItens;
            descontoEntreCincoEDezItens.Proximo = semDesconto;

            return descontoEntreZeroECincoItens.Calcula(orcamento);

        }

    }
}