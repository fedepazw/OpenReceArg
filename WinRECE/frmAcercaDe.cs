using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenRECE
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form, pone los datos de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            this.Text = "Acerca de " + Application.ProductName + " - " + Application.ProductVersion;
            lblNombreAplicacion.Text = Application.ProductName;
            lblVersionAplicacion.Text = "Versión: " + Application.ProductVersion;
        }

        /// <summary>
        /// Cierra la ventana Actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
