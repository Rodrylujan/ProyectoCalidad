using LogicaNegocio.MantenedorComprobante;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using LogicaNegocio.Mantenedor;
using LogicaNegocio.MantenedorReserva;
using LogicaNegocio.MantenedorHabitacion;
using LogicaNegocio.MantenedorServicio;
using iTextSharp.text.pdf.parser;
using System.Diagnostics;

namespace ProyectoFinal.Transacciones
{
    public partial class FrmComprobantes : Form
    {
        private entComprobantePago.ComprobanteDePago selecionado;
        public FrmComprobantes()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            List<entComprobantePago.ComprobanteDePago> comprobantes = logComprobantePago.Instancia.ListarComprobantePago();

            dgvComprobantes.Columns.AddRange(
                new DataGridViewTextBoxColumn { HeaderText = "ID" },
                new DataGridViewTextBoxColumn { HeaderText = "Fecha de registro" },
                new DataGridViewTextBoxColumn { HeaderText = "Monto" },
                new DataGridViewTextBoxColumn { HeaderText = "Detalle" },
                new DataGridViewTextBoxColumn { HeaderText = "Forma de pago" },
                new DataGridViewTextBoxColumn { HeaderText = "Estado" },
                new DataGridViewTextBoxColumn { HeaderText = "Id hospedaje" },
                new DataGridViewTextBoxColumn { HeaderText = "Id reserva" },
                new DataGridViewTextBoxColumn { HeaderText = "Ver" }
            );
            dgvComprobantes.Columns[0].Width = 40;
            foreach (DataGridViewColumn column in dgvComprobantes.Columns) column.SortMode = DataGridViewColumnSortMode.NotSortable;

            foreach (var item in comprobantes)
            {
                dgvComprobantes.Rows.Add(
                    item.id_Comprobante,
                    item.Fecreg_comprobante,
                    item.Monpag_comprobante,
                    item.Detalle,
                    item.Forpago_comprobante,
                    item.Est_comprobante,
                    item.id_Hospedaje,
                    item.id_Reserva.id_Reserva,
                    "VER"
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvComprobantes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                List<entComprobantePago.ComprobanteDePago> listaComprobantes = logComprobantePago.Instancia.ListarComprobantePago();

                DataGridViewRow selectedRow = dgvComprobantes.Rows[e.RowIndex];
                selecionado = new entComprobantePago.ComprobanteDePago();
                selecionado.id_Comprobante = Convert.ToInt32(selectedRow.Cells[0].Value);

                foreach (var item in listaComprobantes)
                {
                    if (item.id_Comprobante==selecionado.id_Comprobante)
                    {
                        selecionado=item;
                        break;
                    }
                }
                entReserva.Reserva r = logReserva.Instancia.buscarReservaPorId(selecionado.id_Reserva.id_Reserva);
                entCliente.Cliente c = logCliente.Instancia.BuscarClientePorId(r.id_Cliente.idCliente);
                entHabitacion.Habitacion h = logHabitacion.Instancia.BuscarHabitacion(r.id_Habitacion.idHabitacion);
                entTipoHabitacion.TipoHabitacion th = logTipoHabitacion.Instancia.BuscarTipoHabitacionPorId(h.idTipoHabitacion.idTipoHabitacion);

                string ruta = null;
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string carpetaSeleccionada = folderDialog.SelectedPath;
                        ruta = carpetaSeleccionada;
                        ruta += "\\Comprobante-" + selecionado.id_Comprobante + ".pdf";
                    }
                }
                if (!string.IsNullOrEmpty(ruta))
                {
                    // Crear un documento PDF
                    Document doc = new Document();

                    // Configurar la ruta del archivo PDF y el tipo de página
                    PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));

                    // Abrir el documento para escribir
                    doc.Open();

                    // Agregar contenido al comprobante de pago
                    Paragraph titulo = new Paragraph("HOTEL CENTRAL");
                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.Font.Size = 25;
                    titulo.Font.SetColor(147, 0, 0);

                    Paragraph saltoline = new Paragraph("\n");
                    Paragraph separador = new Paragraph("______________________________________________________________________________");

                    Paragraph datclihab = new Paragraph("DATOS DEL CLIENTE Y HABITACION");
                    Paragraph apellidos = new Paragraph("Apellidos                :     " + c.apelCliente);
                    Paragraph nombres__ = new Paragraph("Nombres                :     " + c.nombCliente);
                    Paragraph dni______ = new Paragraph("DNI                        :     " + c.dni);
                    Paragraph numhabit = new Paragraph("Numero habitacion:     " + h.numHabitacion);
                    Paragraph fechingte = new Paragraph("Fecha de ingreso  :     " + r.Fecing_Reserva.ToString("dd/MM/yyyy"));
                    Paragraph fechsalid = new Paragraph("Fecha de salida    :     " + r.Fecsal_Reserva.ToString("dd/MM/yyyy"));
                    Paragraph dias = new Paragraph("Cantidad de dias de estadias:     " + ((int)(r.Fecsal_Reserva - r.Fecing_Reserva).TotalDays) + " dias");
                    Paragraph precio = new Paragraph("-   Precio habitacion: s/. " + th.precTipoHabitacion);

                    //separador
                    Paragraph datServicios = new Paragraph("SERVICIOS ADICIONALES");

                    List<entServicio.Servicio> servicios = logServicio.Instancia.ListarServicioPorReserva(r.id_Reserva);
                    List<Paragraph> serviciosListaadd = new List<Paragraph>();
                    foreach (var item in servicios)
                    {
                        serviciosListaadd.Add(new Paragraph("-   " + item.nombre_servicio + " s/. " + item.precio));
                    }

                    Paragraph total = new Paragraph("-   Precio total: s/. " + selecionado.Monpag_comprobante);
                    total.Font.Size = 15;
                    total.Font.IsBold();
                    // Agregar los párrafos al documento
                    doc.Add(titulo);
                    doc.Add(saltoline);
                    doc.Add(separador);
                    doc.Add(saltoline);
                    doc.Add(datclihab);
                    doc.Add(apellidos);
                    doc.Add(nombres__);
                    doc.Add(dni______);
                    doc.Add(numhabit);
                    doc.Add(fechingte);
                    doc.Add(fechsalid);
                    doc.Add(dias);
                    doc.Add(precio);
                    doc.Add(saltoline);
                    doc.Add(separador);
                    doc.Add(saltoline);
                    doc.Add(datServicios);

                    foreach (var item in serviciosListaadd)
                    {
                        doc.Add(item);
                    }

                    doc.Add(separador);
                    doc.Add(saltoline);
                    doc.Add(saltoline);
                    doc.Add(total);

                    // Cerrar el documento
                    doc.Close();
                    Process.Start(ruta);
                }


                    //string filePath = @"C:\Users\YOBER\Desktop\calidad\comprobante.pdf";

                
            }
        }
    }
}
