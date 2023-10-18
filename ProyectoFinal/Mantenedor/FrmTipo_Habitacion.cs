using LogicaNegocio.Mantenedor;
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
    public partial class FrmTipo_Habitacion : MaterialSkin.Controls.MaterialForm
    {
        public FrmTipo_Habitacion()
        {
            InitializeComponent();
            listarTipoHabitacion();
            groupBox1.Enabled = false;
            txtId.Enabled = false;
        }
        private void listarTipoHabitacion()
        {
            dgvTipo_Habitacion.DataSource = logTipoHabitacion.Instancia.ListarTipoHabitacion();
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

        private void dgvTipo_Habitacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipo_Habitacion.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtPrecio.Text = filaActual.Cells[2].Value.ToString();
            txtDetalle.Text = filaActual.Cells[3].Value.ToString();
        }

        private void FrmTipo_Habitacion_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnGrabar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

            btnEditar.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnGrabar.Visible = false;

            btnNuevo.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoHabitacion.TipoHabitacion t = new entTipoHabitacion.TipoHabitacion();
                t.nombTipoHabitacion = txtNombre.Text;
                t.precTipoHabitacion = float.Parse(txtPrecio.Text);
                t.detalle = txtDetalle.Text;

                logTipoHabitacion.Instancia.InsertarTipoHabitacion(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarTipoHabitacion();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoHabitacion.TipoHabitacion t = new entTipoHabitacion.TipoHabitacion();
                t.idTipoHabitacion = int.Parse(txtId.Text);
                t.nombTipoHabitacion = txtNombre.Text;
                t.precTipoHabitacion = float.Parse(txtPrecio.Text);
                t.detalle = txtDetalle.Text;
                logTipoHabitacion.Instancia.EditaTipoHabitacion(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarTipoHabitacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            LimpiarVariables();
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalir.Enabled = true;
        }
    }
}
