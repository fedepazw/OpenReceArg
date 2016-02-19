namespace OpenRECE
{
    partial class frmPtoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPtoVenta));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarPtoVenta = new System.Windows.Forms.Button();
            this.dgvPtoVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPtoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(410, 474);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarPtoVenta
            // 
            this.btnActualizarPtoVenta.Location = new System.Drawing.Point(209, 473);
            this.btnActualizarPtoVenta.Name = "btnActualizarPtoVenta";
            this.btnActualizarPtoVenta.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarPtoVenta.TabIndex = 4;
            this.btnActualizarPtoVenta.Text = "Actualizar Listado";
            this.btnActualizarPtoVenta.UseVisualStyleBackColor = true;
            this.btnActualizarPtoVenta.Click += new System.EventHandler(this.btnActualizarPtoVenta_Click);
            // 
            // dgvPtoVenta
            // 
            this.dgvPtoVenta.AllowUserToAddRows = false;
            this.dgvPtoVenta.AllowUserToDeleteRows = false;
            this.dgvPtoVenta.AllowUserToOrderColumns = true;
            this.dgvPtoVenta.AllowUserToResizeRows = false;
            this.dgvPtoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPtoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPtoVenta.Location = new System.Drawing.Point(12, 9);
            this.dgvPtoVenta.Name = "dgvPtoVenta";
            this.dgvPtoVenta.ReadOnly = true;
            this.dgvPtoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPtoVenta.Size = new System.Drawing.Size(473, 458);
            this.dgvPtoVenta.TabIndex = 3;
            // 
            // frmPtoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarPtoVenta);
            this.Controls.Add(this.dgvPtoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPtoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntos de Venta";
            this.Load += new System.EventHandler(this.frmPtoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPtoVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarPtoVenta;
        private System.Windows.Forms.DataGridView dgvPtoVenta;
    }
}