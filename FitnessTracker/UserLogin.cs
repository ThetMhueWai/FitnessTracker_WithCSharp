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
    public partial class UserLogin : Form
    {
        FitnessDataSetTableAdapters.UsertbTableAdapter user = new FitnessDataSetTableAdapters.UsertbTableAdapter();
        DataTable usertda = new DataTable();

        int logincount = 0;

        public static string loginUName,loginUID;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnULogin_Click(object sender, EventArgs e)
        {
            if (logincount == 2)
            {
                MessageBox.Show("Something Went Wrong Invalid Login, Login Attempt 3");
                Application.Exit();
            }

            else
            {
                if (txtuname.Text == "")
                {
                    MessageBox.Show("Please Fill UserName");
                    txtuname.Focus();
                }
                else if (txtupassword.Text == "")
                {
                    MessageBox.Show("Please Fill Password");
                    txtupassword.Focus();
                }
                else
                {
                    ClsUser userobj = new ClsUser();
                    userobj.UName = txtuname.Text;
                    userobj.UPassword = txtupassword.Text;
                    usertda = user.UserLogin(userobj.UName, userobj.UPassword);

                    if (usertda.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginUID = usertda.Rows[0][0].ToString();
                        loginUName = usertda.Rows[0][1].ToString();

                        Goal goal = new Goal();
                        this.Hide();
                        goal.ShowDialog();
                        
                    }
                    else
                    {
                        logincount += 1;
                        MessageBox.Show("Someting went wrong in Login, Login Attempt " + logincount);
                    }
                }
            } 
        }
    }
}
