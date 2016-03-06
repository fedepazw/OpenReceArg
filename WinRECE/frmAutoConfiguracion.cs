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
    public partial class frmAutoConfiguracion : Form
    {
        public frmAutoConfiguracion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAutoConfiguracion_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Control del Botón Procesar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            autoConfigurar();
        }

        /// <summary>
        /// Realiza todo el proceso de autoconfiguracion
        /// </summary>
        private void autoConfigurar()
        {
            /*Comprobar Conexión con AFIP*/
            if (comprobarConexionAFIP())
            {
                if (desactivarTicketActivo())
                {
                    if (pedirNuevoTicketAcc())
                    {
                        actualizarTablaTiposCbtes();
                        actualizarTablaPuntosVenta();
                        actualizarUltAutorizadosRTA();
                    }
                }
            }            
        }

        /// <summary>
        /// Comprueba la Conexión con el AFIP
        /// </summary>
        /// <returns></returns>
        private bool comprobarConexionAFIP()
        {
            bool respuesta;

            lblConexAfipRTA.ForeColor = Color.Black;
            lblConexAfipRTA.Text = "Procesando...";
            lblConexAfipRTA.Refresh();

            Logica.Internet objLogicaInternet = new Logica.Internet();

            if (objLogicaInternet.estadoWS())
            {
                lblConexAfipRTA.ForeColor = Color.Green;
                lblConexAfipRTA.Text = "OK";
                lblConexAfipRTA.Refresh();
                respuesta = true;
            }
            else
            {
                lblConexAfipRTA.ForeColor = Color.Red;
                lblConexAfipRTA.Text = "ERROR";
                lblConexAfipRTA.Refresh();
                respuesta = false;
            }

            return respuesta;
        }

        /// <summary>
        /// Si existe un Ticket Activo lo desactiva
        /// </summary>
        /// <returns></returns>
        private bool desactivarTicketActivo()
        {
            bool respuesta;
            lblBorrarTicketActivoRTA.ForeColor = Color.Black;
            lblBorrarTicketActivoRTA.Text = "Procesando...";
            lblBorrarTicketActivoRTA.Refresh();

            Logica.Tickets_Acceso objLogicaTicketAcceso = new Logica.Tickets_Acceso();

            try
            {
                objLogicaTicketAcceso.DesactivarTicketActivo();
                lblBorrarTicketActivoRTA.ForeColor = Color.Green;
                lblBorrarTicketActivoRTA.Text = "OK";
                lblBorrarTicketActivoRTA.Refresh();
                respuesta = true;
            }
            catch(Exception ex)
            {
                lblBorrarTicketActivoRTA.ForeColor = Color.Red;
                lblBorrarTicketActivoRTA.Text = "ERROR";
                lblBorrarTicketActivoRTA.Refresh();
                respuesta = false;
            }

            return respuesta;
        }

        /// <summary>
        /// Pide un Nuevo Ticket de Acceso con las configuraciones cargadas
        /// </summary>
        /// <returns></returns>
        private bool pedirNuevoTicketAcc()
        {
            bool respuesta = false;
            lblPedirNuevoTicketAccRTA.ForeColor = Color.Black;
            lblPedirNuevoTicketAccRTA.Text = "Procesando...";
            lblPedirNuevoTicketAccRTA.Refresh();

            /*Pide la configuración desde la B.D.*/
            Entidades.Configuracion_Certificado objEntidadesConfiguracionCertificado = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConfiguracionCertificado = new Logica.Configuracion_Certificado();
            objEntidadesConfiguracionCertificado = objLogicaConfiguracionCertificado.TraerConfiguracion();

            /*Creo un Certificado a partir de la configuración que recuperé desde la B.D.*/
            Entidades.CertificadosX509 objEntidadesCertificado = new Entidades.CertificadosX509();
            const string DEFAULT_SERVICIO = "wsfe";
            const string SERVIDOR_WSAA_PRODUCCION = "https://wsaa.afip.gov.ar/ws/services/LoginCms?WSDL";
            const string SERVIDOR_WSAA_HOMOLOGACION = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?WSDL";

            objEntidadesCertificado.IdServicioNegocio = DEFAULT_SERVICIO;

            if (objEntidadesConfiguracionCertificado.TipoAprobacion == 'P')
            {
                objEntidadesCertificado.UrlWsaaWsdl = SERVIDOR_WSAA_PRODUCCION;                        
            }
            else
            {
                objEntidadesCertificado.UrlWsaaWsdl = SERVIDOR_WSAA_HOMOLOGACION;
            }

            /*Pido en el WebService un Nuevo Ticket de Acceso*/
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();
            Logica.Tickets objTicketRespuesta = new Logica.Tickets();

            objEntidadesTicket_Acceso = objTicketRespuesta.Gestionar_TA(objEntidadesCertificado);
            objEntidadesTicket_Acceso.Cuit = objEntidadesConfiguracionCertificado.Cuit;
            objEntidadesTicket_Acceso.TipoAprobacion = objEntidadesConfiguracionCertificado.TipoAprobacion;

            if (objEntidadesTicket_Acceso.Sign != null)
            {
                Logica.Tickets_Acceso objTicketsAcceso = new Logica.Tickets_Acceso();
                //Guarda el ticket en la B.D.
                objTicketsAcceso.Agregar(objEntidadesTicket_Acceso);
                lblPedirNuevoTicketAccRTA.ForeColor = Color.Green;
                lblPedirNuevoTicketAccRTA.Text = "OK";
                lblPedirNuevoTicketAccRTA.Refresh();
                respuesta = true;
            }
            else
            {
                lblPedirNuevoTicketAccRTA.ForeColor = Color.Red;
                lblPedirNuevoTicketAccRTA.Text = "ERROR";
                lblPedirNuevoTicketAccRTA.Refresh();
            }

            return respuesta;
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla de Tipos de Comprobantes
        /// </summary>
        private void actualizarTablaTiposCbtes()
        {
            lblTablaTiposCbtesRTA.ForeColor = Color.Black;
            lblTablaTiposCbtesRTA.Text = "Procesando...";
            lblTablaTiposCbtesRTA.Refresh();

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
                    lblTablaTiposCbtesRTA.ForeColor = Color.Green;
                    lblTablaTiposCbtesRTA.Text = "OK";
                    lblTablaTiposCbtesRTA.Refresh();
                }
                else
                {
                    lblTablaTiposCbtesRTA.ForeColor = Color.Red;
                    lblTablaTiposCbtesRTA.Text = "ERROR";
                    lblTablaTiposCbtesRTA.Refresh();
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposCbtes_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposCbtesRTA.ForeColor = Color.Green;
                    lblTablaTiposCbtesRTA.Text = "OK";
                    lblTablaTiposCbtesRTA.Refresh();
                }
                else
                {
                    lblTablaTiposCbtesRTA.ForeColor = Color.Red;
                    lblTablaTiposCbtesRTA.Text = "ERROR";
                    lblTablaTiposCbtesRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla de Puntos de Ventas
        /// </summary>
        private void actualizarTablaPuntosVenta()
        {
            lblTablaPuntosVentaRTA.ForeColor = Color.Black;
            lblTablaPuntosVentaRTA.Text = "Procesando...";
            lblTablaPuntosVentaRTA.Refresh();

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
                    lblTablaPuntosVentaRTA.ForeColor = Color.Green;
                    lblTablaPuntosVentaRTA.Text = "OK";
                    lblTablaPuntosVentaRTA.Refresh();
                }
                else
                {
                    lblTablaPuntosVentaRTA.ForeColor = Color.Red;
                    lblTablaPuntosVentaRTA.Text = "ERROR";
                    lblTablaPuntosVentaRTA.Refresh();
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetPtosVenta_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaPuntosVentaRTA.ForeColor = Color.Green;
                    lblTablaPuntosVentaRTA.Text = "OK";
                    lblTablaPuntosVentaRTA.Refresh();
                }
                else
                {
                    lblTablaPuntosVentaRTA.ForeColor = Color.Red;
                    lblTablaPuntosVentaRTA.Text = "ERROR";
                    lblTablaPuntosVentaRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService los Últimos Nros de Comprobantes Autorizados
        /// </summary>
        private void actualizarUltAutorizadosRTA()
        {
            lblTablaUltAutorizadosRTA.ForeColor = Color.Black;
            lblTablaUltAutorizadosRTA.Text = "Procesando...";
            lblTablaUltAutorizadosRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            /*Busco Todos los Puntos de Venta que existen*/
            int ptoVenta;
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();

            DataTable puntosVentaDT = objLogicaPtosVenta.TraerTodos();

            foreach(DataRow ptoVentafila in puntosVentaDT.Rows)
            {
                //Asigno Punto de Venta
                ptoVenta = Convert.ToInt32(ptoVentafila["Id_PtoVenta"]);

                //Llamo al Webservice para recuperar los Ultimos Nros. de Comprobantes
                Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();


                if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
                {
                    /*WebService Producción*/
                    if (objLogicaWebServiceAfip.FECompUltimoAutorizado(objEntidadesTicket_Acceso, ptoVenta) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        lblTablaUltAutorizadosRTA.ForeColor = Color.Green;
                        lblTablaUltAutorizadosRTA.Text = "OK";
                        lblTablaUltAutorizadosRTA.Refresh();
                    }
                    else
                    {
                        lblTablaUltAutorizadosRTA.ForeColor = Color.Red;
                        lblTablaUltAutorizadosRTA.Text = "ERROR";
                        lblTablaUltAutorizadosRTA.Refresh();
                    }
                }
                else
                {
                    /*WebService Homologacion*/
                    if (objLogicaWebServiceAfip.FECompUltimoAutorizado_Homologacion(objEntidadesTicket_Acceso, ptoVenta) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        lblTablaUltAutorizadosRTA.ForeColor = Color.Green;
                        lblTablaUltAutorizadosRTA.Text = "OK";
                        lblTablaUltAutorizadosRTA.Refresh();
                    }
                    else
                    {
                        lblTablaUltAutorizadosRTA.ForeColor = Color.Red;
                        lblTablaUltAutorizadosRTA.Text = "ERROR";
                        lblTablaUltAutorizadosRTA.Refresh();
                    }
                }
            }            
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
