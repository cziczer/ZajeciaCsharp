using System;

namespace Polymorphism
{
    public interface INotificationChannel
    {
        void Send();
    }

    public class MailNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Sending mail...");
        }
    }

    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}