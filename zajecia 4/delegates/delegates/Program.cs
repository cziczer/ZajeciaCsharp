using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // DELEGATY
            var process = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.Resize;
            filterHandler += RemoveRedEyes;

            process.Process("path", filterHandler);
            filterHandler -= filters.ApplyBrightness;
            process.Process("path", filterHandler);

            Console.ReadKey();

        }

        static void RemoveRedEyes(Photo photo)
        {
            Console.WriteLine("Red eyes removed");
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e) 
        {
            Console.WriteLine("Sendin a message");
        }
    }
}
