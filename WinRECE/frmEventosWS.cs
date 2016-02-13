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
    public partial class frmEventosWS : Form
    {
        public frmEventosWS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Eventos WS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEventosWS_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Eventos desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            dgvEventosWS.DataSource = objLogicaEventosWS.TraerTodos();
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
