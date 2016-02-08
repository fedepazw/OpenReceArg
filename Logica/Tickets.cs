using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Logica
{
    public class Tickets
    {
        
        Logica.CertificadosX509 objLogicaCertificados = new CertificadosX509();

        //Atributos de los XML        
        public XmlDocument  Xml_LoginTicket_Respuesta = null;        
        public string       Xml_StrLoginTicket_Peticion_Template = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";        

        // OJO! NO ES THREAD-SAFE 
        private static UInt32 _globalUniqueID = 0;

        /// <summary> 
        ///  Genera el mensaje XML de Ticket de Requerimiento de Acceso (TRA).
        ///  Genera un Sistema de Gestion de Contenidos (CMS) del Ticket de Requerimiento de Acceso (TRA) con el certificado.
        ///  Codifica el CMS en Base64
        ///  Invoca al WebService de Autentificacion y Autorizacion (WSAA) con el CMS Firmado y Recibo la respuesta Ticket de Autorizacion (TA)
        ///  Extrae y valido la informacion de Autorizacion (TA)
        /// </summary> 
        /// <param name="pCertificado_Peticion">Objeto Certificado de Peticion</param> 
        /// <remarks></remarks>     
        public Entidades.Tickets_Acceso Gestionar_TA(Entidades.CertificadosX509 pCertificado_Peticion)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Rta = new Entidades.Tickets_Acceso();
            XmlDocument Xml_LoginTicket_Peticion        = new XmlDocument();
            byte[] LoginTicket_Peticion_Firmada         = null;            
            string Codificado_CMS_Login_TicketPeticion  = "";
            string loginTicket_Respuesta                = "";


            // PASO 1: Genero el mensaje XML de Ticket de Requerimiento de Acceso (TRA).
            Xml_LoginTicket_Peticion = Generar_XML_TRA(pCertificado_Peticion);

            // PASO 2: Genero un Sistema de Gestion de Contenidos (CMS) del Ticket de Requerimiento de Acceso (TRA) con el certificado.
            LoginTicket_Peticion_Firmada = Firmar_XML_TRA(Xml_LoginTicket_Peticion);

            // PASO 3: Codifico el CMS en Base64
            Codificado_CMS_Login_TicketPeticion = Codificar_CMS_TRA(LoginTicket_Peticion_Firmada);

            // PASO 4: Invoco al WebService de Autentificacion y Autorizacion (WSAA) con el CMS Firmado y Recibo la respuesta Ticket de Autorizacion (TA)
            loginTicket_Respuesta = Obtener_TA_Respuesta(Codificado_CMS_Login_TicketPeticion, pCertificado_Peticion);

            // PASO 5: Extraigo y valido la informacion de Autorizacion (TA)
            objEntidadesTicket_Rta = Obtener_Entidad_Respuesta(loginTicket_Respuesta);

            return objEntidadesTicket_Rta;

        }

        /// <summary>
        /// Genera un XML con el Ticket de Requerimiento de Acceso (TRA). LoginTicketRequest.XML
        /// </summary>
        /// <param name="pCertificado_Peticion">Certificado  del Ente Externo (EE)</param>
        /// <returns></returns>
        public XmlDocument Generar_XML_TRA(Entidades.CertificadosX509 pCertificado_Peticion)
        {
            XmlDocument Xml_LoginTicket_Peticion = new XmlDocument();

            //Atributos XML
            XmlNode xmlNodo_IdServicio;
            XmlNode xmlNodo_FchGeneracionPeticion;
            XmlNode xmlNodo_FchExpiracionPeticion;
            XmlNode xmlNodo_Servicio;
            
            try
            {
                Xml_LoginTicket_Peticion.LoadXml(Xml_StrLoginTicket_Peticion_Template);

                xmlNodo_IdServicio = Xml_LoginTicket_Peticion.SelectSingleNode("//uniqueId");
                xmlNodo_FchGeneracionPeticion = Xml_LoginTicket_Peticion.SelectSingleNode("//generationTime");
                xmlNodo_FchExpiracionPeticion = Xml_LoginTicket_Peticion.SelectSingleNode("//expirationTime");
                xmlNodo_Servicio = Xml_LoginTicket_Peticion.SelectSingleNode("//service");

                xmlNodo_IdServicio.InnerText = Convert.ToString(_globalUniqueID);
                xmlNodo_FchGeneracionPeticion.InnerText = DateTime.Now.AddMinutes(-10).ToString("s");
                xmlNodo_FchExpiracionPeticion.InnerText = DateTime.Now.AddMinutes(+10).ToString("s");
                xmlNodo_Servicio.InnerText = pCertificado_Peticion.IdServicioNegocio;

                _globalUniqueID += 1;
            }
            catch (Exception exGenerandoXMLPeticion)
            {
                throw new Exception("ERROR: Clase: Logica.Tickets. Método: Generar_XML_TRA. Descripcion:" + exGenerandoXMLPeticion.Message);
            }

            return Xml_LoginTicket_Peticion;
        }

        /// <summary>
        /// Genera un Sistema de Gestion de Contenidos (CMS) del Ticket de Requerimiento
        /// de Acceso (TRA) firmado con el Certificado. LoginTicketRequest.XML.CMS
        /// </summary>
        /// <param name="pXml_LoginTicket_Peticion">XML del Ticket de Requerimiento de Acceso (TRA)</param>
        /// <param name="pCertificado_Peticion">Certficado del Ente Externo (EE)</param>
        /// <returns></returns>
        public byte[] Firmar_XML_TRA(XmlDocument pXml_LoginTicket_Peticion)
        {
            byte[] XML_TRA_Firmado = null;
            
            try
            {
                X509Certificate2 certFirmante = objLogicaCertificados.ObtenerCertificadoDesdeArchivo();

                // Convierto la Peticion de  Login Ticket a bytes (para Firmarlo)
                Encoding MensajeCodificado = Encoding.UTF8;
                byte[] Mensaje = MensajeCodificado.GetBytes(pXml_LoginTicket_Peticion.OuterXml);

                // Firmo el Mensaje con el certificado
                XML_TRA_Firmado = Logica.CertificadosX509.FirmarMensaje(Mensaje, certFirmante);

            }
            catch (Exception exFirmandoPeticion)
            {
                throw new Exception("ERROR: Clase: Logica.Tickets. Método: Firmar_XML_TRA. Descripcion: " + exFirmandoPeticion.Message);
            }

            return XML_TRA_Firmado;
        }

        /// <summary>
        /// Codifica el CMS del Ticket de Requerimiento de Acceso(TRA) en Base64. 
        /// LoginTicketRequest.XML.CMS.Base64
        /// </summary>
        /// <param name="pTRA_XML_CMS">CMS del Ticket de Requerimiento de Acceso(TRA)</param>
        /// <returns></returns>
        public string Codificar_CMS_TRA(byte[] pTRA_XML_CMS)
        {
            string Base64_CMS_LoginTicket_Peticion = "";

            try
            {
                //Convierto el mensaje a Base64 
                Base64_CMS_LoginTicket_Peticion = Convert.ToBase64String(pTRA_XML_CMS);
            }
            catch (Exception exCodificandoTRA)
            {
                throw new Exception("ERROR: Clase: Logica.Tickets. Método: Codificar_CMS_TRA. Descripcion: " + exCodificandoTRA.Message);
            }

            return Base64_CMS_LoginTicket_Peticion;
        }

        /// <summary>
        /// Invoco al WebService de Autentificacion y Autorizacion (WSAA) con el CMS Firmado 
        /// y Recibo la respuesta Ticket de Autorizacion (TA)
        /// </summary>
        /// <param name="pPeticion_Firmada">CMS Firmado y Codificado</param>
        /// <param name="pCertificado_Peticion">Certificado de Peticion</param>
        /// <returns></returns>
        public string Obtener_TA_Respuesta(string pPeticion_Firmada, Entidades.CertificadosX509 pCertificado_Peticion)
        {
            string loginTicket_Respuesta = "";

            try
            {
                if(pCertificado_Peticion.UrlWsaaWsdl.StartsWith("https://wsaa.afip"))
                {
                    ar.gov.afip.wsaa.LoginCMSService servicioWSAA = new ar.gov.afip.wsaa.LoginCMSService();
                    servicioWSAA.Url = pCertificado_Peticion.UrlWsaaWsdl;
                    loginTicket_Respuesta = servicioWSAA.loginCms(pPeticion_Firmada);
                }
                else
                {                    
                    ar.gov.afip.wsaahomo.LoginCMSService servicioWSAA_Homologacion = new ar.gov.afip.wsaahomo.LoginCMSService();
                    servicioWSAA_Homologacion.Url = pCertificado_Peticion.UrlWsaaWsdl;
                    loginTicket_Respuesta = servicioWSAA_Homologacion.loginCms(pPeticion_Firmada);
                }                               
            }

            catch (Exception excepcionAlInvocarWsaa)
            {
                throw new Exception("ERROR: Clase: Logica.Tickets. Metodo: Obtener_XML_Respuesta. Detalle : " + excepcionAlInvocarWsaa.Message);
            }

            return loginTicket_Respuesta;
        }

        /// <summary>
        /// Obtengo la informacion del Ticket de Autorizacion (TA)
        /// y obtengo un objeto Ticket Autorizacion
        /// </summary>
        /// <param name="pLoginRespuesta">Respuesta TA</param>
        /// <returns></returns>
        public Entidades.Tickets_Acceso Obtener_Entidad_Respuesta(string pLoginRespuesta)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Rta = new Entidades.Tickets_Acceso();

            try
            {
                Xml_LoginTicket_Respuesta = new XmlDocument();
                Xml_LoginTicket_Respuesta.LoadXml(pLoginRespuesta);

                objEntidadesTicket_Rta.Id_Ticket = UInt32.Parse(Xml_LoginTicket_Respuesta.SelectSingleNode("//uniqueId").InnerText);
                objEntidadesTicket_Rta.Fecha_Generacion = DateTime.Parse(Xml_LoginTicket_Respuesta.SelectSingleNode("//generationTime").InnerText);
                objEntidadesTicket_Rta.Fecha_Expiracion = DateTime.Parse(Xml_LoginTicket_Respuesta.SelectSingleNode("//expirationTime").InnerText);
                objEntidadesTicket_Rta.Sign = Xml_LoginTicket_Respuesta.SelectSingleNode("//sign").InnerText;
                objEntidadesTicket_Rta.Token = Xml_LoginTicket_Respuesta.SelectSingleNode("//token").InnerText;
            }
            catch (Exception exAnalizarLoginTicketResponse)
            {
                throw new Exception("ERROR: Clase: Logica.Tickets. Metodo: Obtener_Entidad_Respuesta. Detalle: " + exAnalizarLoginTicketResponse.Message);
            }

            return objEntidadesTicket_Rta;
        }
    }
}
