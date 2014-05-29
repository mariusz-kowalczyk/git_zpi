using git_zpi.Forms.Users;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Auth.Clear();
            FormHelper.Checkout(this, new LoginUserForm());
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            FormHelper.OpenForm(new RegisterUserForm());
        }

        private void buttonGenerujFakture_Click(object sender, EventArgs e)
        {
            InvoiceGenerate IG = new InvoiceGenerate();
            IG.ShowDialog();
        }
    }
}
