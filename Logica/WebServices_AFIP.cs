using System;
using System.Collections.Generic;
using System.Data;
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposPaises
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.FEPaisResponse respuesta = new AFIP_WSFEV1_Produccion.FEPaisResponse();

            /*Paises Recuperados*/
            Entidades.TiposPaises objEntidadesPaises = new Entidades.TiposPaises();
            Logica.TiposPaises objLogicaPaises = new Logica.TiposPaises();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposPaises(autorizacion);
            
            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.PaisTipo paisItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposPaises (Homologacion)
        /// Devuelve los Códigos de Paises y su descripción.
        /// Guarda en la B.D. el Código de País y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposPaises_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposPaises
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.FEPaisResponse respuesta = new AFIP_WSFEV1_Homologacion.FEPaisResponse();

            /*Paises Recuperados*/
            Entidades.TiposPaises objEntidadesPaises = new Entidades.TiposPaises();
            Logica.TiposPaises objLogicaPaises = new Logica.TiposPaises();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposPaises(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposPaises (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposPaises (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Pais devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaPaises.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.PaisTipo paisItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposCbtes
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.CbteTipoResponse respuesta = new AFIP_WSFEV1_Produccion.CbteTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposCbtes objEntidadesTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposCbte(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.CbteTipo cbteTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposCbtes (Homologacion)
        /// Devuelve los Códigos de Tipos Comprobantes y su descripción.
        /// Guarda en la B.D. el Código de Comprobantes y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposCbtes_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposCbtes
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.CbteTipoResponse respuesta = new AFIP_WSFEV1_Homologacion.CbteTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposCbtes objEntidadesTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposCbte(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposCbtes (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposCbtes (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Tipo Comprobante devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposCbtes.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.CbteTipo cbteTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposConcepto
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.ConceptoTipoResponse respuesta = new AFIP_WSFEV1_Produccion.ConceptoTipoResponse();
            /*Tipos de Conceptos Recuperados*/
            Entidades.TiposConceptos objEntidadesTiposConceptos = new Entidades.TiposConceptos();
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposConcepto(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.ConceptoTipo conceptoTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposConcepto (Homologacion)
        /// Devuelve los Códigos de Tipos Conceptos y su descripción.
        /// Guarda en la B.D. el Tipo Concepto y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposConcepto_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposConcepto
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.ConceptoTipoResponse respuesta = new AFIP_WSFEV1_Homologacion.ConceptoTipoResponse();
            /*Tipos de Conceptos Recuperados*/
            Entidades.TiposConceptos objEntidadesTiposConceptos = new Entidades.TiposConceptos();
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposConcepto(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposConceptos (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposConceptos (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Concepto devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposConceptos.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.ConceptoTipo conceptoTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposDoc
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.DocTipoResponse respuesta = new AFIP_WSFEV1_Produccion.DocTipoResponse();
            /*Tipos de Documentos Recuperados*/
            Entidades.TiposDocumentos objEntidadesTiposDocumento = new Entidades.TiposDocumentos();
            Logica.TiposDocumentos objLogicaTiposDocumento = new Logica.TiposDocumentos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposDoc(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.DocTipo documentoTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposDoc (Homologacion)
        /// Devuelve los Códigos de Tipos Documentos y su descripción.
        /// Guarda en la B.D. el Tipo Documentos y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposDoc_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposDoc
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.DocTipoResponse respuesta = new AFIP_WSFEV1_Homologacion.DocTipoResponse();
            /*Tipos de Documentos Recuperados*/
            Entidades.TiposDocumentos objEntidadesTiposDocumento = new Entidades.TiposDocumentos();
            Logica.TiposDocumentos objLogicaTiposDocumento = new Logica.TiposDocumentos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposDoc(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposDoc (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposDoc (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposDocumento.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.DocTipo documentoTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposIva
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.IvaTipoResponse respuesta = new AFIP_WSFEV1_Produccion.IvaTipoResponse();
            /*Tipos de Iva Recuperados*/
            Entidades.TiposIva objEntidadesTiposIva = new Entidades.TiposIva();
            Logica.TiposIva objLogicaTiposIva = new Logica.TiposIva();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposIva(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.IvaTipo ivaTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposIva (Homologacion)
        /// Devuelve los Códigos de Tipos Iva y su descripción.
        /// Guarda en la B.D. el Tipo Iva y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposIva_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposIva
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.IvaTipoResponse respuesta = new AFIP_WSFEV1_Homologacion.IvaTipoResponse();
            /*Tipos de Iva Recuperados*/
            Entidades.TiposIva objEntidadesTiposIva = new Entidades.TiposIva();
            Logica.TiposIva objLogicaTiposIva = new Logica.TiposIva();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposIva(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposIva (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposIva (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposIva.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.IvaTipo ivaTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposMonedas
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.MonedaResponse respuesta = new AFIP_WSFEV1_Produccion.MonedaResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposMonedas objEntidadesTiposMonedas = new Entidades.TiposMonedas();
            Logica.TiposMonedas objLogicaTiposMonedas = new Logica.TiposMonedas();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposMonedas(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.Moneda monedaTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposMonedas (Homologacion)
        /// Devuelve los Códigos de Tipos Monedas y su descripción.
        /// Guarda en la B.D. el Tipo Monedas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposMonedas_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposMonedas
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.MonedaResponse respuesta = new AFIP_WSFEV1_Homologacion.MonedaResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposMonedas objEntidadesTiposMonedas = new Entidades.TiposMonedas();
            Logica.TiposMonedas objLogicaTiposMonedas = new Logica.TiposMonedas();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposMonedas(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposMonedas (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposMonedas (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposMonedas.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.Moneda monedaTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposOpcionales
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.OpcionalTipoResponse respuesta = new AFIP_WSFEV1_Produccion.OpcionalTipoResponse();
            /*Tipos Opcionales Recuperados*/
            Entidades.TiposOpcionales objEntidadesTiposOpcionales = new Entidades.TiposOpcionales();
            Logica.TiposOpcionales objLogicaTiposOpcionales = new Logica.TiposOpcionales();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposOpcional(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.OpcionalTipo opcionalTipoItem in respuesta.ResultGet)
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
        /// Llama al WebService FEParamGetTiposOpcionales (Homologacion)
        /// Devuelve los Códigos de Tipos Opcionales y su descripción.
        /// Guarda en la B.D. el Tipo Opcionales y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposOpcionales_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposOpcionales
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.OpcionalTipoResponse respuesta = new AFIP_WSFEV1_Homologacion.OpcionalTipoResponse();
            /*Tipos Opcionales Recuperados*/
            Entidades.TiposOpcionales objEntidadesTiposOpcionales = new Entidades.TiposOpcionales();
            Logica.TiposOpcionales objLogicaTiposOpcionales = new Logica.TiposOpcionales();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposOpcional(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposOpcionales (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposOpcionales (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposOpcionales.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.OpcionalTipo opcionalTipoItem in respuesta.ResultGet)
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
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposTributos
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.FETributoResponse respuesta = new AFIP_WSFEV1_Produccion.FETributoResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposTributos objEntidadesTiposTributos = new Entidades.TiposTributos();
            Logica.TiposTributos objLogicaTiposTributos = new Logica.TiposTributos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetTiposTributos(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
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
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
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

                foreach (AFIP_WSFEV1_Produccion.TributoTipo tributoTipoItem in respuesta.ResultGet)
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

        /// <summary>
        /// Llama al WebService FEParamGetTiposTributos (Homologacion)
        /// Devuelve los Códigos de Tipos de Tributos y su descripción.
        /// Guarda en la B.D. el Tipo de Tributos y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetTiposTributos_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposTributos
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.FETributoResponse respuesta = new AFIP_WSFEV1_Homologacion.FETributoResponse();
            /*Tipos de Monedas Recuperados*/
            Entidades.TiposTributos objEntidadesTiposTributos = new Entidades.TiposTributos();
            Logica.TiposTributos objLogicaTiposTributos = new Logica.TiposTributos();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetTiposTributos(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetTiposTributos (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetTiposTributos (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaTiposTributos.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.TributoTipo tributoTipoItem in respuesta.ResultGet)
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

        /// <summary>
        /// Llama al WebService FEParamGetPtosVenta
        /// Devuelve los Puntos de Venta y su descripción.
        /// Guarda en la B.D. el Puntos de Ventas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetPtosVenta(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetPtosVenta
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.FEPtoVentaResponse respuesta = new AFIP_WSFEV1_Produccion.FEPtoVentaResponse();
            /*Puntos de Venta Recuperados*/
            Entidades.PtosVenta objEntidadesPtosVenta= new Entidades.PtosVenta();
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
            respuesta = webService.FEParamGetPtosVenta(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetPtosVenta";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetPtosVenta";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaPtosVenta.BorrarTodos();

                foreach (AFIP_WSFEV1_Produccion.PtoVenta ptoVentaItem in respuesta.ResultGet)
                {
                    objEntidadesPtosVenta.Id_PtoVenta = ptoVentaItem.Nro;
                    objEntidadesPtosVenta.EmisionTipo = ptoVentaItem.EmisionTipo;
                    objEntidadesPtosVenta.Bloqueado = Convert.ToChar(ptoVentaItem.Bloqueado);

                    if (ptoVentaItem.FchBaja != "NULL")
                    {
                        objEntidadesPtosVenta.FchBaja = DateTime.ParseExact(ptoVentaItem.FchBaja, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }


                    objLogicaPtosVenta.Agregar(objEntidadesPtosVenta);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }
        
        /// <summary>
        /// Llama al WebService FEParamGetPtosVenta (Homologacion)
        /// Devuelve los Puntos de Venta y su descripción.
        /// Guarda en la B.D. el Puntos de Ventas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FEParamGetPtosVenta_Homologacion(Entidades.Tickets_Acceso pTicket_Rta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetPtosVenta
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.FEPtoVentaResponse respuesta = new AFIP_WSFEV1_Homologacion.FEPtoVentaResponse();
            /*Puntos de Venta Recuperados*/
            Entidades.PtosVenta objEntidadesPtosVenta = new Entidades.PtosVenta();
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Llamo al WebService*/
            AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
            respuesta = webService.FEParamGetPtosVenta(autorizacion);

            /*Por cada Error devuelto lo agrego en la B.D.*/
            if (respuesta.Errors != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                {
                    objEntidadesErroresWS.Codigo = errorItem.Code;
                    objEntidadesErroresWS.Mensaje = errorItem.Msg;
                    objEntidadesErroresWS.Fecha = DateTime.Now;
                    objEntidadesErroresWS.Observaciones = "Llamando al WS: FEParamGetPtosVenta (Homologacion)";

                    objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
            }

            /*Por cada Evento devuelto lo agrego en la B.D.*/
            if (respuesta.Events != null)
            {
                foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                {
                    objEntidadesEventosWS.Codigo = eventoItem.Code;
                    objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                    objEntidadesEventosWS.Fecha = DateTime.Now;
                    objEntidadesEventosWS.Observaciones = "Llamando al WS: FEParamGetPtosVenta (Homologacion)";

                    objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
            }

            /*Por cada Documento devuelto lo agrego en la B.D.*/
            if (respuesta.ResultGet != null)
            {
                /*Primero Borra el listado de la base para cargarlo de Cero*/
                objLogicaPtosVenta.BorrarTodos();

                foreach (AFIP_WSFEV1_Homologacion.PtoVenta ptoVentaItem in respuesta.ResultGet)
                {
                    objEntidadesPtosVenta.Id_PtoVenta = ptoVentaItem.Nro;
                    objEntidadesPtosVenta.EmisionTipo = ptoVentaItem.EmisionTipo;
                    objEntidadesPtosVenta.Bloqueado = Convert.ToChar(ptoVentaItem.Bloqueado);

                    if (ptoVentaItem.FchBaja != "NULL")
                    {
                        objEntidadesPtosVenta.FchBaja = DateTime.ParseExact(ptoVentaItem.FchBaja, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    }


                    objLogicaPtosVenta.Agregar(objEntidadesPtosVenta);
                }

                objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FECompUltimoAutorizado
        /// Devuelve los Puntos de Venta y su descripción.
        /// Guarda en la B.D. el Puntos de Ventas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FECompUltimoAutorizado(Entidades.Tickets_Acceso pTicket_Rta, int pPtoVenta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FECompUltimoAutorizado
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.FERecuperaLastCbteResponse respuesta = new AFIP_WSFEV1_Produccion.FERecuperaLastCbteResponse();
            int cbteTipo = 0;
            /*Ultimos Nros de Comprobantes Recuperados*/
            Entidades.UltCbtesAutorizados objEntidadesUltNroCbte = new Entidades.UltCbtesAutorizados();
            Logica.UltCbtesAutorizados objLogicaUltNroCbte = new Logica.UltCbtesAutorizados();
            /*Tipos de Comprobantes*/
            Entidades.TiposCbtes objEntidadTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Tipos de Comprobantes*/
            objLogicaTiposCbtes.TraerTodos();

            /*Primero Borra el listado de la base para cargarlo de Cero*/
            objLogicaUltNroCbte.BorrarTodos();

            foreach (DataRow filaTipoCbte in objLogicaTiposCbtes.TraerTodos().Rows)
            {
                cbteTipo = Convert.ToInt32(filaTipoCbte[0]); //filaTipoCbte[0] Id_TipoCbte

                /*Llamo al WebService*/
                AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
                respuesta = webService.FECompUltimoAutorizado(autorizacion, pPtoVenta, cbteTipo);

                /*Por cada Error devuelto lo agrego en la B.D.*/
                if (respuesta.Errors != null)
                {
                    foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
                    {
                        objEntidadesErroresWS.Codigo = errorItem.Code;
                        objEntidadesErroresWS.Mensaje = errorItem.Msg;
                        objEntidadesErroresWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompUltimoAutorizado";

                        objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
                }

                /*Por cada Evento devuelto lo agrego en la B.D.*/
                if (respuesta.Events != null)
                {
                    foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
                    {
                        objEntidadesEventosWS.Codigo = eventoItem.Code;
                        objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                        objEntidadesEventosWS.Fecha = DateTime.Now;
                        objEntidadesEventosWS.Observaciones = "Llamando al WS: FECompUltimoAutorizado";

                        objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
                }

                /*Por cada Ultimo Nro Comprobante Autorizado devuelto lo agrego en la B.D.*/                
                if (respuesta.CbteTipo != 0)
                {
                    objEntidadesUltNroCbte.Id_PtoVenta = respuesta.PtoVta;
                    objEntidadesUltNroCbte.Id_TipoCbte = respuesta.CbteTipo;
                    objEntidadesUltNroCbte.Nro_Cbte = respuesta.CbteNro;

                    objLogicaUltNroCbte.Agregar(objEntidadesUltNroCbte);

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
                }
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FECompUltimoAutorizado (Homologacion)
        /// Devuelve los Puntos de Venta y su descripción.
        /// Guarda en la B.D. el Puntos de Ventas y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FECompUltimoAutorizado_Homologacion(Entidades.Tickets_Acceso pTicket_Rta, int pPtoVenta)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FECompUltimoAutorizado
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.FERecuperaLastCbteResponse respuesta = new AFIP_WSFEV1_Homologacion.FERecuperaLastCbteResponse();
            int cbteTipo = 0;
            /*Ultimos Nros de Comprobantes Recuperados*/
            Entidades.UltCbtesAutorizados objEntidadesUltNroCbte = new Entidades.UltCbtesAutorizados();
            Logica.UltCbtesAutorizados objLogicaUltNroCbte = new Logica.UltCbtesAutorizados();
            /*Tipos de Comprobantes*/
            Entidades.TiposCbtes objEntidadTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Tipos de Comprobantes*/
            objLogicaTiposCbtes.TraerTodos();

            /*Primero Borra el listado de la base para cargarlo de Cero*/
            objLogicaUltNroCbte.BorrarTodos();

            foreach (DataRow filaTipoCbte in objLogicaTiposCbtes.TraerTodos().Rows)
            {
                cbteTipo = Convert.ToInt32(filaTipoCbte[0]); //filaTipoCbte[0] Id_TipoCbte

                /*Llamo al WebService*/
                AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
                respuesta = webService.FECompUltimoAutorizado(autorizacion, pPtoVenta, cbteTipo);

                /*Por cada Error devuelto lo agrego en la B.D.*/
                if (respuesta.Errors != null)
                {
                    foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                    {
                        objEntidadesErroresWS.Codigo = errorItem.Code;
                        objEntidadesErroresWS.Mensaje = errorItem.Msg;
                        objEntidadesErroresWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompUltimoAutorizado";

                        objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
                }

                /*Por cada Evento devuelto lo agrego en la B.D.*/
                if (respuesta.Events != null)
                {
                    foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                    {
                        objEntidadesEventosWS.Codigo = eventoItem.Code;
                        objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                        objEntidadesEventosWS.Fecha = DateTime.Now;
                        objEntidadesEventosWS.Observaciones = "Llamando al WS: FECompUltimoAutorizado";

                        objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
                }

                /*Por cada Ultimo Nro Comprobante Autorizado devuelto lo agrego en la B.D.*/
                if (respuesta.CbteTipo != 0)
                {
                    objEntidadesUltNroCbte.Id_PtoVenta = respuesta.PtoVta;
                    objEntidadesUltNroCbte.Id_TipoCbte = respuesta.CbteTipo;
                    objEntidadesUltNroCbte.Nro_Cbte = respuesta.CbteNro;

                    objLogicaUltNroCbte.Agregar(objEntidadesUltNroCbte);

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
                }
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FECompConsultar
        /// Devuelve los Comprobantes ya aprobados.
        /// NOTA: El Servicio FECompConsultar funciona a partir del 28-07-2015, para comprobantes con fechas anteriores devuelve error
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FECompConsultar(Entidades.Tickets_Acceso pTicket_Rta, int pPtoVenta, int pTipoCbte)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://servicios1.afip.gov.ar/wsfev1/service.asmx?op=FECompConsultar
             */
            /*WebService*/
            AFIP_WSFEV1_Produccion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Produccion.FEAuthRequest();
            AFIP_WSFEV1_Produccion.FECompConsultaResponse respuesta = new AFIP_WSFEV1_Produccion.FECompConsultaResponse();
            /*Comprobante a Consultar*/
            AFIP_WSFEV1_Produccion.FECompConsultaReq cbteAConsultar = new AFIP_WSFEV1_Produccion.FECompConsultaReq();
            /*Comprobantes Recuperados*/
            Entidades.Comprobantes_Autorizados objEntidadesCbtesAutorizados = new Entidades.Comprobantes_Autorizados();
            Logica.Comprobantes_Autorizados objLogicaCbtesAutorizados = new Logica.Comprobantes_Autorizados();
            /*Comprobantes Recuperados*/
            Logica.UltCbtesAutorizados objLogicaUltCbteAutorizado = new Logica.UltCbtesAutorizados();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Asigno los datos al Comprobante a Consultar*/
            cbteAConsultar.PtoVta = pPtoVenta;
            cbteAConsultar.CbteTipo = pTipoCbte;

            /*Busco cual es el Ultimo Nro de Comprobante Autorizado para recorrer hasta ese*/
            long ultCbteAutorizado = objLogicaUltCbteAutorizado.TraerUltNro(cbteAConsultar.PtoVta, cbteAConsultar.CbteTipo);

            /*Primero Borra el listado de la base para cargarlo de Cero*/
            objLogicaCbtesAutorizados.BorrarCbtesEspecifico(cbteAConsultar.PtoVta, cbteAConsultar.CbteTipo);

            for (long i=1; i <= ultCbteAutorizado; i++)
            {
                /*Asigno el Nro a Comprobar*/
                cbteAConsultar.CbteNro = i;

                /*Llamo al WebService*/
                AFIP_WSFEV1_Produccion.Service webService = new AFIP_WSFEV1_Produccion.Service();
                respuesta = webService.FECompConsultar(autorizacion, cbteAConsultar);

                /*Por cada Error devuelto lo agrego en la B.D.*/
                if (respuesta.Errors != null)
                {
                    foreach (AFIP_WSFEV1_Produccion.Err errorItem in respuesta.Errors)
                    {
                        objEntidadesErroresWS.Codigo = errorItem.Code;
                        objEntidadesErroresWS.Mensaje = errorItem.Msg;
                        objEntidadesErroresWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompConsulta. Nro. Cbte = " + cbteAConsultar.CbteNro.ToString() + " Tipo Cbte = " + cbteAConsultar.CbteTipo.ToString() + " Punto Venta = " + cbteAConsultar.PtoVta.ToString();

                        objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
                }

                /*Por cada Evento devuelto lo agrego en la B.D.*/
                if (respuesta.Events != null)
                {
                    foreach (AFIP_WSFEV1_Produccion.Evt eventoItem in respuesta.Events)
                    {
                        objEntidadesEventosWS.Codigo = eventoItem.Code;
                        objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                        objEntidadesEventosWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompConsulta. Nro. Cbte = " + cbteAConsultar.CbteNro.ToString() + " Tipo Cbte = " + cbteAConsultar.CbteTipo.ToString() + " Punto Venta = " + cbteAConsultar.PtoVta.ToString();

                        objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
                }

                /*Por cada Comprobante Autorizado devuelto lo agrego en la B.D.*/
                if (respuesta.ResultGet != null)
                {
                    objEntidadesCbtesAutorizados.Id_PtoVenta = Convert.ToInt16(respuesta.ResultGet.PtoVta);
                    objEntidadesCbtesAutorizados.Id_TipoCbte = respuesta.ResultGet.CbteTipo;
                    objEntidadesCbtesAutorizados.Id_TipoConcepto = respuesta.ResultGet.Concepto;
                    objEntidadesCbtesAutorizados.Id_TipoDoc = respuesta.ResultGet.DocTipo;
                    objEntidadesCbtesAutorizados.DocNro = respuesta.ResultGet.DocNro;
                    objEntidadesCbtesAutorizados.Nro_CbteDesde = respuesta.ResultGet.CbteDesde;
                    objEntidadesCbtesAutorizados.Nro_CbteHasta = respuesta.ResultGet.CbteHasta;
                    objEntidadesCbtesAutorizados.CbteFch = DateTime.ParseExact(respuesta.ResultGet.CbteFch, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.ImpTotal = respuesta.ResultGet.ImpTotal;
                    objEntidadesCbtesAutorizados.ImpTotConc = respuesta.ResultGet.ImpTotConc;
                    objEntidadesCbtesAutorizados.ImpNeto = respuesta.ResultGet.ImpNeto;
                    objEntidadesCbtesAutorizados.ImpOpEx = respuesta.ResultGet.ImpOpEx;
                    objEntidadesCbtesAutorizados.ImpTrib = respuesta.ResultGet.ImpTrib;
                    objEntidadesCbtesAutorizados.ImpIVA = respuesta.ResultGet.ImpIVA;
                    objEntidadesCbtesAutorizados.FchServDesde = DateTime.ParseExact(respuesta.ResultGet.FchServDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchServHasta = DateTime.ParseExact(respuesta.ResultGet.FchServHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchVtoPago = DateTime.ParseExact(respuesta.ResultGet.FchVtoPago, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.Id_TipoMoneda = respuesta.ResultGet.MonId;
                    objEntidadesCbtesAutorizados.MonCotiz = respuesta.ResultGet.MonCotiz;
                    objEntidadesCbtesAutorizados.Resultado = respuesta.ResultGet.Resultado;
                    objEntidadesCbtesAutorizados.CodAutorizacion = respuesta.ResultGet.CodAutorizacion;
                    objEntidadesCbtesAutorizados.EmisionTipo = respuesta.ResultGet.EmisionTipo;
                    objEntidadesCbtesAutorizados.FchVto = DateTime.ParseExact(respuesta.ResultGet.FchVto, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchProceso = DateTime.ParseExact(respuesta.ResultGet.FchProceso, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

                    objLogicaCbtesAutorizados.Agregar(objEntidadesCbtesAutorizados);

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
                }
            }

            return objEntidadesWebService_AFIP_Rta;
        }

        /// <summary>
        /// Llama al WebService FECompConsultar (Homologacion)
        /// Devuelve los Comprobantes ya aprobados.
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public Entidades.WebServices_AFIP.RespuestaWS FECompConsultar_Homologacion(Entidades.Tickets_Acceso pTicket_Rta, int pPtoVenta, int pTipoCbte)
        {
            Entidades.WebServices_AFIP.RespuestaWS objEntidadesWebService_AFIP_Rta = new Entidades.WebServices_AFIP.RespuestaWS();
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FECompConsultar
             */
            /*WebService*/
            AFIP_WSFEV1_Homologacion.FEAuthRequest autorizacion = new AFIP_WSFEV1_Homologacion.FEAuthRequest();
            AFIP_WSFEV1_Homologacion.FECompConsultaResponse respuesta = new AFIP_WSFEV1_Homologacion.FECompConsultaResponse();
            /*Comprobante a Consultar*/
            AFIP_WSFEV1_Homologacion.FECompConsultaReq cbteAConsultar = new AFIP_WSFEV1_Homologacion.FECompConsultaReq();
            /*Comprobantes Recuperados*/
            Entidades.Comprobantes_Autorizados objEntidadesCbtesAutorizados = new Entidades.Comprobantes_Autorizados();
            Logica.Comprobantes_Autorizados objLogicaCbtesAutorizados = new Logica.Comprobantes_Autorizados();
            /*Comprobantes Recuperados*/
            Logica.UltCbtesAutorizados objLogicaUltCbteAutorizado = new Logica.UltCbtesAutorizados();
            /*Errores Devueltos*/
            Entidades.Errores_WS objEntidadesErroresWS = new Entidades.Errores_WS();
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
            /*Eventos Devueltos*/
            Entidades.Eventos_WS objEntidadesEventosWS = new Entidades.Eventos_WS();
            Logica.Eventos_WS objLogicaEventosWS = new Logica.Eventos_WS();

            /*Asigno los datos a la autorización*/
            autorizacion.Cuit = pTicket_Rta.Cuit;
            autorizacion.Sign = pTicket_Rta.Sign;
            autorizacion.Token = pTicket_Rta.Token;

            /*Asigno los datos al Comprobante a Consultar*/
            cbteAConsultar.PtoVta = pPtoVenta;
            cbteAConsultar.CbteTipo = pTipoCbte;

            /*Busco cual es el Ultimo Nro de Comprobante Autorizado para recorrer hasta ese*/
            long ultCbteAutorizado = objLogicaUltCbteAutorizado.TraerUltNro(cbteAConsultar.PtoVta, cbteAConsultar.CbteTipo);

            /*Primero Borra el listado de la base para cargarlo de Cero*/
            objLogicaCbtesAutorizados.BorrarCbtesEspecifico(cbteAConsultar.PtoVta, cbteAConsultar.CbteTipo);

            for (long i = 1; i <= ultCbteAutorizado; i++)
            {
                /*Asigno el Nro a Comprobar*/
                cbteAConsultar.CbteNro = i;

                /*Llamo al WebService*/
                AFIP_WSFEV1_Homologacion.Service webService = new AFIP_WSFEV1_Homologacion.Service();
                respuesta = webService.FECompConsultar(autorizacion, cbteAConsultar);

                /*Por cada Error devuelto lo agrego en la B.D.*/
                if (respuesta.Errors != null)
                {
                    foreach (AFIP_WSFEV1_Homologacion.Err errorItem in respuesta.Errors)
                    {
                        objEntidadesErroresWS.Codigo = errorItem.Code;
                        objEntidadesErroresWS.Mensaje = errorItem.Msg;
                        objEntidadesErroresWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompConsulta. Nro. Cbte = " + cbteAConsultar.CbteNro.ToString() + " Tipo Cbte = " + cbteAConsultar.CbteTipo.ToString() + " Punto Venta = " + cbteAConsultar.PtoVta.ToString();

                        objLogicaErroresWS.Agregar(objEntidadesErroresWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Error;
                }

                /*Por cada Evento devuelto lo agrego en la B.D.*/
                if (respuesta.Events != null)
                {
                    foreach (AFIP_WSFEV1_Homologacion.Evt eventoItem in respuesta.Events)
                    {
                        objEntidadesEventosWS.Codigo = eventoItem.Code;
                        objEntidadesEventosWS.Mensaje = eventoItem.Msg;
                        objEntidadesEventosWS.Fecha = DateTime.Now;
                        objEntidadesErroresWS.Observaciones = "Llamando al WS: FECompConsulta. Nro. Cbte = " + cbteAConsultar.CbteNro.ToString() + " Tipo Cbte = " + cbteAConsultar.CbteTipo.ToString() + " Punto Venta = " + cbteAConsultar.PtoVta.ToString();

                        objLogicaEventosWS.Agregar(objEntidadesEventosWS);
                    }

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Evento;
                }

                /*Por cada Comprobante Autorizado devuelto lo agrego en la B.D.*/
                if (respuesta.ResultGet != null)
                {
                    objEntidadesCbtesAutorizados.Id_PtoVenta = Convert.ToInt16(respuesta.ResultGet.PtoVta);
                    objEntidadesCbtesAutorizados.Id_TipoCbte = respuesta.ResultGet.CbteTipo;
                    objEntidadesCbtesAutorizados.Id_TipoConcepto = respuesta.ResultGet.Concepto;
                    objEntidadesCbtesAutorizados.Id_TipoDoc = respuesta.ResultGet.DocTipo;
                    objEntidadesCbtesAutorizados.DocNro = respuesta.ResultGet.DocNro;
                    objEntidadesCbtesAutorizados.Nro_CbteDesde = respuesta.ResultGet.CbteDesde;
                    objEntidadesCbtesAutorizados.Nro_CbteHasta = respuesta.ResultGet.CbteHasta;
                    objEntidadesCbtesAutorizados.CbteFch = DateTime.ParseExact(respuesta.ResultGet.CbteFch, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.ImpTotal = respuesta.ResultGet.ImpTotal;
                    objEntidadesCbtesAutorizados.ImpTotConc = respuesta.ResultGet.ImpTotConc;
                    objEntidadesCbtesAutorizados.ImpNeto = respuesta.ResultGet.ImpNeto;
                    objEntidadesCbtesAutorizados.ImpOpEx = respuesta.ResultGet.ImpOpEx;
                    objEntidadesCbtesAutorizados.ImpTrib = respuesta.ResultGet.ImpTrib;
                    objEntidadesCbtesAutorizados.ImpIVA = respuesta.ResultGet.ImpIVA;
                    objEntidadesCbtesAutorizados.FchServDesde = DateTime.ParseExact(respuesta.ResultGet.FchServDesde, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchServHasta = DateTime.ParseExact(respuesta.ResultGet.FchServHasta, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchVtoPago = DateTime.ParseExact(respuesta.ResultGet.FchVtoPago, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.Id_TipoMoneda = respuesta.ResultGet.MonId;
                    objEntidadesCbtesAutorizados.MonCotiz = respuesta.ResultGet.MonCotiz;
                    objEntidadesCbtesAutorizados.Resultado = respuesta.ResultGet.Resultado;
                    objEntidadesCbtesAutorizados.CodAutorizacion = respuesta.ResultGet.CodAutorizacion;
                    objEntidadesCbtesAutorizados.EmisionTipo = respuesta.ResultGet.EmisionTipo;
                    objEntidadesCbtesAutorizados.FchVto = DateTime.ParseExact(respuesta.ResultGet.FchVto, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    objEntidadesCbtesAutorizados.FchProceso = DateTime.ParseExact(respuesta.ResultGet.FchProceso, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

                    objLogicaCbtesAutorizados.Agregar(objEntidadesCbtesAutorizados);

                    objEntidadesWebService_AFIP_Rta = Entidades.WebServices_AFIP.RespuestaWS.Correcta;
                }
            }

            return objEntidadesWebService_AFIP_Rta;
        }

    }
}
