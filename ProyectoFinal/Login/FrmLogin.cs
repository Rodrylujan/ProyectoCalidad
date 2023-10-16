using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Login
{
    public partial class FrmLogin : Form
    {
        private Form FormActivo = null;

        public FrmLogin()
        {
            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            AbrirFormHijo(new FrmIniciarSesion());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbCambiarPasss_Click(object sender, EventArgs e)
        {
            btnAtras.Visible = true;
            btnSalir.Visible = false;
            AbrirFormHijo(new FrmCambiarPass());
        }

        private void lbOlvidePasss_Click(object sender, EventArgs e)
        {
            FrmOlvidePass frmOlvidePass = new FrmOlvidePass();
            frmOlvidePass.Show();
        }

        /// <summary>
        /// Carga un formulario dentro de un panel en el formulario principal
        /// </summary>
        /// <param name="formhijo"> Formulario que se mostrara</param>
        private void AbrirFormHijo(Form formhijo)
        {
            if (FormActivo != null)
                FormActivo.Close();
            FormActivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formhijo);
            panelPrincipal.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
            
        }
        private void FormHijo_FormCerrado(object sender, EventArgs e)
        {
            // Cuando se cierre el formulario hijo, también cierra el formulario principal
            this.Close();
        }

        private void FormHijo_FormCerradoAtras(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if(FormActivo is FrmCambiarPass)
            {
                FrmCambiarPass frmCambiarPass = (FrmCambiarPass)FormActivo;
                DialogResult result = DialogResult.Yes;
                if (frmCambiarPass.hayDatosIngresados)
                {
                    result = MessageBox.Show("¿Quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }                   
                if (result == DialogResult.Yes)
                {
                    FormLoad();
                    btnAtras.Visible = false;
                    btnSalir.Visible = true;
                }
            }            
        }
    }
}
