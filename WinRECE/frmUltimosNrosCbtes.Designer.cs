namespace OpenRECE
{
    partial class frmUltimosNrosCbtes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUltimosNrosCbtes));
            this.lblPtoVenta = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cboPtosVenta = new System.Windows.Forms.ComboBox();
            this.btnActualizarUltimosNros = new System.Windows.Forms.Button();
            this.dgvUltNrosCbtes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltNrosCbtes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPtoVenta
            // 
            this.lblPtoVenta.AutoSize = true;
            this.lblPtoVenta.Location = new System.Drawing.Point(25, 34);
            this.lblPtoVenta.Name = "lblPtoVenta";
            this.lblPtoVenta.Size = new System.Drawing.Size(84, 13);
            this.lblPtoVenta.TabIndex = 0;
            this.lblPtoVenta.Text = "Punto de Venta:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(442, 309);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cboPtosVenta
            // 
            this.cboPtosVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPtosVenta.FormattingEnabled = true;
            this.cboPtosVenta.Location = new System.Drawing.Point(115, 31);
            this.cboPtosVenta.Name = "cboPtosVenta";
            this.cboPtosVenta.Size = new System.Drawing.Size(321, 21);
            this.cboPtosVenta.TabIndex = 16;
            // 
            // btnActualizarUltimosNros
            // 
            this.btnActualizarUltimosNros.Location = new System.Drawing.Point(442, 29);
            this.btnActualizarUltimosNros.Name = "btnActualizarUltimosNros";
            this.btnActualizarUltimosNros.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUltimosNros.TabIndex = 17;
            this.btnActualizarUltimosNros.Text = "Procesar";
            this.btnActualizarUltimosNros.UseVisualStyleBackColor = true;
            this.btnActualizarUltimosNros.Click += new System.EventHandler(this.btnActualizarUltimosNros_Click);
            // 
            // dgvUltNrosCbtes
            // 
            this.dgvUltNrosCbtes.AllowUserToAddRows = false;
            this.dgvUltNrosCbtes.AllowUserToDeleteRows = false;
            this.dgvUltNrosCbtes.AllowUserToOrderColumns = true;
            this.dgvUltNrosCbtes.AllowUserToResizeRows = false;
            this.dgvUltNrosCbtes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUltNrosCbtes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltNrosCbtes.Location = new System.Drawing.Point(28, 58);
            this.dgvUltNrosCbtes.Name = "dgvUltNrosCbtes";
            this.dgvUltNrosCbtes.ReadOnly = true;
            this.dgvUltNrosCbtes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltNrosCbtes.Size = new System.Drawing.Size(489, 245);
            this.dgvUltNrosCbtes.TabIndex = 18;
            // 
            // frmUltimosNrosCbtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 355);
            this.ControlBox = false;
            this.Controls.Add(this.dgvUltNrosCbtes);
            this.Controls.Add(this.btnActualizarUltimosNros);
            this.Controls.Add(this.cboPtosVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblPtoVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUltimosNrosCbtes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimos Nros. Cbtes Autorizados";
            this.Load += new System.EventHandler(this.frmUltimosNrosCbtes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltNrosCbtes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPtoVenta;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboPtosVenta;
        private System.Windows.Forms.Button btnActualizarUltimosNros;
        private System.Windows.Forms.DataGridView dgvUltNrosCbtes;
    }
}