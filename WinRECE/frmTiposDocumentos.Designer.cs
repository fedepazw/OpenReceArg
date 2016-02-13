namespace OpenRECE
{
    partial class frmTiposDocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposDocumentos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposDocumentos = new System.Windows.Forms.Button();
            this.dgvTiposDocumentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(416, 474);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnActualizarTiposDocumentos
            // 
            this.btnActualizarTiposDocumentos.Location = new System.Drawing.Point(215, 473);
            this.btnActualizarTiposDocumentos.Name = "btnActualizarTiposDocumentos";
            this.btnActualizarTiposDocumentos.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposDocumentos.TabIndex = 10;
            this.btnActualizarTiposDocumentos.Text = "Actualizar Listado";
            this.btnActualizarTiposDocumentos.UseVisualStyleBackColor = true;
            this.btnActualizarTiposDocumentos.Click += new System.EventHandler(this.btnActualizarTiposDocumentos_Click);
            // 
            // dgvTiposDocumentos
            // 
            this.dgvTiposDocumentos.AllowUserToAddRows = false;
            this.dgvTiposDocumentos.AllowUserToDeleteRows = false;
            this.dgvTiposDocumentos.AllowUserToOrderColumns = true;
            this.dgvTiposDocumentos.AllowUserToResizeRows = false;
            this.dgvTiposDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDocumentos.Location = new System.Drawing.Point(18, 9);
            this.dgvTiposDocumentos.Name = "dgvTiposDocumentos";
            this.dgvTiposDocumentos.ReadOnly = true;
            this.dgvTiposDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposDocumentos.Size = new System.Drawing.Size(473, 458);
            this.dgvTiposDocumentos.TabIndex = 9;
            // 
            // frmTiposDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposDocumentos);
            this.Controls.Add(this.dgvTiposDocumentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Documentos";
            this.Load += new System.EventHandler(this.frmTiposDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposDocumentos;
        private System.Windows.Forms.DataGridView dgvTiposDocumentos;
    }
}