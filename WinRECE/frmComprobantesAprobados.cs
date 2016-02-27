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
    public partial class frmComprobantesAprobados : Form
    {
        public frmComprobantesAprobados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga el Combo de Ptos de Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComprobantesAprobados_Load(object sender, EventArgs e)
        {            
            CargarComboPtosVenta();
            CargarComboTiposCbtes();
            TraerTodos(Convert.ToInt32(cboPtosVenta.SelectedValue), Convert.ToInt32(cboTipoCbte.SelectedValue));
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
        /// Llena el combo box de Tipos de Comprobantes        
        /// </summary>
        void CargarComboTiposCbtes()
        {
            Logica.UltCbtesAutorizados objLogicaUltCbtesAutorizados = new Logica.UltCbtesAutorizados();

            cboTipoCbte.DataSource = objLogicaUltCbtesAutorizados.TraerTodos();
            cboTipoCbte.ValueMember = "Id_TipoCbte";
            cboTipoCbte.DisplayMember = "Descripcion";
        }

        /// <summary>
        /// Carga el DataGrid los Comprobantes Autorizados desde la B.D.
        /// </summary>
        void TraerTodos(int pPtoVenta, int pTipoCbte)
        {
            Logica.Comprobantes_Autorizados objLogicaCbtesAutorizados = new Logica.Comprobantes_Autorizados();

            dgvCbtesAutorizados.DataSource = objLogicaCbtesAutorizados.TraerCbtesEspecifico(pPtoVenta, pTipoCbte);
        }

        /// <summary>
        /// Control Botón Traer Comprobantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraerCbtes_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();
            Entidades.Comprobantes objEntidadesComprobantes = new Entidades.Comprobantes();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();
          
            //Asigno Punto de Venta
            int ptoVenta = Convert.ToInt32(cboPtosVenta.SelectedValue);
            //Asigno Tipo de Comprobante
            int tipoCbte = Convert.ToInt32(cboTipoCbte.SelectedValue);

            //Llamo al Webservice para recuperar los Comprobantes Aprobados
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FECompConsultar(objEntidadesTicket_Acceso, ptoVenta, tipoCbte) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Comprobantes Autorizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FECompConsultar_Homologacion(objEntidadesTicket_Acceso, ptoVenta, tipoCbte) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Comprobantes Autorizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }
            TraerTodos(ptoVenta, tipoCbte);
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
