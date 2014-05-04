using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Models
{
    class ZpiDbContext : DbContext
    {
        public ZpiDbContext()
            : base("SqlClient")
        {
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
