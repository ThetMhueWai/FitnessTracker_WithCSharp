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


        }

        private void dgvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTrack.CurrentRow.Index;
            txtTrackID.Text = dgvTrack[0, row].Value.ToString();
            txtgoal.Text = dgvTrack[7, row].Value.ToString();

            dgvTrack.Refresh();
        }
    }
}
