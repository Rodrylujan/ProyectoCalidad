
namespace ProyectoFinal.Login
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lbIntentos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbContraseñas = new System.Windows.Forms.Label();
            this.lbOlvidePasss = new System.Windows.Forms.Label();
            this.lbCambiarPasss = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(286, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(268, 93);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(241, 26);
            this.txbUser.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(268, 145);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(241, 26);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.MouseEnter += new System.EventHandler(this.txbPassword_MouseEnter);
            this.txbPassword.MouseLeave += new System.EventHandler(this.txbPassword_MouseLeave);
            // 
            // lbIntentos
            // 
            this.lbIntentos.ForeColor = System.Drawing.Color.Red;
            this.lbIntentos.Location = new System.Drawing.Point(185, 51);
            this.lbIntentos.Name = "lbIntentos";
            this.lbIntentos.Size = new System.Drawing.Size(324, 23);
            this.lbIntentos.TabIndex = 5;
            this.lbIntentos.Text = "Numero de intentos restantes: 3";
            this.lbIntentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(619, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbContraseñas
            // 
            this.lbContraseñas.Location = new System.Drawing.Point(515, 145);
            this.lbContraseñas.Name = "lbContraseñas";
            this.lbContraseñas.Size = new System.Drawing.Size(224, 93);
            this.lbContraseñas.TabIndex = 7;
            // 
            // lbOlvidePasss
            // 
            this.lbOlvidePasss.ForeColor = System.Drawing.Color.Red;
            this.lbOlvidePasss.Location = new System.Drawing.Point(383, 292);
            this.lbOlvidePasss.Name = "lbOlvidePasss";
            this.lbOlvidePasss.Size = new System.Drawing.Size(95, 15);
            this.lbOlvidePasss.TabIndex = 10;
            this.lbOlvidePasss.Text = "Olvide contraseña";
            this.lbOlvidePasss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbOlvidePasss.Click += new System.EventHandler(this.lbOlvidePasss_Click);
            // 
            // lbCambiarPasss
            // 
            this.lbCambiarPasss.ForeColor = System.Drawing.Color.Red;
            this.lbCambiarPasss.Location = new System.Drawing.Point(203, 292);
            this.lbCambiarPasss.Name = "lbCambiarPasss";
            this.lbCambiarPasss.Size = new System.Drawing.Size(102, 15);
            this.lbCambiarPasss.TabIndex = 11;
            this.lbCambiarPasss.Text = "Cambiar contraseña ";
            this.lbCambiarPasss.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCambiarPasss.Click += new System.EventHandler(this.lbCambiarPasss_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 345);
            this.Controls.Add(this.lbCambiarPasss);
            this.Controls.Add(this.lbOlvidePasss);
            this.Controls.Add(this.lbContraseñas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbIntentos);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lbIntentos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbContraseñas;
        private System.Windows.Forms.Label lbOlvidePasss;
        private System.Windows.Forms.Label lbCambiarPasss;
    }
}