using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class PtosVenta
    {
        Datos.PtosVenta objDatosPtosVenta = new Datos.PtosVenta();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Punto de Venta a la B.D.
        /// </summary>
        /// <param name="pTipoTributo"></param>
        public void Agregar(Entidades.PtosVenta pPtoVenta)
        {
            objDatosPtosVenta.Agregar(pPtoVenta);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Puntos de Venta de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosPtosVenta.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Puntos de Venta a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosPtosVenta.BorrarTodos();
        }
    }
}
