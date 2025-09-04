namespace ImageBatchResizer
{
    partial class AddImageSizeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbSizeType = new ComboBox();
            lblSizeType = new Label();
            cbSizeMode = new ComboBox();
            lblSizeMode = new Label();
            lblWidth = new Label();
            nudWidth = new NumericUpDown();
            nudHeight = new NumericUpDown();
            lblHeight = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // cbSizeType
            // 
            cbSizeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSizeType.FormattingEnabled = true;
            cbSizeType.Items.AddRange(new object[] { "Pixels", "Percentage" });
            cbSizeType.Location = new Point(12, 71);
            cbSizeType.Name = "cbSizeType";
            cbSizeType.Size = new Size(384, 23);
            cbSizeType.TabIndex = 7;
            // 
            // lblSizeType
            // 
            lblSizeType.AutoSize = true;
            lblSizeType.Location = new Point(12, 53);
            lblSizeType.Name = "lblSizeType";
            lblSizeType.Size = new Size(56, 15);
            lblSizeType.TabIndex = 6;
            lblSizeType.Text = "Size type:";
            // 
            // cbSizeMode
            // 
            cbSizeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSizeMode.FormattingEnabled = true;
            cbSizeMode.Items.AddRange(new object[] { "Center", "Stretch" });
            cbSizeMode.Location = new Point(12, 27);
            cbSizeMode.Name = "cbSizeMode";
            cbSizeMode.Size = new Size(384, 23);
            cbSizeMode.TabIndex = 5;
            // 
            // lblSizeMode
            // 
            lblSizeMode.AutoSize = true;
            lblSizeMode.Location = new Point(12, 9);
            lblSizeMode.Name = "lblSizeMode";
            lblSizeMode.Size = new Size(64, 15);
            lblSizeMode.TabIndex = 4;
            lblSizeMode.Text = "Size mode:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(12, 97);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(42, 15);
            lblWidth.TabIndex = 8;
            lblWidth.Text = "Width:";
            // 
            // nudWidth
            // 
            nudWidth.Location = new Point(12, 115);
            nudWidth.Maximum = new decimal(new int[] { 7680, 0, 0, 0 });
            nudWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(120, 23);
            nudWidth.TabIndex = 9;
            nudWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.Location = new Point(138, 115);
            nudHeight.Maximum = new decimal(new int[] { 7680, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(120, 23);
            nudHeight.TabIndex = 11;
            nudHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(138, 97);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 10;
            lblHeight.Text = "Height:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 161);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(93, 161);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddImageSizeDialog
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(410, 196);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(nudHeight);
            Controls.Add(lblHeight);
            Controls.Add(nudWidth);
            Controls.Add(lblWidth);
            Controls.Add(cbSizeType);
            Controls.Add(lblSizeType);
            Controls.Add(cbSizeMode);
            Controls.Add(lblSizeMode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddImageSizeDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Size";
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSizeType;
        private Label lblSizeType;
        private ComboBox cbSizeMode;
        private Label lblSizeMode;
        private Label lblWidth;
        private NumericUpDown nudWidth;
        private NumericUpDown nudHeight;
        private Label lblHeight;
        private Button btnOK;
        private Button btnCancel;
    }
}