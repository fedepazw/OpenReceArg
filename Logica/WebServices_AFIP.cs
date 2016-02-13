using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class WebServices_AFIP
    {
        /// <summary>
        /// Llama al WebService FEParamGetTiposPaises
        /// Devuelve los Códigos de Paises y su descripción.
        /// Guarda en la B.D. el Código de País y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposPaises(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposPaises
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.FEPaisResponse respuesta = new ar.gov.afip.wswhomo.FEPaisResponse();
            /*Paises Recuperados*/
            Entidades.Paises objEntidadesPaises = new Entidades.Paises();
            Logica.Paises objLogicaPaises = new Logica.Paises();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposPaises(autorizacion);
            
            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposPaises";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposPaises";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Pais devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaPaises.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.PaisTipo paisItem in respuesta.ResultGet)
                {
                    objEntidadesPaises.Id_Pais = paisItem.Id;
                    objEntidadesPaises.Descripcion = paisItem.Desc;

                    objLogicaPaises.Agregar(objEntidadesPaises);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposCbtes
        /// Devuelve los Códigos de Tipos Comprobantes y su descripción.
        /// Guarda en la B.D. el Código de Comprobantes y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposCbtes(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposCbtes
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.CbteTipoResponse respuesta = new ar.gov.afip.wswhomo.CbteTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposCbtes objEntidadesTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposCbte(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposCbtes";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposCbtes";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Tipo Comprobante devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposCbtes.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.CbteTipo cbteTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposCbtes.Id_TipoCbte = cbteTipoItem.Id;
                    objEntidadesTiposCbtes.Descripcion = cbteTipoItem.Desc;
                    if (cbteTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposCbtes.FchDesde = DateTime.ParseExact(cbteTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (cbteTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposCbtes.FchHasta = DateTime.ParseExact(cbteTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposCbtes.Agregar(objEntidadesTiposCbtes);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposConcepto
        /// Devuelve los Códigos de Tipos Conceptos y su descripción.
        /// Guarda en la B.D. el Tipo Concepto y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposConcepto(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposConcepto
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.ConceptoTipoResponse respuesta = new ar.gov.afip.wswhomo.ConceptoTipoResponse();
            /*Tipos de Conceptos Recuperados*/
            Entidades.TiposConceptos objEntidadesTiposConceptos = new Entidades.TiposConceptos();
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposConcepto(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposConceptos";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposConceptos";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Concepto devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposConceptos.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.ConceptoTipo conceptoTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposConceptos.Id_TipoConcepto = conceptoTipoItem.Id;
                    objEntidadesTiposConceptos.Descripcion = conceptoTipoItem.Desc;
                    if (conceptoTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposConceptos.FchDesde = DateTime.ParseExact(conceptoTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (conceptoTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposConceptos.FchHasta = DateTime.ParseExact(conceptoTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposConceptos.Agregar(objEntidadesTiposConceptos);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposDoc
        /// Devuelve los Códigos de Tipos Documentos y su descripción.
        /// Guarda en la B.D. el Tipo Documentos y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposDoc(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposDoc
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.DocTipoResponse respuesta = new ar.gov.afip.wswhomo.DocTipoResponse();
            /*Tipos de Documentos Recuperados*/
            Entidades.TiposDocumentos objEntidadesTiposDocumento = new Entidades.TiposDocumentos();
            Logica.TiposDocumentos objLogicaTiposDocumento = new Logica.TiposDocumentos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposDoc(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposDoc";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposDoc";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposDocumento.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.DocTipo documentoTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposDocumento.Id_TipoDocumento = documentoTipoItem.Id;
                    objEntidadesTiposDocumento.Descripcion = documentoTipoItem.Desc;
                    if (documentoTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposDocumento.FchDesde = DateTime.ParseExact(documentoTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (documentoTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposDocumento.FchHasta = DateTime.ParseExact(documentoTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposDocumento.Agregar(objEntidadesTiposDocumento);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;

            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposIva
        /// Devuelve los Códigos de Tipos Iva y su descripción.
        /// Guarda en la B.D. el Tipo Iva y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposIva(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposIva
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.IvaTipoResponse respuesta = new ar.gov.afip.wswhomo.IvaTipoResponse();
            /*Tipos de Iva Recuperados*/
            Entidades.TiposIva objEntidadesTiposIva = new Entidades.TiposIva();
            Logica.TiposIva objLogicaTiposIva = new Logica.TiposIva();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposIva(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposIva";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposIva";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposIva.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.IvaTipo ivaTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposIva.Id_TipoIva = ivaTipoItem.Id;
                    objEntidadesTiposIva.Descripcion = ivaTipoItem.Desc;
                    if (ivaTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposIva.FchDesde = DateTime.ParseExact(ivaTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (ivaTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposIva.FchHasta = DateTime.ParseExact(ivaTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposIva.Agregar(objEntidadesTiposIva);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposMonedas
        /// Devuelve los Códigos de Tipos Monedas y su descripción.
        /// Guarda en la B.D. el Tipo Monedas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposMonedas(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposMonedas
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.MonedaResponse respuesta = new ar.gov.afip.wswhomo.MonedaResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposMonedas objEntidadesTiposMonedas = new Entidades.TiposMonedas();
            Logica.TiposMonedas objLogicaTiposMonedas = new Logica.TiposMonedas();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposMonedas(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposMonedas";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposMonedas";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposMonedas.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.Moneda monedaTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposMonedas.Id_TipoMoneda = monedaTipoItem.Id;
                    objEntidadesTiposMonedas.Descripcion = monedaTipoItem.Desc;
                    if (monedaTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposMonedas.FchDesde = DateTime.ParseExact(monedaTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (monedaTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposMonedas.FchHasta = DateTime.ParseExact(monedaTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposMonedas.Agregar(objEntidadesTiposMonedas);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposOpcionales
        /// Devuelve los Códigos de Tipos Opcionales y su descripción.
        /// Guarda en la B.D. el Tipo Opcionales y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposOpcionales(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposOpcionales
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.OpcionalTipoResponse respuesta = new ar.gov.afip.wswhomo.OpcionalTipoResponse();
            /*Tipos Opcionales Recuperados*/
            Entidades.TiposOpcionales objEntidadesTiposOpcionales = new Entidades.TiposOpcionales();
            Logica.TiposOpcionales objLogicaTiposOpcionales = new Logica.TiposOpcionales();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposOpcional(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposOpcionales";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposOpcionales";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposOpcionales.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.OpcionalTipo opcionalTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposOpcionales.Id_TipoOpcional = opcionalTipoItem.Id;
                    objEntidadesTiposOpcionales.Descripcion = opcionalTipoItem.Desc;
                    if (opcionalTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposOpcionales.FchDesde = DateTime.ParseExact(opcionalTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (opcionalTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposOpcionales.FchHasta = DateTime.ParseExact(opcionalTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposOpcionales.Agregar(objEntidadesTiposOpcionales);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposTributos
        /// Devuelve los Códigos de Tipos de Tributos y su descripción.
        /// Guarda en la B.D. el Tipo de Tributos y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposTributos(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposTributos
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.FETributoResponse respuesta = new ar.gov.afip.wswhomo.FETributoResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposTributos objEntidadesTiposTributos = new Entidades.TiposTributos();
            Logica.TiposTributos objLogicaTiposTributos = new Logica.TiposTributos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();
            /*Configuracion (CUIT)*/
            Entidades.Configuracion_Certificado objEntidadesConf_Cert = new Entidades.Configuracion_Certificado();
            Logica.Configuracion_Certificado objLogicaConf_Cert = new Logica.Configuracion_Certificado();
            objEntidadesConf_Cert = objLogicaConf_Cert.TraerConfiguracion();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = objEntidadesConf_Cert.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            ar.gov.afip.wswhomo.Service webService = new ar.gov.afip.wswhomo.Service();
            respuesta = webService.FEParamGetTiposTributos(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (ar.gov.afip.wswhomo.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposTributos";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (ar.gov.afip.wswhomo.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposTributos";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposTributos.BorrarTodos();

                foreach (ar.gov.afip.wswhomo.TributoTipo tributoTipoItem in respuesta.ResultGet)
                {
                    objEntidadesTiposTributos.Id_TipoTributo = tributoTipoItem.Id;
                    objEntidadesTiposTributos.Descripcion = tributoTipoItem.Desc;
                    if (tributoTipoItem.FchDesde != "NULL")
                    {
                        objEntidadesTiposTributos.FchDesde = DateTime.ParseExact(tributoTipoItem.FchDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }
                    if (tributoTipoItem.FchHasta != "NULL")
                    {
                        objEntidadesTiposTributos.FchHasta = DateTime.ParseExact(tributoTipoItem.FchHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    objLogicaTiposTributos.Agregar(objEntidadesTiposTributos);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }
    }
}
