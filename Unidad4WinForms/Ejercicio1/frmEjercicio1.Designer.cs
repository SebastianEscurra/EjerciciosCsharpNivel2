namespace Ejercicio1
{
    partial class frmFormulario1
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
            this.btnApretar = new System.Windows.Forms.Button();
            this.lblFormularioCambiate = new System.Windows.Forms.Label();
            this.txbCambiante = new System.Windows.Forms.TextBox();
            this.txbPrueba = new System.Windows.Forms.TextBox();
            this.txbContarCaracteres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApretar
            // 
            this.btnApretar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.btnApretar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(100)))), ((int)(((byte)(193)))));
            this.btnApretar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(128)))));
            this.btnApretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApretar.Location = new System.Drawing.Point(485, 181);
            this.btnApretar.Name = "btnApretar";
            this.btnApretar.Size = new System.Drawing.Size(78, 24);
            this.btnApretar.TabIndex = 0;
            this.btnApretar.Text = "Apretar";
            this.btnApretar.UseVisualStyleBackColor = true;
            this.btnApretar.Click += new System.EventHandler(this.btnApretar_Click);
            // 
            // lblFormularioCambiate
            // 
            this.lblFormularioCambiate.AutoSize = true;
            this.lblFormularioCambiate.BackColor = System.Drawing.Color.Transparent;
            this.lblFormularioCambiate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormularioCambiate.Font = new System.Drawing.Font("Stencil Std", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioCambiate.ForeColor = System.Drawing.Color.Maroon;
            this.lblFormularioCambiate.Location = new System.Drawing.Point(245, 105);
            this.lblFormularioCambiate.Name = "lblFormularioCambiate";
            this.lblFormularioCambiate.Size = new System.Drawing.Size(391, 26);
            this.lblFormularioCambiate.TabIndex = 1;
            this.lblFormularioCambiate.Text = "Cuando pases por encima cambiare";
            this.lblFormularioCambiate.MouseLeave += new System.EventHandler(this.lblFormularioCambiate_MouseLeave);
            this.lblFormularioCambiate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFormularioCambiate_MouseMove);
            // 
            // txbCambiante
            // 
            this.txbCambiante.Location = new System.Drawing.Point(261, 251);
            this.txbCambiante.Name = "txbCambiante";
            this.txbCambiante.Size = new System.Drawing.Size(261, 20);
            this.txbCambiante.TabIndex = 2;
            this.txbCambiante.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            this.txbCambiante.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // txbPrueba
            // 
            this.txbPrueba.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txbPrueba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbPrueba.Location = new System.Drawing.Point(261, 325);
            this.txbPrueba.Margin = new System.Windows.Forms.Padding(5);
            this.txbPrueba.MaxLength = 5;
            this.txbPrueba.Name = "txbPrueba";
            this.txbPrueba.Size = new System.Drawing.Size(100, 20);
            this.txbPrueba.TabIndex = 3;
            this.txbPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrueba_KeyPress);
            // 
            // txbContarCaracteres
            // 
            this.txbContarCaracteres.Location = new System.Drawing.Point(421, 324);
            this.txbContarCaracteres.Multiline = true;
            this.txbContarCaracteres.Name = "txbContarCaracteres";
            this.txbContarCaracteres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbContarCaracteres.Size = new System.Drawing.Size(199, 89);
            this.txbContarCaracteres.TabIndex = 4;
            this.txbContarCaracteres.Leave += new System.EventHandler(this.txbContarCaracteres_Leave);
            // 
            // frmFormulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(98)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbContarCaracteres);
            this.Controls.Add(this.txbPrueba);
            this.Controls.Add(this.txbCambiante);
            this.Controls.Add(this.lblFormularioCambiate);
            this.Controls.Add(this.btnApretar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormulario1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario vacio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincioal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApretar;
        private System.Windows.Forms.Label lblFormularioCambiate;
        private System.Windows.Forms.TextBox txbCambiante;
        private System.Windows.Forms.TextBox txbPrueba;
        private System.Windows.Forms.TextBox txbContarCaracteres;
    }
}

