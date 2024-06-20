using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            bool vpassword = is_validPassword(txtUserPassword.Text);

            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Fill User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (vpassword==false)
                {
                    MessageBox.Show("Customer Password format in correct","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    txtUserPassword.Focus();
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

        private bool is_validPassword(String password)
        {
            bool is_valid = true;
            Regex has_Number = new Regex(@"[0-9]");
            Regex has_UpperChar = new Regex(@"[A-Z]");
            Regex has_LowerChar = new Regex(@"[a-z]");
            Regex has_MinMaxChar = new Regex(@".{8,}");

            if (!has_UpperChar.IsMatch(password))
            {
                lblUpper.Text = "X At least 1 upper character";
                lblUpper.ForeColor = Color.Red;
                txtUserPassword.Focus();
                is_valid = false;
            }
            else
            {
                lblUpper.Text = "Correct 1 Upper Character";
                lblUpper.ForeColor = Color.Green;
            }

            if (!has_LowerChar.IsMatch(password))
            {
                lblLower.Text = "X At least 1 lower character";
                lblLower.ForeColor = Color.Red;
                txtUserPassword.Focus();
                is_valid = false;
            }
            else
            {
                lblLower.Text = "Correct 1 lower Character";
                lblLower.ForeColor = Color.Green;
            }

            if (!has_MinMaxChar.IsMatch(password))
            {
                lblminmax.Text = "X At least 8 characters";
                lblminmax.ForeColor = Color.Red;
                txtUserPassword.Focus();
                is_valid = false;
            }
            else
            {
                lblminmax.Text = "Correct 8 Character";
                lblminmax.ForeColor = Color.Green;
            }

            if (!has_Number.IsMatch(password))
            {
                lblnumber.Text = "X At least 1 number";
                lblnumber.ForeColor = Color.Red;
                txtUserPassword.Focus();
                is_valid = false;
            }
            else
            {
                lblnumber.Text = "Correct 1 number";
                lblnumber.ForeColor = Color.Green;
            }
            return is_valid;
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            userAutoID();
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            bool vpassword = is_validPassword(txtUserPassword.Text);
            lblLower.Visible = true;
            lblUpper.Visible = true;
            lblnumber.Visible = true;
            lblminmax.Visible = true;
            
        }
    }
}
