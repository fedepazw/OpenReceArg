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
            this.txtNroCbteDesde = new System.Windows.Forms.TextBox();
            this.txtNroCbteHasta = new System.Windows.Forms.TextBox();
            this.lblNroCbteDesde = new System.Windows.Forms.Label();
            this.lblNroCbteHasta = new System.Windows.Forms.Label();
            this.printDocCbtesAutorizados = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.chkFiltroNros = new System.Windows.Forms.CheckBox();
            this.btnFiltrarCbtes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCbtesAutorizados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnTraerCbtes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraerCbtes.Location = new System.Drawing.Point(727, 23);
            this.btnTraerCbtes.Name = "btnTraerCbtes";
            this.btnTraerCbtes.Size = new System.Drawing.Size(99, 48);
            this.btnTraerCbtes.TabIndex = 6;
            this.btnTraerCbtes.Text = "Actualizar desde AFIP";
            this.btnTraerCbtes.UseVisualStyleBackColor = true;
            this.btnTraerCbtes.Click += new System.EventHandler(this.btnTraerCbtes_Click);
            // 
            // dgvCbtesAutorizados
            // 
            this.dgvCbtesAutorizados.AllowUserToAddRows = false;
            this.dgvCbtesAutorizados.AllowUserToDeleteRows = false;
            this.dgvCbtesAutorizados.AllowUserToOrderColumns = true;
            this.dgvCbtesAutorizados.AllowUserToResizeRows = false;
            this.dgvCbtesAutorizados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCbtesAutorizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCbtesAutorizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCbtesAutorizados.Location = new System.Drawing.Point(12, 90);
            this.dgvCbtesAutorizados.Name = "dgvCbtesAutorizados";
            this.dgvCbtesAutorizados.ReadOnly = true;
            this.dgvCbtesAutorizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCbtesAutorizados.Size = new System.Drawing.Size(860, 418);
            this.dgvCbtesAutorizados.TabIndex = 26;
            // 
            // cboPtosVenta
            // 
            this.cboPtosVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboPtosVenta.FormattingEnabled = true;
            this.cboPtosVenta.Location = new System.Drawing.Point(295, 10);
            this.cboPtosVenta.Name = "cboPtosVenta";
            this.cboPtosVenta.Size = new System.Drawing.Size(321, 21);
            this.cboPtosVenta.TabIndex = 25;
            // 
            // lblPtoVenta
            // 
            this.lblPtoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPtoVenta.AutoSize = true;
            this.lblPtoVenta.Location = new System.Drawing.Point(205, 13);
            this.lblPtoVenta.Name = "lblPtoVenta";
            this.lblPtoVenta.Size = new System.Drawing.Size(84, 13);
            this.lblPtoVenta.TabIndex = 24;
            this.lblPtoVenta.Text = "Punto de Venta:";
            // 
            // cboTipoCbte
            // 
            this.cboTipoCbte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboTipoCbte.FormattingEnabled = true;
            this.cboTipoCbte.Location = new System.Drawing.Point(295, 37);
            this.cboTipoCbte.Name = "cboTipoCbte";
            this.cboTipoCbte.Size = new System.Drawing.Size(321, 21);
            this.cboTipoCbte.TabIndex = 28;
            // 
            // lblTipoCbte
            // 
            this.lblTipoCbte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTipoCbte.AutoSize = true;
            this.lblTipoCbte.Location = new System.Drawing.Point(177, 41);
            this.lblTipoCbte.Name = "lblTipoCbte";
            this.lblTipoCbte.Size = new System.Drawing.Size(112, 13);
            this.lblTipoCbte.TabIndex = 27;
            this.lblTipoCbte.Text = "Tipo de Comprobante:";
            // 
            // txtNroCbteDesde
            // 
            this.txtNroCbteDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNroCbteDesde.Location = new System.Drawing.Point(399, 64);
            this.txtNroCbteDesde.MaxLength = 7;
            this.txtNroCbteDesde.Name = "txtNroCbteDesde";
            this.txtNroCbteDesde.Size = new System.Drawing.Size(58, 20);
            this.txtNroCbteDesde.TabIndex = 29;
            this.txtNroCbteDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroCbteDesde.Visible = false;
            this.txtNroCbteDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCbteDesde_KeyPress);
            // 
            // txtNroCbteHasta
            // 
            this.txtNroCbteHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNroCbteHasta.Location = new System.Drawing.Point(558, 64);
            this.txtNroCbteHasta.MaxLength = 7;
            this.txtNroCbteHasta.Name = "txtNroCbteHasta";
            this.txtNroCbteHasta.Size = new System.Drawing.Size(58, 20);
            this.txtNroCbteHasta.TabIndex = 30;
            this.txtNroCbteHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroCbteHasta.Visible = false;
            this.txtNroCbteHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCbteHasta_KeyPress);
            // 
            // lblNroCbteDesde
            // 
            this.lblNroCbteDesde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNroCbteDesde.AutoSize = true;
            this.lblNroCbteDesde.Location = new System.Drawing.Point(292, 67);
            this.lblNroCbteDesde.Name = "lblNroCbteDesde";
            this.lblNroCbteDesde.Size = new System.Drawing.Size(92, 13);
            this.lblNroCbteDesde.TabIndex = 31;
            this.lblNroCbteDesde.Text = "Nro. Cbte. Desde:";
            this.lblNroCbteDesde.Visible = false;
            // 
            // lblNroCbteHasta
            // 
            this.lblNroCbteHasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNroCbteHasta.AutoSize = true;
            this.lblNroCbteHasta.Location = new System.Drawing.Point(463, 67);
            this.lblNroCbteHasta.Name = "lblNroCbteHasta";
            this.lblNroCbteHasta.Size = new System.Drawing.Size(89, 13);
            this.lblNroCbteHasta.TabIndex = 32;
            this.lblNroCbteHasta.Text = "Nro. Cbte. Hasta:";
            this.lblNroCbteHasta.Visible = false;
            // 
            // printDocCbtesAutorizados
            // 
            this.printDocCbtesAutorizados.DocumentName = "Comprobantes Autorizados";
            this.printDocCbtesAutorizados.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocCbtesAutorizados_PrintPage);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(715, 514);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 39);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chkFiltroNros
            // 
            this.chkFiltroNros.AutoSize = true;
            this.chkFiltroNros.Location = new System.Drawing.Point(180, 67);
            this.chkFiltroNros.Name = "chkFiltroNros";
            this.chkFiltroNros.Size = new System.Drawing.Size(112, 17);
            this.chkFiltroNros.TabIndex = 34;
            this.chkFiltroNros.Text = "Filtrar Nros. Cbtes.";
            this.chkFiltroNros.UseVisualStyleBackColor = true;
            this.chkFiltroNros.CheckedChanged += new System.EventHandler(this.chkFiltroNros_CheckedChanged);
            // 
            // btnFiltrarCbtes
            // 
            this.btnFiltrarCbtes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrarCbtes.Location = new System.Drawing.Point(622, 22);
            this.btnFiltrarCbtes.Name = "btnFiltrarCbtes";
            this.btnFiltrarCbtes.Size = new System.Drawing.Size(99, 48);
            this.btnFiltrarCbtes.TabIndex = 35;
            this.btnFiltrarCbtes.Text = "Filtrar";
            this.btnFiltrarCbtes.UseVisualStyleBackColor = true;
            this.btnFiltrarCbtes.Click += new System.EventHandler(this.btnFiltrarCbtes_Click);
            // 
            // frmComprobantesAprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnFiltrarCbtes);
            this.Controls.Add(this.chkFiltroNros);
            this.Controls.Add(this.btnTraerCbtes);
            this.Controls.Add(this.lblPtoVenta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblNroCbteHasta);
            this.Controls.Add(this.dgvCbtesAutorizados);
            this.Controls.Add(this.cboPtosVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNroCbteDesde);
            this.Controls.Add(this.lblTipoCbte);
            this.Controls.Add(this.txtNroCbteDesde);
            this.Controls.Add(this.txtNroCbteHasta);
            this.Controls.Add(this.cboTipoCbte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
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
        private System.Windows.Forms.TextBox txtNroCbteDesde;
        private System.Windows.Forms.TextBox txtNroCbteHasta;
        private System.Windows.Forms.Label lblNroCbteDesde;
        private System.Windows.Forms.Label lblNroCbteHasta;
        private System.Drawing.Printing.PrintDocument printDocCbtesAutorizados;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.CheckBox chkFiltroNros;
        private System.Windows.Forms.Button btnFiltrarCbtes;
    }
}