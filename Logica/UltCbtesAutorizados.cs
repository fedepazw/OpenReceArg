using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class UltCbtesAutorizados
    {
        Datos.UltCbtesAutorizados objDatosUltNroCbtes = new Datos.UltCbtesAutorizados();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Ultimo Cbte Autorizado a la B.D.
        /// </summary>
        /// <param name="pUltNroCbte"></param>
        public void Agregar(Entidades.UltCbtesAutorizados pUltNroCbte)
        {
            objDatosUltNroCbtes.Agregar(pUltNroCbte);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Ulimos Nros de Cbtes de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosUltNroCbtes.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Ultimos Nros de Cbtes a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosUltNroCbtes.BorrarTodos();
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver el Ulimo Nro de Cbte de la B.D.
        /// </summary>
        /// <returns>Ultimo Nro Cbte</returns>
        public long TraerUltNro(int pPtoVenta, int pTipoCbte)
        {
            long UltNroCbte = 0;

            UltNroCbte = objDatosUltNroCbtes.TraerUltNro(pPtoVenta, pTipoCbte);

            return UltNroCbte;
        }
    }
}
