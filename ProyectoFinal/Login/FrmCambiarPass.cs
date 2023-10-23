﻿using entUser;
using LogicaNegocio.MantenedorUser;
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
                            "- Solo incluir los siguientes caracteres especales: # @ %\n" +
                            "- Minimo 8 caracteres\n";
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
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
        }
    }
}
