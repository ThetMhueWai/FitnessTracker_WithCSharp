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

        public Goal()
        {
            InitializeComponent();
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            txtmID.Text=UserLogin.loginUID;
            txtmName.Text = UserLogin.loginUName;


        }
    }
}
