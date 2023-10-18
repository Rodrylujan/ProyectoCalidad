
namespace ProyectoFinal.Transacciones
{
    partial class FrmReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_reservas = new System.Windows.Forms.DataGridView();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cm_formapago = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.date_salida = new System.Windows.Forms.DateTimePicker();
            this.date_ingreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_reserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_numerohabitacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idhabitacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCambiarHabitacio = new System.Windows.Forms.Button();
            this.btn_select_habitacion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCambiarCliente = new System.Windows.Forms.Button();
            this.btn_selec_cli = new System.Windows.Forms.Button();
            this.txt_dni_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_agregar_servicio = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_servicio = new System.Windows.Forms.ComboBox();
            this.dg_servicios = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_servicios)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_reservas
            // 
            this.dg_reservas.AllowUserToAddRows = false;
            this.dg_reservas.AllowUserToDeleteRows = false;
            this.dg_reservas.AllowUserToResizeColumns = false;
            this.dg_reservas.AllowUserToResizeRows = false;
            this.dg_reservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_reservas.BackgroundColor = System.Drawing.Color.Silver;
            this.dg_reservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_reservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_reservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_reservas.EnableHeadersVisualStyles = false;
            this.dg_reservas.Location = new System.Drawing.Point(9, 72);
            this.dg_reservas.Margin = new System.Windows.Forms.Padding(2);
            this.dg_reservas.Name = "dg_reservas";
            this.dg_reservas.ReadOnly = true;
            this.dg_reservas.RowHeadersVisible = false;
            this.dg_reservas.RowHeadersWidth = 51;
            this.dg_reservas.RowTemplate.Height = 24;
            this.dg_reservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reservas.Size = new System.Drawing.Size(1117, 167);
            this.dg_reservas.TabIndex = 0;
            this.dg_reservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_reservas_CellContentDoubleClick);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(1163, 76);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(96, 44);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(1163, 138);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(96, 44);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1163, 198);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(96, 44);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cm_formapago);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.date_salida);
            this.groupBox1.Controls.Add(this.date_ingreso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id_reserva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 260);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(608, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registar Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Forma de pago";
            // 
            // cm_formapago
            // 
            this.cm_formapago.FormattingEnabled = true;
            this.cm_formapago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cm_formapago.Location = new System.Drawing.Point(117, 104);
            this.cm_formapago.Margin = new System.Windows.Forms.Padding(2);
            this.cm_formapago.Name = "cm_formapago";
            this.cm_formapago.Size = new System.Drawing.Size(151, 21);
            this.cm_formapago.TabIndex = 16;
            this.cm_formapago.Text = "(Selecionar)";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(312, 24);
            this.checkBoxEstado.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(102, 17);
            this.checkBoxEstado.TabIndex = 8;
            this.checkBoxEstado.Text = "Estado Reserva";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // date_salida
            // 
            this.date_salida.Location = new System.Drawing.Point(385, 70);
            this.date_salida.Margin = new System.Windows.Forms.Padding(2);
            this.date_salida.Name = "date_salida";
            this.date_salida.Size = new System.Drawing.Size(151, 20);
            this.date_salida.TabIndex = 7;
            // 
            // date_ingreso
            // 
            this.date_ingreso.Location = new System.Drawing.Point(117, 68);
            this.date_ingreso.Margin = new System.Windows.Forms.Padding(2);
            this.date_ingreso.Name = "date_ingreso";
            this.date_ingreso.Size = new System.Drawing.Size(151, 20);
            this.date_ingreso.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Ingreso";
            // 
            // txt_id_reserva
            // 
            this.txt_id_reserva.Location = new System.Drawing.Point(117, 28);
            this.txt_id_reserva.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_reserva.Name = "txt_id_reserva";
            this.txt_id_reserva.Size = new System.Drawing.Size(99, 20);
            this.txt_id_reserva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(32, 144);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(81, 37);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(32, 86);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(81, 37);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(32, 34);
            this.btn_grabar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(81, 37);
            this.btn_grabar.TabIndex = 9;
            this.btn_grabar.Text = "Grabar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.txt_numerohabitacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_idhabitacion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnCambiarHabitacio);
            this.groupBox2.Controls.Add(this.btn_select_habitacion);
            this.groupBox2.Location = new System.Drawing.Point(11, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(296, 205);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txt_numerohabitacion
            // 
            this.txt_numerohabitacion.Location = new System.Drawing.Point(59, 115);
            this.txt_numerohabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_numerohabitacion.Name = "txt_numerohabitacion";
            this.txt_numerohabitacion.ReadOnly = true;
            this.txt_numerohabitacion.Size = new System.Drawing.Size(192, 20);
            this.txt_numerohabitacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Numero";
            // 
            // txt_idhabitacion
            // 
            this.txt_idhabitacion.Location = new System.Drawing.Point(59, 78);
            this.txt_idhabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_idhabitacion.Name = "txt_idhabitacion";
            this.txt_idhabitacion.ReadOnly = true;
            this.txt_idhabitacion.Size = new System.Drawing.Size(192, 20);
            this.txt_idhabitacion.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Codigo";
            // 
            // btnCambiarHabitacio
            // 
            this.btnCambiarHabitacio.Location = new System.Drawing.Point(9, 156);
            this.btnCambiarHabitacio.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarHabitacio.Name = "btnCambiarHabitacio";
            this.btnCambiarHabitacio.Size = new System.Drawing.Size(78, 38);
            this.btnCambiarHabitacio.TabIndex = 3;
            this.btnCambiarHabitacio.Text = "Cambiar";
            this.btnCambiarHabitacio.UseVisualStyleBackColor = true;
            this.btnCambiarHabitacio.Click += new System.EventHandler(this.btnCambiarHabitacio_Click);
            // 
            // btn_select_habitacion
            // 
            this.btn_select_habitacion.Location = new System.Drawing.Point(60, 16);
            this.btn_select_habitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btn_select_habitacion.Name = "btn_select_habitacion";
            this.btn_select_habitacion.Size = new System.Drawing.Size(191, 38);
            this.btn_select_habitacion.TabIndex = 2;
            this.btn_select_habitacion.Text = "Seleccionar habitacion";
            this.btn_select_habitacion.UseVisualStyleBackColor = true;
            this.btn_select_habitacion.Click += new System.EventHandler(this.btn_select_habitacion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.txt_nombre_cliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnCambiarCliente);
            this.groupBox3.Controls.Add(this.btn_selec_cli);
            this.groupBox3.Controls.Add(this.txt_dni_cliente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(321, 419);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(296, 205);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(63, 121);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.ReadOnly = true;
            this.txt_nombre_cliente.Size = new System.Drawing.Size(192, 20);
            this.txt_nombre_cliente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // btnCambiarCliente
            // 
            this.btnCambiarCliente.Location = new System.Drawing.Point(106, 165);
            this.btnCambiarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarCliente.Name = "btnCambiarCliente";
            this.btnCambiarCliente.Size = new System.Drawing.Size(78, 38);
            this.btnCambiarCliente.TabIndex = 4;
            this.btnCambiarCliente.Text = "Cambiar";
            this.btnCambiarCliente.UseVisualStyleBackColor = true;
            this.btnCambiarCliente.Click += new System.EventHandler(this.btnCambiarCliente_Click);
            // 
            // btn_selec_cli
            // 
            this.btn_selec_cli.Location = new System.Drawing.Point(63, 15);
            this.btn_selec_cli.Margin = new System.Windows.Forms.Padding(2);
            this.btn_selec_cli.Name = "btn_selec_cli";
            this.btn_selec_cli.Size = new System.Drawing.Size(191, 38);
            this.btn_selec_cli.TabIndex = 3;
            this.btn_selec_cli.Text = "Seleccionar Cliente";
            this.btn_selec_cli.UseVisualStyleBackColor = true;
            this.btn_selec_cli.Click += new System.EventHandler(this.btn_selec_cli_Click);
            // 
            // txt_dni_cliente
            // 
            this.txt_dni_cliente.Location = new System.Drawing.Point(63, 84);
            this.txt_dni_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dni_cliente.Name = "txt_dni_cliente";
            this.txt_dni_cliente.ReadOnly = true;
            this.txt_dni_cliente.Size = new System.Drawing.Size(192, 20);
            this.txt_dni_cliente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "DNI";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Controls.Add(this.btn_agregar_servicio);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cb_servicio);
            this.groupBox4.Controls.Add(this.dg_servicios);
            this.groupBox4.Location = new System.Drawing.Point(633, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 364);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Servicios adicionales";
            // 
            // btn_agregar_servicio
            // 
            this.btn_agregar_servicio.Location = new System.Drawing.Point(234, 292);
            this.btn_agregar_servicio.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar_servicio.Name = "btn_agregar_servicio";
            this.btn_agregar_servicio.Size = new System.Drawing.Size(78, 38);
            this.btn_agregar_servicio.TabIndex = 16;
            this.btn_agregar_servicio.Text = "Agregar servicio";
            this.btn_agregar_servicio.UseVisualStyleBackColor = true;
            this.btn_agregar_servicio.Click += new System.EventHandler(this.btn_agregar_servicio_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Servicio";
            // 
            // cb_servicio
            // 
            this.cb_servicio.FormattingEnabled = true;
            this.cb_servicio.Location = new System.Drawing.Point(69, 302);
            this.cb_servicio.Margin = new System.Windows.Forms.Padding(2);
            this.cb_servicio.Name = "cb_servicio";
            this.cb_servicio.Size = new System.Drawing.Size(128, 21);
            this.cb_servicio.TabIndex = 14;
            // 
            // dg_servicios
            // 
            this.dg_servicios.AllowUserToAddRows = false;
            this.dg_servicios.AllowUserToDeleteRows = false;
            this.dg_servicios.AllowUserToResizeColumns = false;
            this.dg_servicios.AllowUserToResizeRows = false;
            this.dg_servicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_servicios.BackgroundColor = System.Drawing.Color.Silver;
            this.dg_servicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_servicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_servicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_servicios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_servicios.EnableHeadersVisualStyles = false;
            this.dg_servicios.Location = new System.Drawing.Point(17, 28);
            this.dg_servicios.Name = "dg_servicios";
            this.dg_servicios.ReadOnly = true;
            this.dg_servicios.RowHeadersVisible = false;
            this.dg_servicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_servicios.Size = new System.Drawing.Size(460, 252);
            this.dg_servicios.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox5.Controls.Add(this.btn_grabar);
            this.groupBox5.Controls.Add(this.btn_cancelar);
            this.groupBox5.Controls.Add(this.btn_modificar);
            this.groupBox5.Location = new System.Drawing.Point(1146, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(143, 364);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opciones";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1318, 649);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dg_reservas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_servicios)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_reservas;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_salida;
        private System.Windows.Forms.DateTimePicker date_ingreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_reserva;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Button btn_select_habitacion;
        private System.Windows.Forms.Button btn_selec_cli;
        private System.Windows.Forms.TextBox txt_dni_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_agregar_servicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_servicio;
        private System.Windows.Forms.DataGridView dg_servicios;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cm_formapago;
        private System.Windows.Forms.Button btnCambiarHabitacio;
        private System.Windows.Forms.Button btnCambiarCliente;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numerohabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idhabitacion;
        private System.Windows.Forms.Label label9;
    }
}