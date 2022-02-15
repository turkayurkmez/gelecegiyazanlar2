using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir sınıf, interface'i implemente ettiğinde, o interface'den gelen tüm fonksiyonlar kullanılabilir olmalı. 
             * 
             * Bir fonksiyon bir interface'e bağlı olmaya zorlanmamalı.
             */
        }

    }


    public interface IMessage
    {
         string From { get; set; }
         string To { get; set; }
         string Body { get; set; }
         string Subject { get; set; }
      
       
    }
    public interface ITextMessage: IMessage
    {
         string Content { get; set; }
    }
    public interface IVideoMessage : IMessage
    {
        int VideoDuration { get; set; }
        string VideoFormat { get; set; }
    }


    public interface IImageMessage : IMessage
    {
        string ImageSize { get; set; }
        string ImageFormat { get; set; }
    }

    public class TextMessage : ITextMessage
    {
        public string From { get ; set ; }
        public string To { get ; set ; }
        public string Body { get ; set ; }
        public string Subject { get ; set ; }
        public string Content { get; set ; }
    }

    public class VideoMessage : IVideoMessage
    {
        public int VideoDuration { get ; set ; }
        public string VideoFormat { get ; set ; }
        public string From { get ; set ; }
        public string To { get ; set ; }
        public string Body { get ; set ; }
        public string Subject { get ; set ; }
    }

    public class ImageMessage : IImageMessage
    {
        public string ImageSize { get ; set ; }
        public string ImageFormat { get ; set ; }
        public string From { get ; set ; }
        public string To { get ; set ; }
        public string Body { get ; set ; }
        public string Subject { get ; set ; }
    }
}
