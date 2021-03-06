using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DelegatesPractice
{


    public class VideoEncoder
    {
        // Define delegate (method signature)
        // Define event based on delegate
        // Raise(publish) event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        protected virtual void OnVideoEncoded()
        {
            // if subscribers exist
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            // call event
            OnVideoEncoded();
        }
    }
}
