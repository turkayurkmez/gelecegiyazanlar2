using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Report report = new Report(new MailSender())
            //Araba araba = new Araba(new Aku());
            Report report1 = new Report(new MailSender());
            report1.Send();
            Report report2 = new Report(new WhatsAppSender());
            report2.Send();
            
            Report report3 = new Report(new SlackSender());
            report3.Send();

            Report report4 = new Report(new TelegramSender());
            report4.Send();





        }
    }

    public class Report
    {
        ISender sender;

        public Report(ISender sender)
        {
            this.sender = sender;
        }
        public void Send()
        {
          
            sender.Send();

        }
    }

    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail ile gönderildi");
        }

    }

    public class SlackSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Slack ile gönderildi");
        }
    }

    public class WhatsAppSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");

        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile gönderildi");

        }
    }

}
