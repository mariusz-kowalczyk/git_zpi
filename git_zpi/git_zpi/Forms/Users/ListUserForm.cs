using git_zpi.Models;
using git_zpi.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_zpi.Forms.Users
{
    public partial class ListUserForm : BaseForm
    {
        private IUserRepository _users;

        public ListUserForm()
        {
            InitializeComponent();

            _users = new UserRepository(new ZpiDbContext());
            usersDataGridView.DataSource = _users.All();

            EditLink.UseColumnTextForLinkValue = true;
            
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView s = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                DataGridViewCellCollection cells = s.Rows[e.RowIndex].Cells;
                int ID = int.Parse(cells["IDColumn"].Value.ToString());
                switch (s.Columns[e.ColumnIndex].Name)
                {
                    case "EditLink" :
                        MessageBox.Show("Edytuj " + ID);
                        break;
                }
            }
        }
    }
}
