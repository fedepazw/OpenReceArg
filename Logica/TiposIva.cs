using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposIva
    {
        Datos.TiposIva objDatosTiposIva = new Datos.TiposIva();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Iva a la B.D.
        /// </summary>
        /// <param name="pTipoIva"></param>
        public void Agregar(Entidades.TiposIva pTipoIva)
        {
            objDatosTiposIva.Agregar(pTipoIva);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Iva de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposIva.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Tipos de Iva a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposIva.BorrarTodos();
        }
    }
}
