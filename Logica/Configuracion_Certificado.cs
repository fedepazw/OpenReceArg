using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Configuracion_Certificado
    {
        Datos.Configuracion_Certificado objDatosConfCertificado = new Datos.Configuracion_Certificado();

        /// <summary>
        /// Delega a la Capa da Datos agregar el Registro en ña B.D.
        /// </summary>
        /// <param name="pConfigCertificado">Objeto Certificado Configuracion</param>
        public void Agregar(Entidades.Configuracion_Certificado pConfigCertificado)
        {
            objDatosConfCertificado.Agregar(pConfigCertificado);
        }

        /// <summary>
        /// Delega a la Capa de Datos el modificar un Registro en la B.D.
        /// </summary>
        /// <param name="pConfigCertificado">Objeto Certificado Configuracion</param>
        public void Modificar(Entidades.Configuracion_Certificado pConfigCertificado)
        {
            objDatosConfCertificado.Modificar(pConfigCertificado);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver la configuracion de la B.D.
        /// </summary>
        /// <returns></returns>
        public Entidades.Configuracion_Certificado TraerConfiguracion()
        {
            Entidades.Configuracion_Certificado objEntidadesConfigCertificado = new Entidades.Configuracion_Certificado();

            objEntidadesConfigCertificado = objDatosConfCertificado.TraerConfiguracion();

            return objEntidadesConfigCertificado;
        }



    }
}
