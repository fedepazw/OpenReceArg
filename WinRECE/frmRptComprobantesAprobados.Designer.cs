namespace OpenRECE
{
    partial class frmRptComprobantesAprobados
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
            this.components = new System.ComponentModel.Container();
            this.rvCbtesAutorizados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsCbtesAutorizados = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsCbtesAutorizados)).BeginInit();
            this.SuspendLayout();
            // 
            // rvCbtesAutorizados
            // 
            this.rvCbtesAutorizados.Location = new System.Drawing.Point(12, 21);
            this.rvCbtesAutorizados.Name = "rvCbtesAutorizados";
            this.rvCbtesAutorizados.Size = new System.Drawing.Size(732, 366);
            this.rvCbtesAutorizados.TabIndex = 0;
            // 
            // frmRptComprobantesAprobados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 434);
            this.Controls.Add(this.rvCbtesAutorizados);
            this.Name = "frmRptComprobantesAprobados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Comprobantes Autorizados";
            this.Load += new System.EventHandler(this.frmRptComprobantesAprobados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCbtesAutorizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvCbtesAutorizados;
        private System.Windows.Forms.BindingSource bsCbtesAutorizados;
    }
}