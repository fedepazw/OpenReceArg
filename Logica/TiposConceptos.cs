using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TiposConceptos
    {
        Datos.TiposConceptos objDatosTiposConceptos = new Datos.TiposConceptos();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Tipo de Concepto a la B.D.
        /// </summary>
        /// <param name="pTipoConcepto"></param>
        public void Agregar(Entidades.TiposConceptos pTipoConcepto)
        {
            objDatosTiposConceptos.Agregar(pTipoConcepto);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Tipos de Conceptos de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosTiposConceptos.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Tipos de Conceptos a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosTiposConceptos.BorrarTodos();
        }
    }
}
