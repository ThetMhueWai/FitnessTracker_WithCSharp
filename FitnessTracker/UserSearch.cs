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
    public partial class UserSearch : Form
    {
        FitnessDataSetTableAdapters.TracktbTableAdapter track = new FitnessDataSetTableAdapters.TracktbTableAdapter();
        DataTable trackdta = new DataTable();

        public static string trackid, activityname, uid;

        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            dgvSearch.DataSource=track.GetData();
            dgvSearch.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                dgvSearch.DataSource = track.SearchByActName(UserLogin.loginUID, txtsractName.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong",ex.Message);
            }
        }
    }
}
