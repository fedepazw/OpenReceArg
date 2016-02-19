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
    public partial class frmTiposTributos : Form
    {
        public frmTiposTributos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga los Tipos Tributos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposTributos_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Tributos desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposTributos objLogicaTiposTributos = new Logica.TiposTributos();

            dgvTiposTributos.DataSource = objLogicaTiposTributos.TraerTodos();

        }

        /// <summary>
        /// Control del Botón Actualizar Tipos de Tributos
        /// Llama al WebService para obtener los Tributos y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposTributos_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Tributos
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposTributos(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Tributos actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            else
            {
                /*WebService Homologación*/
                if (objLogicaWebServiceAfip.FEParamGetTiposTributos_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Tipos de Tributos actualizados desde el WebService");
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
