namespace OpenRECE
{
    partial class frmPruebaWebService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPruebaWebService));
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tLayoutPruebas = new System.Windows.Forms.TableLayoutPanel();
            this.lblConexInternet = new System.Windows.Forms.Label();
            this.lblEstadoConexInternet = new System.Windows.Forms.Label();
            this.lblConexWS = new System.Windows.Forms.Label();
            this.lblEstadoWS = new System.Windows.Forms.Label();
            this.lblTituloEstado = new System.Windows.Forms.Label();
            this.tLayoutPruebas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(136, 254);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 39);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Realizar Prueba";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(273, 254);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 39);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tLayoutPruebas
            // 
            this.tLayoutPruebas.ColumnCount = 2;
            this.tLayoutPruebas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPruebas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPruebas.Controls.Add(this.lblEstadoWS, 1, 1);
            this.tLayoutPruebas.Controls.Add(this.lblConexWS, 0, 1);
            this.tLayoutPruebas.Controls.Add(this.lblEstadoConexInternet, 1, 0);
            this.tLayoutPruebas.Controls.Add(this.lblConexInternet, 0, 0);
            this.tLayoutPruebas.Location = new System.Drawing.Point(36, 54);
            this.tLayoutPruebas.Name = "tLayoutPruebas";
            this.tLayoutPruebas.RowCount = 2;
            this.tLayoutPruebas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPruebas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutPruebas.Size = new System.Drawing.Size(278, 168);
            this.tLayoutPruebas.TabIndex = 4;
            // 
            // lblConexInternet
            // 
            this.lblConexInternet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConexInternet.AutoSize = true;
            this.lblConexInternet.Location = new System.Drawing.Point(23, 35);
            this.lblConexInternet.Name = "lblConexInternet";
            this.lblConexInternet.Size = new System.Drawing.Size(93, 13);
            this.lblConexInternet.TabIndex = 0;
            this.lblConexInternet.Text = "Conexión Internet:";
            // 
            // lblEstadoConexInternet
            // 
            this.lblEstadoConexInternet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstadoConexInternet.AutoSize = true;
            this.lblEstadoConexInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoConexInternet.Location = new System.Drawing.Point(193, 33);
            this.lblEstadoConexInternet.Name = "lblEstadoConexInternet";
            this.lblEstadoConexInternet.Size = new System.Drawing.Size(30, 17);
            this.lblEstadoConexInternet.TabIndex = 1;
            this.lblEstadoConexInternet.Text = "OK";
            // 
            // lblConexWS
            // 
            this.lblConexWS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConexWS.AutoSize = true;
            this.lblConexWS.Location = new System.Drawing.Point(32, 113);
            this.lblConexWS.Name = "lblConexWS";
            this.lblConexWS.Size = new System.Drawing.Size(75, 26);
            this.lblConexWS.TabIndex = 2;
            this.lblConexWS.Text = "Conexión con WebService:";
            // 
            // lblEstadoWS
            // 
            this.lblEstadoWS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstadoWS.AutoSize = true;
            this.lblEstadoWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoWS.Location = new System.Drawing.Point(193, 117);
            this.lblEstadoWS.Name = "lblEstadoWS";
            this.lblEstadoWS.Size = new System.Drawing.Size(30, 17);
            this.lblEstadoWS.TabIndex = 3;
            this.lblEstadoWS.Text = "OK";
            // 
            // lblTituloEstado
            // 
            this.lblTituloEstado.AutoSize = true;
            this.lblTituloEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstado.Location = new System.Drawing.Point(18, 16);
            this.lblTituloEstado.Name = "lblTituloEstado";
            this.lblTituloEstado.Size = new System.Drawing.Size(330, 25);
            this.lblTituloEstado.TabIndex = 5;
            this.lblTituloEstado.Text = "Estado del WebService WSFEv1";
            // 
            // frmPruebaWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 305);
            this.ControlBox = false;
            this.Controls.Add(this.lblTituloEstado);
            this.Controls.Add(this.tLayoutPruebas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPruebaWebService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba WebService";
            this.Load += new System.EventHandler(this.frmPruebaWebService_Load);
            this.tLayoutPruebas.ResumeLayout(false);
            this.tLayoutPruebas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TableLayoutPanel tLayoutPruebas;
        private System.Windows.Forms.Label lblEstadoWS;
        private System.Windows.Forms.Label lblConexWS;
        private System.Windows.Forms.Label lblEstadoConexInternet;
        private System.Windows.Forms.Label lblConexInternet;
        private System.Windows.Forms.Label lblTituloEstado;
    }
}