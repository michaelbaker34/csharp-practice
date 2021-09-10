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
            // subscriber
            var mailService = new MailService();
            // subscriber
            var messageService = new MessageService();
             
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}
