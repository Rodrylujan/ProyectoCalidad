using entHabitacion;
using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorHabitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.view
{
    public partial class FrmSelectHabitacion : Form
    {
        private List<entHabitacion.Habitacion> lisHabitacionesSelect;
        private entHabitacion.Habitacion selecionado;
        public FrmSelectHabitacion()
        {
            InitializeComponent();
            CargarClientes();
        }
        private void CargarClientes()
        {
            dgvHabitaciones.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "Numero" },
                new DataGridViewTextBoxColumn { HeaderText = "Piso" },
                new DataGridViewTextBoxColumn { HeaderText = "Estado" },
                new DataGridViewTextBoxColumn { HeaderText = "Tipo habitacion" }
            );
            dgvHabitaciones.Columns[0].Width = 40;

            foreach (DataGridViewColumn column in dgvHabitaciones.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            lisHabitacionesSelect = logHabitacion.Instancia.ListarHabitacion();
            listarHabitaciones();
        }
        private void listarHabitaciones()
        {
            dgvHabitaciones.Rows.Clear();

            foreach (var item in lisHabitacionesSelect)
            {
                dgvHabitaciones.Rows.Add(
                    item.idHabitacion,
                    item.numHabitacion,
                    item.numPisoHabitacion,
                    item.DisHabitacion,
                    item.idTipoHabitacion.idTipoHabitacion
                );
            }
        }
        public Habitacion getHabitacion()
        {
            return selecionado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                if (rb_cod.Checked)
                {
                    lisHabitacionesSelect = logHabitacion.Instancia.ListarHabitacionPorCodigo(Convert.ToInt32(txt_buscar.Text));
                }
                else if (rb_num.Checked)
                {
                    lisHabitacionesSelect = logHabitacion.Instancia.ListarHabitacionPorNumero(Convert.ToInt32(txt_buscar.Text));
                }
                else if (rb_piso.Checked)
                {
                    lisHabitacionesSelect = logHabitacion.Instancia.ListarHabitacionPorPiso(Convert.ToInt32(txt_buscar.Text));
                }
            }
            else
            {
                lisHabitacionesSelect = logHabitacion.Instancia.ListarHabitacion();
            }
            listarHabitaciones();
        }

        private void dgvHabitaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHabitaciones.Rows[e.RowIndex];
                selecionado = new entHabitacion.Habitacion();
                selecionado.idHabitacion = Convert.ToInt32(selectedRow.Cells[0].Value);
                selecionado.numHabitacion = Convert.ToInt16(selectedRow.Cells[1].Value);
                selecionado.numPisoHabitacion = Convert.ToInt16(selectedRow.Cells[2].Value);
                selecionado.DisHabitacion = Convert.ToString(selectedRow.Cells[3].Value);
                selecionado.idTipoHabitacion = new entTipoHabitacion.TipoHabitacion();
                selecionado.idTipoHabitacion.idTipoHabitacion = Convert.ToInt16(selectedRow.Cells[4].Value);
                this.Close();
            }
        }
    }
}
