using System;

namespace bridges
{
    public class SmsSender : ISender
    {
        public void Send(IMessage message)
        {
            Console.WriteLine("Sending message through SMS");
            Console.WriteLine($"The message was {message.Message}");
        }
    }
}