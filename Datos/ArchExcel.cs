using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using ClosedXML.Excel;

namespace Datos
{
    public class ArchExcel
    {
        /// <summary>
        /// Guarda un Archivo XLSX (Excel 2007 o posterior)
        /// </summary>
        /// <param name="pDTable">DataTable con Datos a Guardar</param>
        /// <param name="pNombreArchivo">Nombre del Archivo</param>
        public void guardarArchivoExcel(DataTable pDTable, string pNombreHoja, string pNombreArchivo)
        {
            XLWorkbook wb = new XLWorkbook();
            string archivo = Path.GetFileNameWithoutExtension(pNombreArchivo);

            wb.Worksheets.Add(pDTable, pNombreHoja);
            wb.PageOptions.Header.Center.AddText("Documento: " + archivo + " generado con OpenRECE");
            wb.SaveAs(pNombreArchivo);
        }

    }
}
