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
                        borrarLogsErrores();
                        borrarLogsEventos();
                        actualizarTablaPaises();
                        actualizarTablaTiposCbtes();
                        actualizarTablaTiposConceptos();
                        actulizarTablaTiposDocumentos();
                        actualizarTablaTiposIva();
                        actualizarTablaTiposMonedas();
                        actualizarTablaTiposOpcionales();
                        actualizarTablaTiposTributos();
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
            catch(Exception)
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
        /// Borra los Logs de Errores
        /// </summary>
        private void borrarLogsErrores()
        {
            lblBorrarErroresRTA.ForeColor = Color.Black;
            lblBorrarErroresRTA.Text = "Procesando...";
            lblBorrarErroresRTA.Refresh();

            //Borro los Logs de Errores
            Logica.Errores_WS objLogicaErrores = new Logica.Errores_WS();

            try
            {
                objLogicaErrores.BorrarTodos();

                lblBorrarErroresRTA.ForeColor = Color.Green;
                lblBorrarErroresRTA.Text = "OK";
                lblBorrarErroresRTA.Refresh();
            }
            catch (Exception)
            {
                lblBorrarErroresRTA.ForeColor = Color.Red;
                lblBorrarErroresRTA.Text = "ERROR";
                lblBorrarErroresRTA.Refresh();
            }
        }

        /// <summary>
        /// Borra los Logs de Eventos
        /// </summary>
        private void borrarLogsEventos()
        {
            lblBorrarEventosRTA.ForeColor = Color.Black;
            lblBorrarEventosRTA.Text = "Procesando...";
            lblBorrarEventosRTA.Refresh();

            //Borro los Logs de Eventos
            Logica.Eventos_WS objLogicaEventos = new Logica.Eventos_WS();

            try
            {
                objLogicaEventos.BorrarTodos();

                lblBorrarEventosRTA.ForeColor = Color.Green;
                lblBorrarEventosRTA.Text = "OK";
                lblBorrarEventosRTA.Refresh();
            }
            catch (Exception)
            {
                lblBorrarEventosRTA.ForeColor = Color.Red;
                lblBorrarEventosRTA.Text = "ERROR";
                lblBorrarEventosRTA.Refresh();
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla de Paises
        /// </summary>
        private void actualizarTablaPaises()
        {
            lblTablaPaisesRTA.ForeColor = Color.Black;
            lblTablaPaisesRTA.Text = "Procesando...";
            lblTablaPaisesRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Paises
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposPaises(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaPaisesRTA.ForeColor = Color.Green;
                    lblTablaPaisesRTA.Text = "OK";
                    lblTablaPaisesRTA.Refresh();
                }
                else
                {
                    lblTablaPaisesRTA.ForeColor = Color.Red;
                    lblTablaPaisesRTA.Text = "ERROR";
                    lblTablaPaisesRTA.Refresh();
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposPaises_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaPaisesRTA.ForeColor = Color.Green;
                    lblTablaPaisesRTA.Text = "OK";
                    lblTablaPaisesRTA.Refresh();
                }
                else
                {
                    lblTablaPaisesRTA.ForeColor = Color.Red;
                    lblTablaPaisesRTA.Text = "ERROR";
                    lblTablaPaisesRTA.Refresh();
                }
            }
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
        /// Actualiza desde el WebService la Tabla de Tipos de Conceptos
        /// </summary>
        private void actualizarTablaTiposConceptos()
        {
            lblTablaTiposConceptosRTA.ForeColor = Color.Black;
            lblTablaTiposConceptosRTA.Text = "Procesando...";
            lblTablaTiposConceptosRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Comprobantes
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposConcepto(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposConceptosRTA.ForeColor = Color.Green;
                    lblTablaTiposConceptosRTA.Text = "OK";
                    lblTablaTiposConceptosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposConceptosRTA.ForeColor = Color.Red;
                    lblTablaTiposConceptosRTA.Text = "ERROR";
                    lblTablaTiposConceptosRTA.Refresh();
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposConcepto_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposConceptosRTA.ForeColor = Color.Green;
                    lblTablaTiposConceptosRTA.Text = "OK";
                    lblTablaTiposConceptosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposConceptosRTA.ForeColor = Color.Red;
                    lblTablaTiposConceptosRTA.Text = "ERROR";
                    lblTablaTiposConceptosRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla de Tipos de Documentos
        /// </summary>
        private void actulizarTablaTiposDocumentos()
        {
            lblTablaTiposDocumentosRTA.ForeColor = Color.Black;
            lblTablaTiposDocumentosRTA.Text = "Procesando...";
            lblTablaTiposDocumentosRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Comprobantes
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposDoc(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposDocumentosRTA.ForeColor = Color.Green;
                    lblTablaTiposDocumentosRTA.Text = "OK";
                    lblTablaTiposDocumentosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposDocumentosRTA.ForeColor = Color.Red;
                    lblTablaTiposDocumentosRTA.Text = "ERROR";
                    lblTablaTiposDocumentosRTA.Refresh();
                }
            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposDoc_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposDocumentosRTA.ForeColor = Color.Green;
                    lblTablaTiposDocumentosRTA.Text = "OK";
                    lblTablaTiposDocumentosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposDocumentosRTA.ForeColor = Color.Red;
                    lblTablaTiposDocumentosRTA.Text = "ERROR";
                    lblTablaTiposDocumentosRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla de Tipos Iva
        /// </summary>
        private void actualizarTablaTiposIva()
        {
            lblTablaTiposIvaRTA.ForeColor = Color.Black;
            lblTablaTiposIvaRTA.Text = "Procesando...";
            lblTablaTiposIvaRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Iva
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposIva(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposIvaRTA.ForeColor = Color.Green;
                    lblTablaTiposIvaRTA.Text = "OK";
                    lblTablaTiposIvaRTA.Refresh();
                }
                else
                {
                    lblTablaTiposIvaRTA.ForeColor = Color.Red;
                    lblTablaTiposIvaRTA.Text = "ERROR";
                    lblTablaTiposIvaRTA.Refresh();
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposIva_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposIvaRTA.ForeColor = Color.Green;
                    lblTablaTiposIvaRTA.Text = "OK";
                    lblTablaTiposIvaRTA.Refresh();
                }
                else
                {
                    lblTablaTiposIvaRTA.ForeColor = Color.Red;
                    lblTablaTiposIvaRTA.Text = "ERROR";
                    lblTablaTiposIvaRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla Tipos de Monedas
        /// </summary>
        private void actualizarTablaTiposMonedas()
        {
            lblTablaTiposMonedasRTA.ForeColor = Color.Black;
            lblTablaTiposMonedasRTA.Text = "Procesando...";
            lblTablaTiposMonedasRTA.Refresh();

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
                    lblTablaTiposMonedasRTA.ForeColor = Color.Green;
                    lblTablaTiposMonedasRTA.Text = "OK";
                    lblTablaTiposMonedasRTA.Refresh();
                }
                else
                {
                    lblTablaTiposMonedasRTA.ForeColor = Color.Red;
                    lblTablaTiposMonedasRTA.Text = "ERROR";
                    lblTablaTiposMonedasRTA.Refresh();
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposMonedas_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposMonedasRTA.ForeColor = Color.Green;
                    lblTablaTiposMonedasRTA.Text = "OK";
                    lblTablaTiposMonedasRTA.Refresh();
                }
                else
                {
                    lblTablaTiposMonedasRTA.ForeColor = Color.Red;
                    lblTablaTiposMonedasRTA.Text = "ERROR";
                    lblTablaTiposMonedasRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla Tipos Opcionales
        /// </summary>
        private void actualizarTablaTiposOpcionales()
        {
            lblTablaTiposOpcionalesRTA.ForeColor = Color.Black;
            lblTablaTiposOpcionalesRTA.Text = "Procesando...";
            lblTablaTiposOpcionalesRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Monedas 
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposOpcionales(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposOpcionalesRTA.ForeColor = Color.Green;
                    lblTablaTiposOpcionalesRTA.Text = "OK";
                    lblTablaTiposOpcionalesRTA.Refresh();
                }
                else
                {
                    lblTablaTiposOpcionalesRTA.ForeColor = Color.Red;
                    lblTablaTiposOpcionalesRTA.Text = "ERROR";
                    lblTablaTiposOpcionalesRTA.Refresh();
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposOpcionales_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposOpcionalesRTA.ForeColor = Color.Green;
                    lblTablaTiposOpcionalesRTA.Text = "OK";
                    lblTablaTiposOpcionalesRTA.Refresh();
                }
                else
                {
                    lblTablaTiposOpcionalesRTA.ForeColor = Color.Red;
                    lblTablaTiposOpcionalesRTA.Text = "ERROR";
                    lblTablaTiposOpcionalesRTA.Refresh();
                }
            }
        }

        /// <summary>
        /// Actualiza desde el WebService la Tabla Tipos de Tributos
        /// </summary>
        private void actualizarTablaTiposTributos()
        {
            lblTablaTiposTributosRTA.ForeColor = Color.Black;
            lblTablaTiposTributosRTA.Text = "Procesando...";
            lblTablaTiposTributosRTA.Refresh();

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Tipos de Monedas 
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEParamGetTiposTributos(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposTributosRTA.ForeColor = Color.Green;
                    lblTablaTiposTributosRTA.Text = "OK";
                    lblTablaTiposTributosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposTributosRTA.ForeColor = Color.Red;
                    lblTablaTiposTributosRTA.Text = "ERROR";
                    lblTablaTiposTributosRTA.Refresh();
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEParamGetTiposTributos_Homologacion(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    lblTablaTiposTributosRTA.ForeColor = Color.Green;
                    lblTablaTiposTributosRTA.Text = "OK";
                    lblTablaTiposTributosRTA.Refresh();
                }
                else
                {
                    lblTablaTiposTributosRTA.ForeColor = Color.Red;
                    lblTablaTiposTributosRTA.Text = "ERROR";
                    lblTablaTiposTributosRTA.Refresh();
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
