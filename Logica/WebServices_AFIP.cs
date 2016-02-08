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
        /// Guarda en la B.D. el Código de País y su descripción
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

            /*Por cada Pais devuelto lo agrego en la B.D.*/
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
    }
}
