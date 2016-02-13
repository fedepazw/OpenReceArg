namespace OpenRECE
{
    partial class frmTiposOpcionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposOpcionales));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposOpcionales = new System.Windows.Forms.Button();
            this.dgvTiposOpcionales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposOpcionales)).BeginInit();
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
            // btnActualizarTiposOpcionales
            // 
            this.btnActualizarTiposOpcionales.Location = new System.Drawing.Point(209, 473);
            this.btnActualizarTiposOpcionales.Name = "btnActualizarTiposOpcionales";
            this.btnActualizarTiposOpcionales.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposOpcionales.TabIndex = 4;
            this.btnActualizarTiposOpcionales.Text = "Actualizar Listado";
            this.btnActualizarTiposOpcionales.UseVisualStyleBackColor = true;
            this.btnActualizarTiposOpcionales.Click += new System.EventHandler(this.btnActualizarTiposOpcionales_Click);
            // 
            // dgvTiposOpcionales
            // 
            this.dgvTiposOpcionales.AllowUserToAddRows = false;
            this.dgvTiposOpcionales.AllowUserToDeleteRows = false;
            this.dgvTiposOpcionales.AllowUserToOrderColumns = true;
            this.dgvTiposOpcionales.AllowUserToResizeRows = false;
            this.dgvTiposOpcionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposOpcionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposOpcionales.Location = new System.Drawing.Point(12, 9);
            this.dgvTiposOpcionales.Name = "dgvTiposOpcionales";
            this.dgvTiposOpcionales.ReadOnly = true;
            this.dgvTiposOpcionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposOpcionales.Size = new System.Drawing.Size(473, 458);
            this.dgvTiposOpcionales.TabIndex = 3;
            // 
            // frmTiposOpcionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposOpcionales);
            this.Controls.Add(this.dgvTiposOpcionales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposOpcionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Datos Opcionales";
            this.Load += new System.EventHandler(this.frmTiposOpcionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposOpcionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposOpcionales;
        private System.Windows.Forms.DataGridView dgvTiposOpcionales;
    }
}