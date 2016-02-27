using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Comprobantes_Autorizados
    {
        Datos.Comprobantes_Autorizados objDatosCbtesAutorizados = new Datos.Comprobantes_Autorizados();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Cbte Autorizado a la B.D.
        /// </summary>
        /// <param name="pCbtesAutorizados"></param>
        public void Agregar(Entidades.Comprobantes_Autorizados pCbtesAutorizados)
        {
            objDatosCbtesAutorizados.Agregar(pCbtesAutorizados);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Cbtes Autorizados de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosCbtesAutorizados.TraerTodos();

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Cbtes Autorizados a la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            objDatosCbtesAutorizados.BorrarTodos();
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Cbtes Autorizados de un Pto Venta 
        /// y Tipo Cbte especifido de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerCbtesEspecifico(int pPtoVenta, int pTipoCbte)
        {
            DataTable dt = new DataTable();

            dt = objDatosCbtesAutorizados.TraerCbtesEspecifico(pPtoVenta, pTipoCbte);

            return dt;
        }

        /// <summary>
        /// Delega a la Capa de Datos Borrar todos los Cbtes Autorizados de un Pto Venta 
        /// y Tipo Cbte especifido de la B.D.
        /// </summary>
        /// <returns></returns>
        public void BorrarCbtesEspecifico(int pPtoVenta, int pTipoCbte)
        {
            objDatosCbtesAutorizados.BorrarCbtesEspecifico(pPtoVenta, pTipoCbte);
        }
    }
}
