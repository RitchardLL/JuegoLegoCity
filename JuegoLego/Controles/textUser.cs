using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JuegoLego.Controles
{
    public partial class textUser : UserControl
    {
        private string texto;

        public string Texto
        {
            get { return texto; }
            set {
                texto = value;
                txtTexto.Text = texto;
            }
        }

        public textUser()
        {
            InitializeComponent();
        }

        public bool Validar(string pattern = "")
        {
            Regex rgx = new Regex(pattern);
            if (rgx.IsMatch(txtTexto.Text))
            {
                txtTexto.ForeColor = Color.Black;
                return true;
            }
            else
            {
                txtTexto.ForeColor = Color.Red;
                return false;
            }
        }
         public void ocultar()
        {
            txtTexto.PasswordChar = '*';
        }

        private void txtTexto_Enter(object sender, EventArgs e)
        {
            pnlTexto.BackColor = Color.White;
            txtTexto.ForeColor = Color.Black;
            if (txtTexto.Text.Equals(texto))
            {
                txtTexto.Text = "";
            }
        }

        private void txtTexto_Leave(object sender, EventArgs e)
        {
            pnlTexto.BackColor = Color.Black;
            if (txtTexto.Text.Equals(""))
            {
                txtTexto.Text = texto;
                txtTexto.ForeColor = Color.Gray;
            }
        }
    }
}
