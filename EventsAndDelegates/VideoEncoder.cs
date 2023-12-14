using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class Video
    {
        public string Title { get; set; }
    }
    public class VideoEncoder
    {


        // define a delegate 
        // define event based upon that delegate 
        // Raise the event
        public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);
        public event VideoEncoderEventHandler VideoEncoded; 

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding the video...");
            Thread.Sleep(2000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //Console.WriteLine(VideoEncoded.GetInvocationList +"on video encoded");
            if (VideoEncoded != null) { 
                VideoEncoded(this, new VideoEventArgs() { Video = video});
                foreach (var handler in VideoEncoded.GetInvocationList())
                {
                    Console.WriteLine(handler.Method.Name);
                    Console.WriteLine(handler.Target?.GetType());

                }

            }
        }
    }
}
