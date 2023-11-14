using System;
using System.Collections.Generic;
using System.Text;

namespace PartOneLibrary
{
    public class User
    {
        public User()
        {

        }

        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
