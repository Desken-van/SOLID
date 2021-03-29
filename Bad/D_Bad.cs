using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Bad
{
    class D_Bad
    {
        class Message
        {
            public string Text { get; set; }
            public MessageSender Sender { get; set; }

            public void Send()
            {
                Sender.Send(Text);
            }
        }
        class MessageSender
        {
            public void Send(string text)
            {
                Console.WriteLine(text);
            }
        }
        //static void Main(string[] args)
        //{
            //Message sms = new Message();
            //sms.Text = "Hi guys";
            //MessageSender sender = new MessageSender();
            //sms.Sender = sender;
            //sms.Send();
            //Console.ReadKey();
        //}
    }
}
