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
    public partial class frmUltimosNrosCbtes : Form
    {
        public frmUltimosNrosCbtes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga el Combo de Ptos de Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUltimosNrosCbtes_Load(object sender, EventArgs e)
        {
            TraerTodos();
            CargarComboPtosVenta();
        }

        /// <summary>
        /// Llena el combo box de Puntos de Venta        
        /// </summary>
        void CargarComboPtosVenta()
        {
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();

            cboPtosVenta.DataSource = objLogicaPtosVenta.TraerTodos();
            cboPtosVenta.ValueMember = "Id_PtoVenta";
            cboPtosVenta.DisplayMember = "Id_PtoVenta";
        }

        /// <summary>
        /// Carga el DataGrid los Últimos Nros. Comprobantes desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.UltCbtesAutorizados objLogicaUltNrosCbtes = new Logica.UltCbtesAutorizados();

            dgvUltNrosCbtes.DataSource = objLogicaUltNrosCbtes.TraerTodos();
        }

        /// <summary>
        /// Control Botón Actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarUltimosNros_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Asigno Punto de Venta
            int ptoVenta = Convert.ToInt32(cboPtosVenta.SelectedValue);

            //Llamo al Webservice para recuperar los Ultimos Nros. de Comprobantes
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();
                

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FECompUltimoAutorizado(objEntidadesTicket_Acceso, ptoVenta) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Últimos Nros. de Comprobantes actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FECompUltimoAutorizado_Homologacion(objEntidadesTicket_Acceso, ptoVenta) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Últimos Nros. de Comprobantes actualizados desde el WebService");
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
