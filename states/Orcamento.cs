namespace states
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IEstadoOrcamento EstadoAtual { get; set; }

        public Orcamento()
        {
            this.EstadoAtual = new EmAprovacao();
        }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDesconto()
        {
            EstadoAtual.AplicaDesconto(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}