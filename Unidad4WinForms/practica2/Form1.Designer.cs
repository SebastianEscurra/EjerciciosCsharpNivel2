namespace practica2
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.gbxPizza = new System.Windows.Forms.GroupBox();
            this.rbtFugazzeta = new System.Windows.Forms.RadioButton();
            this.rbtAnana = new System.Windows.Forms.RadioButton();
            this.rbtNapolitana = new System.Windows.Forms.RadioButton();
            this.cmbColores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNumeroFav = new System.Windows.Forms.Label();
            this.nudNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lwListaElementos = new System.Windows.Forms.ListView();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbxPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(136, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(183, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(183, 103);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 2;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(183, 139);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(135, 17);
            this.ckbChocolate.TabIndex = 3;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // gbxPizza
            // 
            this.gbxPizza.Controls.Add(this.rbtFugazzeta);
            this.gbxPizza.Controls.Add(this.rbtAnana);
            this.gbxPizza.Controls.Add(this.rbtNapolitana);
            this.gbxPizza.Location = new System.Drawing.Point(183, 163);
            this.gbxPizza.Name = "gbxPizza";
            this.gbxPizza.Size = new System.Drawing.Size(322, 70);
            this.gbxPizza.TabIndex = 4;
            this.gbxPizza.TabStop = false;
            this.gbxPizza.Text = "Pizza";
            // 
            // rbtFugazzeta
            // 
            this.rbtFugazzeta.AutoSize = true;
            this.rbtFugazzeta.Location = new System.Drawing.Point(231, 40);
            this.rbtFugazzeta.Name = "rbtFugazzeta";
            this.rbtFugazzeta.Size = new System.Drawing.Size(74, 17);
            this.rbtFugazzeta.TabIndex = 2;
            this.rbtFugazzeta.TabStop = true;
            this.rbtFugazzeta.Text = "Fugazzeta";
            this.rbtFugazzeta.UseVisualStyleBackColor = true;
            // 
            // rbtAnana
            // 
            this.rbtAnana.AutoSize = true;
            this.rbtAnana.Location = new System.Drawing.Point(132, 40);
            this.rbtAnana.Name = "rbtAnana";
            this.rbtAnana.Size = new System.Drawing.Size(56, 17);
            this.rbtAnana.TabIndex = 1;
            this.rbtAnana.TabStop = true;
            this.rbtAnana.Text = "Anana";
            this.rbtAnana.UseVisualStyleBackColor = true;
            // 
            // rbtNapolitana
            // 
            this.rbtNapolitana.AutoSize = true;
            this.rbtNapolitana.Location = new System.Drawing.Point(17, 40);
            this.rbtNapolitana.Name = "rbtNapolitana";
            this.rbtNapolitana.Size = new System.Drawing.Size(76, 17);
            this.rbtNapolitana.TabIndex = 0;
            this.rbtNapolitana.TabStop = true;
            this.rbtNapolitana.Text = "Napolitana";
            this.rbtNapolitana.UseVisualStyleBackColor = true;
            // 
            // cmbColores
            // 
            this.cmbColores.FormattingEnabled = true;
            this.cmbColores.Location = new System.Drawing.Point(183, 239);
            this.cmbColores.Name = "cmbColores";
            this.cmbColores.Size = new System.Drawing.Size(121, 21);
            this.cmbColores.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(109, 245);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color favorito:";
            // 
            // lblNumeroFav
            // 
            this.lblNumeroFav.AutoSize = true;
            this.lblNumeroFav.Location = new System.Drawing.Point(98, 281);
            this.lblNumeroFav.Name = "lblNumeroFav";
            this.lblNumeroFav.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroFav.TabIndex = 8;
            this.lblNumeroFav.Text = "Numero favorito:";
            // 
            // nudNumeroFavorito
            // 
            this.nudNumeroFavorito.Location = new System.Drawing.Point(184, 274);
            this.nudNumeroFavorito.Name = "nudNumeroFavorito";
            this.nudNumeroFavorito.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroFavorito.TabIndex = 9;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(183, 448);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lwListaElementos
            // 
            this.lwListaElementos.HideSelection = false;
            this.lwListaElementos.Location = new System.Drawing.Point(183, 344);
            this.lwListaElementos.Name = "lwListaElementos";
            this.lwListaElementos.Size = new System.Drawing.Size(205, 97);
            this.lwListaElementos.TabIndex = 11;
            this.lwListaElementos.UseCompatibleStateImageBehavior = false;
            this.lwListaElementos.View = System.Windows.Forms.View.List;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(183, 316);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 12;
            this.btnPerfil.Text = "Ver perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 509);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lwListaElementos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.nudNumeroFavorito);
            this.Controls.Add(this.lblNumeroFav);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbColores);
            this.Controls.Add(this.gbxPizza);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxPizza.ResumeLayout(false);
            this.gbxPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.GroupBox gbxPizza;
        private System.Windows.Forms.RadioButton rbtFugazzeta;
        private System.Windows.Forms.RadioButton rbtAnana;
        private System.Windows.Forms.RadioButton rbtNapolitana;
        private System.Windows.Forms.ComboBox cmbColores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNumeroFav;
        private System.Windows.Forms.NumericUpDown nudNumeroFavorito;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListView lwListaElementos;
        private System.Windows.Forms.Button btnPerfil;
    }
}

