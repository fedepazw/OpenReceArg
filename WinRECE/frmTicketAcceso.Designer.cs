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
            this.lblIdTicketAccesoRta = new System.Windows.Forms.Label();
            this.lblIdTicketAcceso = new System.Windows.Forms.Label();
            this.lblFchExpiracion = new System.Windows.Forms.Label();
            this.lblFchGeneracion = new System.Windows.Forms.Label();
            this.lblFchExpiracionRta = new System.Windows.Forms.Label();
            this.lblFchGeneracionRta = new System.Windows.Forms.Label();
            this.menuStripSuperior = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeComprobantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeConceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeIvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeMonedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDatosOpcionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeTributosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVerificarInternet = new System.Windows.Forms.Button();
            this.ultimosNúmerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRespuestaAFIP.SuspendLayout();
            this.tlpRtaAFIP.SuspendLayout();
            this.menuStripSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(434, 196);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(105, 41);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSolicitarTA
            // 
            this.btnSolicitarTA.Location = new System.Drawing.Point(333, 196);
            this.btnSolicitarTA.Name = "btnSolicitarTA";
            this.btnSolicitarTA.Size = new System.Drawing.Size(95, 41);
            this.btnSolicitarTA.TabIndex = 6;
            this.btnSolicitarTA.Text = "Ticket de Acceso";
            this.btnSolicitarTA.UseVisualStyleBackColor = true;
            this.btnSolicitarTA.Visible = false;
            this.btnSolicitarTA.Click += new System.EventHandler(this.btnSolicitarTA_Click);
            // 
            // gbRespuestaAFIP
            // 
            this.gbRespuestaAFIP.Controls.Add(this.tlpRtaAFIP);
            this.gbRespuestaAFIP.Location = new System.Drawing.Point(12, 58);
            this.gbRespuestaAFIP.Name = "gbRespuestaAFIP";
            this.gbRespuestaAFIP.Size = new System.Drawing.Size(524, 100);
            this.gbRespuestaAFIP.TabIndex = 7;
            this.gbRespuestaAFIP.TabStop = false;
            this.gbRespuestaAFIP.Text = "Ticket Acceso AFIP";
            // 
            // tlpRtaAFIP
            // 
            this.tlpRtaAFIP.ColumnCount = 2;
            this.tlpRtaAFIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.Controls.Add(this.lblIdTicketAccesoRta, 1, 0);
            this.tlpRtaAFIP.Controls.Add(this.lblIdTicketAcceso, 0, 0);
            this.tlpRtaAFIP.Controls.Add(this.lblFchExpiracion, 0, 2);
            this.tlpRtaAFIP.Controls.Add(this.lblFchGeneracion, 0, 1);
            this.tlpRtaAFIP.Controls.Add(this.lblFchExpiracionRta, 1, 2);
            this.tlpRtaAFIP.Controls.Add(this.lblFchGeneracionRta, 1, 1);
            this.tlpRtaAFIP.Location = new System.Drawing.Point(80, 19);
            this.tlpRtaAFIP.Name = "tlpRtaAFIP";
            this.tlpRtaAFIP.RowCount = 3;
            this.tlpRtaAFIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRtaAFIP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRtaAFIP.Size = new System.Drawing.Size(364, 66);
            this.tlpRtaAFIP.TabIndex = 2;
            this.tlpRtaAFIP.Visible = false;
            // 
            // lblIdTicketAccesoRta
            // 
            this.lblIdTicketAccesoRta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdTicketAccesoRta.AutoSize = true;
            this.lblIdTicketAccesoRta.Location = new System.Drawing.Point(273, 5);
            this.lblIdTicketAccesoRta.Name = "lblIdTicketAccesoRta";
            this.lblIdTicketAccesoRta.Size = new System.Drawing.Size(0, 13);
            this.lblIdTicketAccesoRta.TabIndex = 11;
            // 
            // lblIdTicketAcceso
            // 
            this.lblIdTicketAcceso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIdTicketAcceso.AutoSize = true;
            this.lblIdTicketAcceso.Location = new System.Drawing.Point(65, 5);
            this.lblIdTicketAcceso.Name = "lblIdTicketAcceso";
            this.lblIdTicketAcceso.Size = new System.Drawing.Size(114, 13);
            this.lblIdTicketAcceso.TabIndex = 10;
            this.lblIdTicketAcceso.Text = "Nro. de Ticket Pedido:";
            // 
            // lblFchExpiracion
            // 
            this.lblFchExpiracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchExpiracion.AutoSize = true;
            this.lblFchExpiracion.Location = new System.Drawing.Point(22, 49);
            this.lblFchExpiracion.Name = "lblFchExpiracion";
            this.lblFchExpiracion.Size = new System.Drawing.Size(157, 13);
            this.lblFchExpiracion.TabIndex = 0;
            this.lblFchExpiracion.Text = "Fecha de Expiración del Ticket:";
            // 
            // lblFchGeneracion
            // 
            this.lblFchGeneracion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchGeneracion.AutoSize = true;
            this.lblFchGeneracion.Location = new System.Drawing.Point(16, 28);
            this.lblFchGeneracion.Name = "lblFchGeneracion";
            this.lblFchGeneracion.Size = new System.Drawing.Size(163, 13);
            this.lblFchGeneracion.TabIndex = 1;
            this.lblFchGeneracion.Text = "Fecha de Generación del Ticket:";
            // 
            // lblFchExpiracionRta
            // 
            this.lblFchExpiracionRta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchExpiracionRta.AutoSize = true;
            this.lblFchExpiracionRta.Location = new System.Drawing.Point(361, 49);
            this.lblFchExpiracionRta.Name = "lblFchExpiracionRta";
            this.lblFchExpiracionRta.Size = new System.Drawing.Size(0, 13);
            this.lblFchExpiracionRta.TabIndex = 3;
            // 
            // lblFchGeneracionRta
            // 
            this.lblFchGeneracionRta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFchGeneracionRta.AutoSize = true;
            this.lblFchGeneracionRta.Location = new System.Drawing.Point(361, 28);
            this.lblFchGeneracionRta.Name = "lblFchGeneracionRta";
            this.lblFchGeneracionRta.Size = new System.Drawing.Size(0, 13);
            this.lblFchGeneracionRta.TabIndex = 2;
            // 
            // menuStripSuperior
            // 
            this.menuStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.comprobantesToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.logsToolStripMenuItem,
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
            // comprobantesToolStripMenuItem
            // 
            this.comprobantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorizadosToolStripMenuItem,
            this.ultimosNúmerosToolStripMenuItem});
            this.comprobantesToolStripMenuItem.Enabled = false;
            this.comprobantesToolStripMenuItem.Name = "comprobantesToolStripMenuItem";
            this.comprobantesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.comprobantesToolStripMenuItem.Text = "Com&probantes";
            // 
            // autorizadosToolStripMenuItem
            // 
            this.autorizadosToolStripMenuItem.Name = "autorizadosToolStripMenuItem";
            this.autorizadosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.autorizadosToolStripMenuItem.Text = "&Autorizados";
            this.autorizadosToolStripMenuItem.Click += new System.EventHandler(this.autorizadosToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.tiposDeComprobantesToolStripMenuItem,
            this.tiposDeConceptosToolStripMenuItem,
            this.tiposDeDocumentosToolStripMenuItem,
            this.tiposDeIvaToolStripMenuItem,
            this.tiposDeMonedasToolStripMenuItem,
            this.tiposDeDatosOpcionalesToolStripMenuItem,
            this.tiposDeTributosToolStripMenuItem,
            this.paisesToolStripMenuItem});
            this.tablasToolStripMenuItem.Enabled = false;
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "&Tablas";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntosDeVentaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.empresaToolStripMenuItem.Text = "&Empresa";
            // 
            // puntosDeVentaToolStripMenuItem
            // 
            this.puntosDeVentaToolStripMenuItem.Name = "puntosDeVentaToolStripMenuItem";
            this.puntosDeVentaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.puntosDeVentaToolStripMenuItem.Text = "Puntos de &Venta";
            this.puntosDeVentaToolStripMenuItem.Click += new System.EventHandler(this.puntosDeVentaToolStripMenuItem_Click);
            // 
            // tiposDeComprobantesToolStripMenuItem
            // 
            this.tiposDeComprobantesToolStripMenuItem.Name = "tiposDeComprobantesToolStripMenuItem";
            this.tiposDeComprobantesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeComprobantesToolStripMenuItem.Text = "&Tipos de Comprobantes";
            this.tiposDeComprobantesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeComprobantesToolStripMenuItem_Click);
            // 
            // tiposDeConceptosToolStripMenuItem
            // 
            this.tiposDeConceptosToolStripMenuItem.Name = "tiposDeConceptosToolStripMenuItem";
            this.tiposDeConceptosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeConceptosToolStripMenuItem.Text = "Tipos de &Conceptos";
            this.tiposDeConceptosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeConceptosToolStripMenuItem_Click);
            // 
            // tiposDeDocumentosToolStripMenuItem
            // 
            this.tiposDeDocumentosToolStripMenuItem.Name = "tiposDeDocumentosToolStripMenuItem";
            this.tiposDeDocumentosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeDocumentosToolStripMenuItem.Text = "Tipos de &Documentos";
            this.tiposDeDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDocumentosToolStripMenuItem_Click);
            // 
            // tiposDeIvaToolStripMenuItem
            // 
            this.tiposDeIvaToolStripMenuItem.Name = "tiposDeIvaToolStripMenuItem";
            this.tiposDeIvaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeIvaToolStripMenuItem.Text = "Tipos de &Iva";
            this.tiposDeIvaToolStripMenuItem.Click += new System.EventHandler(this.tiposDeIvaToolStripMenuItem_Click);
            // 
            // tiposDeMonedasToolStripMenuItem
            // 
            this.tiposDeMonedasToolStripMenuItem.Name = "tiposDeMonedasToolStripMenuItem";
            this.tiposDeMonedasToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeMonedasToolStripMenuItem.Text = "Tipos de &Monedas";
            this.tiposDeMonedasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeMonedasToolStripMenuItem_Click);
            // 
            // tiposDeDatosOpcionalesToolStripMenuItem
            // 
            this.tiposDeDatosOpcionalesToolStripMenuItem.Name = "tiposDeDatosOpcionalesToolStripMenuItem";
            this.tiposDeDatosOpcionalesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeDatosOpcionalesToolStripMenuItem.Text = "Tipos de Datos &Opcionales";
            this.tiposDeDatosOpcionalesToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDatosOpcionalesToolStripMenuItem_Click);
            // 
            // tiposDeTributosToolStripMenuItem
            // 
            this.tiposDeTributosToolStripMenuItem.Name = "tiposDeTributosToolStripMenuItem";
            this.tiposDeTributosToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.tiposDeTributosToolStripMenuItem.Text = "Tipos de &Tributos";
            this.tiposDeTributosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeTributosToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
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
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erroresToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "&Logs";
            // 
            // erroresToolStripMenuItem
            // 
            this.erroresToolStripMenuItem.Name = "erroresToolStripMenuItem";
            this.erroresToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.erroresToolStripMenuItem.Text = "E&rrores";
            this.erroresToolStripMenuItem.Click += new System.EventHandler(this.erroresToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.eventosToolStripMenuItem.Text = "E&ventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
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
            // btnVerificarInternet
            // 
            this.btnVerificarInternet.Location = new System.Drawing.Point(209, 196);
            this.btnVerificarInternet.Name = "btnVerificarInternet";
            this.btnVerificarInternet.Size = new System.Drawing.Size(95, 41);
            this.btnVerificarInternet.TabIndex = 11;
            this.btnVerificarInternet.Text = "Verificar Conexión";
            this.btnVerificarInternet.UseVisualStyleBackColor = true;
            this.btnVerificarInternet.Click += new System.EventHandler(this.btnVerificarInternet_Click);
            // 
            // ultimosNúmerosToolStripMenuItem
            // 
            this.ultimosNúmerosToolStripMenuItem.Name = "ultimosNúmerosToolStripMenuItem";
            this.ultimosNúmerosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ultimosNúmerosToolStripMenuItem.Text = "&Ultimos Números";
            this.ultimosNúmerosToolStripMenuItem.Click += new System.EventHandler(this.ultimosNúmerosToolStripMenuItem_Click);
            // 
            // frmTicketAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 252);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerificarInternet);
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
        private System.Windows.Forms.ToolStripMenuItem tiposDeConceptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeIvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erroresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.Label lblIdTicketAcceso;
        private System.Windows.Forms.Label lblIdTicketAccesoRta;
        private System.Windows.Forms.Button btnVerificarInternet;
        private System.Windows.Forms.ToolStripMenuItem tiposDeMonedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDatosOpcionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeTributosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntosDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprobantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimosNúmerosToolStripMenuItem;
    }
}