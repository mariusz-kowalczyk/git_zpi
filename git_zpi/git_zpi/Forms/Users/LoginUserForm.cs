using git_zpi.Lib;
using git_zpi.Models;
using git_zpi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_zpi.Forms.Users
{
    public partial class LoginUserForm : BaseForm
    {
        private IUserRepository _users;

        public LoginUserForm()
        {
            InitializeComponent();
            this.enableCloseApp = true;
            _users = new UserRepository(new ZpiDbContext());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string login = loginTextBox.Text;
            string pass = UserModel.hashPass(passwordTextBox.Text);

            UserModel user = _users.GetByLogin(login);
            if (user != null && user.Password == pass)
            {
                //zaloguj
                Auth.SetUser(user);
                FormHelper.Checkout(this, new MainForm());
            }
            else
            {
                //niepoprawne dane
                MessageBox.Show("Niepoprawny login lub hasło");
            }

            Cursor = Cursors.Default;
        }
    }
}
