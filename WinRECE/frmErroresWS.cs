using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenRECE
{
    public partial class frmErroresWS : Form
    {
        
        public frmErroresWS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Errores WS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmErroresWS_Load(object sender, EventArgs e)
        {
            configuraArchivoExcel();
            TraerTodos();
        }

        /// <summary>
        /// Configura los parámetros del Archivo Excel
        /// </summary>
        private void configuraArchivoExcel()
        {            
            saveFileDialogExcel.Title = "Guardar Archivo de Logs de Errores";
            saveFileDialogExcel.AddExtension = true;
            saveFileDialogExcel.DefaultExt = ".xlsx";
            saveFileDialogExcel.FileName = "OR_LogErrores_";
            saveFileDialogExcel.Filter = "Archivo de Excel 2007 (*.xlsx)|*.xlsx";
            saveFileDialogExcel.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        /// <summary>
        /// Carga el DataGrid los Errores desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();

            dgvErroresWS.DataSource = objLogicaErroresWS.TraerTodos();
        }

        /// <summary>
        /// Cierra la ventana actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Control del Botón Exportar a Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            exportarExcel();
        }

        /// <summary>
        /// Exporta a Excel el DataTable
        /// </summary>
        private void exportarExcel()
        {
            string fechaActual;
            string nombreHojaExcel;

            /*Asigno un nombre de Archivo*/
            fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmm");
            saveFileDialogExcel.FileName = saveFileDialogExcel.FileName + fechaActual;

            if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                Logica.Errores_WS objLogicaErroresWS = new Logica.Errores_WS();
                DataTable datosAExportar;

                Logica.ArchExcel objLogicaArchExcel = new Logica.ArchExcel();

                /*Asigno Nombre a la Hoja de Excel*/
                nombreHojaExcel = "Log de Errores";

                /*Creo el DataTable a Exportar*/
                datosAExportar = objLogicaErroresWS.TraerTodos();

                objLogicaArchExcel.guardarArchivoExcel(datosAExportar, nombreHojaExcel, saveFileDialogExcel.FileName);

                frmAbrirArchivo objAbrirArch = new frmAbrirArchivo();

                if (objAbrirArch.ShowDialog() == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(saveFileDialogExcel.FileName);
                }
            }
        }
    }
}
