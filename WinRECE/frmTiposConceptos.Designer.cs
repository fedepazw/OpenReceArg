namespace OpenRECE
{
    partial class frmTiposConceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposConceptos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposConceptos = new System.Windows.Forms.Button();
            this.dgvTiposConceptos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(416, 209);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarTiposConceptos
            // 
            this.btnActualizarTiposConceptos.Location = new System.Drawing.Point(215, 208);
            this.btnActualizarTiposConceptos.Name = "btnActualizarTiposConceptos";
            this.btnActualizarTiposConceptos.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposConceptos.TabIndex = 7;
            this.btnActualizarTiposConceptos.Text = "Actualizar Listado";
            this.btnActualizarTiposConceptos.UseVisualStyleBackColor = true;
            this.btnActualizarTiposConceptos.Click += new System.EventHandler(this.btnActualizarTiposConceptos_Click);
            // 
            // dgvTiposConceptos
            // 
            this.dgvTiposConceptos.AllowUserToAddRows = false;
            this.dgvTiposConceptos.AllowUserToDeleteRows = false;
            this.dgvTiposConceptos.AllowUserToOrderColumns = true;
            this.dgvTiposConceptos.AllowUserToResizeRows = false;
            this.dgvTiposConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposConceptos.Location = new System.Drawing.Point(18, 9);
            this.dgvTiposConceptos.Name = "dgvTiposConceptos";
            this.dgvTiposConceptos.ReadOnly = true;
            this.dgvTiposConceptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposConceptos.Size = new System.Drawing.Size(473, 192);
            this.dgvTiposConceptos.TabIndex = 6;
            // 
            // frmTiposConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposConceptos);
            this.Controls.Add(this.dgvTiposConceptos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposConceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Conceptos";
            this.Load += new System.EventHandler(this.frmTiposConceptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposConceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposConceptos;
        private System.Windows.Forms.DataGridView dgvTiposConceptos;
    }
}