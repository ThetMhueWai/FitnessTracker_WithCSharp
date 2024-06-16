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
    public partial class AdminStart : Form
    {
        public AdminStart()
        {
            InitializeComponent();
        }

        private void btnnewAdmin_Click(object sender, EventArgs e)
        {
            AdminRegister AReg = new AdminRegister();
            this.Hide();
            AReg.ShowDialog();
        }

        private void btnCurrentAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin Alogin = new AdminLogin();
            this.Hide();
            Alogin.ShowDialog();
        }
    }
}
