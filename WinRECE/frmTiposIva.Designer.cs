namespace OpenRECE
{
    partial class frmTiposIva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposIva));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposIva = new System.Windows.Forms.Button();
            this.dgvTiposIva = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposIva)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(416, 215);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarTiposIva
            // 
            this.btnActualizarTiposIva.Location = new System.Drawing.Point(215, 214);
            this.btnActualizarTiposIva.Name = "btnActualizarTiposIva";
            this.btnActualizarTiposIva.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposIva.TabIndex = 13;
            this.btnActualizarTiposIva.Text = "Actualizar Listado";
            this.btnActualizarTiposIva.UseVisualStyleBackColor = true;
            this.btnActualizarTiposIva.Click += new System.EventHandler(this.btnActualizarTiposIva_Click);
            // 
            // dgvTiposIva
            // 
            this.dgvTiposIva.AllowUserToAddRows = false;
            this.dgvTiposIva.AllowUserToDeleteRows = false;
            this.dgvTiposIva.AllowUserToOrderColumns = true;
            this.dgvTiposIva.AllowUserToResizeRows = false;
            this.dgvTiposIva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposIva.Location = new System.Drawing.Point(18, 9);
            this.dgvTiposIva.Name = "dgvTiposIva";
            this.dgvTiposIva.ReadOnly = true;
            this.dgvTiposIva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposIva.Size = new System.Drawing.Size(473, 199);
            this.dgvTiposIva.TabIndex = 12;
            // 
            // frmTiposIva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposIva);
            this.Controls.Add(this.dgvTiposIva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposIva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Iva";
            this.Load += new System.EventHandler(this.frmTiposIva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposIva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposIva;
        private System.Windows.Forms.DataGridView dgvTiposIva;
    }
}