namespace conexionDB
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
            this.dgvPokedex = new System.Windows.Forms.DataGridView();
            this.pbxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregarPokemon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokedex
            // 
            this.dgvPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokedex.Location = new System.Drawing.Point(29, 62);
            this.dgvPokedex.Name = "dgvPokedex";
            this.dgvPokedex.Size = new System.Drawing.Size(500, 150);
            this.dgvPokedex.TabIndex = 0;
            this.dgvPokedex.SelectionChanged += new System.EventHandler(this.dgvPokedex_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(589, 62);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(170, 150);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 1;
            this.pbxPokemon.TabStop = false;
            // 
            // btnAgregarPokemon
            // 
            this.btnAgregarPokemon.Location = new System.Drawing.Point(29, 239);
            this.btnAgregarPokemon.Name = "btnAgregarPokemon";
            this.btnAgregarPokemon.Size = new System.Drawing.Size(104, 23);
            this.btnAgregarPokemon.TabIndex = 3;
            this.btnAgregarPokemon.Text = "Agregar Pokemon";
            this.btnAgregarPokemon.UseVisualStyleBackColor = true;
            this.btnAgregarPokemon.Click += new System.EventHandler(this.btnAgregarPokemon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarPokemon);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokedex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokedex;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnAgregarPokemon;
    }
}

