using System;

namespace Polymorphism
{
    public class MailService
    {
        public void Send()
        {
            Console.WriteLine("Sending email...");
        }
    }

    public class SmsService
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}