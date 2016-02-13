namespace OpenRECE
{
    partial class frmTiposTributos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiposTributos));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnActualizarTiposTributos = new System.Windows.Forms.Button();
            this.dgvTiposTributos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTributos)).BeginInit();
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
            // btnActualizarTiposTributos
            // 
            this.btnActualizarTiposTributos.Location = new System.Drawing.Point(209, 473);
            this.btnActualizarTiposTributos.Name = "btnActualizarTiposTributos";
            this.btnActualizarTiposTributos.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarTiposTributos.TabIndex = 4;
            this.btnActualizarTiposTributos.Text = "Actualizar Listado";
            this.btnActualizarTiposTributos.UseVisualStyleBackColor = true;
            this.btnActualizarTiposTributos.Click += new System.EventHandler(this.btnActualizarTiposTributos_Click);
            // 
            // dgvTiposTributos
            // 
            this.dgvTiposTributos.AllowUserToAddRows = false;
            this.dgvTiposTributos.AllowUserToDeleteRows = false;
            this.dgvTiposTributos.AllowUserToOrderColumns = true;
            this.dgvTiposTributos.AllowUserToResizeRows = false;
            this.dgvTiposTributos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposTributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposTributos.Location = new System.Drawing.Point(12, 9);
            this.dgvTiposTributos.Name = "dgvTiposTributos";
            this.dgvTiposTributos.ReadOnly = true;
            this.dgvTiposTributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposTributos.Size = new System.Drawing.Size(473, 458);
            this.dgvTiposTributos.TabIndex = 3;
            // 
            // frmTiposTributos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarTiposTributos);
            this.Controls.Add(this.dgvTiposTributos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiposTributos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Tributos";
            this.Load += new System.EventHandler(this.frmTiposTributos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposTributos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnActualizarTiposTributos;
        private System.Windows.Forms.DataGridView dgvTiposTributos;
    }
}