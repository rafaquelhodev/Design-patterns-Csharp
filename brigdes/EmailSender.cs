using System;

namespace bridges
{
    public class EmailSender : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message through email");
            message.Send();
            Console.WriteLine($"The message was {message.Message}");
        }
    }
}