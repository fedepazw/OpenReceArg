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
    public partial class frmTiposConceptos : Form
    {
        public frmTiposConceptos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Tipos de Conceptos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposConceptos_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Conceptos desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();

            dgvTiposConceptos.DataSource = objLogicaTiposConceptos.TraerTodos();
        }

        /// <summary>
        /// Control del Botón Actualizar Tipos Conceptos
        /// Llama al WebService para obtener los Tipos de Conceptos y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposConceptos_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Conceptos
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposConcepto(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Conceptos actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposConcepto_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Conceptos actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }

            TraerTodos();
        }

        /// <summary>
        /// Cierra la Ventana Actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
