namespace PracticaIntegradora
{
    partial class frmNuevo
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
            this.txbCantidadVendida = new System.Windows.Forms.TextBox();
            this.txbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.btnCarga = new System.Windows.Forms.Button();
            this.txbCodigoDeArticuloArticulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargarArticulo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDia = new System.Windows.Forms.TextBox();
            this.txbNumeroDeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCodigoDeArticulo = new System.Windows.Forms.ComboBox();
            this.lblDatosCargados = new System.Windows.Forms.Label();
            this.lblVentasCargadas = new System.Windows.Forms.Label();
            this.lbxNumeroDeArticulo = new System.Windows.Forms.ListBox();
            this.btnMostrarCantidadVendida = new System.Windows.Forms.Button();
            this.lbxCantidadTotal = new System.Windows.Forms.ListBox();
            this.lbxMeseSinVenta = new System.Windows.Forms.ListBox();
            this.btnMesSinVenta = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lbxPromedio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbCantidadVendida
            // 
            this.txbCantidadVendida.Location = new System.Drawing.Point(262, 291);
            this.txbCantidadVendida.Name = "txbCantidadVendida";
            this.txbCantidadVendida.Size = new System.Drawing.Size(100, 20);
            this.txbCantidadVendida.TabIndex = 25;
            // 
            // txbPrecioUnitario
            // 
            this.txbPrecioUnitario.Location = new System.Drawing.Point(52, 181);
            this.txbPrecioUnitario.Name = "txbPrecioUnitario";
            this.txbPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txbPrecioUnitario.TabIndex = 18;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(232, 326);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(163, 23);
            this.btnCarga.TabIndex = 13;
            this.btnCarga.Text = "Cargar datos de  ventas";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // txbCodigoDeArticuloArticulo
            // 
            this.txbCodigoDeArticuloArticulo.Location = new System.Drawing.Point(52, 126);
            this.txbCodigoDeArticuloArticulo.Name = "txbCodigoDeArticuloArticulo";
            this.txbCodigoDeArticuloArticulo.Size = new System.Drawing.Size(100, 20);
            this.txbCodigoDeArticuloArticulo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cantidad vendida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio unitario: ";
            // 
            // btnCargarArticulo
            // 
            this.btnCargarArticulo.Location = new System.Drawing.Point(17, 228);
            this.btnCargarArticulo.Name = "btnCargarArticulo";
            this.btnCargarArticulo.Size = new System.Drawing.Size(163, 23);
            this.btnCargarArticulo.TabIndex = 10;
            this.btnCargarArticulo.Text = "Cargar datos del articulo";
            this.btnCargarArticulo.UseVisualStyleBackColor = true;
            this.btnCargarArticulo.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo de articulo: ";
            // 
            // txbDia
            // 
            this.txbDia.Location = new System.Drawing.Point(262, 227);
            this.txbDia.Name = "txbDia";
            this.txbDia.Size = new System.Drawing.Size(100, 20);
            this.txbDia.TabIndex = 23;
            this.txbDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDia_KeyPress);
            // 
            // txbNumeroDeCliente
            // 
            this.txbNumeroDeCliente.Location = new System.Drawing.Point(262, 41);
            this.txbNumeroDeCliente.Name = "txbNumeroDeCliente";
            this.txbNumeroDeCliente.Size = new System.Drawing.Size(100, 20);
            this.txbNumeroDeCliente.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Dia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero de cliente:";
            // 
            // txbMes
            // 
            this.txbMes.Location = new System.Drawing.Point(262, 160);
            this.txbMes.Name = "txbMes";
            this.txbMes.Size = new System.Drawing.Size(100, 20);
            this.txbMes.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo de articulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mes:";
            // 
            // cbCodigoDeArticulo
            // 
            this.cbCodigoDeArticulo.FormattingEnabled = true;
            this.cbCodigoDeArticulo.Location = new System.Drawing.Point(252, 111);
            this.cbCodigoDeArticulo.Name = "cbCodigoDeArticulo";
            this.cbCodigoDeArticulo.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoDeArticulo.TabIndex = 26;
            // 
            // lblDatosCargados
            // 
            this.lblDatosCargados.AutoSize = true;
            this.lblDatosCargados.Location = new System.Drawing.Point(52, 275);
            this.lblDatosCargados.Name = "lblDatosCargados";
            this.lblDatosCargados.Size = new System.Drawing.Size(0, 13);
            this.lblDatosCargados.TabIndex = 27;
            // 
            // lblVentasCargadas
            // 
            this.lblVentasCargadas.AutoSize = true;
            this.lblVentasCargadas.Location = new System.Drawing.Point(235, 362);
            this.lblVentasCargadas.Name = "lblVentasCargadas";
            this.lblVentasCargadas.Size = new System.Drawing.Size(0, 13);
            this.lblVentasCargadas.TabIndex = 28;
            // 
            // lbxNumeroDeArticulo
            // 
            this.lbxNumeroDeArticulo.FormattingEnabled = true;
            this.lbxNumeroDeArticulo.Location = new System.Drawing.Point(510, 54);
            this.lbxNumeroDeArticulo.Name = "lbxNumeroDeArticulo";
            this.lbxNumeroDeArticulo.Size = new System.Drawing.Size(102, 147);
            this.lbxNumeroDeArticulo.TabIndex = 29;
            // 
            // btnMostrarCantidadVendida
            // 
            this.btnMostrarCantidadVendida.Location = new System.Drawing.Point(510, 25);
            this.btnMostrarCantidadVendida.Name = "btnMostrarCantidadVendida";
            this.btnMostrarCantidadVendida.Size = new System.Drawing.Size(173, 23);
            this.btnMostrarCantidadVendida.TabIndex = 30;
            this.btnMostrarCantidadVendida.Text = "Mostrar cantidad vendida";
            this.btnMostrarCantidadVendida.UseVisualStyleBackColor = true;
            this.btnMostrarCantidadVendida.Click += new System.EventHandler(this.btnMostrarCantidadVendida_Click);
            // 
            // lbxCantidadTotal
            // 
            this.lbxCantidadTotal.FormattingEnabled = true;
            this.lbxCantidadTotal.Location = new System.Drawing.Point(618, 54);
            this.lbxCantidadTotal.Name = "lbxCantidadTotal";
            this.lbxCantidadTotal.Size = new System.Drawing.Size(102, 147);
            this.lbxCantidadTotal.TabIndex = 31;
            // 
            // lbxMeseSinVenta
            // 
            this.lbxMeseSinVenta.FormattingEnabled = true;
            this.lbxMeseSinVenta.Location = new System.Drawing.Point(510, 265);
            this.lbxMeseSinVenta.Name = "lbxMeseSinVenta";
            this.lbxMeseSinVenta.Size = new System.Drawing.Size(230, 56);
            this.lbxMeseSinVenta.TabIndex = 32;
            // 
            // btnMesSinVenta
            // 
            this.btnMesSinVenta.Location = new System.Drawing.Point(510, 236);
            this.btnMesSinVenta.Name = "btnMesSinVenta";
            this.btnMesSinVenta.Size = new System.Drawing.Size(173, 23);
            this.btnMesSinVenta.TabIndex = 33;
            this.btnMesSinVenta.Text = "Meses sin venta";
            this.btnMesSinVenta.UseVisualStyleBackColor = true;
            this.btnMesSinVenta.Click += new System.EventHandler(this.btnMesSinVenta_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(510, 340);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(173, 36);
            this.btnPromedio.TabIndex = 35;
            this.btnPromedio.Text = "Mostrar articulos que sus ventas sean mayores al promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lbxPromedio
            // 
            this.lbxPromedio.FormattingEnabled = true;
            this.lbxPromedio.Location = new System.Drawing.Point(510, 382);
            this.lbxPromedio.Name = "lbxPromedio";
            this.lbxPromedio.Size = new System.Drawing.Size(230, 56);
            this.lbxPromedio.TabIndex = 34;
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.lbxPromedio);
            this.Controls.Add(this.btnMesSinVenta);
            this.Controls.Add(this.lbxMeseSinVenta);
            this.Controls.Add(this.lbxCantidadTotal);
            this.Controls.Add(this.btnMostrarCantidadVendida);
            this.Controls.Add(this.lbxNumeroDeArticulo);
            this.Controls.Add(this.lblVentasCargadas);
            this.Controls.Add(this.lblDatosCargados);
            this.Controls.Add(this.cbCodigoDeArticulo);
            this.Controls.Add(this.txbCantidadVendida);
            this.Controls.Add(this.txbPrecioUnitario);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.txbCodigoDeArticuloArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCargarArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbDia);
            this.Controls.Add(this.txbNumeroDeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "frmNuevo";
            this.Text = "frmNuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCantidadVendida;
        private System.Windows.Forms.TextBox txbPrecioUnitario;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.TextBox txbCodigoDeArticuloArticulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDia;
        private System.Windows.Forms.TextBox txbNumeroDeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCodigoDeArticulo;
        private System.Windows.Forms.Label lblDatosCargados;
        private System.Windows.Forms.Label lblVentasCargadas;
        private System.Windows.Forms.ListBox lbxNumeroDeArticulo;
        private System.Windows.Forms.Button btnMostrarCantidadVendida;
        private System.Windows.Forms.ListBox lbxCantidadTotal;
        private System.Windows.Forms.ListBox lbxMeseSinVenta;
        private System.Windows.Forms.Button btnMesSinVenta;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.ListBox lbxPromedio;
    }
}