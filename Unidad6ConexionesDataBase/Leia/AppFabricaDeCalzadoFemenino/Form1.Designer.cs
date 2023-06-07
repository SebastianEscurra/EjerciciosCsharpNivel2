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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.pbxImagenCalzados = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCalzados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(128)))));
            this.dgvListaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(99)))));
            this.dgvListaPedidos.Location = new System.Drawing.Point(37, 78);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.Size = new System.Drawing.Size(761, 150);
            this.dgvListaPedidos.TabIndex = 0;
            this.dgvListaPedidos.SelectionChanged += new System.EventHandler(this.dgvListaPedidos_SelectionChanged);
            // 
            // pbxImagenCalzados
            // 
            this.pbxImagenCalzados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxImagenCalzados.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagenCalzados.Location = new System.Drawing.Point(297, 234);
            this.pbxImagenCalzados.Name = "pbxImagenCalzados";
            this.pbxImagenCalzados.Size = new System.Drawing.Size(231, 191);
            this.pbxImagenCalzados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenCalzados.TabIndex = 1;
            this.pbxImagenCalzados.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTitulo.Font = new System.Drawing.Font("Humanst521 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.lblTitulo.Location = new System.Drawing.Point(315, 29);
            this.lblTitulo.MinimumSize = new System.Drawing.Size(227, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 35);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Lista de Pedidos";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarPedido.Location = new System.Drawing.Point(37, 262);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarPedido.TabIndex = 3;
            this.btnAgregarPedido.Text = "Agregar pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbxImagenCalzados);
            this.Controls.Add(this.dgvListaPedidos);
            this.MinimumSize = new System.Drawing.Size(840, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenCalzados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.PictureBox pbxImagenCalzados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarPedido;
    }
}

