namespace ProyectoFinal.view
{
    partial class FrmSelectHabitacion
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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_piso = new System.Windows.Forms.RadioButton();
            this.rb_num = new System.Windows.Forms.RadioButton();
            this.rb_cod = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.AllowUserToResizeColumns = false;
            this.dgvHabitaciones.AllowUserToResizeRows = false;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(19, 144);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(871, 380);
            this.dgvHabitaciones.TabIndex = 10;
            this.dgvHabitaciones.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_piso);
            this.groupBox1.Controls.Add(this.rb_num);
            this.groupBox1.Controls.Add(this.rb_cod);
            this.groupBox1.Controls.Add(this.txt_buscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 113);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Habitacion";
            // 
            // rb_piso
            // 
            this.rb_piso.AutoSize = true;
            this.rb_piso.Location = new System.Drawing.Point(252, 78);
            this.rb_piso.Name = "rb_piso";
            this.rb_piso.Size = new System.Drawing.Size(57, 24);
            this.rb_piso.TabIndex = 3;
            this.rb_piso.TabStop = true;
            this.rb_piso.Text = "Piso";
            this.rb_piso.UseVisualStyleBackColor = true;
            // 
            // rb_num
            // 
            this.rb_num.AutoSize = true;
            this.rb_num.Location = new System.Drawing.Point(138, 78);
            this.rb_num.Name = "rb_num";
            this.rb_num.Size = new System.Drawing.Size(83, 24);
            this.rb_num.TabIndex = 2;
            this.rb_num.TabStop = true;
            this.rb_num.Text = "Numero";
            this.rb_num.UseVisualStyleBackColor = true;
            // 
            // rb_cod
            // 
            this.rb_cod.AutoSize = true;
            this.rb_cod.Checked = true;
            this.rb_cod.Location = new System.Drawing.Point(22, 78);
            this.rb_cod.Name = "rb_cod";
            this.rb_cod.Size = new System.Drawing.Size(77, 24);
            this.rb_cod.TabIndex = 1;
            this.rb_cod.TabStop = true;
            this.rb_cod.Text = "Codigo";
            this.rb_cod.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(22, 36);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(307, 26);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(794, 12);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 44);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmSelectHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 536);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectHabitacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_piso;
        private System.Windows.Forms.RadioButton rb_num;
        private System.Windows.Forms.RadioButton rb_cod;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btnSalir;
    }
}