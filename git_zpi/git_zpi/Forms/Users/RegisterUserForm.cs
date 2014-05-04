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
    public partial class RegisterUserForm : Form
    {
        private IUserRepository _users;

        public RegisterUserForm()
        {
            InitializeComponent();
            _users = new UserRepository(new ZpiDbContext());
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            UserModel user = new UserModel();
            user.Login = loginTextBox.Text;
            user.Password = UserModel.hashPass(passwordTextBox.Text);
            user.Firstname = firstnameTextBox.Text;
            user.Lastname = lastnameTextBox.Text;
            _users.Add(user);

            MessageBox.Show("Dodano pomyślnie nowego użytkownika");
            FormHelper.CloseForm(this);

            Cursor = Cursors.Default;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormHelper.CloseForm(this);
        }
    }
}
