using System;
using System.Runtime.InteropServices;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // DELEGATY
            //var process = new PhotoProcessor();
            //var filters = new PhotoFilters();

            ////PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.Resize;
            //filterHandler += RemoveRedEyes;

            //process.Process("first photo", filterHandler);
            //filterHandler -= filters.ApplyBrightness;

            //Console.WriteLine();
            //process.Process("second path", filterHandler);

          //  EVENTY
           var video = new Video() { Title = "Shrek" };
            var videoEncoder = new VideoEncoder(); // publisher eventów
            var mailService = new MailService(); //subscriber eventu

            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // event handler - referencja do funkcji

            videoEncoder.Encode(video);

            var messageService = new MessageService();

            //videoEncoder.VideoEncoded += messageService.AnotherHandler;

            videoEncoder.Encode(video);

            Console.ReadKey();

        }

        static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Red eyes removed");
        }
    }
}
