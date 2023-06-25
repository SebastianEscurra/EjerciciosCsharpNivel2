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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokedex
            // 
            this.dgvPokedex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokedex.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokedex.Location = new System.Drawing.Point(29, 62);
            this.dgvPokedex.MultiSelect = false;
            this.dgvPokedex.Name = "dgvPokedex";
            this.dgvPokedex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokedex.Size = new System.Drawing.Size(546, 184);
            this.dgvPokedex.TabIndex = 0;
            this.dgvPokedex.SelectionChanged += new System.EventHandler(this.dgvPokedex_SelectionChanged);
            // 
            // pbxPokemon
            // 
            this.pbxPokemon.Location = new System.Drawing.Point(581, 62);
            this.pbxPokemon.Name = "pbxPokemon";
            this.pbxPokemon.Size = new System.Drawing.Size(190, 184);
            this.pbxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPokemon.TabIndex = 1;
            this.pbxPokemon.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 255);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarPokemon_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(122, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(71, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(215, 255);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(92, 23);
            this.btnEliminarFisico.TabIndex = 5;
            this.btnEliminarFisico.Text = "Eliminar fisico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(329, 255);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(92, 23);
            this.btnEliminarLogico.TabIndex = 6;
            this.btnEliminarLogico.Text = "Eliminar logico";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(13, 39);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(64, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro rapido:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(78, 36);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(126, 20);
            this.tbxFiltro.TabIndex = 8;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(535, 267);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 302);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxPokemon);
            this.Controls.Add(this.dgvPokedex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pokedex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokedex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokedex;
        private System.Windows.Forms.PictureBox pbxPokemon;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnFiltro;
    }
}

