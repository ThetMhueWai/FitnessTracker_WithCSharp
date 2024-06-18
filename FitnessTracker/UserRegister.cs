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
    public partial class UserRegister : Form
    {
        FitnessDataSetTableAdapters.UsertbTableAdapter user = new FitnessDataSetTableAdapters.UsertbTableAdapter();
        DataTable usertda = new DataTable();

        public UserRegister()
        {
            InitializeComponent();
        }

        private void btnURegister_Click(object sender, EventArgs e)
        {
            DateTime dob = dtpUserBirth.Value;
            MessageBox.Show("Date Of Birth" + dob);
        }

        public void userAutoID()
        {
            usertda = user.GetData();
            if (usertda.Rows.Count == 0)
            {
                txtUserID.Text = "U001";
            }
            else
            {
                int size = usertda.Rows.Count - 1;
                string oldid = usertda.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));
                if (newid >= 1 && newid < 9)
                {
                    txtUserID.Text = "U00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtUserID.Text = "U0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtUserID.Text = "U" + (newid + 1);
                }
            }
        } 

        private void UserRegister_Load(object sender, EventArgs e)
        {
            userAutoID();
        }
    }
}
