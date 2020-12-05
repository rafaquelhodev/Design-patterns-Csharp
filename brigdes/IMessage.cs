namespace bridges
{
    public interface IMessage
    {
        ISender Sender { get; set; }
        string Message { get; set; }

        void Format();
        void Send();
    }
}