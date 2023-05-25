namespace AppFabricaDeCalzadoFemenino
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
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.pbxImagenCalzados = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCalzados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Location = new System.Drawing.Point(53, 68);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.Size = new System.Drawing.Size(500, 150);
            this.dgvListaPedidos.TabIndex = 0;
            this.dgvListaPedidos.SelectionChanged += new System.EventHandler(this.dgvListaPedidos_SelectionChanged);
            // 
            // pbxImagenCalzados
            // 
            this.pbxImagenCalzados.Location = new System.Drawing.Point(559, 68);
            this.pbxImagenCalzados.Name = "pbxImagenCalzados";
            this.pbxImagenCalzados.Size = new System.Drawing.Size(185, 150);
            this.pbxImagenCalzados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCalzados.TabIndex = 1;
            this.pbxImagenCalzados.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxImagenCalzados);
            this.Controls.Add(this.dgvListaPedidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCalzados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.PictureBox pbxImagenCalzados;
    }
}

