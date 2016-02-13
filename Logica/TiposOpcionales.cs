using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposOpcionales
    {
        Datos.TiposOpcionales objDatosTiposOpcional = new Datos.TiposOpcionales();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo Opcional a la B.D.
        /// </summary>
        /// <param name="pTipoOpcional"></param>
        public void Agregar(Entidades.TiposOpcionales pTipoOpcional)
        {
            objDatosTiposOpcional.Agregar(pTipoOpcional);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos Opcional de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposOpcional.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Tipos Opcional a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposOpcional.BorrarTodos();
        }
    }
}
