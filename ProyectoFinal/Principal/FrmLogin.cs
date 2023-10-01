using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Mantenedor;
using ProyectoFinal.Transacciones;

namespace ProyectoFinal.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmTipo_Habitacion v = new FrmTipo_Habitacion();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHabitacion h = new FrmHabitacion();
            h.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmReserva frmReserva = new FrmReserva();
            frmReserva.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmServicio_Habitacion frmServicio_Habitacion = new FrmServicio_Habitacion();
            frmServicio_Habitacion.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmComprobantes frmComprobantes = new FrmComprobantes();
            frmComprobantes.Show();
        }
    }
}
