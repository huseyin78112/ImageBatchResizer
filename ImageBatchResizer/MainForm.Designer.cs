namespace ImageBatchResizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFiles = new Label();
            lbFiles = new ListBox();
            btnAddFile = new Button();
            btnRemoveFile = new Button();
            btnRemoveSize = new Button();
            btnAddSize = new Button();
            lbSizes = new ListBox();
            lblSizes = new Label();
            lblOutputFolder = new Label();
            tbOutputFolder = new TextBox();
            btnStartBatchResize = new Button();
            ofdInputFile = new OpenFileDialog();
            btnBrowseOutputFolder = new Button();
            fbdOutputFolder = new FolderBrowserDialog();
            lblOutputNameFormat = new Label();
            tbOutputNameFormat = new TextBox();
            lblOutputNameFormatTutorial = new Label();
            SuspendLayout();
            // 
            // lblFiles
            // 
            lblFiles.AutoSize = true;
            lblFiles.Location = new Point(12, 9);
            lblFiles.Name = "lblFiles";
            lblFiles.Size = new Size(33, 15);
            lblFiles.TabIndex = 0;
            lblFiles.Text = "Files:";
            // 
            // lbFiles
            // 
            lbFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbFiles.FormattingEnabled = true;
            lbFiles.IntegralHeight = false;
            lbFiles.ItemHeight = 15;
            lbFiles.Location = new Point(12, 27);
            lbFiles.Name = "lbFiles";
            lbFiles.Size = new Size(332, 382);
            lbFiles.TabIndex = 1;
            lbFiles.SelectedIndexChanged += lbFiles_SelectedIndexChanged;
            // 
            // btnAddFile
            // 
            btnAddFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddFile.Location = new Point(12, 415);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(75, 23);
            btnAddFile.TabIndex = 2;
            btnAddFile.Text = "Add";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveFile.Enabled = false;
            btnRemoveFile.Location = new Point(93, 415);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(75, 23);
            btnRemoveFile.TabIndex = 3;
            btnRemoveFile.Text = "Remove";
            btnRemoveFile.UseVisualStyleBackColor = true;
            btnRemoveFile.Click += btnRemoveFile_Click;
            // 
            // btnRemoveSize
            // 
            btnRemoveSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveSize.Enabled = false;
            btnRemoveSize.Location = new Point(431, 415);
            btnRemoveSize.Name = "btnRemoveSize";
            btnRemoveSize.Size = new Size(75, 23);
            btnRemoveSize.TabIndex = 7;
            btnRemoveSize.Text = "Remove";
            btnRemoveSize.UseVisualStyleBackColor = true;
            btnRemoveSize.Click += btnRemoveSize_Click;
            // 
            // btnAddSize
            // 
            btnAddSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddSize.Location = new Point(350, 415);
            btnAddSize.Name = "btnAddSize";
            btnAddSize.Size = new Size(75, 23);
            btnAddSize.TabIndex = 6;
            btnAddSize.Text = "Add";
            btnAddSize.UseVisualStyleBackColor = true;
            btnAddSize.Click += btnAddSize_Click;
            // 
            // lbSizes
            // 
            lbSizes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbSizes.FormattingEnabled = true;
            lbSizes.IntegralHeight = false;
            lbSizes.ItemHeight = 15;
            lbSizes.Location = new Point(350, 27);
            lbSizes.Name = "lbSizes";
            lbSizes.Size = new Size(332, 382);
            lbSizes.TabIndex = 5;
            lbSizes.SelectedIndexChanged += lbSizes_SelectedIndexChanged;
            // 
            // lblSizes
            // 
            lblSizes.AutoSize = true;
            lblSizes.Location = new Point(350, 9);
            lblSizes.Name = "lblSizes";
            lblSizes.Size = new Size(35, 15);
            lblSizes.TabIndex = 4;
            lblSizes.Text = "Sizes:";
            // 
            // lblOutputFolder
            // 
            lblOutputFolder.AutoSize = true;
            lblOutputFolder.Location = new Point(688, 9);
            lblOutputFolder.Name = "lblOutputFolder";
            lblOutputFolder.Size = new Size(82, 15);
            lblOutputFolder.TabIndex = 8;
            lblOutputFolder.Text = "Output folder:";
            // 
            // tbOutputFolder
            // 
            tbOutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOutputFolder.Location = new Point(688, 27);
            tbOutputFolder.Name = "tbOutputFolder";
            tbOutputFolder.Size = new Size(303, 23);
            tbOutputFolder.TabIndex = 9;
            // 
            // btnStartBatchResize
            // 
            btnStartBatchResize.Location = new Point(688, 56);
            btnStartBatchResize.Name = "btnStartBatchResize";
            btnStartBatchResize.Size = new Size(75, 23);
            btnStartBatchResize.TabIndex = 11;
            btnStartBatchResize.Text = "Start";
            btnStartBatchResize.UseVisualStyleBackColor = true;
            btnStartBatchResize.Click += btnStartBatchResize_Click;
            // 
            // ofdInputFile
            // 
            ofdInputFile.Filter = "All supported types|*.bmp; *.gif; *.jpeg; *.jpg; *.png; *.tiff; *.webp|Windows Bitmap|*.bmp|GIF|*.gif|JPEG|*.jpeg; *.jpg|PNG|*.png|TIFF|*.tiff|WebP|*.webp";
            ofdInputFile.Multiselect = true;
            // 
            // btnBrowseOutputFolder
            // 
            btnBrowseOutputFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseOutputFolder.Location = new Point(997, 26);
            btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
            btnBrowseOutputFolder.Size = new Size(75, 23);
            btnBrowseOutputFolder.TabIndex = 10;
            btnBrowseOutputFolder.Text = "Browse";
            btnBrowseOutputFolder.UseVisualStyleBackColor = true;
            btnBrowseOutputFolder.Click += btnBrowseOutputFolder_Click;
            // 
            // lblOutputNameFormat
            // 
            lblOutputNameFormat.AutoSize = true;
            lblOutputNameFormat.Location = new Point(688, 82);
            lblOutputNameFormat.Name = "lblOutputNameFormat";
            lblOutputNameFormat.Size = new Size(120, 15);
            lblOutputNameFormat.TabIndex = 12;
            lblOutputNameFormat.Text = "Output name format:";
            // 
            // tbOutputNameFormat
            // 
            tbOutputNameFormat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbOutputNameFormat.Location = new Point(688, 100);
            tbOutputNameFormat.Name = "tbOutputNameFormat";
            tbOutputNameFormat.Size = new Size(384, 23);
            tbOutputNameFormat.TabIndex = 13;
            tbOutputNameFormat.Text = "{file}_{width}_{height}{ext}";
            // 
            // lblOutputNameFormatTutorial
            // 
            lblOutputNameFormatTutorial.AutoSize = true;
            lblOutputNameFormatTutorial.Location = new Point(688, 126);
            lblOutputNameFormatTutorial.Name = "lblOutputNameFormatTutorial";
            lblOutputNameFormatTutorial.Size = new Size(265, 75);
            lblOutputNameFormatTutorial.TabIndex = 14;
            lblOutputNameFormatTutorial.Text = "For an output name:\r\n{file}: Original file name without extension\r\n{width}: Output width\r\n{height}: Output height\r\n{ext}: Original file name extension (including dot)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 450);
            Controls.Add(lblOutputNameFormatTutorial);
            Controls.Add(tbOutputNameFormat);
            Controls.Add(lblOutputNameFormat);
            Controls.Add(btnBrowseOutputFolder);
            Controls.Add(btnStartBatchResize);
            Controls.Add(tbOutputFolder);
            Controls.Add(lblOutputFolder);
            Controls.Add(btnRemoveSize);
            Controls.Add(btnAddSize);
            Controls.Add(lbSizes);
            Controls.Add(lblSizes);
            Controls.Add(btnRemoveFile);
            Controls.Add(btnAddFile);
            Controls.Add(lbFiles);
            Controls.Add(lblFiles);
            MinimumSize = new Size(1100, 300);
            Name = "MainForm";
            ShowIcon = false;
            Text = "Image Batch Resizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFiles;
        private ListBox lbFiles;
        private Button btnAddFile;
        private Button btnRemoveFile;
        private Button btnRemoveSize;
        private Button btnAddSize;
        private ListBox lbSizes;
        private Label lblSizes;
        private Label lblOutputFolder;
        private TextBox tbOutputFolder;
        private Button btnStartBatchResize;
        private OpenFileDialog ofdInputFile;
        private Button btnBrowseOutputFolder;
        private FolderBrowserDialog fbdOutputFolder;
        private Label lblOutputNameFormat;
        private TextBox tbOutputNameFormat;
        private Label lblOutputNameFormatTutorial;
    }
}
