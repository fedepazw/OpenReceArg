namespace OpenRECE
{
    partial class frmTiposMonedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposMonedas));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposMonedas = new System.Windows.Forms.Button();
            this.dgvTiposMonedas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(410, 125);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarTiposMonedas
            // 
            this.btnActualizarTiposMonedas.Location = new System.Drawing.Point(209, 124);
            this.btnActualizarTiposMonedas.Name = "btnActualizarTiposMonedas";
            this.btnActualizarTiposMonedas.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposMonedas.TabIndex = 4;
            this.btnActualizarTiposMonedas.Text = "Actualizar Listado";
            this.btnActualizarTiposMonedas.UseVisualStyleBackColor = true;
            this.btnActualizarTiposMonedas.Click += new System.EventHandler(this.btnActualizarTiposMonedas_Click);
            // 
            // dgvTiposMonedas
            // 
            this.dgvTiposMonedas.AllowUserToAddRows = false;
            this.dgvTiposMonedas.AllowUserToDeleteRows = false;
            this.dgvTiposMonedas.AllowUserToOrderColumns = true;
            this.dgvTiposMonedas.AllowUserToResizeRows = false;
            this.dgvTiposMonedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposMonedas.Location = new System.Drawing.Point(12, 9);
            this.dgvTiposMonedas.Name = "dgvTiposMonedas";
            this.dgvTiposMonedas.ReadOnly = true;
            this.dgvTiposMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposMonedas.Size = new System.Drawing.Size(473, 109);
            this.dgvTiposMonedas.TabIndex = 3;
            // 
            // frmTiposMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 173);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposMonedas);
            this.Controls.Add(this.dgvTiposMonedas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Monedas";
            this.Load += new System.EventHandler(this.frmTiposMonedas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposMonedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposMonedas;
        private System.Windows.Forms.DataGridView dgvTiposMonedas;
    }
}