using System;
namespace fotobuch2.Core.Models
{
    public class ImageWrapper
    {
        public string Path { get; set; }
        public int AmountChoosen { get; set; }

        public ImageWrapper(string path)
        {
            Path = path;
            AmountChoosen = 0;
        }
    }
}
