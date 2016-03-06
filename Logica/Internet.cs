using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Internet
    {
        /// <summary>
        /// Detecta si hay conexión con internet
        /// </summary>
        /// <returns></returns>
        public bool hayInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Detecta si el WebService WSFEv1 de AFIP está funcionando
        /// </summary>
        /// <returns></returns>
        public bool estadoWS()
        {
            bool estado = false;

            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice para recuperar los Paises
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                /*WebService Producción*/
                if (objLogicaWebServiceAfip.FEDummy() == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }

            }
            else
            {
                /*WebService Homologacion*/
                if (objLogicaWebServiceAfip.FEDummy_Homologacion() == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
            }

            return estado;
        }
    }
}
