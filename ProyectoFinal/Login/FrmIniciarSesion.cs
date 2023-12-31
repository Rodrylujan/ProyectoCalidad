﻿using entUser;
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
        private readonly string messageUserDefect = "Ingrese su usuario";
        private readonly string messagePasswordDefect = "Ingrese su contraseña";
        private readonly string messageIntentos = "Numero de intentos: ";
        private int Intentos = 0;

        private readonly Color colorMessage = Color.FromArgb(144, 144, 144);
        private readonly Color colorText = Color.Black;

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
            int id_usuario = 0;

            if (user != null && contra != null)
            {
                id_usuario = logUser.Instancia.validarInicioSesion(user, contra);
                
            }
            else if (contra == "" && user == "") MessageBox.Show("complete los campos");
            else if (user == "") MessageBox.Show("Ingrese su usuario");
            else MessageBox.Show("Ingrese su contraseña");

            if (id_usuario >= 1)
            {
                lbIntentos.Text = "";
                Intentos = 0;
                if (RecordarUser.Checked)
                {
                    Properties.Settings.Default.User = txbUser.Text;
                    Properties.Settings.Default.Clave = txbContra.Text;
                    Properties.Settings.Default.Recordar = RecordarUser.Checked;
                }
                else
                {
                    Properties.Settings.Default.User = "";
                    Properties.Settings.Default.Clave = "";
                    Properties.Settings.Default.Recordar = RecordarUser.Checked;
                }

                Properties.Settings.Default.Save();
                this.Hide();
                int id_rol_user = logUser.Instancia.buscarUsuario(id_usuario).id_rol;
                FrmPrincipal principal = new FrmPrincipal(id_rol_user);
                principal.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario no validos");
                Intentos++;
                if (Intentos >= 3)
                {
                    DateTime hora = DateTime.Now.AddMinutes(60);
                    Properties.Settings.Default.DateBloque = hora.ToString("dd/MM/yyyy HH:mm:ss");
                    Properties.Settings.Default.Save();
                    btnIniciarSesion.Enabled = false;
                    lbIntentos.Text = "Vuelva a intentarlo a " + hora;
                    horaFecha.Start();
                }
                else
                {
                    lbIntentos.Text = messageIntentos + Intentos;
                    lbIntentos.Visible = true;
                }
                
            }
        }

        private void FrmIniciarSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(RecordarUser.Checked)
            {
                Properties.Settings.Default.User = txbUser.Text;
                Properties.Settings.Default.Clave = txbContra.Text;
                Properties.Settings.Default.Recordar = RecordarUser.Checked;
            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Clave = "";
                Properties.Settings.Default.Recordar = RecordarUser.Checked;
            }
            Properties.Settings.Default.Save();
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Recordar==true)
            {
                txbPassword_Enter(txbContra, new EventArgs());
                txbUser_Enter(txbUser, new EventArgs());
                txbUser.Text = Properties.Settings.Default.User;
                txbContra.Text = Properties.Settings.Default.Clave;
                RecordarUser.Checked = Properties.Settings.Default.Recordar ;
            }

            string dateBloqueado = Properties.Settings.Default.DateBloque;
            dateBloqueado = "";
            DateTime horaDesbloque=DateTime.Now;
            if (dateBloqueado!="")
                horaDesbloque = Convert.ToDateTime(dateBloqueado);
            if (dateBloqueado == "" || DateTime.Now >= horaDesbloque)
            {
                btnIniciarSesion.Enabled = true;
                horaFecha.Stop();
                Properties.Settings.Default.DateBloque = "";
                Properties.Settings.Default.Save();

            }
            else
            {
                btnIniciarSesion.Enabled = false;
                horaFecha.Start();
                lbIntentos.Text = "Vuelva a intentarlo a " + horaDesbloque;
                lbIntentos.Visible = true;
            }
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            string dateBloqueado = Properties.Settings.Default.DateBloque;
            DateTime horaDesbloque = DateTime.Now;
            if (dateBloqueado != "")
                horaDesbloque = Convert.ToDateTime(dateBloqueado);
            if (dateBloqueado == "" || DateTime.Now >= horaDesbloque)
            {
                btnIniciarSesion.Enabled = true;
                horaFecha.Stop();
                Properties.Settings.Default.DateBloque = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
