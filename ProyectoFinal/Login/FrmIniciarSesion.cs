using entUser;
using LogicaNegocio.MantenedorUser;
using ProyectoFinal.Principal;
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

            txbContra.Text = messagePasswordDefect;
            txbContra.ForeColor = colorMessage;
            txbContra.PasswordChar = '\0';
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
            if (txbContra.Text == messagePasswordDefect)
            {
                txbContra.Text = "";
                txbContra.ForeColor = colorText;
                txbContra.PasswordChar = '*';
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbContra.Text))
            {
                txbContra.Text = messagePasswordDefect;
                txbContra.ForeColor = colorMessage;
                txbContra.PasswordChar = '\0';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txbUser.Text;
            string contra = txbContra.Text;
            int estado = 0;

            if (user != null && contra != null)
            {
                estado = logUser.Instancia.validarInicioSesion(user, contra);
            }
            else if (contra == "" && user == "") MessageBox.Show("complete los campos");
            else if (user == "") MessageBox.Show("Ingrese su usuario");
            else MessageBox.Show("Ingrese su contraseña");
            if (estado >= 1)
            {
                this.Hide();
                int id_rol_user = logUser.Instancia.buscarUsuario(estado).id_rol;
                FrmPrincipal principal = new FrmPrincipal(id_rol_user);
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario no validos");
            }
        }
    }
}
