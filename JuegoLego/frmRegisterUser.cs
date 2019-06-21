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
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Gestionar()
        {
            tUserUsuario.Texto = "Alias";
            tUserPassword.Texto = "Password";
            tUserPassword.ocultar();
            tUserRepeatPassword.Texto = "Repite Password";
            tUserRepeatPassword.ocultar();
            tUserName.Texto = "Nombre";
            tUserApellidos.Texto = "Apellidos";
            tUserMail.Texto = "Correo";
        }
        bool validaciones()
        {
            if (!tUserName.Validar(@"^[a-zA-Z]+$")) return false;
            return true;
        }

        private void tUserApellidos_Load(object sender, EventArgs e)
        {

        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            Gestionar();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                this.Close();
            }
        }
    }
}
