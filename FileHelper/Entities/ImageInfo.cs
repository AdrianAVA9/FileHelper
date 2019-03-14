using System.IO;

namespace FileHelper.Entities
{
    public class ImageInfo:FileInfo
    {
        public Stream Stream { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
