﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace OpenRECE
{
    public partial class frmTicketAcceso : Form
    {
        /*Configuracion Guardada en la B.D.*/
        Entidades.Configuracion_Certificado objEntidadesConfiguracionCertificado = new Entidades.Configuracion_Certificado();
        Logica.Configuracion_Certificado objLogicaConfiguracionCertificado = new Logica.Configuracion_Certificado();

        /*Direcciones de los WebServices*/        
        const string SERVIDOR_WSAA_PRODUCCION = "https://wsaa.afip.gov.ar/ws/services/LoginCms?WSDL";
        const string SERVIDOR_WSAA_HOMOLOGACION = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?WSDL";
        const string SERVIDOR_WSFEV1_HOMOLOGACION = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL";
        const string DEFAULT_SERVICIO = "wsfe";
        
        public frmTicketAcceso()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Carga Aplicacion
        /// Verifica si tiene cargada la configuración en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTicketAcceso_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + " - "+ Application.ProductVersion;

            objEntidadesConfiguracionCertificado = objLogicaConfiguracionCertificado.TraerConfiguracion();
            /*Verifica si tiene una configuracion cargada en la B.D.*/
            if (objEntidadesConfiguracionCertificado.Cuit == 0)
            {
                MessageBox.Show("Para utilizar el programa primero debe cargar el certificado desde Configuracion -> Certificado");
            }
        }

        /// <summary>
        /// Control del Botón de Pedir Ticket de Acceso.
        /// Si hay uno vigente en la B.D. utiliza este, sino pide uno nuevo al WebService.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSolicitarTA_Click(object sender, EventArgs e)
        {
            objEntidadesConfiguracionCertificado = objLogicaConfiguracionCertificado.TraerConfiguracion();
            /*Verifica si tiene una configuracion cargada en la B.D.*/
            if (objEntidadesConfiguracionCertificado.Cuit != 0)
            {
                /*Tiene una configuracion cargada*/
                //Entidades.Tickets objEntidadesTicket_Rta = new Entidades.Tickets();
                Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
                Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

                //Devuelve un Ticket Vigente guardado en la B.D.
                objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

                if (objEntidadesTicket_Acceso.Id_Ticket == 0)
                {
                    /*No hay ningún Ticket de Acceso habilitado en la base de Datos, se pedirá uno nuevo*/
                    Entidades.CertificadosX509 objEntidadesCertificado = new Entidades.CertificadosX509();
                    Logica.CertificadosX509 objLogicaCertificado = new Logica.CertificadosX509();                                        
                    
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
                    Logica.Tickets objTicketRespuesta = new Logica.Tickets();                    
                    objEntidadesTicket_Acceso = objTicketRespuesta.Gestionar_TA(objEntidadesCertificado);

                    if (objEntidadesTicket_Acceso.Sign != null)
                    {
                        Logica.Tickets_Acceso objTicketsAcceso = new Logica.Tickets_Acceso();
                        //Guarda el ticket en la B.D.
                        objTicketsAcceso.Agregar(objEntidadesTicket_Acceso);
                    }
                }

                mostrarDatosTicketAcceso(objEntidadesTicket_Acceso);
            }
            else
            {
                MessageBox.Show("Para utilizar el programa primero debe cargar el certificado desde Configuracion -> Certificado");
            }
        }

        /// <summary>
        /// Muestra en los datos de la respuesta del WebService guardado en la B.D.
        /// </summary>
        /// <param name="pTicket_Rta">Ticket Respuesta WebService</param>
        private void mostrarDatosTicketAcceso(Entidades.Tickets_Acceso pTicket_Rta)
        {
            lblFchGeneracionRta.Text = pTicket_Rta.Fecha_Generacion.ToShortDateString() + ' ' + pTicket_Rta.Fecha_Generacion.ToShortTimeString();
            lblFchExpiracionRta.Text = pTicket_Rta.Fecha_Expiracion.ToShortDateString() + ' ' + pTicket_Rta.Fecha_Expiracion.ToShortTimeString();
            tlpRtaAFIP.Visible = true;
            tablasToolStripMenuItem.Enabled = true; //Se permite el Acceso a las Tablas solo si tiene un Ticket de Acceso Activo
        }

        /// <summary>
        /// Abre el Form de Paises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaises objPaises = new frmPaises();

            objPaises.ShowDialog();
        }

        /// <summary>
        /// Abre el Form de Tipos Comprobantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiposDeComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposCbtes objTiposCbtes = new frmTiposCbtes();

            objTiposCbtes.ShowDialog();

        }

        /// <summary>
        /// Abre el Form de Configuracion de Certificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void certificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracionCertificado objConfiguracionCertificado = new frmConfiguracionCertificado();

            objConfiguracionCertificado.ShowDialog();
        }

        /// <summary>
        /// Muestra el Form de Información de la Aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe objAcercaDe = new frmAcercaDe();

            objAcercaDe.ShowDialog();
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