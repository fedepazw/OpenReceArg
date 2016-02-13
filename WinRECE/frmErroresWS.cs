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
    public partial class frmErroresWS : Form
    {
        public frmErroresWS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Errores WS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmErroresWS_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Errores desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();

            dgvErroresWS.DataSource = objLogicaErroresWS.TraerTodos();
        }

        /// <summary>
        /// Cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
