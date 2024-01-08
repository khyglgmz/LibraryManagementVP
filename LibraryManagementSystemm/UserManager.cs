using LibraryManagementSystemm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemm
{
    public static class UserManager
    {
        private static User? _currentUser;

        public static User? CurrentUser
        {
            get { return _currentUser; }
        }

        public static void Login(User user)
        {
            _currentUser = user;
        }

        public static void Logout()
        {
            _currentUser = null;
        }
    }
}
