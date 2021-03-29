using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    class D_Good
    {
        interface ISender
        {
            void Send(string text);
        }
        class Message
        {
            public string Text { get; set; }
            public ISender Sender { get; set; }

            public Message(ISender sender)
            {
                this.Sender = sender;
            }

            public void Send()
            {
                Sender.Send(Text);
            }
        }
        class TelegramSender : ISender
        {
            public void Send(string text)
            {
                Console.WriteLine("Отправка в телеграм");
            }
        }
        class GmailSender : ISender
        {
            public void Send(string text)
            {
                Console.WriteLine("Отправка в Gmail");
            }
        }
        //static void Main(string[] args)
        //{
            //Message sms = new Message(new TelegramSender());
            //sms.Send();
            //sms.Sender = new GmailSender();
            //sms.Send();
            //Console.ReadKey();
        //}
    }
}
