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
    public partial class frmTiposIva : Form
    {
        public frmTiposIva()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form
        /// Caraga los Tipos de Conceptos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTiposIva_Load(object sender, EventArgs e)
        {
            TraerTodos();
        }

        /// <summary>
        /// Carga el DataGrid los Tipos de Iva desde la B.D.
        /// </summary>
        void TraerTodos()
        {
            Logica.TiposIva objLogicaTiposIva = new Logica.TiposIva();

            dgvTiposIva.DataSource = objLogicaTiposIva.TraerTodos();
        }

        /// <summary>
        /// Control del Botón Actualizar Tipos Iva
        /// Llama al WebService para obtener los Tipos de Iva y guardarlos en la B.D.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizarTiposIva_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();

            //Llamo al Webservice de Documentos para recuperar los Paises
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objLogicaWebServiceAfip.FEParamGetTiposIva(objEntidadesTicket_Acceso) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
            {
                MessageBox.Show("Tipos de Iva actualizados desde el WebService");
            }
            else
            {
                MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
            }

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
