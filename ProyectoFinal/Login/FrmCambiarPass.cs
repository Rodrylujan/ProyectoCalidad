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
                            "- Debe incluir un numero, una mayuscula y \n" +
                            "    una minuscula\n" +
                            "- Solo incluir los siguientes caracteres \n    especales: # @ %\n" +
                            "- Minimo 8 caracteres\n";
            lbContraseñas.Text = condiciones;
        }

        private void txbNuevoPassword_MouseLeave(object sender, EventArgs e)
        {
            lbContraseñas.Text = "";
        }
    }
}
