using entUser;
using LogicaNegocio.MantenedorUser;
using ProyectoFinal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Login
{
    public partial class FrmCambiarPass : Form
    {
        public bool hayDatosIngresados = false;
        private int id_usuario;

        public FrmCambiarPass()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNuevoPassword_MouseEnter(object sender, EventArgs e)
        {
            string condiciones = "";
            condiciones = "- Minimo 8 caracteres\n" +
                            "- Debe incluir un numero, una mayuscula y una minuscula\n" +
                            "- Solo incluir los siguientes caracteres especales: # @ %\n";
            lbContraseñas.Text = condiciones;
            lbMesage.Visible = true;
        }

        private void txbNuevoPassword_MouseLeave(object sender, EventArgs e)
        {
            lbContraseñas.Text = "";
            lbMesage.Visible = false;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txbUser.Text) && !string.IsNullOrWhiteSpace(txbPasswordActual.Text))
            {
                int id_usuario;
                id_usuario = logUser.Instancia.validarInicioSesion(txbUser.Text, txbPasswordActual.Text);
                if (id_usuario >= 1)
                {
                    PanelUserPassword.Visible = false;
                    panelNewPassword.Visible = true;
                    panelNewPassword.Location = new Point(35, 145);
                    hayDatosIngresados = true;
                    lbMesage.Visible = false;
                    this.id_usuario = id_usuario;
                }
                else
                {
                    lbMesage.Visible = true;
                    this.id_usuario = 0;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            User usuario = logUser.Instancia.buscarUsuario(id_usuario);
            if (!string.IsNullOrWhiteSpace(txbNewPassword.Text) && !string.IsNullOrWhiteSpace(txbConfirmPassword.Text) && usuario!=null)
            {
                if (txbNewPassword.Text== txbConfirmPassword.Text)
                {
                    if (ValidarContraseña(txbNewPassword.Text))
                    {
                        usuario.password = txbNewPassword.Text;
                        logUser.Instancia.editarUsuario(usuario);
                        //AQUI SE CAMBIO DE CONTRASEÑA CORRECTAMENTE
                        // Muestra FrmIniciarSesion en el formulario principal FrmLogin
                        FrmLogin frmLogin = (FrmLogin)this.Owner;
                        if (frmLogin != null)
                        {
                            frmLogin.AbrirFormHijo(new FrmIniciarSesion());
                        }

                        // Cierra el formulario actual (FrmCambiarPass)
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No cumples con los requisitos minimos para la contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }
        public bool ValidarContraseña(string contraseña)
        {
            // Comprueba si la contraseña tiene al menos 8 caracteres.
            if (contraseña.Length < 8)
                return false;

            // Comprueba si la contraseña contiene al menos una letra minúscula.
            if (!Regex.IsMatch(contraseña, @"[a-z]"))
                return false;

            // Comprueba si la contraseña contiene al menos una letra mayúscula.
            if (!Regex.IsMatch(contraseña, @"[A-Z]"))
                return false;

            // Comprueba si la contraseña contiene al menos un número.
            if (!Regex.IsMatch(contraseña, @"[0-9]"))
                return false;

            // Comprueba si la contraseña solo contiene los caracteres especiales permitidos.
            if (!Regex.IsMatch(contraseña, @"^[#@%a-zA-Z0-9]+$"))
                return false;

            return true;
        }

        private void txbNewPassword_KeyUp(object sender, KeyEventArgs e)
        {
            verificacion.Visible = true;
            if (ValidarContraseña(txbNewPassword.Text))
            {
                verificacion.Image = Resources.Correcto;
            }
            else
            {
                verificacion.Image = Resources.Incorrecto;
            }
        }
    }
}
