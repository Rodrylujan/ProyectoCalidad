using entRol;
using entUser;
using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorRol;
using LogicaNegocio.MantenedorUser;
using ProyectoFinal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Mantenedor
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
            listarUsers();
            groupBox1.Enabled = false;
            txtId.Enabled = false;
            ComboBoxs();
        }

        private void ComboBoxs()
        {
            cmbRol.ValueMember = "id_rol";
            cmbRol.DisplayMember = "nombre";
            List<Rol> lista = logRol.Instancia.listarRol();
            cmbRol.DataSource = lista;
        }

        private void listarUsers()
        {
            List<User> usuarios = logUser.Instancia.listarUsuarios();
            dgvUsers.DataSource = usuarios;
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
        private void LimpiarVariables()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalir.Enabled = true;
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
            this.Close();   
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                try
                {
                    User u = new User();
                    u.userName = txtNombre.Text.Trim();
                    u.password = txtApellido.Text.Trim();
                    Rol rolAux = (Rol)cmbRol.SelectedItem;
                    u.id_rol = rolAux.id_rol;
                    u.estado = cbkEstadoCliente.Checked;
                    logUser.Instancia.insertarUsuario(u);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro.." + ex);
                }
                LimpiarVariables();
                groupBox1.Enabled = false;
                listarUsers();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.id_usuario = Convert.ToInt16(txtId.Text.Trim());
                u.userName = txtNombre.Text.Trim();
                u.password = txtApellido.Text.Trim();
                Rol rolAux = (Rol)cmbRol.SelectedItem;
                u.id_rol = rolAux.id_rol;
                u.estado = cbkEstadoCliente.Checked;
                logUser.Instancia.editarUsuario(u);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarUsers();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            LimpiarVariables();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaActual = dgvUsers.Rows[e.RowIndex];
                txtId.Text = filaActual.Cells[0].Value.ToString();
                txtNombre.Text = filaActual.Cells[1].Value.ToString();
                txtApellido.Text = filaActual.Cells[2].Value.ToString();
                cmbRol.SelectedIndex= cmbRol.FindString(filaActual.Cells[3].Value.ToString());
                cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
            }
        }
        public bool ValidarContraseña(string contraseña)
        {
            // Comprueba si la contraseña tiene al menos 8 caracteres.
            if (contraseña.Length < 8)
                return false;

            // Comprueba si la contraseña contiene al menos una letra minúscula.
            if (!Regex.IsMatch(contraseña, @"[a-z]"))
                return false;

            // Comprueba si la contraseña contiene al menos una letra mayúscula.
            if (!Regex.IsMatch(contraseña, @"[A-Z]"))
                return false;

            // Comprueba si la contraseña contiene al menos un número.
            if (!Regex.IsMatch(contraseña, @"[0-9]"))
                return false;

            // Comprueba si la contraseña solo contiene los caracteres especiales permitidos.
            if (!Regex.IsMatch(contraseña, @"^[#@%a-zA-Z0-9]+$"))
                return false;

            return true;
        }

        private void txtApellido_KeyUp(object sender, KeyEventArgs e)
        {
            verificacion.Visible = true;
            if (ValidarContraseña(txtApellido.Text))
            {
                verificacion.Image = Resources.Correcto;
            }
            else
            {
                verificacion.Image = Resources.Incorrecto;
            }
        }
    }
}
