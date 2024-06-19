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
    public partial class UserRegister : Form
    {
        FitnessDataSetTableAdapters.UsertbTableAdapter user = new FitnessDataSetTableAdapters.UsertbTableAdapter();
        DataTable usertda = new DataTable();

        public UserRegister()
        {
            InitializeComponent();
        }

        private void btnURegister_Click(object sender, EventArgs e)
        {
            String password = txtUserPassword.Text;
            String adminName = txtUserName.Text;

            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Fill User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (txtPhone.Text == "")
                {
                    MessageBox.Show("Fill User Phone!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUserEmail.Text == "")
                {
                    MessageBox.Show("Fill User Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserEmail.Focus();
                }
                else if (txtUserPassword.Text == "")
                {
                    MessageBox.Show("Fill User Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Focus();

                }
                else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOther.Checked == false)
                {
                    MessageBox.Show("Please Choose Your Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Length < 8 || password.Length > 14)
                {
                    MessageBox.Show("Please Vaild Password Length, should enter between 8 and 16", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Focus();
                }
                else if (!password.Any(char.IsUpper))
                {
                    MessageBox.Show("Please should include Upper Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Focus();
                }
                else if (!password.Any(char.IsLower))
                {
                    MessageBox.Show("Please should include lower Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Focus();
                }
                else if (!password.Any(char.IsDigit))
                {
                    MessageBox.Show("Please should include digit Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserPassword.Focus();
                }
                else if (!adminName.Any(char.IsDigit))
                {
                    MessageBox.Show("Please should include digit Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else
                {
                    ClsUser users = new ClsUser();
                    users.UID = txtUserID.Text;
                    users.UName = txtUserName.Text;
                    users.UPassword = txtUserPassword.Text;
                    users.UEmail = txtUserEmail.Text;
                    users.UPhone = txtPhone.Text;
                    users.Udob = dtpUserBirth.Value;
                    if (rdoMale.Checked == true)
                    {
                        users.UGender = "Male";
                    }
                    else if (rdoFemale.Checked == true)
                    {
                        users.UGender = "Female";
                    }
                    else if (rdoOther.Checked == true)
                    {
                        users.UGender = "Other";
                    }
                    

                    int insertquery = user.UserRegister(users.UID, users.UName, users.UPassword, users.UPhone, users.UEmail, users.UGender, users.Udob.ToString());

                    if (insertquery > 0)
                    {
                        MessageBox.Show("Admin data insert Successfully Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        userAutoID();

                        UserLogin Ulogin = new UserLogin();
                        this.Hide();
                        Ulogin.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again", ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void userAutoID()
        {
            usertda = user.GetData();
            if (usertda.Rows.Count == 0)
            {
                txtUserID.Text = "U001";
            }
            else
            {
                int size = usertda.Rows.Count - 1;
                string oldid = usertda.Rows[size][0].ToString();
                int newid = Convert.ToInt32(oldid.Substring(1, 3));
                if (newid >= 1 && newid < 9)
                {
                    txtUserID.Text = "U00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {
                    txtUserID.Text = "U0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {
                    txtUserID.Text = "U" + (newid + 1);
                }
            }
        }

        public void ClearAll()
        {
            txtUserName.Text = "";
            txtUserPassword.Text = "";
            txtUserEmail.Text = "";
            txtPhone.Text = "";
            rdoMale.Checked = true;
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            userAutoID();
        }
    }
}
