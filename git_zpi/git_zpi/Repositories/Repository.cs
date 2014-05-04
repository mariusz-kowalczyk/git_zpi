using git_zpi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Repositories
{
    class Repository
    {
        protected ZpiDbContext _context;
        private bool disposed = false;

        public Repository(ZpiDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                _context.Dispose();
                disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
