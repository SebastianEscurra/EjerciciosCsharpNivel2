namespace AppFabricaDeCalzadoFemenino
{
    partial class frmAgregarPedido
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTIpoDeCalzado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPresupuestoFinal = new System.Windows.Forms.Label();
            this.lblFechaDePedido = new System.Windows.Forms.Label();
            this.lblFechaDeEntrega = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxTipoDeCalzado = new System.Windows.Forms.ComboBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.dtpFechaDePedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDeEntrega = new System.Windows.Forms.DateTimePicker();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPresupuestoFinalDato = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(64, 26);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTIpoDeCalzado
            // 
            this.lblTIpoDeCalzado.AutoSize = true;
            this.lblTIpoDeCalzado.Location = new System.Drawing.Point(20, 54);
            this.lblTIpoDeCalzado.Name = "lblTIpoDeCalzado";
            this.lblTIpoDeCalzado.Size = new System.Drawing.Size(86, 13);
            this.lblTIpoDeCalzado.TabIndex = 1;
            this.lblTIpoDeCalzado.Text = "Tipo de calzado:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(54, 82);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPresupuestoFinal
            // 
            this.lblPresupuestoFinal.AutoSize = true;
            this.lblPresupuestoFinal.Location = new System.Drawing.Point(154, 109);
            this.lblPresupuestoFinal.Name = "lblPresupuestoFinal";
            this.lblPresupuestoFinal.Size = new System.Drawing.Size(91, 13);
            this.lblPresupuestoFinal.TabIndex = 3;
            this.lblPresupuestoFinal.Text = "Presupuesto final:";
            // 
            // lblFechaDePedido
            // 
            this.lblFechaDePedido.AutoSize = true;
            this.lblFechaDePedido.Location = new System.Drawing.Point(15, 143);
            this.lblFechaDePedido.Name = "lblFechaDePedido";
            this.lblFechaDePedido.Size = new System.Drawing.Size(90, 13);
            this.lblFechaDePedido.TabIndex = 4;
            this.lblFechaDePedido.Text = "Fecha de pedido:";
            // 
            // lblFechaDeEntrega
            // 
            this.lblFechaDeEntrega.AutoSize = true;
            this.lblFechaDeEntrega.Location = new System.Drawing.Point(15, 171);
            this.lblFechaDeEntrega.Name = "lblFechaDeEntrega";
            this.lblFechaDeEntrega.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDeEntrega.TabIndex = 5;
            this.lblFechaDeEntrega.Text = "Fecha de entrega:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 207);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxTipoDeCalzado
            // 
            this.cbxTipoDeCalzado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoDeCalzado.FormattingEnabled = true;
            this.cbxTipoDeCalzado.Location = new System.Drawing.Point(112, 46);
            this.cbxTipoDeCalzado.Name = "cbxTipoDeCalzado";
            this.cbxTipoDeCalzado.Size = new System.Drawing.Size(197, 21);
            this.cbxTipoDeCalzado.TabIndex = 8;
            this.cbxTipoDeCalzado.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDeCalzado_SelectedIndexChanged);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(112, 75);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(197, 20);
            this.tbxCantidad.TabIndex = 9;
            this.tbxCantidad.TextChanged += new System.EventHandler(this.tbxCantidad_TextChanged);
            // 
            // dtpFechaDePedido
            // 
            this.dtpFechaDePedido.Location = new System.Drawing.Point(109, 136);
            this.dtpFechaDePedido.Name = "dtpFechaDePedido";
            this.dtpFechaDePedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDePedido.TabIndex = 11;
            // 
            // dtpFechaDeEntrega
            // 
            this.dtpFechaDeEntrega.Location = new System.Drawing.Point(109, 166);
            this.dtpFechaDeEntrega.Name = "dtpFechaDeEntrega";
            this.dtpFechaDeEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDeEntrega.TabIndex = 12;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(112, 199);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(197, 21);
            this.cbxEstado.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(67, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPresupuestoFinalDato
            // 
            this.lblPresupuestoFinalDato.AutoSize = true;
            this.lblPresupuestoFinalDato.Location = new System.Drawing.Point(242, 109);
            this.lblPresupuestoFinalDato.Name = "lblPresupuestoFinalDato";
            this.lblPresupuestoFinalDato.Size = new System.Drawing.Size(0, 13);
            this.lblPresupuestoFinalDato.TabIndex = 16;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(112, 18);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(197, 21);
            this.cbxCliente.TabIndex = 17;
            // 
            // frmAgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 304);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblPresupuestoFinalDato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.dtpFechaDeEntrega);
            this.Controls.Add(this.dtpFechaDePedido);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.cbxTipoDeCalzado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaDeEntrega);
            this.Controls.Add(this.lblFechaDePedido);
            this.Controls.Add(this.lblPresupuestoFinal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTIpoDeCalzado);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 343);
            this.Name = "frmAgregarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPedido";
            this.Load += new System.EventHandler(this.frmAgregarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTIpoDeCalzado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPresupuestoFinal;
        private System.Windows.Forms.Label lblFechaDePedido;
        private System.Windows.Forms.Label lblFechaDeEntrega;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxTipoDeCalzado;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaDePedido;
        private System.Windows.Forms.DateTimePicker dtpFechaDeEntrega;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPresupuestoFinalDato;
        private System.Windows.Forms.ComboBox cbxCliente;
    }
}