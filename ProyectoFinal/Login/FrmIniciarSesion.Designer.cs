namespace ProyectoFinal.Login
{
    partial class FrmIniciarSesion
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
            this.components = new System.ComponentModel.Container();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.RecordarUser = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIntentos = new System.Windows.Forms.Label();
            this.txbContra = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.btnIniciarSesion);
            this.panelPrincipal.Controls.Add(this.RecordarUser);
            this.panelPrincipal.Controls.Add(this.pictureBox3);
            this.panelPrincipal.Controls.Add(this.pictureBox2);
            this.panelPrincipal.Controls.Add(this.label3);
            this.panelPrincipal.Controls.Add(this.lbIntentos);
            this.panelPrincipal.Controls.Add(this.txbContra);
            this.panelPrincipal.Controls.Add(this.txbUser);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(500, 450);
            this.panelPrincipal.TabIndex = 14;
            // 
            // RecordarUser
            // 
            this.RecordarUser.AutoSize = true;
            this.RecordarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordarUser.Location = new System.Drawing.Point(227, 278);
            this.RecordarUser.Name = "RecordarUser";
            this.RecordarUser.Size = new System.Drawing.Size(86, 21);
            this.RecordarUser.TabIndex = 15;
            this.RecordarUser.Text = "Recordar";
            this.RecordarUser.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoFinal.Properties.Resources.cerrar_con_llave;
            this.pictureBox3.Location = new System.Drawing.Point(89, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(89, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.label3.Location = new System.Drawing.Point(104, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "INICIAR SESION";
            // 
            // lbIntentos
            // 
            this.lbIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntentos.ForeColor = System.Drawing.Color.Red;
            this.lbIntentos.Location = new System.Drawing.Point(89, 117);
            this.lbIntentos.Name = "lbIntentos";
            this.lbIntentos.Size = new System.Drawing.Size(369, 23);
            this.lbIntentos.TabIndex = 2;
            this.lbIntentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbContra
            // 
            this.txbContra.BackColor = System.Drawing.Color.White;
            this.txbContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txbContra.Location = new System.Drawing.Point(160, 233);
            this.txbContra.Name = "txbContra";
            this.txbContra.Size = new System.Drawing.Size(241, 26);
            this.txbContra.TabIndex = 4;
            this.txbContra.Tag = "";
            this.txbContra.Enter += new System.EventHandler(this.txbPassword_Enter);
            this.txbContra.Leave += new System.EventHandler(this.txbPassword_Leave);
            // 
            // txbUser
            // 
            this.txbUser.BackColor = System.Drawing.Color.White;
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144)))));
            this.txbUser.Location = new System.Drawing.Point(160, 158);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(241, 26);
            this.txbUser.TabIndex = 3;
            this.txbUser.Tag = "";
            this.txbUser.Enter += new System.EventHandler(this.txbUser_Enter);
            this.txbUser.Leave += new System.EventHandler(this.txbUser_Leave);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(215, 316);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarSesion.TabIndex = 16;
            this.btnIniciarSesion.Text = "login";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "FrmIniciarSesion";
            this.Text = "FrmIniciarSesion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIniciarSesion_FormClosing);
            this.Load += new System.EventHandler(this.FrmIniciarSesion_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIntentos;
        private System.Windows.Forms.TextBox txbContra;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox RecordarUser;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}