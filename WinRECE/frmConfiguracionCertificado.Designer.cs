namespace OpenRECE
{
    partial class frmConfiguracionCertificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionCertificado));
            this.gbTipoAprobacion = new System.Windows.Forms.GroupBox();
            this.rbServidorHomologacion = new System.Windows.Forms.RadioButton();
            this.rbServidorProduccion = new System.Windows.Forms.RadioButton();
            this.lblCertificadoPFX = new System.Windows.Forms.Label();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.txtPFXPassword = new System.Windows.Forms.TextBox();
            this.btnArchCertificadoPFX = new System.Windows.Forms.Button();
            this.txtArchCertificadoPFX = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.gbDatosCertificado = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.openArchCertificadoPFX = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardarConf = new System.Windows.Forms.Button();
            this.gbTipoAprobacion.SuspendLayout();
            this.gbDatosCertificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoAprobacion
            // 
            this.gbTipoAprobacion.Controls.Add(this.rbServidorHomologacion);
            this.gbTipoAprobacion.Controls.Add(this.rbServidorProduccion);
            this.gbTipoAprobacion.Location = new System.Drawing.Point(19, 144);
            this.gbTipoAprobacion.Name = "gbTipoAprobacion";
            this.gbTipoAprobacion.Size = new System.Drawing.Size(170, 65);
            this.gbTipoAprobacion.TabIndex = 14;
            this.gbTipoAprobacion.TabStop = false;
            this.gbTipoAprobacion.Text = "Tipo de Aprobación";
            // 
            // rbServidorHomologacion
            // 
            this.rbServidorHomologacion.AutoSize = true;
            this.rbServidorHomologacion.Checked = true;
            this.rbServidorHomologacion.Location = new System.Drawing.Point(7, 42);
            this.rbServidorHomologacion.Name = "rbServidorHomologacion";
            this.rbServidorHomologacion.Size = new System.Drawing.Size(136, 17);
            this.rbServidorHomologacion.TabIndex = 1;
            this.rbServidorHomologacion.TabStop = true;
            this.rbServidorHomologacion.Text = "Homologacion (Prueba)";
            this.rbServidorHomologacion.UseVisualStyleBackColor = true;
            // 
            // rbServidorProduccion
            // 
            this.rbServidorProduccion.AutoSize = true;
            this.rbServidorProduccion.Location = new System.Drawing.Point(7, 20);
            this.rbServidorProduccion.Name = "rbServidorProduccion";
            this.rbServidorProduccion.Size = new System.Drawing.Size(79, 17);
            this.rbServidorProduccion.TabIndex = 0;
            this.rbServidorProduccion.Text = "Producción";
            this.rbServidorProduccion.UseVisualStyleBackColor = true;
            // 
            // lblCertificadoPFX
            // 
            this.lblCertificadoPFX.AutoSize = true;
            this.lblCertificadoPFX.Location = new System.Drawing.Point(94, 75);
            this.lblCertificadoPFX.Name = "lblCertificadoPFX";
            this.lblCertificadoPFX.Size = new System.Drawing.Size(56, 13);
            this.lblCertificadoPFX.TabIndex = 13;
            this.lblCertificadoPFX.Text = "Password:";
            // 
            // lblCertificado
            // 
            this.lblCertificado.AutoSize = true;
            this.lblCertificado.Location = new System.Drawing.Point(6, 48);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(148, 13);
            this.lblCertificado.TabIndex = 12;
            this.lblCertificado.Text = "Archivo del Certificado (.PFX):";
            // 
            // txtPFXPassword
            // 
            this.txtPFXPassword.Location = new System.Drawing.Point(156, 71);
            this.txtPFXPassword.MaxLength = 10;
            this.txtPFXPassword.Name = "txtPFXPassword";
            this.txtPFXPassword.PasswordChar = '*';
            this.txtPFXPassword.Size = new System.Drawing.Size(89, 20);
            this.txtPFXPassword.TabIndex = 11;
            this.txtPFXPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPFXPassword.UseSystemPasswordChar = true;
            // 
            // btnArchCertificadoPFX
            // 
            this.btnArchCertificadoPFX.Location = new System.Drawing.Point(498, 42);
            this.btnArchCertificadoPFX.Name = "btnArchCertificadoPFX";
            this.btnArchCertificadoPFX.Size = new System.Drawing.Size(34, 23);
            this.btnArchCertificadoPFX.TabIndex = 10;
            this.btnArchCertificadoPFX.Text = "...";
            this.btnArchCertificadoPFX.UseVisualStyleBackColor = true;
            this.btnArchCertificadoPFX.Click += new System.EventHandler(this.btnArchCertificadoPFX_Click);
            // 
            // txtArchCertificadoPFX
            // 
            this.txtArchCertificadoPFX.Location = new System.Drawing.Point(156, 45);
            this.txtArchCertificadoPFX.Name = "txtArchCertificadoPFX";
            this.txtArchCertificadoPFX.Size = new System.Drawing.Size(336, 20);
            this.txtArchCertificadoPFX.TabIndex = 9;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(122, 22);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(28, 13);
            this.lblCuit.TabIndex = 15;
            this.lblCuit.Text = "Cuit:";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(156, 19);
            this.txtCuit.MaxLength = 11;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(89, 20);
            this.txtCuit.TabIndex = 16;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // gbDatosCertificado
            // 
            this.gbDatosCertificado.Controls.Add(this.txtCuit);
            this.gbDatosCertificado.Controls.Add(this.lblCuit);
            this.gbDatosCertificado.Controls.Add(this.lblCertificadoPFX);
            this.gbDatosCertificado.Controls.Add(this.txtArchCertificadoPFX);
            this.gbDatosCertificado.Controls.Add(this.lblCertificado);
            this.gbDatosCertificado.Controls.Add(this.btnArchCertificadoPFX);
            this.gbDatosCertificado.Controls.Add(this.txtPFXPassword);
            this.gbDatosCertificado.Location = new System.Drawing.Point(19, 38);
            this.gbDatosCertificado.Name = "gbDatosCertificado";
            this.gbDatosCertificado.Size = new System.Drawing.Size(539, 100);
            this.gbDatosCertificado.TabIndex = 17;
            this.gbDatosCertificado.TabStop = false;
            this.gbDatosCertificado.Text = "Certificado";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(465, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 35);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // openArchCertificadoPFX
            // 
            this.openArchCertificadoPFX.FileName = "certificado.pfx";
            // 
            // btnGuardarConf
            // 
            this.btnGuardarConf.Location = new System.Drawing.Point(373, 220);
            this.btnGuardarConf.Name = "btnGuardarConf";
            this.btnGuardarConf.Size = new System.Drawing.Size(86, 35);
            this.btnGuardarConf.TabIndex = 19;
            this.btnGuardarConf.Text = "Guardar";
            this.btnGuardarConf.UseVisualStyleBackColor = true;
            this.btnGuardarConf.Click += new System.EventHandler(this.btnGuardarConf_Click);
            // 
            // frmConfiguracionCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 264);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarConf);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbDatosCertificado);
            this.Controls.Add(this.gbTipoAprobacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracionCertificado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración Certificado";
            this.Load += new System.EventHandler(this.frmConfiguracionCertificado_Load);
            this.gbTipoAprobacion.ResumeLayout(false);
            this.gbTipoAprobacion.PerformLayout();
            this.gbDatosCertificado.ResumeLayout(false);
            this.gbDatosCertificado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoAprobacion;
        private System.Windows.Forms.RadioButton rbServidorHomologacion;
        private System.Windows.Forms.RadioButton rbServidorProduccion;
        private System.Windows.Forms.Label lblCertificadoPFX;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.TextBox txtPFXPassword;
        private System.Windows.Forms.Button btnArchCertificadoPFX;
        private System.Windows.Forms.TextBox txtArchCertificadoPFX;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.GroupBox gbDatosCertificado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.OpenFileDialog openArchCertificadoPFX;
        private System.Windows.Forms.Button btnGuardarConf;
    }
}