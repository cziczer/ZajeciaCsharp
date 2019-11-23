
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var notification = new VideoNotification();



        //    notification.RegisterNotificationChannel(new MailNotificationChannel());
            notification.RegisterNotificationChannel(new SmsNotificationChannel());
            notification.Notification();

            Console.ReadKey();
        }
    }
}
