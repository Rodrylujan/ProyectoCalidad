using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Login
{
    public partial class FrmIniciarSesion : MaterialSkin.Controls.MaterialForm
    {
        private string messageUserDefect = "Ingrese su usuario";
        private string messagePasswordDefect = "Ingrese su contraseña";

        private Color colorMessage = Color.FromArgb(144, 144, 144);
        private Color colorText = Color.Black;

        public FrmIniciarSesion()
        {
            InitializeComponent();
            ConfigInicial();
        }
        private void ConfigInicial()
        {
            lbIntentos.Visible = false;

            txbUser.Text = messageUserDefect;
            txbUser.ForeColor = colorMessage;

            txbPassword.Text = messagePasswordDefect;
            txbPassword.ForeColor = colorMessage;
            txbPassword.PasswordChar = '\0';
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == messageUserDefect)
            {
                txbUser.Text = "";
                txbUser.ForeColor = colorText;
            }
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUser.Text))
            {
                txbUser.Text = messageUserDefect;
                txbUser.ForeColor = colorMessage;
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == messagePasswordDefect)
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = colorText;
                txbPassword.PasswordChar = '*';
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                txbPassword.Text = messagePasswordDefect;
                txbPassword.ForeColor = colorMessage;
                txbPassword.PasswordChar = '\0';
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
