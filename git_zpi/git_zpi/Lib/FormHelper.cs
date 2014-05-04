using git_zpi.Forms;
using git_zpi.Forms.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_zpi.Lib
{
    class FormHelper
    {
        private static int countOpenWindows = 1;

        public static void Checkout(Form oldForm, Form newForm)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(() => Application.Run(newForm)));
            t.SetApartmentState(System.Threading.ApartmentState.STA);

            t.Start();
            oldForm.Close();
        }

        public static void OpenForm(Form form)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(() => Application.Run(form)));
            t.SetApartmentState(System.Threading.ApartmentState.STA);

            countOpenWindows++;
            t.Start();
        }

        public static void CloseForm(Form form)
        {
            if (countOpenWindows > 1)
            {
                countOpenWindows--;
                form.Close();
            }
            else
            {
                if (Auth.Check())
                {
                    Checkout(form, new MainForm());
                }
                else
                {
                    Checkout(form, new LoginUserForm());
                }
            }
            
        }
    }
}
