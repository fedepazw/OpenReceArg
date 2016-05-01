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
    public partial class frmAbrirArchivo : Form
    {
        public frmAbrirArchivo()
        {
            InitializeComponent();
        }

        /// <summary>        
        /// Devuelve OK al formulario que lo llama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Devuelve Cancel al formulario que lo llama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
