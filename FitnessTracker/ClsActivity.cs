using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    class ClsActivity
    {
        String actID, actName, mone, mtwo, mthree, calb;

        public String AID
        {
            get { return actID; }
            set { actID = value; }
        }

        public String AName
        {
            get { return actName; }
            set { actName = value; }
        }
        public String MOne
        {
            get { return mone; }
            set { mone = value; }
        }
        public String MTwo
        {
            get { return mtwo; }
            set { mtwo = value; }
        }
        public String MThree
        {
            get { return mthree; }
            set { mthree = value; }
        }
    }
}
