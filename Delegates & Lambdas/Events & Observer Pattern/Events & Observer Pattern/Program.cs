namespace Events___Observer_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Observer Pattern

            YoutubeChannel channel = new YoutubeChannel();

            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();

            sub1.Subscribe(channel);
            sub2.Subscribe(channel);
            sub3.Subscribe(channel);

            //channel.UploadVideo("video1");
            //channel.UploadVideo("video2");
            //channel.UploadVideo("video3");

            //channel.videoUpload("Delegate"); // problem- direct invoke
            //channel.videoUpload = null; // problem#2- setting delegate to null    

            channel.videoUpload += (string title) => Console.WriteLine(title);

        }
    }

    public delegate void VideoUpload(string title);

    public class YoutubeChannel
    {
        public event VideoUpload videoUpload;
        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"New video uploaded {videoTitle}");
            videoUpload.Invoke(videoTitle);
        }
    }

    public class Subscriber
    {
        public void Subscribe(YoutubeChannel ytChannel)
        {
            ytChannel.videoUpload += WatchTheVideo;
        }

        public void WatchTheVideo(string videoTitle) // handler
        {
            Console.WriteLine($"User watch {videoTitle}");
        }
    }
}
