using git_zpi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Repositories
{
    class UserRepository : Repository, IUserRepository
    {
        public UserRepository(ZpiDbContext context)
            : base(context)
        {

        }

        public void Add(UserModel user)
        {
            user.CreatedAt = System.DateTime.Now;
            user.UpdatedAt = System.DateTime.Now;

            _context.Users.Add(user);

            _context.SaveChanges();
        }
    }
}
