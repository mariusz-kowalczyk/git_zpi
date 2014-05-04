using git_zpi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Repositories
{
    interface IUserRepository : IDisposable
    {
        void Add(UserModel user);
    }
}
