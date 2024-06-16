using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsAdmin
    {
        String adminID, adminName, adminAddress, adminPhone, adminPassword, adminEmail;
        public String AID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        public String AName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        public String AAddress
        {
            get { return adminAddress; }
            set { adminAddress = value; }
        }
        public String APhone
        {
            get { return adminPhone; }
            set { adminPhone = value; }
        }
        public String APassword
        {
            get { return adminPassword; }
            set { adminPassword = value; }
        }
        public String AGmail
        {
            get { return adminEmail; }
            set { adminEmail = value; }
        }
    }
}
