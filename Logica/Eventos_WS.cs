using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Eventos_WS
    {
        Datos.Eventos_WS objDatosEventosWS = new Datos.Eventos_WS();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Eventos ES a la B.D.
        /// </summary>
        /// <param name="pEventoWS"></param>
        public void Agregar(Entidades.Eventos_WS pEventosWS)
        {
            objDatosEventosWS.Agregar(pEventosWS);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Eventos WS de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosEventosWS.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Eventos a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosEventosWS.BorrarTodos();
        }
    }
}
