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
    public partial class frmPtoVenta : Form
    {
        public frmPtoVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga los Puntos de Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPtoVenta_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Paises desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();

            dgvPtoVenta.DataSource = objLogicaPtosVenta.TraerTodos();

        }

        /// <summary>
        /// Control del Botón Actualizar Puntos de Venta
        /// Llama al WebService para obtener los Puntos de Venta y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarPtoVenta_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Puntos de Venta
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetPtosVenta(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Puntos de Venta actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetPtosVenta_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Puntos de Venta actualizados desde el WebService");
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
