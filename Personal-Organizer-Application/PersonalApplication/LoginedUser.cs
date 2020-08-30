using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Organizer_Application
{
    class LoginedUser
    {
        private User user;
        private static LoginedUser loginedUser;
        public User UserGetSet { get => user; set => user = value; }
        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}
