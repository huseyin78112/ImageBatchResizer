namespace ImageBatchResizer
{
    partial class WaitDialog
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
            lblWaitReason = new Label();
            SuspendLayout();
            // 
            // lblWaitReason
            // 
            lblWaitReason.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblWaitReason.Location = new Point(12, 9);
            lblWaitReason.Name = "lblWaitReason";
            lblWaitReason.Size = new Size(335, 91);
            lblWaitReason.TabIndex = 0;
            lblWaitReason.Text = "Wait string here";
            // 
            // WaitDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 109);
            ControlBox = false;
            Controls.Add(lblWaitReason);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WaitDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Please wait...";
            FormClosing += WaitDialog_FormClosing;
            Shown += WaitDialog_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Label lblWaitReason;
    }
}