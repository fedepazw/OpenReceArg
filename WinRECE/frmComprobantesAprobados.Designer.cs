namespace OpenRECE
{
    partial class frmComprobantesAprobados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprobantesAprobados));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnTraerCbtes = new System.Windows.Forms.Button();
            this.dgvCbtesAutorizados = new System.Windows.Forms.DataGridView();
            this.cboPtosVenta = new System.Windows.Forms.ComboBox();
            this.lblPtoVenta = new System.Windows.Forms.Label();
            this.cboTipoCbte = new System.Windows.Forms.ComboBox();
            this.lblTipoCbte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCbtesAutorizados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(796, 514);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnTraerCbtes
            // 
            this.btnTraerCbtes.Location = new System.Drawing.Point(599, 21);
            this.btnTraerCbtes.Name = "btnTraerCbtes";
            this.btnTraerCbtes.Size = new System.Drawing.Size(99, 48);
            this.btnTraerCbtes.TabIndex = 6;
            this.btnTraerCbtes.Text = "Procesar";
            this.btnTraerCbtes.UseVisualStyleBackColor = true;
            this.btnTraerCbtes.Click += new System.EventHandler(this.btnTraerCbtes_Click);
            // 
            // dgvCbtesAutorizados
            // 
            this.dgvCbtesAutorizados.AllowUserToAddRows = false;
            this.dgvCbtesAutorizados.AllowUserToDeleteRows = false;
            this.dgvCbtesAutorizados.AllowUserToOrderColumns = true;
            this.dgvCbtesAutorizados.AllowUserToResizeRows = false;
            this.dgvCbtesAutorizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCbtesAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCbtesAutorizados.Location = new System.Drawing.Point(12, 75);
            this.dgvCbtesAutorizados.Name = "dgvCbtesAutorizados";
            this.dgvCbtesAutorizados.ReadOnly = true;
            this.dgvCbtesAutorizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCbtesAutorizados.Size = new System.Drawing.Size(860, 433);
            this.dgvCbtesAutorizados.TabIndex = 26;
            // 
            // cboPtosVenta
            // 
            this.cboPtosVenta.FormattingEnabled = true;
            this.cboPtosVenta.Location = new System.Drawing.Point(272, 21);
            this.cboPtosVenta.Name = "cboPtosVenta";
            this.cboPtosVenta.Size = new System.Drawing.Size(321, 21);
            this.cboPtosVenta.TabIndex = 25;
            // 
            // lblPtoVenta
            // 
            this.lblPtoVenta.AutoSize = true;
            this.lblPtoVenta.Location = new System.Drawing.Point(182, 24);
            this.lblPtoVenta.Name = "lblPtoVenta";
            this.lblPtoVenta.Size = new System.Drawing.Size(84, 13);
            this.lblPtoVenta.TabIndex = 24;
            this.lblPtoVenta.Text = "Punto de Venta:";
            // 
            // cboTipoCbte
            // 
            this.cboTipoCbte.FormattingEnabled = true;
            this.cboTipoCbte.Location = new System.Drawing.Point(272, 48);
            this.cboTipoCbte.Name = "cboTipoCbte";
            this.cboTipoCbte.Size = new System.Drawing.Size(321, 21);
            this.cboTipoCbte.TabIndex = 28;
            // 
            // lblTipoCbte
            // 
            this.lblTipoCbte.AutoSize = true;
            this.lblTipoCbte.Location = new System.Drawing.Point(154, 52);
            this.lblTipoCbte.Name = "lblTipoCbte";
            this.lblTipoCbte.Size = new System.Drawing.Size(112, 13);
            this.lblTipoCbte.TabIndex = 27;
            this.lblTipoCbte.Text = "Tipo de Comprobante:";
            // 
            // frmComprobantesAprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.cboTipoCbte);
            this.Controls.Add(this.lblTipoCbte);
            this.Controls.Add(this.dgvCbtesAutorizados);
            this.Controls.Add(this.cboPtosVenta);
            this.Controls.Add(this.lblPtoVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnTraerCbtes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmComprobantesAprobados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes Autorizados";
            this.Load += new System.EventHandler(this.frmComprobantesAprobados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCbtesAutorizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnTraerCbtes;
        private System.Windows.Forms.DataGridView dgvCbtesAutorizados;
        private System.Windows.Forms.ComboBox cboPtosVenta;
        private System.Windows.Forms.Label lblPtoVenta;
        private System.Windows.Forms.ComboBox cboTipoCbte;
        private System.Windows.Forms.Label lblTipoCbte;
    }
}