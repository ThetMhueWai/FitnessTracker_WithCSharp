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
    public partial class Track : Form
    {
        FitnessDataSetTableAdapters.TracktbTableAdapter track = new FitnessDataSetTableAdapters.TracktbTableAdapter();
        FitnessDataSetTableAdapters.ActivitytbTableAdapter activity = new FitnessDataSetTableAdapters.ActivitytbTableAdapter();

        DataTable trackdta = new DataTable();

        public Track()
        {
            InitializeComponent();
        }

        private void Track_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDataSet.Tracktb' table. You can move, or remove it, as needed.
            this.tracktbTableAdapter.Fill(this.fitnessDataSet.Tracktb);

            trackdta = track.GetData();
            dgvTrack.DataSource = trackdta;

            trackdta=track.GetDataByUserID(UserLogin.loginUID);

        }

        private void dgvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTrack.CurrentRow.Index;
            txtTrackID.Text = dgvTrack[0, row].Value.ToString();
            txtgoal.Text = dgvTrack[7, row].Value.ToString();

            dgvTrack.Refresh();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int met = Convert.ToInt32(txtMet.Text);
            int weight = Convert.ToInt32(txtbodyWeight.Text);
            int hours = Convert.ToInt32(txtTimetaken.Text);

            int result = met * weight * hours;
            txtTotalcal.Text = Convert.ToString(result);
        }

        public void clearall()
        {
            txtMet.Text = "";
            txtTimetaken.Text = "";
            txtbodyWeight.Text = "";
            txtTotalcal.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int goal = Convert.ToInt32(txtgoal.Text);
            if (Convert.ToInt32(txtTotalcal.Text) >= goal)
            {
                track.UpdateTrackInformation("Complete", Convert.ToInt32(txtTotalcal.Text), txtTrackID.Text);
                MessageBox.Show("Your Calories Burning Goal is Complete!");

                dgvTrack.DataSource = track.GetDataByUserID(UserLogin.loginUID);
                dgvTrack.Refresh();

                clearall();
            }
            else 
            {
                MessageBox.Show("Sorry! You Cannot get your goal Try Again");

                UserLogin ul = new UserLogin();
                this.Hide();
                ul.ShowDialog();
            }

        }
    }
}
