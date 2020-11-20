
using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var notification = new VideoNotification();

            notification.RegisterNotificationChannel(new MailNotificationChannel());
            notification.RegisterNotificationChannel(new SmsNotificationChannel());
            //notification.Notification();

            //object a = new object();
            //var testIsOperator = new SmsNotificationChannel();
            //if (testIsOperator is INotificationChannel)
            //    Console.WriteLine("object implements INoticationChannel");

            //var castAsObject = (INotificationChannel)testIsOperator;

            ExampleClass conflict = new ExampleClass();
            IPaint paint = conflict;
            ISurface surface = conflict;

            conflict.Paint();
            paint.Paint();
            surface.Paint();

            Console.WriteLine(conflict.Mystery());
            //conflict.Mystery();

            Console.ReadKey();
        }
    }
}
