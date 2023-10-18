using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorHabitacion;
using LogicaNegocio.MantenedorServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Mantenedor
{
    public partial class FrmServicio_Habitacion : MaterialSkin.Controls.MaterialForm
    {
        public FrmServicio_Habitacion()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            txtId.Enabled = false;
            ListarServicio();
        }
        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDetalle.Text = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalir.Enabled = true;
        }
        private void ListarServicio()
        {
            dgvSerHab.DataSource = logServicio.Instancia.ListarServicio();
        }


        private void FrmServicio_Habitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

            btnEditar.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

            btnNuevo.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entServicio.Servicio s = new entServicio.Servicio();

                s.nombre_servicio = txtNombre.Text;
                s.precio = float.Parse(txtPrecio.Text);
                s.descripcion = txtDetalle.Text;


                logServicio.Instancia.InsertarServicio(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            ListarServicio();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entServicio.Servicio s = new entServicio.Servicio();
                s.idServicio = int.Parse(txtId.Text);
                s.nombre_servicio = txtNombre.Text;
                s.precio = float.Parse(txtPrecio.Text);
                s.descripcion = txtDetalle.Text;


                logServicio.Instancia.EditaServicio(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            ListarServicio();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            LimpiarVariables();
        }
    }
}
