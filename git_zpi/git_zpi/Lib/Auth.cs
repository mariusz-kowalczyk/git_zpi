using git_zpi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_zpi.Lib
{
    class Auth
    {
        private static UserModel _user = null;

        public static void SetUser(UserModel user)
        {
            _user = user;
        }

        public static UserModel GetUser()
        {
            return _user;
        }

        public static bool Check()
        {
            if (_user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Clear()
        {
            _user = null;
        }
    }
}
