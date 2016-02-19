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
    public partial class frmTiposCbtes : Form
    {
        public frmTiposCbtes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Tipos de Comprobantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposCbtes_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Comprobantes desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();

            dgvTiposCbtes.DataSource = objLogicaTiposCbtes.TraerTodos();
        }

        /// <summary>
        /// Control del Botón Actualizar Tipos Comprobantes
        /// Llama al WebService para obtener los Tipos de Comprobantes y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposCbtes_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Comprobantes
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposCbtes(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Comprobantes actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposCbtes_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Comprobantes actualizados desde el WebService");
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
