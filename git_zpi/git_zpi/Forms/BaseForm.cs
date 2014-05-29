using git_zpi.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_zpi.Forms
{
    public partial class BaseForm : Form
    {
        public bool enableCloseApp = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (this.enableCloseApp) return;

            e.Cancel = true;
            FormHelper.CloseForm(this);
        }
    }
}
