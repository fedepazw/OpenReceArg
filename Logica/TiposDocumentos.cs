using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposDocumentos
    {
        Datos.TiposDocumentos objDatosTiposDocumentos = new Datos.TiposDocumentos();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Documentos a la B.D.
        /// </summary>
        /// <param name="pTipoDocumento"></param>
        public void Agregar(Entidades.TiposDocumentos pTipoDocumento)
        {
            objDatosTiposDocumentos.Agregar(pTipoDocumento);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Documentos de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposDocumentos.TraerTodos();

            return dt;
        }
    }
}
