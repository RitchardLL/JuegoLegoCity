using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoLego
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Text = "User name";
            txtPass.Text = "Password";
            txtUser.ForeColor = Color.Gray;
            txtPass.ForeColor = Color.Gray;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            pnlUser.BackColor = Color.White;
            txtUser.ForeColor = Color.White;
            if (txtUser.Text.Equals("User name"))
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            pnlUser.BackColor = Color.Black;
            txtUser.ForeColor = Color.Black;
            if (txtUser.Text.Equals(""))
            {
                txtUser.Text = "User name";
                txtUser.ForeColor = Color.Gray;
            }
            else
            {
                txtUser.ForeColor = Color.Black;

            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            pnlPass.BackColor = Color.White;
            txtPass.ForeColor = Color.White;
            if (txtPass.Text.Equals("Password"))
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.White;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            pnlPass.BackColor = Color.Black;
            txtPass.ForeColor = Color.Black;
            if (txtPass.Text.Equals(""))
            { 
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
                txtPass.Text = "Password"  ;
                txtPass.ForeColor = Color.Gray;
            }
            else
            {
                txtPass.ForeColor = Color.Black;

            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar =='*')
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRegisterUser newUser = new frmRegisterUser();
            newUser.ShowDialog();
            this.Visible = true;
        }
    }
}
