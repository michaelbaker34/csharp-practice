using System;

namespace DelegatesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            
            // publisher
            var videoEncoder = new VideoEncoder();
            //subscriber
            var mailService = new MailService();

            videoEncoder.Encode(video);
        }

        public class MailService
        {
            public void OnVideoEncoded(object source, EventArgs e)
            {
                Console.WriteLine("MailService: Sending email...");
            }
        }
    }
}
