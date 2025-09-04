using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageBatchResizer
{
    public partial class AddImageSizeDialog : Form
    {
        public AddImageSizeDialog()
        {
            InitializeComponent();
            cbSizeMode.SelectedIndex = 0;
            cbSizeType.SelectedIndex = 0;
        }

        private ImageSize _image_size;
        private ImageSize.ImageSizeMode GetSelectedSizeMode()
        {
            switch (cbSizeMode.SelectedIndex)
            {
                case 0:
                    return ImageSize.ImageSizeMode.Center;
                case 1:
                    return ImageSize.ImageSizeMode.Stretch;
            }
            return ImageSize.ImageSizeMode.Center;
        }
        private ImageSize.ImageSizeType GetSelectedSizeType()
        {
            switch (cbSizeType.SelectedIndex)
            {
                case 0:
                    return ImageSize.ImageSizeType.Pixels;
                case 1:
                    return ImageSize.ImageSizeType.Percentage;
            }
            return ImageSize.ImageSizeType.Pixels;
        }

        public ImageSize ResultSize => _image_size;

        private void btnOK_Click(object sender, EventArgs e)
        {
            _image_size = new ImageSize();
            _image_size.Width = (int)nudWidth.Value;
            _image_size.Height = (int)nudHeight.Value;
            _image_size.SizeMode = GetSelectedSizeMode();
            _image_size.SizeType = GetSelectedSizeType();
            this.DialogResult = DialogResult.OK;
        }
    }
}
