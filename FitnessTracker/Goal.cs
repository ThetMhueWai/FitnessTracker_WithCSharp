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
            trackdta = track.GetData();
            if (trackdta.Rows.Count == 0)
            {
                txtTrackID.Text = "T001";
            }
            else
            {
                int size = trackdta.Rows.Count - 1;
                string oldid = trackdta.Rows[size][0].ToString();
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

        //public void selectactivity()
        //{
        //    activitydta = activity.GetData();
        //    if (activitydta.Rows.Count > 0)
        //    {
        //        DataRow dr = activitydta.NewRow();
        //        cboactivity.DataSource = activitydta;

        //        cboactivity.DisplayMember = "actName";
        //        cboactivity.ValueMember = "actID";

        //    }
        //}

        private void Goal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessDataSet.Activitytb' table. You can move, or remove it, as needed.
            this.activitytbTableAdapter.Fill(this.fitnessDataSet.Activitytb);
            txtmID.Text=UserLogin.loginUID;
            txtmName.Text = UserLogin.loginUName;
            trackAutoID();
            txtactID.Text = "";
        }

        private void cboactivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = cboactivity.SelectedValue.ToString();
            txtactID.Text = id;

            activitydta = activity.SelectActivity(txtactID.Text);
            if (activitydta.Rows.Count > 0)
            {
                txtmetricone.Text=activitydta.Rows[0]["MetricOne"].ToString();
                txtmetrictwo.Text=activitydta.Rows[0]["MetricTwo"].ToString();
                txtmetricthree.Text=activitydta.Rows[0]["MetricThree"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int recordedCount=track.RecordTrack(txtTrackID.Text, cboactivity.Text, "Incomplete", txtmID.Text, txtactID.Text, goalDate.Text, Convert.ToInt32(txtGoal.Text));
            
            if (recordedCount > 0)
            {
                MessageBox.Show("Define Goal Successfully");
                Track t = new Track();

                

                this.Hide();
                t.ShowDialog();

            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSearch usearch = new UserSearch();
            usearch.ShowDialog();
        }
    }
}
