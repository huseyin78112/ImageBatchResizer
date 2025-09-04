namespace ImageBatchResizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            int failedImages = 0;
            if (ofdInputFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofdInputFile.FileNames)
                {
                    try
                    {
                        if (!lbFiles.Items.Contains(file))
                        {
                            ImageItem ii = new ImageItem();
                            ii.Bitmap = new Bitmap(file);
                            ii.FileName = file;
                            lbFiles.Items.Add(ii);
                        }
                    }
                    catch
                    {
                        failedImages++;
                    }
                }
                if (failedImages != 0)
                {
                    MessageBox.Show(failedImages + " images failed to open, they're invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            ImageItem ii = (ImageItem)lbFiles.SelectedItem;
            ii.Bitmap.Dispose();
            lbFiles.Items.Remove(ii);
        }

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            AddImageSizeDialog dlg = new AddImageSizeDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lbSizes.Items.Add(dlg.ResultSize);
            }
        }

        private void btnRemoveSize_Click(object sender, EventArgs e)
        {
            lbSizes.Items.Remove(lbSizes.SelectedItem);
        }

        private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
        {
            if (fbdOutputFolder.ShowDialog() == DialogResult.OK)
            {
                tbOutputFolder.Text = fbdOutputFolder.SelectedPath;
            }
        }

        private void btnStartBatchResize_Click(object sender, EventArgs e)
        {
            if (lbFiles.Items.Count == 0)
            {
                MessageBox.Show("At least one file must be specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lbSizes.Items.Count == 0)
            {
                MessageBox.Show("At least one size must be specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbOutputFolder.Text))
            {
                MessageBox.Show("Output folder can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Path.IsPathFullyQualified(tbOutputFolder.Text))
            {
                MessageBox.Show("The output folder is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(tbOutputFolder.Text))
            {
                MessageBox.Show("Output folder doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(tbOutputNameFormat.Text))
            {
                MessageBox.Show("Output name format can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbOutputNameFormat.Text.IndexOfAny(Path.GetInvalidFileNameChars()) > 0)
            {
                MessageBox.Show("The output name format contains disallowed characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartBatches();
        }

        private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFiles.SelectedIndex < 0)
            {
                btnRemoveFile.Enabled = false;
            }
            else
            {
                btnRemoveFile.Enabled = true;
            }
        }

        private void lbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSizes.SelectedIndex < 0)
            {
                btnRemoveSize.Enabled = false;
            }
            else
            {
                btnRemoveSize.Enabled = true;
            }
        }

        private void StartBatches()
        {
            var items = lbFiles.Items;
            string output = tbOutputFolder.Text;
            string oformat = tbOutputNameFormat.Text;
            bool failed = false;
            WaitDialog wd = new WaitDialog("Batch is in progress.", () =>
            {
                try
                {
                    foreach (var item in items)
                    {
                        if (item is ImageItem ii)
                        {
                            foreach (var size in lbSizes.Items)
                            {
                                if (size is ImageSize imgsize)
                                {
                                    Size nsize = new Size();
                                    if (imgsize.SizeType == ImageSize.ImageSizeType.Pixels)
                                    {
                                        nsize = new Size(imgsize.Width, imgsize.Height);
                                    }
                                    else
                                    {
                                        nsize = new Size((int)(ii.Bitmap.Width * (((double)imgsize.Width) / 100)), (int)(ii.Bitmap.Height * (((double)imgsize.Height) / 100)));
                                    }
                                    Bitmap nb = null;
                                    if (imgsize.SizeMode == ImageSize.ImageSizeMode.Center)
                                    {
                                        nb = new Bitmap(nsize.Width, nsize.Height);
                                        Graphics g = Graphics.FromImage(nb);
                                        g.DrawImage(ii.Bitmap, new Point((nsize.Width - ii.Bitmap.Width) / 2, (nsize.Height - ii.Bitmap.Height) / 2));
                                    }
                                    else if (imgsize.SizeMode == ImageSize.ImageSizeMode.Stretch)
                                    {
                                        nb = new Bitmap(ii.Bitmap, nsize);
                                    }
                                    nb.Save(Path.Combine(output, oformat.Replace("{file}", Path.GetFileNameWithoutExtension(ii.FileName)).Replace("{width}", nsize.Width.ToString()).Replace("{height}", nsize.Height.ToString()).Replace("{ext}", Path.GetExtension(ii.FileName))));
                                    nb.Dispose();
                                }
                            }
                        }
                    }
                }
                catch
                {
                    failed = true;
                }
            });
            wd.ShowDialog();
            if (failed)
            {
                MessageBox.Show("Batch operation was interrupted because of an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Batch operation complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
