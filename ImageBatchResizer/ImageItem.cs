using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBatchResizer
{
    public class ImageItem
    {
        public string FileName;
        public Bitmap Bitmap;
        public override string ToString()
        {
            return FileName;
        }
    }
}
