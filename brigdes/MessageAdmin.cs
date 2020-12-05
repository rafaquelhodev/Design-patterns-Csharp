namespace bridges
{
    public class MessageAdmin : IMessage
    {
        public ISender Sender { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }

        public void Format()
        {
            Message = $"Message for admin {UserName}";
        }

        public void Send()
        {
            Sender.Send(this);
        }
    }
}