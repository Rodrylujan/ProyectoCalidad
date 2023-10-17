
namespace ProyectoFinal.Login
{
    partial class FrmNuevaPass
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txbConfirmarPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNuevoPasssword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContraseñas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(619, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Atras";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(259, 199);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 40);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // txbConfirmarPassword
            // 
            this.txbConfirmarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConfirmarPassword.Location = new System.Drawing.Point(221, 123);
            this.txbConfirmarPassword.Name = "txbConfirmarPassword";
            this.txbConfirmarPassword.PasswordChar = '*';
            this.txbConfirmarPassword.Size = new System.Drawing.Size(284, 26);
            this.txbConfirmarPassword.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirmar contraseña";
            // 
            // txbNuevoPasssword
            // 
            this.txbNuevoPasssword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNuevoPasssword.Location = new System.Drawing.Point(221, 65);
            this.txbNuevoPasssword.Name = "txbNuevoPasssword";
            this.txbNuevoPasssword.PasswordChar = '*';
            this.txbNuevoPasssword.Size = new System.Drawing.Size(284, 26);
            this.txbNuevoPasssword.TabIndex = 16;
            this.txbNuevoPasssword.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.txbNuevoPasssword.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nueva contraseña";
            // 
            // lbContraseñas
            // 
            this.lbContraseñas.Location = new System.Drawing.Point(515, 65);
            this.lbContraseñas.Name = "lbContraseñas";
            this.lbContraseñas.Size = new System.Drawing.Size(224, 93);
            this.lbContraseñas.TabIndex = 20;
            // 
            // FrmNuevaPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 345);
            this.Controls.Add(this.lbContraseñas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbConfirmarPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNuevoPasssword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaPass";
            this.Text = "FrmNuevaPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txbConfirmarPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNuevoPasssword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbContraseñas;
    }
}