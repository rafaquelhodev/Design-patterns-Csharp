namespace bridges
{
    public class MessageNormalUser : IMessage
    {
        public ISender Sender { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }

        public MessageNormalUser(string userName)
        {
            UserName = userName;
            this.Format();
        }

        public void Format()
        {
            Message = $"Message for client {UserName}";
        }

        public void Send()
        {
            Sender.Send(this);
        }
    }
}