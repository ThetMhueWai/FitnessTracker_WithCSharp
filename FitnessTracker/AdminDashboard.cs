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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            tssbtnAName.Text = AdminLogin.loginUserName;
            txtadminuID.Text = AdminLogin.loginUserID;
        }

        private void tsbtnAddActivity_Click(object sender, EventArgs e)
        {
            Activity acti = new Activity();
            //this.Hide();
            acti.ShowDialog();
        }

   
    }
}
