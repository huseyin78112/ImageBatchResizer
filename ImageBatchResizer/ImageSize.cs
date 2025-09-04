using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBatchResizer
{
    public class ImageSize
    {
        public enum ImageSizeType
        {
            Pixels,
            Percentage
        }
        public enum ImageSizeMode
        {
            Center,
            Stretch
        }
        public int Width;
        public int Height;
        public ImageSizeType SizeType;
        public ImageSizeMode SizeMode;
        public override string ToString()
        {
            return $"{Width}x{Height} ({SizeType}, {SizeMode})";
        }
    }
}
