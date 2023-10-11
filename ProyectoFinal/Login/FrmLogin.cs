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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lbIntentos.Visible = false;
            lbIntentos.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbPassword_MouseEnter(object sender, EventArgs e)
        {
            string condiciones = "";
            condiciones = "- Minimo 8 caracteres\n" +
                            "- Debe incluir un numero, una mayuscula y \n" +
                            "    una minuscula\n" +
                            "- Solo incluir los siguientes caracteres \n    especales: # @ %\n" +
                            "- Minimo 8 caracteres\n";
            lbContraseñas.Text = condiciones;
        }

        private void txbPassword_MouseLeave(object sender, EventArgs e)
        {
            lbContraseñas.Text = "";
        }

        private void lbCambiarPasss_Click(object sender, EventArgs e)
        {
            FrmCambiarPass frmCambiarPass = new FrmCambiarPass();
            frmCambiarPass.Show();
        }

        private void lbOlvidePasss_Click(object sender, EventArgs e)
        {
            FrmOlvidePass frmOlvidePass = new FrmOlvidePass();
            frmOlvidePass.Show();
        }
    }
}
