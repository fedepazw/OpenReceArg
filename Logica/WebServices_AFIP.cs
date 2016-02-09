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
        public void FEParamGetTiposPaises(Entidades.Tickets_Acceso pTicket_Rta)
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposPaises
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.FEPaisResponse respuesta = new ar.gov.afip.wswhomo.FEPaisResponse();
            /*Paises Recuperados*/
            Entidades.Paises objEntidadesPaises = new Entidades.Paises();
            Logica.Paises objLogicaPaises = new Logica.Paises();
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

            /*Por cada Pais devuelto lo agrego en la B.D.*/
            foreach (ar.gov.afip.wswhomo.PaisTipo paisItem in respuesta.ResultGet)
            {
                objEntidadesPaises.Id_Pais = paisItem.Id;
                objEntidadesPaises.Descripcion = paisItem.Desc;

                objLogicaPaises.Agregar(objEntidadesPaises);

            }

        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposCbtes
        /// Devuelve los Códigos de Tipos Comprobantes y su descripción.
        /// Guarda en la B.D. el Código de Comprobantes y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public void FEParamGetTiposCbtes(Entidades.Tickets_Acceso pTicket_Rta)
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposCbtes
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.CbteTipoResponse respuesta = new ar.gov.afip.wswhomo.CbteTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposCbtes objEntidadesTiposCbtes = new Entidades.TiposCbtes();
            Logica.TiposCbtes objLogicaTiposCbtes = new Logica.TiposCbtes();
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

            /*Por cada Tipo Comprobante devuelto lo agrego en la B.D.*/
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
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposConcepto
        /// Devuelve los Códigos de Tipos Conceptos y su descripción.
        /// Guarda en la B.D. el Tipo Concepto y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public void FEParamGetTiposConcepto(Entidades.Tickets_Acceso pTicket_Rta)
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposConcepto
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.ConceptoTipoResponse respuesta = new ar.gov.afip.wswhomo.ConceptoTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposConceptos objEntidadesTiposConceptos = new Entidades.TiposConceptos();
            Logica.TiposConceptos objLogicaTiposConceptos = new Logica.TiposConceptos();
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

            /*Por cada Concepto devuelto lo agrego en la B.D.*/
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
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposDoc
        /// Devuelve los Códigos de Tipos Documentos y su descripción.
        /// Guarda en la B.D. el Tipo Documentos y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public void FEParamGetTiposDoc(Entidades.Tickets_Acceso pTicket_Rta)
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposDoc
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.DocTipoResponse respuesta = new ar.gov.afip.wswhomo.DocTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposDocumentos objEntidadesTiposDocumento = new Entidades.TiposDocumentos();
            Logica.TiposDocumentos objLogicaTiposDocumento = new Logica.TiposDocumentos();
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

            /*Por cada Documento devuelto lo agrego en la B.D.*/
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
        }

        /// <summary>
        /// Llama al WebService FEParamGetTiposIva
        /// Devuelve los Códigos de Tipos Iva y su descripción.
        /// Guarda en la B.D. el Tipo Iva y su descripción
        /// </summary>
        /// <param name="pTicket_Rta"></param>
        public void FEParamGetTiposIva(Entidades.Tickets_Acceso pTicket_Rta)
        {
            /*
             * https://wswhomo.afip.gov.ar/wsfev1/service.asmx?op=FEParamGetTiposIva
             */
            /*WebService*/
            ar.gov.afip.wswhomo.FEAuthRequest autorizacion = new ar.gov.afip.wswhomo.FEAuthRequest();
            ar.gov.afip.wswhomo.IvaTipoResponse respuesta = new ar.gov.afip.wswhomo.IvaTipoResponse();
            /*Tipos de Cbtes Recuperados*/
            Entidades.TiposIva objEntidadesTiposIva = new Entidades.TiposIva();
            Logica.TiposIva objLogicaTiposIva = new Logica.TiposIva();
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

            /*Por cada Documento devuelto lo agrego en la B.D.*/
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
        }
    }
}
