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
    public partial class frmPaises : Form
    {
        public frmPaises()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga los Paises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPaises_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Paises desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.Paises objLogicaPaises = new Logica.Paises();

            dgvPaises.DataSource = objLogicaPaises.TraerTodos();

        }

        /// <summary>
        /// Control del Botón Actualizar Paises
        /// Llama al WebService para obtener los Paises y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarPaises_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice de Paises para recuperar los Paises
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objLogicaWebServiceAfip.FEParamGetTiposPaises(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
            {
                MessageBox.Show("Paises actualizados desde el WebService");
            }
            else
            {
                MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
            }

            TraerTodos();
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
