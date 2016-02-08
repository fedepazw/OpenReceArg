using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace Entidades
{
    public class CertificadosX509
    {
        //Atributos del Certificado               
        
        private string urlWsaaWsdl;
        /// <summary>
        /// Dirección URL del WSAA WSDL
        /// </summary>
        public string UrlWsaaWsdl
        {
            get { return urlWsaaWsdl; }
            set { urlWsaaWsdl = value; }
        }

        private string idServicioNegocio;
        /// <summary>
        /// Identificador del Servicio de Negocio
        /// </summary>
        public string IdServicioNegocio
        {
            get { return idServicioNegocio; }
            set { idServicioNegocio = value; }
        }

    }
}
