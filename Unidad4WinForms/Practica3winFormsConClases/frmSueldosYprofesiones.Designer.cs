namespace Practica3winFormsConClases
{
    partial class frmSueldosYprofesiones
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSubtituloCarga = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtbLocalidad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtbDireccion = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtbDocumento = new System.Windows.Forms.TextBox();
            this.grbxProfesion = new System.Windows.Forms.GroupBox();
            this.rbtnIngenieroDeSoftware = new System.Windows.Forms.RadioButton();
            this.rbtnAnalistaDeDatos = new System.Windows.Forms.RadioButton();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbxSeleccionPersonal = new System.Windows.Forms.ComboBox();
            this.btnCargarPersona = new System.Windows.Forms.Button();
            this.lblSubTituloSeleccionPersonal = new System.Windows.Forms.Label();
            this.lblSubTituloMostrarDato = new System.Windows.Forms.Label();
            this.cbxMostrarDato = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.lvwListaDatos = new System.Windows.Forms.ListView();
            this.grbxProfesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(265, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(302, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sueldos y profesiones";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbNombre.Location = new System.Drawing.Point(77, 79);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "&Nombre:";
            // 
            // lblSubtituloCarga
            // 
            this.lblSubtituloCarga.AutoSize = true;
            this.lblSubtituloCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloCarga.Location = new System.Drawing.Point(10, 49);
            this.lblSubtituloCarga.Name = "lblSubtituloCarga";
            this.lblSubtituloCarga.Size = new System.Drawing.Size(124, 17);
            this.lblSubtituloCarga.TabIndex = 3;
            this.lblSubtituloCarga.Text = "Carga de datos:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(39, 109);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad:";
            // 
            // txtbEdad
            // 
            this.txtbEdad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbEdad.Location = new System.Drawing.Point(77, 105);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(100, 20);
            this.txtbEdad.TabIndex = 1;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(19, 187);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 9;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtbLocalidad
            // 
            this.txtbLocalidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbLocalidad.Location = new System.Drawing.Point(77, 183);
            this.txtbLocalidad.Name = "txtbLocalidad";
            this.txtbLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtbLocalidad.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 161);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtbDireccion
            // 
            this.txtbDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbDireccion.Location = new System.Drawing.Point(77, 157);
            this.txtbDireccion.Name = "txtbDireccion";
            this.txtbDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtbDireccion.TabIndex = 3;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(10, 135);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 11;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtbDocumento
            // 
            this.txtbDocumento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtbDocumento.Location = new System.Drawing.Point(77, 131);
            this.txtbDocumento.Name = "txtbDocumento";
            this.txtbDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtbDocumento.TabIndex = 2;
            // 
            // grbxProfesion
            // 
            this.grbxProfesion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbxProfesion.Controls.Add(this.rbtnIngenieroDeSoftware);
            this.grbxProfesion.Controls.Add(this.rbtnAnalistaDeDatos);
            this.grbxProfesion.Location = new System.Drawing.Point(23, 260);
            this.grbxProfesion.Name = "grbxProfesion";
            this.grbxProfesion.Size = new System.Drawing.Size(154, 73);
            this.grbxProfesion.TabIndex = 6;
            this.grbxProfesion.TabStop = false;
            this.grbxProfesion.Text = "Profesion:";
            // 
            // rbtnIngenieroDeSoftware
            // 
            this.rbtnIngenieroDeSoftware.AutoSize = true;
            this.rbtnIngenieroDeSoftware.Location = new System.Drawing.Point(19, 47);
            this.rbtnIngenieroDeSoftware.Name = "rbtnIngenieroDeSoftware";
            this.rbtnIngenieroDeSoftware.Size = new System.Drawing.Size(127, 17);
            this.rbtnIngenieroDeSoftware.TabIndex = 1;
            this.rbtnIngenieroDeSoftware.TabStop = true;
            this.rbtnIngenieroDeSoftware.Text = "Ingeniero de software";
            this.rbtnIngenieroDeSoftware.UseVisualStyleBackColor = true;
            // 
            // rbtnAnalistaDeDatos
            // 
            this.rbtnAnalistaDeDatos.AutoSize = true;
            this.rbtnAnalistaDeDatos.Location = new System.Drawing.Point(19, 25);
            this.rbtnAnalistaDeDatos.Name = "rbtnAnalistaDeDatos";
            this.rbtnAnalistaDeDatos.Size = new System.Drawing.Size(106, 17);
            this.rbtnAnalistaDeDatos.TabIndex = 0;
            this.rbtnAnalistaDeDatos.TabStop = true;
            this.rbtnAnalistaDeDatos.Text = "Analista de datos";
            this.rbtnAnalistaDeDatos.UseVisualStyleBackColor = true;
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(3, 225);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(73, 13);
            this.lblFechaDeNacimiento.TabIndex = 13;
            this.lblFechaDeNacimiento.Text = "F. nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(77, 221);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // cbxSeleccionPersonal
            // 
            this.cbxSeleccionPersonal.FormattingEnabled = true;
            this.cbxSeleccionPersonal.Location = new System.Drawing.Point(467, 101);
            this.cbxSeleccionPersonal.Name = "cbxSeleccionPersonal";
            this.cbxSeleccionPersonal.Size = new System.Drawing.Size(121, 21);
            this.cbxSeleccionPersonal.TabIndex = 8;
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCargarPersona.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCargarPersona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCargarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCargarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPersona.Location = new System.Drawing.Point(77, 355);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(106, 36);
            this.btnCargarPersona.TabIndex = 7;
            this.btnCargarPersona.Text = "&Cargar persona";
            this.btnCargarPersona.UseVisualStyleBackColor = false;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // lblSubTituloSeleccionPersonal
            // 
            this.lblSubTituloSeleccionPersonal.AutoSize = true;
            this.lblSubTituloSeleccionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTituloSeleccionPersonal.Location = new System.Drawing.Point(442, 74);
            this.lblSubTituloSeleccionPersonal.Name = "lblSubTituloSeleccionPersonal";
            this.lblSubTituloSeleccionPersonal.Size = new System.Drawing.Size(169, 17);
            this.lblSubTituloSeleccionPersonal.TabIndex = 17;
            this.lblSubTituloSeleccionPersonal.Text = "Seleccion de personal";
            // 
            // lblSubTituloMostrarDato
            // 
            this.lblSubTituloMostrarDato.AutoSize = true;
            this.lblSubTituloMostrarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTituloMostrarDato.Location = new System.Drawing.Point(442, 139);
            this.lblSubTituloMostrarDato.Name = "lblSubTituloMostrarDato";
            this.lblSubTituloMostrarDato.Size = new System.Drawing.Size(170, 17);
            this.lblSubTituloMostrarDato.TabIndex = 19;
            this.lblSubTituloMostrarDato.Text = "¿Que dato desea ver?";
            // 
            // cbxMostrarDato
            // 
            this.cbxMostrarDato.FormattingEnabled = true;
            this.cbxMostrarDato.Location = new System.Drawing.Point(467, 166);
            this.cbxMostrarDato.Name = "cbxMostrarDato";
            this.cbxMostrarDato.Size = new System.Drawing.Size(121, 21);
            this.cbxMostrarDato.TabIndex = 9;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Location = new System.Drawing.Point(489, 217);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lvwListaDatos
            // 
            this.lvwListaDatos.HideSelection = false;
            this.lvwListaDatos.Location = new System.Drawing.Point(285, 248);
            this.lvwListaDatos.Name = "lvwListaDatos";
            this.lvwListaDatos.Size = new System.Drawing.Size(503, 143);
            this.lvwListaDatos.TabIndex = 21;
            this.lvwListaDatos.UseCompatibleStateImageBehavior = false;
            this.lvwListaDatos.View = System.Windows.Forms.View.List;
            // 
            // frmSueldosYprofesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.lvwListaDatos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.lblSubTituloMostrarDato);
            this.Controls.Add(this.cbxMostrarDato);
            this.Controls.Add(this.lblSubTituloSeleccionPersonal);
            this.Controls.Add(this.btnCargarPersona);
            this.Controls.Add(this.cbxSeleccionPersonal);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.grbxProfesion);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtbDocumento);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtbLocalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtbDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.lblSubtituloCarga);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(816, 449);
            this.Name = "frmSueldosYprofesiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sueldos y profesiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbxProfesion.ResumeLayout(false);
            this.grbxProfesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSubtituloCarga;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtbLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtbDireccion;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtbDocumento;
        private System.Windows.Forms.GroupBox grbxProfesion;
        private System.Windows.Forms.RadioButton rbtnIngenieroDeSoftware;
        private System.Windows.Forms.RadioButton rbtnAnalistaDeDatos;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cbxSeleccionPersonal;
        private System.Windows.Forms.Button btnCargarPersona;
        private System.Windows.Forms.Label lblSubTituloSeleccionPersonal;
        private System.Windows.Forms.Label lblSubTituloMostrarDato;
        private System.Windows.Forms.ComboBox cbxMostrarDato;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ListView lvwListaDatos;
    }
}

