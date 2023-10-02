using entHabitacion;
using entReserva;
using entTipoHabitacion;
using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorComprobante;
using LogicaNegocio.MantenedorHabitacion;
using LogicaNegocio.MantenedorReserva;
using LogicaNegocio.MantenedorServicio;
using ProyectoFinal.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Transacciones
{
    public partial class FrmReserva : Form
    {
        List<entServicio.Servicio> listaServicios = new List<entServicio.Servicio>();
        private bool cliente = false;
        private bool habitacion = false;
        entCliente.Cliente cliSelecionado = null;
        entHabitacion.Habitacion habSelecionada = null;

        public FrmReserva()
        {
            InitializeComponent();
            txt_id_reserva.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            LlenarDatosTipoServicio();
            inicializar();
            date_ingreso.Value = DateTime.Now;
            date_salida.Value = DateTime.Now.AddDays(1);
            ConfigDataReservas();
        }
        private void ConfigDataReservas()
        {
            dg_reservas.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "estado" },
                new DataGridViewTextBoxColumn { HeaderText = "fecha de ingreso" },
                new DataGridViewTextBoxColumn { HeaderText = "fecha de salida" },
                new DataGridViewTextBoxColumn { HeaderText = "cliente" },
                new DataGridViewTextBoxColumn { HeaderText = "habitacion" }
            );
            dg_reservas.Columns[0].Width = 40;
            foreach (DataGridViewColumn column in dg_reservas.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;
            Listarreservas();
        }
        private void inicializar()
        {
            dg_servicios.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "nombre servicio" },
                new DataGridViewTextBoxColumn { HeaderText = "precio" },
                new DataGridViewTextBoxColumn { HeaderText = "detalle" }
            );
            dg_servicios.Columns[0].Width = 40;
        }
        private void LlenarDatosTipoServicio()
        {
            cb_servicio.DataSource = logServicio.Instancia.ListarServicio();
            cb_servicio.DisplayMember = "nombre_servicio";
            cb_servicio.ValueMember = "idServicio";
        }
        private void LimpiarVariables()
        {
            txt_id_reserva.Text = "";
            txt_nombre_cliente.Text = "";
            txt_numerohabitacion.Text = "";
            txt_idhabitacion.Text = "";
            txt_dni_cliente.Text = "";
            date_ingreso.Value = DateTime.Now;
            date_salida.Value = DateTime.Now.AddDays(1);
            listaServicios.Clear();
            ListaDeServiciosAdicionales();
        }
        private void Listarreservas()
        {
            List<Reserva> lista = logReserva.Instancia.ListarReserva();

            dg_reservas.Rows.Clear();

            foreach (var item in lista)
            {
                dg_reservas.Rows.Add(
                    item.id_Reserva,
                    item.Est_Reserva,
                    item.Fecing_Reserva,
                    item.Fecsal_Reserva,
                    item.id_Cliente.nombCliente + " " + item.id_Cliente.apelCliente,
                    item.id_Habitacion.numHabitacion
                );
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            date_ingreso.Enabled = true;

            btn_grabar.Visible = true;
            LimpiarVariables();
            btn_modificar.Visible = false;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;

            date_ingreso.Enabled = false;
            

            btn_modificar.Visible = true;
            btn_grabar.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            bool validar1 = cliente && habitacion && cm_formapago.SelectedIndex != -1 && cb_servicio.SelectedIndex != -1;

            if (validar1)
            {
                int id = Convert.ToInt16(txt_idhabitacion.Text.ToString());
                DateTime inicio = date_ingreso.Value;
                DateTime fin = date_salida.Value;
                int seguir = logReserva.Instancia.validarReserva(id, inicio,fin );
                if (seguir==0)
                {
                    try
                    {
                        entReserva.Reserva r = new entReserva.Reserva();
                        entCliente.Cliente c = new entCliente.Cliente();
                        entHabitacion.Habitacion h = new entHabitacion.Habitacion();

                        r.Fecing_Reserva = date_ingreso.Value;
                        r.Fecsal_Reserva = date_salida.Value;
                        r.Est_Reserva = checkBoxEstado.Checked;

                        c = cliSelecionado;     ///buscar cliente dni
                        h = habSelecionada;

                        h.DisHabitacion = "OCUPADO";
                        logHabitacion.Instancia.EditaHabitacion(h);
                        r.id_Cliente = c;
                        r.id_Habitacion = h;

                        int ultimoID = logReserva.Instancia.InsertarReserva(r);
                        if (ultimoID != -1)
                        {
                            entComprobantePago.ComprobanteDePago com = new entComprobantePago.ComprobanteDePago();
                            com.Fecreg_comprobante = DateTime.Now;

                            int diasDeEstadia = (int)(date_salida.Value.Date - date_ingreso.Value.Date).TotalDays;
                            TipoHabitacion th2 = habSelecionada.idTipoHabitacion;
                            th2 = logTipoHabitacion.Instancia.BuscarTipoHabitacionPorId(th2.idTipoHabitacion);
                            double precioPorDia = th2.precTipoHabitacion;
                            double cantidadTotal = diasDeEstadia * precioPorDia;

                            float monto_servicios = 0;
                            for (int i = 0; i < listaServicios.Count; i++)
                            {
                                var item = listaServicios[i];
                                monto_servicios += item.precio;
                            }
                            com.Monpag_comprobante = (float)cantidadTotal + monto_servicios;

                            com.Forpago_comprobante = cm_formapago.SelectedItem.ToString();
                            if (!r.Est_Reserva) com.Est_comprobante = false;
                            else com.Est_comprobante = true;
                            com.Detalle = "en proceso";

                            Reserva reserva = new Reserva();
                            reserva.id_Reserva = ultimoID;

                            com.id_Reserva = reserva;
                            com.id_Tarjeta = new entTarjeta.Tarjeta();
                            com.id_Hospedaje = new entHospedaje.Hospedaje();

                            int id_comprobante = logComprobantePago.Instancia.InsertarComprobantePago(com);
                            // registrar detalleservicios
                            if (listaServicios.Count > 0)
                            {
                                foreach (var item in listaServicios)
                                {
                                    entDeatlleServicio.DetalleServicioAdicional d = new entDeatlleServicio.DetalleServicioAdicional();
                                    d.id_comprobante = new entComprobantePago.ComprobanteDePago();
                                    d.id_comprobante.id_Comprobante = id_comprobante;
                                    d.id_SerAdicional = new entServicio.Servicio();
                                    d.id_SerAdicional.idServicio = item.idServicio;
                                    logDetalleServicio.Instancia.InsertarDetalleServicio(d);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro.." + ex);
                    }
                    LimpiarVariables();
                    groupBox1.Enabled = false;
                    Listarreservas();
                    cliente = false;
                    habitacion = false;
                }
                else
                {
                    MessageBox.Show("Las fechas no son validas");
                }
                
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox3.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void btn_select_habitacion_Click(object sender, EventArgs e)
        {
            FrmSelectHabitacion frmSelectHabitacion = new FrmSelectHabitacion();
            frmSelectHabitacion.ShowDialog();
            habSelecionada = frmSelectHabitacion.getHabitacion();

            txt_idhabitacion.Text = habSelecionada.idHabitacion.ToString();
            txt_numerohabitacion.Text = habSelecionada.numHabitacion.ToString();

            btn_select_habitacion.Enabled = false;
            habitacion = true;
            //entHabitacion.Habitacion h ;
            //int id = int.Parse(txt_id_habitacion.Text);
            //h = logHabitacion.Instancia.BuscarHabitacion(id);
            //if (h.idHabitacion >0)
            //{
            //    MessageBox.Show("SE AGREGO CORRECTAMENTE");
            //    habitacion = true;
            //    btn_select_habitacion.Enabled = false;
            //    txt_id_habitacion.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("La habitacion no existe");
            //}
        }

        private void btn_selec_cli_Click(object sender, EventArgs e)
        {
            FrmSelectCliente frmSelectCliente = new FrmSelectCliente();
            frmSelectCliente.ShowDialog();
            cliSelecionado = frmSelectCliente.getCliente(); 

            txt_dni_cliente.Text = cliSelecionado.dni;
            txt_nombre_cliente.Text = cliSelecionado.nombCliente + " " + cliSelecionado.apelCliente;


            btn_selec_cli.Enabled = false;
            cliente = true;
            //int id = int.Parse(txt_id_cliente.Text);
            //entCliente.Cliente c = logCliente.Instancia.BuscarClientePorDni(id);

            //if (c.idCliente > 0)
            //{
            //    MessageBox.Show("Cliente agregago");
            //    cliente = true;
            //    btn_selec_cli.Enabled = false;
            //    txt_id_cliente.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("El cliente no existe");
            //}
        }

        private void btn_agregar_servicio_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cb_servicio.SelectedValue);
            listaServicios.Add(logServicio.Instancia.BuscarServicio(id));
            if(listaServicios.Count>0) ListaDeServiciosAdicionales();
        }
        private void ListaDeServiciosAdicionales()
        {
            dg_servicios.Rows.Clear();
            foreach (var item in listaServicios)
            {
                dg_servicios.Rows.Add(
                    item.idServicio,
                    item.nombre_servicio,
                    item.precio,
                    item.descripcion
                );
            }
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            cliente = false;
            txt_dni_cliente.Enabled = true;
            btn_selec_cli.Enabled = true;
            txt_nombre_cliente.Text = "";
            txt_dni_cliente.Text = "";
            cliSelecionado = null;
        }

        private void btnCambiarHabitacio_Click(object sender, EventArgs e)
        {
            habitacion = false;
            txt_idhabitacion.Enabled = true;
            btn_select_habitacion.Enabled = true;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (cm_formapago.SelectedIndex != -1 && cb_servicio.SelectedIndex != -1)
            {
                try
                {
                    entReserva.Reserva r = new entReserva.Reserva();
                    entCliente.Cliente c = new entCliente.Cliente();
                    entDeatlleServicio.DetalleServicioAdicional d = new entDeatlleServicio.DetalleServicioAdicional();
                    entHabitacion.Habitacion h = new entHabitacion.Habitacion();

                    r.id_Reserva = int.Parse(txt_id_reserva.Text);
                    r.Fecing_Reserva = date_ingreso.Value;
                    r.Fecsal_Reserva = date_salida.Value;
                    r.Est_Reserva = checkBoxEstado.Checked;

                    c = cliSelecionado;     ///buscar cliente dni
                    h = habSelecionada;

                    if (r.Est_Reserva)
                    {
                        h.DisHabitacion = "DISPONIBLE";
                        logHabitacion.Instancia.EditaHabitacion(h);
                    }

                    r.id_Cliente = c;
                    r.id_Habitacion = h;

                    if (logReserva.Instancia.EditaReserva(r))
                    {
                        entComprobantePago.ComprobanteDePago com = logComprobantePago.Instancia.BuscarComprobantePorReserva(r.id_Reserva);
                        
                        int diasDeEstadia = (int)(date_salida.Value - date_ingreso.Value).TotalDays;

                        TipoHabitacion th2 = habSelecionada.idTipoHabitacion;
                        th2 = logTipoHabitacion.Instancia.BuscarTipoHabitacionPorId(th2.idTipoHabitacion);
                        double precioPorDia = th2.precTipoHabitacion;
                        double cantidadTotal = diasDeEstadia * precioPorDia;

                        float monto_servicios = 0;
                        for (int i = 0; i < listaServicios.Count; i++) 
                        {
                            var item = listaServicios[i];
                            monto_servicios += item.precio;
                        }

                        com.Monpag_comprobante = (float)cantidadTotal + monto_servicios;



                        com.Forpago_comprobante = cm_formapago.SelectedItem.ToString();
                        if (!r.Est_Reserva) com.Est_comprobante = false;
                        else com.Est_comprobante = true;
                        com.id_Reserva.id_Reserva = r.id_Reserva;

                        logComprobantePago.Instancia.EditaComprobantePago(com);
                        // registrar detalleservicios

                        int can_registrados = logDetalleServicio.Instancia.contCantidadReservasporComprobante(com.id_Comprobante);




                        if (listaServicios.Count > can_registrados)
                        {
                            for (int i = can_registrados; i < listaServicios.Count; i++) //comprobar si es -1
                            {
                                var item = listaServicios[i];
                                entDeatlleServicio.DetalleServicioAdicional dt = new entDeatlleServicio.DetalleServicioAdicional();
                                dt.id_comprobante = new entComprobantePago.ComprobanteDePago();
                                dt.id_comprobante.id_Comprobante = com.id_Comprobante;
                                dt.id_SerAdicional = new entServicio.Servicio();
                                dt.id_SerAdicional.idServicio = item.idServicio;
                                logDetalleServicio.Instancia.InsertarDetalleServicio(dt);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro.." + ex);
                }
                LimpiarVariables();
                groupBox1.Enabled = false;
                Listarreservas();
                cliente = false;
                habitacion = false;
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void dg_reservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dg_reservas.Rows[e.RowIndex];
            bool band = (bool)filaActual.Cells[1].Value;
            if (!band)
            {
                txt_id_reserva.Text = filaActual.Cells[0].Value.ToString();
                checkBoxEstado.Checked = (bool)filaActual.Cells[1].Value;
                date_ingreso.Value = DateTime.Parse(filaActual.Cells[2].Value.ToString());
                date_salida.Value = DateTime.Parse(filaActual.Cells[3].Value.ToString());
                cm_formapago.SelectedIndex = 0;

                List<Reserva> reservas = logReserva.Instancia.ListarReserva();

                foreach (Reserva reserva in reservas)
                {
                    if (reserva.id_Reserva == Convert.ToInt32(txt_id_reserva.Text))
                    {
                        cliSelecionado = logCliente.Instancia.BuscarClientePorId(reserva.id_Cliente.idCliente);
                        habSelecionada = logHabitacion.Instancia.BuscarHabitacion(reserva.id_Habitacion.idHabitacion); ;
                    }
                }
                txt_dni_cliente.Text = cliSelecionado.dni;
                txt_nombre_cliente.Text = cliSelecionado.nombCliente + " " + cliSelecionado.apelCliente;

                txt_idhabitacion.Text = habSelecionada.idHabitacion.ToString();
                txt_numerohabitacion.Text = habSelecionada.numHabitacion.ToString();

                listaServicios = logServicio.Instancia.ListarServicioPorReserva(int.Parse(txt_id_reserva.Text));
                ListaDeServiciosAdicionales();
            }
        }
    }
}
