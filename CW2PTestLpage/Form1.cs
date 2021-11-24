using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CW2PTestLpage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            txt_password.MaxLength = 16;
        }

        SqlConnection con;

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection("CONNECCTION STRING");
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-9PI6981;Initial Catalog=CW2PTestLForm;Integrated Security=True");
                //database containt table lDetails and table containt username primary key data type varchar and passUser data type varchar
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from lDetails where username = '" + txt_username.Text + "' and passUser = '" + txt_password.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Succeded, ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Invalid frm = new Invalid();
                    frm.ShowDialog();
                    //MessageBox.Show("Invalid Login, Please check the logins", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Something is wrong, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/GlamourRich");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/glamour_richlk/");
        }
    }
}
