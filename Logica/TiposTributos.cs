using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposTributos
    {
        Datos.TiposTributos objDatosTiposTributo = new Datos.TiposTributos();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Tributo a la B.D.
        /// </summary>
        /// <param name="pTipoTributo"></param>
        public void Agregar(Entidades.TiposTributos pTipoTributo)
        {
            objDatosTiposTributo.Agregar(pTipoTributo);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Tributo de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposTributo.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Tipos de Tributo a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposTributo.BorrarTodos();
        }
    }
}
