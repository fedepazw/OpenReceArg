using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Paises
    {
        Datos.Paises objDatosPaises = new Datos.Paises();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Pais a la B.D.
        /// </summary>
        /// <param name="pPais"></param>
        public void Agregar(Entidades.Paises pPais)
        {
            objDatosPaises.Agregar(pPais);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver todos los Paises de la B.D.
        /// </summary>
        /// <returns></returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();

            dt = objDatosPaises.TraerTodos();

            return dt;
        }
    }
}
