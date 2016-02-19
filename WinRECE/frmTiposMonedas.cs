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
    public partial class frmTiposMonedas : Form
    {
        public frmTiposMonedas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga los Tipos de Monedas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposMonedas_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Monedas desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposMonedas objLogicaTiposMonedas = new Logica.TiposMonedas();

            dgvTiposMonedas.DataSource = objLogicaTiposMonedas.TraerTodos();

        }

        /// <summary>
        /// Control del Botón Actualizar Monedas
        /// Llama al WebService para obtener los Tipos de Monedas y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposMonedas_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Monedas
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposMonedas(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Monedas actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            else
            {
                /*WebService Homlogación*/
                if (objLogicaWebServiceAfip.FEParamGetTiposMonedas_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Monedas actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
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
