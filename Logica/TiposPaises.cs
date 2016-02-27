using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposPaises
    {
        Datos.TiposPaises objDatosTiposPaises = new Datos.TiposPaises();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Pais a la B.D.
        /// </summary>
        /// <param name="pPais"></param>
        public void Agregar(Entidades.TiposPaises pPais)
        {
            objDatosTiposPaises.Agregar(pPais);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Paises de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposPaises.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Paises a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposPaises.BorrarTodos();
        }
    }
}
