namespace FlujoVenta
{
    partial class IniciarCaja
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
            this.bienvenida = new System.Windows.Forms.Label();
            this.explicacionlogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnInicioCaja = new System.Windows.Forms.Button();
            this.btnLimpiarCaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Location = new System.Drawing.Point(50, 29);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(250, 13);
            this.bienvenida.TabIndex = 0;
            this.bienvenida.Text = "Bienvenido al Sistema de Ventas de Pizza Hat Spa.";
            // 
            // explicacionlogin
            // 
            this.explicacionlogin.AutoSize = true;
            this.explicacionlogin.Location = new System.Drawing.Point(72, 66);
            this.explicacionlogin.Name = "explicacionlogin";
            this.explicacionlogin.Size = new System.Drawing.Size(160, 13);
            this.explicacionlogin.TabIndex = 1;
            this.explicacionlogin.Text = "Ingrese su Usuario y Contrasena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contrasena";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(72, 130);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(161, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(161, 173);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(153, 20);
            this.txtContrasena.TabIndex = 5;
            // 
            // btnInicioCaja
            // 
            this.btnInicioCaja.Location = new System.Drawing.Point(109, 236);
            this.btnInicioCaja.Name = "btnInicioCaja";
            this.btnInicioCaja.Size = new System.Drawing.Size(75, 23);
            this.btnInicioCaja.TabIndex = 6;
            this.btnInicioCaja.Text = "Ingresar";
            this.btnInicioCaja.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCaja
            // 
            this.btnLimpiarCaja.Location = new System.Drawing.Point(239, 236);
            this.btnLimpiarCaja.Name = "btnLimpiarCaja";
            this.btnLimpiarCaja.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCaja.TabIndex = 7;
            this.btnLimpiarCaja.Text = "Limpiar";
            this.btnLimpiarCaja.UseVisualStyleBackColor = true;
            // 
            // IniciarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 298);
            this.Controls.Add(this.btnLimpiarCaja);
            this.Controls.Add(this.btnInicioCaja);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.explicacionlogin);
            this.Controls.Add(this.bienvenida);
            this.Name = "IniciarCaja";
            this.Text = "IniciarCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label explicacionlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnInicioCaja;
        private System.Windows.Forms.Button btnLimpiarCaja;
    }
}