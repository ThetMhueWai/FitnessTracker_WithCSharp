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
    public partial class Activity : Form
    {
        FitnessDataSetTableAdapters.ActivitytbTableAdapter activity = new FitnessDataSetTableAdapters.ActivitytbTableAdapter();
        DataTable activitydta = new DataTable(); 

        public Activity()
        {
            InitializeComponent();
        }

        public void activityAutoID()
        {
            activitydta = activity.GetData();
            if (activitydta.Rows.Count == 0)
            {
                txtActivityID.Text = "a001";
            }
            else
            {
                int size = activitydta.Rows.Count - 1;
                string oldid = activitydta.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));
                if (newid >= 1 && newid < 9)
                {
                    txtActivityID.Text = "a00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtActivityID.Text = "a0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtActivityID.Text = "a" + (newid + 1);
                }

            }

        } 

        private void Activity_Load(object sender, EventArgs e)
        {
            activityAutoID();
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            if (txtActivityName.Text == "")
            {
                MessageBox.Show("Fill Activity Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivityName.Focus();
            }
            else if (txtMetricOne.Text == "")
            {
                MessageBox.Show("Fill Metric One!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricOne.Focus();
            }

            else if (txtMetricTwo.Text == "")
            {
                MessageBox.Show("Fill Metric Two!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricTwo.Focus();
            }
            else if (txtMetricThree.Text == "")
            {
                MessageBox.Show("Fill Metric Three!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMetricThree.Focus();
            }
            else
            {

                ClsActivity activities = new ClsActivity();

                activities.AID = txtActivityID.Text;

                activities.AName = txtActivityName.Text;

                activities.MOne = txtMetricOne.Text;

                activities.MTwo = txtMetricTwo.Text;

                activities.MThree = txtMetricThree.Text;

                int insertquery = activity.InsertActivityQuery(activities.AID, activities.AName, activities.MOne, activities.MTwo, activities.MThree);
                if (insertquery > 0)
                {
                    MessageBox.Show("Activity data insert Successfully Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    activityAutoID();

                    //StaffLogin Slogin = new StaffLogin();
                    //this.Hide();
                    //Slogin.ShowDialog();
                }

            } 
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard Adashboard = new AdminDashboard();
            this.Hide();
            Adashboard.ShowDialog();
        }
    }
}
