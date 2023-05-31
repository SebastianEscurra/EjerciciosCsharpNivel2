namespace conexionaDBejercicio2
{
    partial class frmAgregarDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.tbxFecha = new System.Windows.Forms.TextBox();
            this.tbxEstilo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(100, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(28, 63);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(116, 13);
            this.lblCantidadCanciones.TabIndex = 1;
            this.lblCantidadCanciones.Text = "Cantidad de canciones";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(33, 102);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha de lanzamiento";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(100, 135);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(44, 13);
            this.lblEstilo.TabIndex = 3;
            this.lblEstilo.Text = "Id Estilo";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(150, 19);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbxTitulo.TabIndex = 5;
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(150, 56);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbxCantidad.TabIndex = 6;
            // 
            // tbxFecha
            // 
            this.tbxFecha.Location = new System.Drawing.Point(150, 95);
            this.tbxFecha.Name = "tbxFecha";
            this.tbxFecha.Size = new System.Drawing.Size(100, 20);
            this.tbxFecha.TabIndex = 7;
            // 
            // tbxEstilo
            // 
            this.tbxEstilo.Location = new System.Drawing.Point(150, 128);
            this.tbxEstilo.Name = "tbxEstilo";
            this.tbxEstilo.Size = new System.Drawing.Size(100, 20);
            this.tbxEstilo.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(36, 165);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(162, 165);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 200);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxEstilo);
            this.Controls.Add(this.tbxFecha);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgregarDisco";
            this.Text = "AgregarDisco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.TextBox tbxFecha;
        private System.Windows.Forms.TextBox tbxEstilo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}