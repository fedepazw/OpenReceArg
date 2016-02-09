﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenRECE
{
    public partial class frmTiposDocumentos : Form
    {
        public frmTiposDocumentos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Tipos de Conceptos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposDocumentos_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Documentos desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposDocumentos objLogicaTiposDocumentos = new Logica.TiposDocumentos();

            dgvTiposDocumentos.DataSource = objLogicaTiposDocumentos.TraerTodos();
        }

        /// <summary>
        /// Control del Botón Actualizar Tipos Documentos
        /// Llama al WebService para obtener los Tipos de Documentos y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposDocumentos_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice de Documentos para recuperar los Paises
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();
            objLogicaWebServiceAfip.FEParamGetTiposDoc(objEntidadesTicket_Acceso);
            MessageBox.Show("Tipos de Documentos actualizados desde el WebService");
            TraerTodos();
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
    }
}