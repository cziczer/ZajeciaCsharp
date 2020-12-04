using System;
using System.Threading;

namespace delegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(1500);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            // sprawdźmy czy ktoś subskrybuje event! 
            VideoEncoded?.Invoke(this, new VideoEventArgs(){Video =  video}); // source + dodatkowe argumenty
        }
    }

    public class Video
    {
        public string Title { get; set; }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Sending an email about {args.Video.Title}");
        }
    }

    public class MessageService
    {
        public void AnotherHandler(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending SMS!");
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}