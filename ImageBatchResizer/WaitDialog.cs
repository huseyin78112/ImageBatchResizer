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
    public partial class WaitDialog : Form
    {
        private Action _action;
        public WaitDialog(string reason, Action action)
        {
            InitializeComponent();
            lblWaitReason.Text = reason;
            _action = action;
        }
        bool canClose = false;
        private void RequestClose()
        {
            canClose = true;
            Close();
        }

        private void WaitDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !canClose;
        }

        private async void WaitDialog_Shown(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                _action();
            });
            RequestClose();
        }
    }
}
