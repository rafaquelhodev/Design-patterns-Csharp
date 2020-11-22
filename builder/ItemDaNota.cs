namespace builder
{
    public class ItemDaNota
    {
        public string Item { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(string item, double valor)
        {
            this.Item = item;
            this.Valor = valor;
        }
    }
}