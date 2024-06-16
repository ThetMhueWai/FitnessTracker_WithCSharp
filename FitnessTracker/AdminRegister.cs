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
    public partial class AdminRegister : Form
    {
        FitnessDataSetTableAdapters.AdmintbTableAdapter admin = new FitnessDataSetTableAdapters.AdmintbTableAdapter();
        DataTable admindta = new DataTable(); 

        public AdminRegister()
        {
            InitializeComponent();
        }

        public void staffAutoID()
        {
            admindta = admin.GetData();
            if (admindta.Rows.Count == 0)
            {
                txtadminID.Text = "A001";
            }
            else
            {
                int size = admindta.Rows.Count - 1;
                string oldid = admindta.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));
                if (newid >= 1 && newid < 9)
                {
                    txtadminID.Text = "A00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtadminID.Text = "A0" + (newid + 1);
                }

                else if (newid >= 99 && newid < 999)
                {
                    txtadminID.Text = "A" + (newid + 1);
                }

            }

        }
        public void clearall()
        {
            txtadminName.Text = "";
            txtadminPassword.Text = "";
            txtadminPhone.Text = "";
            txtadminGmail.Text = "";
            txtadminAddress.Text = "";
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {
            staffAutoID();
        }

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            String password = txtadminPassword.Text;
            String adminName = txtadminName.Text;

            try
            {
                if (txtadminName.Text == "")
                {
                    MessageBox.Show("Fill Admin Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminName.Focus();
                }
                else if (txtadminAddress.Text == "")
                {
                    MessageBox.Show("Fill Admin Address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtadminGmail.Text == "")
                {
                    MessageBox.Show("Fill Admin Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminGmail.Focus();
                }
                else if (txtadminPassword.Text == "")
                {
                    MessageBox.Show("Fill Admin Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPassword.Focus();

                }
                else if (txtadminPhone.Text == "")
                {
                    MessageBox.Show("Fill Admin Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPhone.Focus();
                }
                else if (password.Length < 8 || password.Length > 14)
                {
                    MessageBox.Show("Please Vaild Password Length, should enter between 8 and 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPassword.Focus();
                }
                else if (!password.Any(char.IsUpper))
                {
                    MessageBox.Show("Please should include Upper Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPassword.Focus();
                }
                else if (!password.Any(char.IsLower))
                {
                    MessageBox.Show("Please should include lower Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPassword.Focus();
                }
                else if (!password.Any(char.IsDigit))
                {
                    MessageBox.Show("Please should include digit Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminPassword.Focus();
                }
                else if (!adminName.Any(char.IsDigit))
                {
                    MessageBox.Show("Please should include digit Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtadminName.Focus();
                }
                else
                {
                    ClsAdmin admins = new ClsAdmin();
                    admins.AID = txtadminID.Text;
                    admins.AName = txtadminName.Text;
                    admins.AAddress = txtadminAddress.Text;
                    admins.APhone = txtadminPhone.Text;
                    admins.APassword = txtadminPassword.Text;
                    admins.AGmail = txtadminGmail.Text;

                    int insertquery = admin.InsertAdminQuery(admins.AID, admins.AName, admins.AAddress, admins.APhone, admins.APassword, admins.AGmail);



                    if (insertquery > 0)
                    {

                        MessageBox.Show("Admin data insert Successfully Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearall();
                        staffAutoID();


                        AdminLogin Alogin = new AdminLogin();
                        this.Hide();
                        Alogin.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Tru Again", ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
