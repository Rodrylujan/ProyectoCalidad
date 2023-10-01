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

namespace ProyectoFinal.view
{
    public partial class FrmSelectCliente : Form
    {
        private List<entCliente.Cliente> lisClienteselect;
        private entCliente.Cliente selecionado;
        public FrmSelectCliente()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "Nombres" },
                new DataGridViewTextBoxColumn { HeaderText = "Apellidos" },
                new DataGridViewTextBoxColumn { HeaderText = "Direccion" },
                new DataGridViewTextBoxColumn { HeaderText = "Telefono" },
                new DataGridViewTextBoxColumn { HeaderText = "DNI" },
                new DataGridViewTextBoxColumn { HeaderText = "Estado" },
                new DataGridViewTextBoxColumn { HeaderText = "Fecha de registro" }
            );
            dgvClientes.Columns[0].Width = 40;

            foreach (DataGridViewColumn column in dgvClientes.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            lisClienteselect = logCliente.Instancia.ListarCliente();
            listarClientes();
        }
        private void listarClientes()
        {
            dgvClientes.Rows.Clear();

            foreach (var item in lisClienteselect)
            {
                dgvClientes.Rows.Add(
                    item.idCliente,
                    item.nombCliente,
                    item.apelCliente,
                    item.direcCliente,
                    item.celular,
                    item.dni,
                    item.estCliente,
                    item.fecRegCliente
                );
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                if (rb_nombre.Checked)
                {
                    lisClienteselect = logCliente.Instancia.listarClienteNombre(txt_buscar.Text);
                }
                else if (rb_dni.Checked)
                {
                    lisClienteselect = logCliente.Instancia.listarClienteDni(Convert.ToInt32(txt_buscar.Text));
                }
                else if (rb_codigo.Checked)
                {
                    lisClienteselect = logCliente.Instancia.listarClienteId(Convert.ToInt32(txt_buscar.Text));
                }
            }
            else
            {
                lisClienteselect = logCliente.Instancia.ListarCliente();
            }
            listarClientes();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvClientes.Rows[e.RowIndex];
                selecionado = new entCliente.Cliente();
                selecionado.idCliente = Convert.ToInt32(selectedRow.Cells[0].Value);
                selecionado.nombCliente = Convert.ToString(selectedRow.Cells[1].Value);
                selecionado.apelCliente = Convert.ToString(selectedRow.Cells[2].Value);
                selecionado.direcCliente = Convert.ToString(selectedRow.Cells[3].Value);
                selecionado.celular = Convert.ToString(selectedRow.Cells[4].Value);
                selecionado.dni = Convert.ToString(selectedRow.Cells[5].Value);
                selecionado.estCliente = Convert.ToBoolean(selectedRow.Cells[6].Value);
                selecionado.fecRegCliente = Convert.ToDateTime(selectedRow.Cells[7].Value);
                this.Close();
            }
            
        }
        public entCliente.Cliente getCliente() { return selecionado; }
    }
}
