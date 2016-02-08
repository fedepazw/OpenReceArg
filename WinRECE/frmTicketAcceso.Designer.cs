namespace OpenRECE
{
    partial class frmTicketAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketAcceso));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSolicitarTA = new System.Windows.Forms.Button();
            this.gbRespuestaAFIP = new System.Windows.Forms.GroupBox();
            this.tlpRtaAFIP = new System.Windows.Forms.TableLayoutPanel();
            this.lblFchGeneracion = new System.Windows.Forms.Label();
            this.lblFchExpiracion = new System.Windows.Forms.Label();
            this.lblFchGeneracionRta = new System.Windows.Forms.Label();
            this.lblFchExpiracionRta = new System.Windows.Forms.Label();
            this.menuStripSuperior = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRespuestaAFIP.SuspendLayout();
            this.tlpRtaAFIP.SuspendLayout();
            this.menuStripSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(434, 268);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(105, 41);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSolicitarTA
            // 
            this.btnSolicitarTA.Location = new System.Drawing.Point(214, 42);
            this.btnSolicitarTA.Name = "btnSolicitarTA";
            this.btnSolicitarTA.Size = new System.Drawing.Size(95, 53);
            this.btnSolicitarTA.TabIndex = 6;
            this.btnSolicitarTA.Text = "Ticket de Acceso";
            this.btnSolicitarTA.UseVisualStyleBackColor = true;
            this.btnSolicitarTA.Click += new System.EventHandler(this.btnSolicitarTA_Click);
            // 
            // gbRespuestaAFIP
            // 
            this.gbRespuestaAFIP.Controls.Add(this.tlpRtaAFIP);
            this.gbRespuestaAFIP.Location = new System.Drawing.Point(15, 101);
            this.gbRespuestaAFIP.Name = "gbRespuestaAFIP";
            this.gbRespuestaAFIP.Size = new System.Drawing.Size(524, 81);
            this.gbRespuestaAFIP.TabIndex = 7;
            this.gbRespuestaAFIP.TabStop = false;
            this.gbRespuestaAFIP.Text = "Respuesta AFIP";
            // 
            // tlpRtaAFIP
            // 
            this.tlpRtaAFIP.ColumnCount = 2;
            this.tlpRtaAFIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.Controls.Add(this.lblFchGeneracion, 0, 0);
            this.tlpRtaAFIP.Controls.Add(this.lblFchExpiracion, 0, 1);
            this.tlpRtaAFIP.Controls.Add(this.lblFchGeneracionRta, 1, 0);
            this.tlpRtaAFIP.Controls.Add(this.lblFchExpiracionRta, 1, 1);
            this.tlpRtaAFIP.Location = new System.Drawing.Point(80, 19);
            this.tlpRtaAFIP.Name = "tlpRtaAFIP";
            this.tlpRtaAFIP.RowCount = 2;
            this.tlpRtaAFIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.Size = new System.Drawing.Size(364, 51);
            this.tlpRtaAFIP.TabIndex = 2;
            this.tlpRtaAFIP.Visible = false;
            // 
            // lblFchGeneracion
            // 
            this.lblFchGeneracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchGeneracion.AutoSize = true;
            this.lblFchGeneracion.Location = new System.Drawing.Point(16, 6);
            this.lblFchGeneracion.Name = "lblFchGeneracion";
            this.lblFchGeneracion.Size = new System.Drawing.Size(163, 13);
            this.lblFchGeneracion.TabIndex = 1;
            this.lblFchGeneracion.Text = "Fecha de Generación del Ticket:";
            // 
            // lblFchExpiracion
            // 
            this.lblFchExpiracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchExpiracion.AutoSize = true;
            this.lblFchExpiracion.Location = new System.Drawing.Point(22, 31);
            this.lblFchExpiracion.Name = "lblFchExpiracion";
            this.lblFchExpiracion.Size = new System.Drawing.Size(157, 13);
            this.lblFchExpiracion.TabIndex = 0;
            this.lblFchExpiracion.Text = "Fecha de Expiración del Ticket:";
            // 
            // lblFchGeneracionRta
            // 
            this.lblFchGeneracionRta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchGeneracionRta.AutoSize = true;
            this.lblFchGeneracionRta.Location = new System.Drawing.Point(361, 6);
            this.lblFchGeneracionRta.Name = "lblFchGeneracionRta";
            this.lblFchGeneracionRta.Size = new System.Drawing.Size(0, 13);
            this.lblFchGeneracionRta.TabIndex = 2;
            // 
            // lblFchExpiracionRta
            // 
            this.lblFchExpiracionRta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchExpiracionRta.AutoSize = true;
            this.lblFchExpiracionRta.Location = new System.Drawing.Point(361, 31);
            this.lblFchExpiracionRta.Name = "lblFchExpiracionRta";
            this.lblFchExpiracionRta.Size = new System.Drawing.Size(0, 13);
            this.lblFchExpiracionRta.TabIndex = 3;
            // 
            // menuStripSuperior
            // 
            this.menuStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuStripSuperior.Name = "menuStripSuperior";
            this.menuStripSuperior.Size = new System.Drawing.Size(551, 24);
            this.menuStripSuperior.TabIndex = 9;
            this.menuStripSuperior.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeComprobantesToolStripMenuItem,
            this.paisesToolStripMenuItem});
            this.tablasToolStripMenuItem.Enabled = false;
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "&Tablas";
            // 
            // tiposDeComprobantesToolStripMenuItem
            // 
            this.tiposDeComprobantesToolStripMenuItem.Name = "tiposDeComprobantesToolStripMenuItem";
            this.tiposDeComprobantesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.tiposDeComprobantesToolStripMenuItem.Text = "&Tipos de Comprobantes";
            this.tiposDeComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeComprobantesToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.paisesToolStripMenuItem.Text = "&Paises";
            this.paisesToolStripMenuItem.Click += new System.EventHandler(this.paisesToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificadoToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "&Configuracion";
            // 
            // certificadoToolStripMenuItem
            // 
            this.certificadoToolStripMenuItem.Name = "certificadoToolStripMenuItem";
            this.certificadoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.certificadoToolStripMenuItem.Text = "C&ertificado";
            this.certificadoToolStripMenuItem.Click += new System.EventHandler(this.certificadoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "A&cerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // frmTicketAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 321);
            this.ControlBox = false;
            this.Controls.Add(this.gbRespuestaAFIP);
            this.Controls.Add(this.btnSolicitarTA);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuStripSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSuperior;
            this.Name = "frmTicketAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenRECEArg";
            this.Load += new System.EventHandler(this.frmTicketAcceso_Load);
            this.gbRespuestaAFIP.ResumeLayout(false);
            this.tlpRtaAFIP.ResumeLayout(false);
            this.tlpRtaAFIP.PerformLayout();
            this.menuStripSuperior.ResumeLayout(false);
            this.menuStripSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSolicitarTA;
        private System.Windows.Forms.GroupBox gbRespuestaAFIP;
        private System.Windows.Forms.Label lblFchGeneracion;
        private System.Windows.Forms.Label lblFchExpiracion;
        private System.Windows.Forms.TableLayoutPanel tlpRtaAFIP;
        private System.Windows.Forms.Label lblFchGeneracionRta;
        private System.Windows.Forms.Label lblFchExpiracionRta;
        private System.Windows.Forms.MenuStrip menuStripSuperior;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeComprobantesToolStripMenuItem;
    }
}