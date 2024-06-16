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
    public partial class AdminLogin : Form
    {
        FitnessDataSetTableAdapters.AdmintbTableAdapter admin = new FitnessDataSetTableAdapters.AdmintbTableAdapter();
        DataTable admindta = new DataTable();
        int logincount = 0;

        public static string loginUserName;
        public static string loginUserID;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (logincount == 2)
            {
                MessageBox.Show("Something Went Wrong Invalid Login, Login Attempt 3");
                Application.Exit();
            }

            else
            {
                if (txtadminuName.Text == "") 
                    {
                        MessageBox.Show("Please Fill UserName");
                        txtadminuName.Focus();
                    }
                    else if (txtadminuPassword.Text == "")
                    {
                        MessageBox.Show("Please Fill Password");
                        txtadminuPassword.Focus();
                    }
                    else
                    {
                        ClsAdmin admintbobj = new ClsAdmin();
                        admintbobj.AName = txtadminuName.Text;
                        admintbobj.APassword = txtadminuPassword.Text;
                        admindta = admin.AdminLogin(admintbobj.AName,admintbobj.APassword);
                        
                        if (admindta.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loginUserID = admindta.Rows[0][0].ToString();
                            loginUserName = admindta.Rows[0][1].ToString();

                            AdminDashboard Adashboard = new AdminDashboard();
                            this.Hide();
                            Adashboard.ShowDialog();
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
