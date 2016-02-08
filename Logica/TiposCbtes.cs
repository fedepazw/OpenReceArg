using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposCbtes
    {
        Datos.TiposCbtes objDatosTiposCbtes = new Datos.TiposCbtes();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Comprobante a la B.D.
        /// </summary>
        /// <param name="pPais"></param>
        public void Agregar(Entidades.TiposCbtes pTipoCbte)
        {
            objDatosTiposCbtes.Agregar(pTipoCbte);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Comprobantes de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposCbtes.TraerTodos();

            return dt;
        }
    }
}
