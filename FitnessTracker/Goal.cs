using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker
{
    public partial class Goal : Form
    {
        FitnessDataSetTableAdapters.UsertbTableAdapter user = new FitnessDataSetTableAdapters.UsertbTableAdapter();
        FitnessDataSetTableAdapters.ActivitytbTableAdapter activity = new FitnessDataSetTableAdapters.ActivitytbTableAdapter();
        FitnessDataSetTableAdapters.TracktbTableAdapter track = new FitnessDataSetTableAdapters.TracktbTableAdapter();

        DataTable activitydta = new DataTable();
        DataTable usertda = new DataTable();
        DataTable trackdta = new DataTable();

        public Goal()
        {
            InitializeComponent();
        }
        public void trackAutoID()
        {
            usertda = user.GetData();
            if (usertda.Rows.Count == 0)
            {
                txtTrackID.Text = "T001";
            }
            else
            {
                int size = usertda.Rows.Count - 1;
                string oldid = usertda.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));
                if (newid >= 1 && newid < 9)
                {
                    txtTrackID.Text = "T00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtTrackID.Text = "T0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtTrackID.Text = "T" + (newid + 1);
                }
            }
        }
        private void Goal_Load(object sender, EventArgs e)
        {
            txtmID.Text=UserLogin.loginUID;
            txtmName.Text = UserLogin.loginUName;
            trackAutoID();

        }
    }
}
