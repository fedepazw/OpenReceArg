using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ArchExcel
    {
        /// <summary>
        /// Delega a la capa de datos la exportacion a un archivo XLSX
        /// </summary>
        /// <param name="pDTable">DataTable a Guardar</param>
        /// <param name="pNombreArchivo">Nombre del Archivo</param>
        public void guardarArchivoExcel(DataTable pDTable, string pNombreHoja, string pNombreArchivo)
        {
            Datos.ArchExcel objDatosArchExcel = new Datos.ArchExcel();

            objDatosArchExcel.guardarArchivoExcel(pDTable, pNombreHoja, pNombreArchivo);
        }
    }
}
