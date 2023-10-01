using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorHabitacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal.Mantenedor
{
    public partial class FrmHabitacion : Form
    {
        public FrmHabitacion()
        {
            InitializeComponent();
            LLenarDatosComboBoxTipoHabitacion();
            CargarHabitacion();
            groupBox1.Enabled = false;
        }
        private void CargarHabitacion()
        {
            
            dgvHabitacion.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "Numero" },
                new DataGridViewTextBoxColumn { HeaderText = "Piso" },
                new DataGridViewTextBoxColumn { HeaderText = "Disponibilidad" },
                new DataGridViewTextBoxColumn { HeaderText = "Tipo de habitacion" }
            );
            dgvHabitacion.Columns[0].Width = 40;
            foreach (DataGridViewColumn column in dgvHabitacion.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            ListarHabitacion();
        }

        private void ListarHabitacion()
        {
            List<entHabitacion.Habitacion> lista = logHabitacion.Instancia.ListarHabitacion();
            dgvHabitacion.Rows.Clear();
            foreach (var item in lista)
            {
                dgvHabitacion.Rows.Add(
                    item.idHabitacion,
                    item.numHabitacion,
                    item.numPisoHabitacion,
                    item.DisHabitacion,
                    item.idTipoHabitacion.nombTipoHabitacion
                );
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void LLenarDatosComboBoxTipoHabitacion()
        {
            cmbidTipoHab.DataSource = LogicaNegocio.Mantenedor.logTipoHabitacion.Instancia.ListarTipoHabitacion();
            cmbidTipoHab.DisplayMember = "nombTipoHabitacion";
            cmbidTipoHab.ValueMember = "idTipoHabitacion";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;
            txtId.Enabled = false;

            btnNuevo.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion.Habitacion h = new entHabitacion.Habitacion();
                entTipoHabitacion.TipoHabitacion th = new entTipoHabitacion.TipoHabitacion();
                h.idHabitacion = int.Parse(txtId.Text);
                h.numHabitacion = int.Parse(txtNumHabitacion.Text);
                h.numPisoHabitacion = int.Parse(txtNumPiso.Text);
                h.DisHabitacion = cmbDisponibilidad.SelectedItem.ToString();
                th.idTipoHabitacion = int.Parse(cmbidTipoHab.SelectedValue.ToString());
                h.idTipoHabitacion = th;

                logHabitacion.Instancia.EditaHabitacion(h);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            ListarHabitacion();

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            LimpiarVariables();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtId.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

            btnEditar.Enabled = false;
            btnSalir.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtId.Text = "";
            txtNumHabitacion.Text = "";
            txtNumPiso.Text = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true; 
            btnSalir.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion.Habitacion h = new entHabitacion.Habitacion();
                entTipoHabitacion.TipoHabitacion th = new entTipoHabitacion.TipoHabitacion();

                h.numHabitacion = int.Parse(txtNumHabitacion.Text);
                h.numPisoHabitacion = int.Parse(txtNumPiso.Text);
                h.DisHabitacion = cmbDisponibilidad.SelectedItem.ToString();
                th.idTipoHabitacion= int.Parse(cmbidTipoHab.SelectedValue.ToString());
                h.idTipoHabitacion = th;

                logHabitacion.Instancia.InsertarHabitacion(h);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            ListarHabitacion();
        }

        private void dgvHabitacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvHabitacion.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString(); 
            txtNumHabitacion.Text = filaActual.Cells[1].Value.ToString();
            txtNumPiso.Text = filaActual.Cells[2].Value.ToString();
            for (int i = 0; i < cmbDisponibilidad.Items.Count; i++)
            {
                string item = cmbDisponibilidad.Items[i].ToString();

                if (item.Equals(filaActual.Cells[3].Value.ToString()))
                {
                    cmbDisponibilidad.SelectedIndex = i;
                    break; // Si deseas detener la comparación después de encontrar una coincidencia.
                }
            }
            for (int i = 0; i < cmbidTipoHab.Items.Count; i++)
            {
                string item = cmbidTipoHab.Items[i].ToString();

                if (item.Equals(filaActual.Cells[4].Value.ToString()))
                {
                    cmbidTipoHab.SelectedIndex = i;
                    break; // Si deseas detener la comparación después de encontrar una coincidencia.
                }
            }
        }
    }
}
