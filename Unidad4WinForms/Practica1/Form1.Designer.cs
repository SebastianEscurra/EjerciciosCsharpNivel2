namespace Practica1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBotonMostrarDatos = new System.Windows.Forms.Button();
            this.lblMostrarInfo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblRecomendacionFormatoFecha = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblEstablecimiento = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtEstablecimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBotonMostrarDatos
            // 
            this.btnBotonMostrarDatos.Location = new System.Drawing.Point(296, 195);
            this.btnBotonMostrarDatos.Name = "btnBotonMostrarDatos";
            this.btnBotonMostrarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnBotonMostrarDatos.TabIndex = 0;
            this.btnBotonMostrarDatos.Text = "OK";
            this.btnBotonMostrarDatos.UseVisualStyleBackColor = true;
            this.btnBotonMostrarDatos.Click += new System.EventHandler(this.btnBotonMostrarDatos_Click);
            // 
            // lblMostrarInfo
            // 
            this.lblMostrarInfo.AutoSize = true;
            this.lblMostrarInfo.Location = new System.Drawing.Point(220, 239);
            this.lblMostrarInfo.Name = "lblMostrarInfo";
            this.lblMostrarInfo.Size = new System.Drawing.Size(0, 13);
            this.lblMostrarInfo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(271, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(336, 100);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNacimiento.TabIndex = 9;
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtFechaNacimiento_TextChanged);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(296, 74);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidad.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(201, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Formulario de datos del cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(218, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(221, 107);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFechaNacimiento.TabIndex = 7;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(218, 80);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 8;
            this.lblNacionalidad.Text = "Nacionalidad:";
            // 
            // lblRecomendacionFormatoFecha
            // 
            this.lblRecomendacionFormatoFecha.AutoSize = true;
            this.lblRecomendacionFormatoFecha.Location = new System.Drawing.Point(442, 103);
            this.lblRecomendacionFormatoFecha.Name = "lblRecomendacionFormatoFecha";
            this.lblRecomendacionFormatoFecha.Size = new System.Drawing.Size(0, 13);
            this.lblRecomendacionFormatoFecha.TabIndex = 10;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(220, 133);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(91, 13);
            this.lblNivel.TabIndex = 11;
            this.lblNivel.Text = "Nivel de estudios:";
            // 
            // lblEstablecimiento
            // 
            this.lblEstablecimiento.AutoSize = true;
            this.lblEstablecimiento.Location = new System.Drawing.Point(220, 156);
            this.lblEstablecimiento.Name = "lblEstablecimiento";
            this.lblEstablecimiento.Size = new System.Drawing.Size(84, 13);
            this.lblEstablecimiento.TabIndex = 12;
            this.lblEstablecimiento.Text = "Establecimiento:";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(314, 126);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivel.TabIndex = 13;
            // 
            // txtEstablecimiento
            // 
            this.txtEstablecimiento.Location = new System.Drawing.Point(307, 152);
            this.txtEstablecimiento.Name = "txtEstablecimiento";
            this.txtEstablecimiento.Size = new System.Drawing.Size(100, 20);
            this.txtEstablecimiento.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 342);
            this.Controls.Add(this.txtEstablecimiento);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.lblEstablecimiento);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblRecomendacionFormatoFecha);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMostrarInfo);
            this.Controls.Add(this.btnBotonMostrarDatos);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Primer formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotonMostrarDatos;
        private System.Windows.Forms.Label lblMostrarInfo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblRecomendacionFormatoFecha;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblEstablecimiento;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtEstablecimiento;
    }
}

