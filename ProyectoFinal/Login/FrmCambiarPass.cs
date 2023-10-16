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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PanelUserPassword.Visible = false;
            panelNewPassword.Visible = true;
            panelNewPassword.Location = new Point(35, 145);

            hayDatosIngresados = true;
        }
    }
}
