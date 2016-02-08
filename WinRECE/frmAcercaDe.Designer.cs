namespace OpenRECE
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNombreAplicacion = new System.Windows.Forms.Label();
            this.lblVersionAplicacion = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.wbLicencia = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(599, 311);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreAplicacion
            // 
            this.lblNombreAplicacion.AutoSize = true;
            this.lblNombreAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAplicacion.Location = new System.Drawing.Point(279, 9);
            this.lblNombreAplicacion.Name = "lblNombreAplicacion";
            this.lblNombreAplicacion.Size = new System.Drawing.Size(174, 33);
            this.lblNombreAplicacion.TabIndex = 1;
            this.lblNombreAplicacion.Text = "OpenRECE";
            // 
            // lblVersionAplicacion
            // 
            this.lblVersionAplicacion.AutoSize = true;
            this.lblVersionAplicacion.Location = new System.Drawing.Point(264, 47);
            this.lblVersionAplicacion.Name = "lblVersionAplicacion";
            this.lblVersionAplicacion.Size = new System.Drawing.Size(45, 13);
            this.lblVersionAplicacion.TabIndex = 2;
            this.lblVersionAplicacion.Text = "Version:";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.Location = new System.Drawing.Point(204, 71);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(344, 20);
            this.lblCreador.TabIndex = 3;
            this.lblCreador.Text = "Creado por: Federico Paz Werner (@fedepazw)";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(17, 159);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(181, 13);
            this.lblLicencia.TabIndex = 4;
            this.lblLicencia.Text = "Bajo Licencia: GNU (Libre y Gratuito)";
            // 
            // wbLicencia
            // 
            this.wbLicencia.Location = new System.Drawing.Point(22, 175);
            this.wbLicencia.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbLicencia.Name = "wbLicencia";
            this.wbLicencia.Size = new System.Drawing.Size(673, 130);
            this.wbLicencia.TabIndex = 6;
            this.wbLicencia.Url = new System.Uri("http://www.gnu.org/licenses/gpl.txt", System.UriKind.Absolute);
            // 
            // frmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 352);
            this.ControlBox = false;
            this.Controls.Add(this.wbLicencia);
            this.Controls.Add(this.lblLicencia);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.lblVersionAplicacion);
            this.Controls.Add(this.lblNombreAplicacion);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de ";
            this.Load += new System.EventHandler(this.frmAcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNombreAplicacion;
        private System.Windows.Forms.Label lblVersionAplicacion;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.WebBrowser wbLicencia;
    }
}