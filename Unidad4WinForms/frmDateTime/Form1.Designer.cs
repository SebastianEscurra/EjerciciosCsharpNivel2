namespace frmDateTime
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
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnRangoFecha = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.calRangoFecha = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(99)))));
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Location = new System.Drawing.Point(338, 56);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 23);
            this.btnFecha.TabIndex = 0;
            this.btnFecha.Text = "Ver";
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnRangoFecha
            // 
            this.btnRangoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(11)))), ((int)(((byte)(99)))));
            this.btnRangoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRangoFecha.Location = new System.Drawing.Point(338, 222);
            this.btnRangoFecha.Name = "btnRangoFecha";
            this.btnRangoFecha.Size = new System.Drawing.Size(75, 23);
            this.btnRangoFecha.TabIndex = 1;
            this.btnRangoFecha.Text = "Ver";
            this.btnRangoFecha.UseVisualStyleBackColor = false;
            this.btnRangoFecha.Click += new System.EventHandler(this.btnRangoFecha_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(10)))), ((int)(((byte)(152)))));
            this.dtpFecha.Location = new System.Drawing.Point(117, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // calRangoFecha
            // 
            this.calRangoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(20)))), ((int)(((byte)(179)))));
            this.calRangoFecha.ForeColor = System.Drawing.SystemColors.MenuText;
            this.calRangoFecha.Location = new System.Drawing.Point(117, 150);
            this.calRangoFecha.Name = "calRangoFecha";
            this.calRangoFecha.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(6)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.calRangoFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnRangoFecha);
            this.Controls.Add(this.btnFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnRangoFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar calRangoFecha;
    }
}

