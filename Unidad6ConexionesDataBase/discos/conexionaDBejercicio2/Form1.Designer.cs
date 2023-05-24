namespace conexionaDBejercicio2
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
            this.dgvListaDiscos = new System.Windows.Forms.DataGridView();
            this.pbxpokemons = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDiscos
            // 
            this.dgvListaDiscos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListaDiscos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaDiscos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvListaDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDiscos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvListaDiscos.Location = new System.Drawing.Point(12, 100);
            this.dgvListaDiscos.Name = "dgvListaDiscos";
            this.dgvListaDiscos.Size = new System.Drawing.Size(487, 172);
            this.dgvListaDiscos.TabIndex = 0;
            this.dgvListaDiscos.SelectionChanged += new System.EventHandler(this.dgvListaDiscos_SelectionChanged);
            // 
            // pbxpokemons
            // 
            this.pbxpokemons.Location = new System.Drawing.Point(518, 100);
            this.pbxpokemons.Name = "pbxpokemons";
            this.pbxpokemons.Size = new System.Drawing.Size(219, 172);
            this.pbxpokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemons.TabIndex = 1;
            this.pbxpokemons.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxpokemons);
            this.Controls.Add(this.dgvListaDiscos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDiscos;
        private System.Windows.Forms.PictureBox pbxpokemons;
    }
}

