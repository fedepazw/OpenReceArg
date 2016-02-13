using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Errores_WS
    {
        Datos.Errores_WS objDatosErroresWS = new Datos.Errores_WS();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Errores ES a la B.D.
        /// </summary>
        /// <param name="pErroresWS"></param>
        public void Agregar(Entidades.Errores_WS pErroresWS)
        {
            objDatosErroresWS.Agregar(pErroresWS);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Errores WS de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosErroresWS.TraerTodos();

            return dt;
        }
    }
}
