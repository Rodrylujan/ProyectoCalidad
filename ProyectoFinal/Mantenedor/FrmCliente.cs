using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Mantenedor;
using entCliente;


namespace ProyectoFinal.Mantenedor
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            listarCliente();
            groupBox1.Enabled = false;
            txtId.Enabled = false;
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

            btnEditar.Enabled = false;
            btnAnular.Enabled = false;
            btnSalir.Enabled = false;
        }
        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtDni.Text = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled=true;
            btnAnular.Enabled=true;
            btnSalir.Enabled=true;
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente.Cliente c = new entCliente.Cliente();
                c.nombCliente = txtNombre.Text.Trim();
                c.apelCliente = txtApellido.Text.Trim();
                c.direcCliente = txtDireccion.Text.Trim();
                c.celular = txtCelular.Text.Trim();
                c.dni = txtDni.Text.Trim();
                c.estCliente = cbkEstadoCliente.Checked;
                c.fecRegCliente = dtFechaRegistro.Value;
                logCliente.Instancia.InsertarCliente(c);
            }catch(Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

            btnNuevo.Enabled = false;
            btnAnular.Enabled = false;
            btnSalir.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtId.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtApellido.Text = filaActual.Cells[2].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();
            txtCelular.Text = filaActual.Cells[4].Value.ToString();
            txtDni.Text = filaActual.Cells[5].Value.ToString();
            cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
            dtFechaRegistro.Text = filaActual.Cells[7].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente.Cliente c = new entCliente.Cliente();
                c.idCliente = int.Parse(txtId.Text.Trim());
                c.nombCliente = txtNombre.Text.Trim();
                c.apelCliente = txtApellido.Text.Trim();
                c.direcCliente = txtDireccion.Text.Trim();
                c.celular = txtCelular.Text.Trim();
                c.dni = txtDni.Text.Trim();
                c.estCliente = cbkEstadoCliente.Checked;
                c.fecRegCliente = dtFechaRegistro.Value;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            LimpiarVariables();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente.Cliente c = new entCliente.Cliente();
                c.idCliente = int.Parse(txtId.Text.Trim());
                cbkEstadoCliente.Checked = false;
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCliente();
        }
    }
}
