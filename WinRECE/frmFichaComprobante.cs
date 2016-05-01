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
    public partial class frmFichaComprobante : Form
    {
        public frmFichaComprobante()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frmFichaComprobante_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        /// <summary>
        /// Carga todos los ComboBox del Form
        /// </summary>
        void CargarCombos()
        {
            CargarComboTiposCbtes();
            CargarComboPtosVenta();
            CargarComboTipoConcepto();
            CargarComboTipoDocumento();
            CargarComboPais();
        }

        /// <summary>
        /// Llena el combo box de Tipos de Comprobantes        
        /// </summary>
        void CargarComboTiposCbtes()
        {
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();

            cmbTipoCbte.DataSource = objLogicaTiposCbtes.TraerTodos();
            cmbTipoCbte.ValueMember = "Id_TipoCbte";
            cmbTipoCbte.DisplayMember = "Descripcion";
        }

        /// <summary>
        /// Llena el combo box de Puntos de Venta        
        /// </summary>
        void CargarComboPtosVenta()
        {
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();

            cmbSucursal.DataSource = objLogicaPtosVenta.TraerTodos();
            cmbSucursal.ValueMember = "Id_PtoVenta";
            cmbSucursal.DisplayMember = "Id_PtoVenta";
        }

        /// <summary>
        /// Llena el combo box de Tipos de Conceptos        
        /// </summary>
        void CargarComboTipoConcepto()
        {
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();

            cmbTipoConcepto.DataSource = objLogicaTiposConceptos.TraerTodos();
            cmbTipoConcepto.ValueMember = "Id_TipoConcepto";
            cmbTipoConcepto.DisplayMember = "Descripcion";
            cmbTipoConcepto.SelectedValue = 3; //Id_TipoConcepto = 3 -> Productos y Servicios
        }

        /// <summary>
        /// Llena el combo box de Tipos de Documento       
        /// </summary>
        void CargarComboTipoDocumento()
        {
            Logica.TiposDocumentos objLogicaTiposDocumentos = new Logica.TiposDocumentos();

            cmbCliDocTipo.DataSource = objLogicaTiposDocumentos.TraerTodos();
            cmbCliDocTipo.ValueMember = "Id_TipoDocumento";
            cmbCliDocTipo.DisplayMember = "Descripcion";
            cmbCliDocTipo.SelectedValue = 96; //Id_TipoDocumento = 96 -> DNI
        }

        /// <summary>
        /// Llena el combo box de Paises     
        /// </summary>
        void CargarComboPais()
        {
            Logica.TiposPaises objLogicaTiposPaises = new Logica.TiposPaises();

            cmbCliPais.DataSource = objLogicaTiposPaises.TraerTodos();
            cmbCliPais.ValueMember = "Id_Pais";
            cmbCliPais.DisplayMember = "Descripcion";
            cmbCliPais.SelectedValue = 200; //Id_Pais = 200 -> Argentina
        }

        private void btnProcesarCbte_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para aprobar el Comprobante
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposPaises(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Paises actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposPaises_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    MessageBox.Show("Paises actualizados desde el WebService");
                }
                else
                {
                    MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                }
            }            
        }
    }
}
