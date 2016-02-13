using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposMonedas
    {
        Datos.TiposMonedas objDatosTiposMoneda = new Datos.TiposMonedas();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Moneda a la B.D.
        /// </summary>
        /// <param name="pTipoMoneda"></param>
        public void Agregar(Entidades.TiposMonedas pTipoMoneda)
        {
            objDatosTiposMoneda.Agregar(pTipoMoneda);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Moneda de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposMoneda.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Tipos de Moneda a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposMoneda.BorrarTodos();
        }
    }
}
