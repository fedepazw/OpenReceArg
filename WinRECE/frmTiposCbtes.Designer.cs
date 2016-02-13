namespace OpenRECE
{
    partial class frmTiposCbtes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposCbtes));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposCbtes = new System.Windows.Forms.Button();
            this.dgvTiposCbtes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposCbtes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(418, 478);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarTiposCbtes
            // 
            this.btnActualizarTiposCbtes.Location = new System.Drawing.Point(217, 477);
            this.btnActualizarTiposCbtes.Name = "btnActualizarTiposCbtes";
            this.btnActualizarTiposCbtes.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposCbtes.TabIndex = 4;
            this.btnActualizarTiposCbtes.Text = "Actualizar Listado";
            this.btnActualizarTiposCbtes.UseVisualStyleBackColor = true;
            this.btnActualizarTiposCbtes.Click += new System.EventHandler(this.btnActualizarTiposCbtes_Click);
            // 
            // dgvTiposCbtes
            // 
            this.dgvTiposCbtes.AllowUserToAddRows = false;
            this.dgvTiposCbtes.AllowUserToDeleteRows = false;
            this.dgvTiposCbtes.AllowUserToOrderColumns = true;
            this.dgvTiposCbtes.AllowUserToResizeRows = false;
            this.dgvTiposCbtes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposCbtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposCbtes.Location = new System.Drawing.Point(20, 13);
            this.dgvTiposCbtes.Name = "dgvTiposCbtes";
            this.dgvTiposCbtes.ReadOnly = true;
            this.dgvTiposCbtes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposCbtes.Size = new System.Drawing.Size(473, 458);
            this.dgvTiposCbtes.TabIndex = 3;
            // 
            // frmTiposCbtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposCbtes);
            this.Controls.Add(this.dgvTiposCbtes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposCbtes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Comprobantes";
            this.Load += new System.EventHandler(this.frmTiposCbtes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposCbtes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposCbtes;
        private System.Windows.Forms.DataGridView dgvTiposCbtes;
    }
}