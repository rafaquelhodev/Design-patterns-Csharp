using System;

namespace bridges
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender smsSender = new SmsSender();
            ISender emailSender = new EmailSender();

            IMessage messageNormalUser = new MessageNormalUser("normal user");
            messageNormalUser.Sender = smsSender;
            messageNormalUser.Send();
        }
    }
}
