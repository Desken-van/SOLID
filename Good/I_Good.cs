using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Good
{
    class I_Good
    {
        interface IMessage
        {
            void Send();
            string Recepient { get; set; }
            string Sender { get; set; }
        }
        interface ISmsMessage : IMessage
        {
            string Text { get; set; }
        }
        interface IEmailMessage : ISmsMessage
        {
            string Email { get; set; }
        }
        class EmailMessage : IEmailMessage
        {
            public string Text { get; set; }
            public string Recepient { get; set; }
            public string Sender { get; set; }
            public string Email { get; set; }
            public void Send()
            {
                Console.WriteLine($"Отправляем по Email сообщение к {Email}:" + Text);
            }
        }
        class SmsMessage : ISmsMessage
        {
            public string Text { get; set; }
            public string Recepient { get; set; }
            public string Sender { get; set; }          
            public void Send()
            {
                Console.WriteLine("Отправляем по Sms сообщение: " + Text);
            }
            //static void Main(string[] args)
            //{
                //IMessage mail = new EmailMessage
                //{
                    //Text = "Hi Nick",
                    //Sender = "John",
                    //Recepient = "Nick",
                    //Email = "nickdot@gmail.com"
                //};
                //mail.Send();
                //IMessage sms = new SmsMessage
                //{
                    //Text = "Hi Nick",
                    //Sender = "John",
                    //Recepient = "Nick",
                //};
                //sms.Send();
                //Console.ReadKey();
            //}
        }
    }
}
