using git_zpi.Forms.Users;
using git_zpi.Models;
using git_zpi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_zpi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IUserRepository _users = new UserRepository(new ZpiDbContext());

            if (_users.Count() > 0)
            {
                Application.Run(new LoginUserForm());
            }
            else
            {
                Application.Run(new RegisterUserForm());
            }
            
        }
    }
}
