using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsUser
    {
        String userID, userName, userPassword, userPhone, userEmail, userGender;
        DateTime userdob;

        public String UID
        {
            get { return userID; }
            set { userID = value; }
        }
        public String UName
        {
            get { return userName; }
            set { userName = value; }
        }
        public String UPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public String UPhone
        {
            get { return userPhone; }
            set { userPhone = value; }
        }
        public String UEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        public String UGender
        {
            get { return userGender; }
            set { userGender = value; }
        }
        public DateTime Udob
        {
            get { return userdob; }
            set { userdob = value; }
        }
    }
}
