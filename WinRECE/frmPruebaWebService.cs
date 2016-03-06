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
    public partial class frmPruebaWebService : Form
    {
        public frmPruebaWebService()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form y realiza las pruebas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPruebaWebService_Load(object sender, EventArgs e)
        {
            probarConexiones();
        }

        private void probarConexiones()
        {
            Logica.Internet objLogicaInternet = new Logica.Internet();

            if (objLogicaInternet.hayInternet())
            {
                lblEstadoConexInternet.ForeColor = Color.Green;
                lblEstadoConexInternet.Text = "OK";

                if (objLogicaInternet.estadoWS())
                {
                    lblEstadoWS.ForeColor = Color.Green;
                    lblEstadoWS.Text = "OK";
                }
                else
                {
                    lblEstadoWS.ForeColor = Color.Red;
                    lblEstadoWS.Text = "ERROR";
                }
            }
            else
            {
                lblEstadoConexInternet.ForeColor = Color.Red;
                lblEstadoConexInternet.Text = "ERROR";
                lblEstadoWS.ForeColor = Color.Red;
                lblEstadoWS.Text = "ERROR";
            }

        }

        /// <summary>
        /// Control del Botón de Prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            probarConexiones();
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
