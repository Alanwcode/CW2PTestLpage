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


namespace CW2PTestLpage
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            txt_confirmPassword.PasswordChar = '*';
            txt_confirmPassword.MaxLength = 16;
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 16;
        }

        private void registration_Load(object sender, EventArgs e)
        {
            lbl_valCPassword.Visible = false;
            lbl_valEMail.Visible = false;
            lbl_valNIC.Visible = false;
            lbl_valPass.Visible = false;
            lbl_valUsername.Visible = false;
            lbl_valAddress.Visible = false;
            lbl_valCNo.Visible = false;
            lbl_valName.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_valCPassword.Visible = false;
            lbl_valEMail.Visible = false;
            lbl_valNIC.Visible = false;
            lbl_valPass.Visible = false;
            lbl_valUsername.Visible = false;
            lbl_valAddress.Visible = false;
            lbl_valCNo.Visible = false;
            lbl_valName.Visible = false;

            txt_address.Clear();
            txt_confirmPassword.Clear();
            txt_contactNo.Clear();
            txt_EMail.Clear();
            txt_name.Clear();
            txt_NIC.Clear();
            txt_password.Clear();
            txt_username.Clear();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int correctACount = 0;
            lbl_valCPassword.Visible = false;
            lbl_valEMail.Visible = false;
            lbl_valNIC.Visible = false;
            lbl_valPass.Visible = false;
            lbl_valUsername.Visible = false;
            lbl_valAddress.Visible = false;
            lbl_valCNo.Visible = false;
            lbl_valName.Visible = false;

            if (string.IsNullOrEmpty(txt_name.Text))
            {
                lbl_valName.Text = "Name Can't be Empty";
                lbl_valName.Visible = true;
            }
            else
            {
                correctACount = correctACount + 1;
            }

            if (string.IsNullOrEmpty(txt_NIC.Text))
            {
                lbl_valNIC.Text = "NIC Can't be Empty";
                lbl_valNIC.Visible = true;
            }
            else
            {
                if (!Regex.IsMatch(txt_NIC.Text, @"^(?:19|20)?\d{2}[0-9]{10}|[0-9]{9}[x|X|v|V]$"))
                {
                    lbl_valNIC.Text = "Invalid NIC, (ex: 200030100436/123456789v)";
                    lbl_valNIC.Visible = true;
                }
                else
                {
                    correctACount = correctACount + 1;
                }
            }

            if (string.IsNullOrEmpty(txt_contactNo.Text))
            {
                lbl_valCNo.Text = "Contact Number Can't be Empty";
                lbl_valCNo.Visible = true;
            }
            else
            {
                if (!Regex.IsMatch(txt_contactNo.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    lbl_valCNo.Text = "Invalid Contact No (ex: +94714523698/0715624562)";
                    lbl_valCNo.Visible = true;
                }
                else
                {
                    correctACount = correctACount + 1;
                }
            }

            if (string.IsNullOrEmpty(txt_EMail.Text))
            {
                lbl_valEMail.Text = "Invalid e-mail, (ex: text@gmail.com)";
                lbl_valEMail.Visible = true;
            }
            else
            {
                if (!Regex.IsMatch(txt_EMail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    lbl_valCNo.Text = "Invalid e-mail, (ex: text@gmail.com)";
                    lbl_valEMail.Visible = true;
                }
                else
                {
                    correctACount = correctACount + 1;
                }
            }

            if (string.IsNullOrEmpty(txt_address.Text))
            {
                lbl_valAddress.Text = "Address Can't be Empty";
                lbl_valAddress.Visible = true;
            }
            else
            {
                correctACount = correctACount + 1;
            }

            if (string.IsNullOrEmpty(txt_username.Text))
            {
                lbl_valUsername.Text = "Username Can't be Empty";
                lbl_valUsername.Visible = true;
            }
            else
            {
                correctACount = correctACount + 1;
            }

            if (string.IsNullOrEmpty(txt_password.Text))
            {
                lbl_valPass.Text = "Password Can't be Empty";
                lbl_valPass.Visible = true;
            }
            else
            {
                correctACount = correctACount + 1;
            }

            if (string.IsNullOrEmpty(txt_confirmPassword.Text))
            {
                lbl_valCPassword.Text = "Pasword Can't be Empty";
                lbl_valCPassword.Visible = true;
            }
            else
            {
                if(txt_password.Text == txt_confirmPassword.Text)
                {
                    correctACount = correctACount + 1;
                }
                else
                {
                    lbl_valCPassword.Text = "Pasword didn't match";
                    lbl_valCPassword.Visible = true;
                    lbl_valPass.Text = "Pasword didn't match";
                    lbl_valPass.Visible = true;
                }
            }

            if(correctACount == 8)
            {
                MessageBox.Show("Registration Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }
    }
}
