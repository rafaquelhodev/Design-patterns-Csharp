namespace decorator
{
    public abstract class Imposto
    {
        public abstract double Calcula(Orcamento orcamento);

        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        public Imposto()
        {
            this.OutroImposto = null;
        }
    }

}