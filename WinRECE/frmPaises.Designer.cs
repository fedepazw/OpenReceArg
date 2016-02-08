namespace OpenRECE
{
    partial class frmPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaises));
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.btnActualizarPaises = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaises
            // 
            this.dgvPaises.AllowUserToAddRows = false;
            this.dgvPaises.AllowUserToDeleteRows = false;
            this.dgvPaises.AllowUserToResizeColumns = false;
            this.dgvPaises.AllowUserToResizeRows = false;
            this.dgvPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Location = new System.Drawing.Point(12, 12);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaises.Size = new System.Drawing.Size(473, 458);
            this.dgvPaises.TabIndex = 0;
            // 
            // btnActualizarPaises
            // 
            this.btnActualizarPaises.Location = new System.Drawing.Point(209, 476);
            this.btnActualizarPaises.Name = "btnActualizarPaises";
            this.btnActualizarPaises.Size = new System.Drawing.Size(75, 40);
            this.btnActualizarPaises.TabIndex = 1;
            this.btnActualizarPaises.Text = "Actualizar Listado";
            this.btnActualizarPaises.UseVisualStyleBackColor = true;
            this.btnActualizarPaises.Click += new System.EventHandler(this.btnActualizarPaises_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(410, 477);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 523);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarPaises);
            this.Controls.Add(this.dgvPaises);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de Paises";
            this.Load += new System.EventHandler(this.frmPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.Button btnActualizarPaises;
        private System.Windows.Forms.Button btnCerrar;
    }
}