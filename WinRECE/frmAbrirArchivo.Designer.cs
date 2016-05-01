namespace OpenRECE
{
    partial class frmAbrirArchivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirArchivo));
            this.lblAbrirArchivo = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAbrirArchivo
            // 
            this.lblAbrirArchivo.AutoSize = true;
            this.lblAbrirArchivo.Location = new System.Drawing.Point(82, 21);
            this.lblAbrirArchivo.Name = "lblAbrirArchivo";
            this.lblAbrirArchivo.Size = new System.Drawing.Size(164, 13);
            this.lblAbrirArchivo.TabIndex = 0;
            this.lblAbrirArchivo.Text = "Desea abrir el archivo generado?";
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(56, 49);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(82, 36);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(187, 49);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(82, 36);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmAbrirArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 110);
            this.ControlBox = false;
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblAbrirArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAbrirArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbrirArchivo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
    }
}