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
    public partial class frmComprobantesAprobados : Form
    {
        public frmComprobantesAprobados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Carga el Combo de Ptos de Venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComprobantesAprobados_Load(object sender, EventArgs e)
        {            
            CargarComboPtosVenta();
            CargarComboTiposCbtes();
            TraerTodos(Convert.ToInt32(cboPtosVenta.SelectedValue), Convert.ToInt32(cboTipoCbte.SelectedValue));
        }

        /// <summary>
        /// Llena el combo box de Puntos de Venta        
        /// </summary>
        void CargarComboPtosVenta()
        {
            Logica.PtosVenta objLogicaPtosVenta = new Logica.PtosVenta();

            cboPtosVenta.DataSource = objLogicaPtosVenta.TraerTodos();
            cboPtosVenta.ValueMember = "Id_PtoVenta";
            cboPtosVenta.DisplayMember = "Id_PtoVenta";
        }

        /// <summary>
        /// Llena el combo box de Tipos de Comprobantes        
        /// </summary>
        void CargarComboTiposCbtes()
        {
            Logica.UltCbtesAutorizados objLogicaUltCbtesAutorizados = new Logica.UltCbtesAutorizados();

            cboTipoCbte.DataSource = objLogicaUltCbtesAutorizados.TraerTodos();
            cboTipoCbte.ValueMember = "Id_TipoCbte";
            cboTipoCbte.DisplayMember = "Descripcion";
        }

        /// <summary>
        /// Carga el DataGrid los Comprobantes Autorizados desde la B.D.
        /// </summary>
        void TraerTodos(int pPtoVenta, int pTipoCbte)
        {
            Logica.Comprobantes_Autorizados objLogicaCbtesAutorizados = new Logica.Comprobantes_Autorizados();

            if (chkFiltroNros.Checked == true)
            {
                dgvCbtesAutorizados.DataSource = objLogicaCbtesAutorizados.TraerCbtesEspecificoNro(pPtoVenta, pTipoCbte, Convert.ToInt32(txtNroCbteDesde.Text), Convert.ToInt32(txtNroCbteHasta.Text));
            }
            else
            {
                dgvCbtesAutorizados.DataSource = objLogicaCbtesAutorizados.TraerCbtesEspecifico(pPtoVenta, pTipoCbte);
            }
        }

        /// <summary>
        /// Controla que solo se carguen Nros. en el TextBox Nro. Desde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNroCbteDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Controla que solo se carguen Nros. en el TextBox Nro. Hasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNroCbteHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Actualiza los Text de los Filtros de Nros de Cbtes
        /// </summary>
        private void actualizarNrosCbtesFiltros()
        {
            Logica.Comprobantes_Autorizados objLogicaCbtesAutorizados = new Logica.Comprobantes_Autorizados();

            //Asigno Punto de Venta
            int ptoVenta = Convert.ToInt32(cboPtosVenta.SelectedValue);
            //Asigno Tipo de Comprobante
            int tipoCbte = Convert.ToInt32(cboTipoCbte.SelectedValue);

            txtNroCbteDesde.Text = (objLogicaCbtesAutorizados.MinimoNroCbteEspecifico(ptoVenta, tipoCbte)).ToString();
            txtNroCbteHasta.Text = (objLogicaCbtesAutorizados.MaximoNroCbteEspecifico(ptoVenta, tipoCbte)).ToString();
        }

        /// <summary>
        /// Control cuanto ComboBox de Punto de Venta cambia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPtosVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkFiltroNros.Checked == true)
            {
                actualizarNrosCbtesFiltros();
            }
        }

        /// <summary>
        /// Contol cuando ComboBox de Tipo de Comprobante cambia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboTipoCbte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkFiltroNros.Checked == true)
            {
                actualizarNrosCbtesFiltros();
            }
        }

        /// <summary>
        /// Muestra o no los filtros de Nros de Cbtes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkFiltroNros_CheckedChanged(object sender, EventArgs e)
        {

            if (chkFiltroNros.Checked == true)
            {
                actualizarNrosCbtesFiltros();

                lblNroCbteDesde.Visible = true;
                txtNroCbteDesde.Visible = true;
                lblNroCbteHasta.Visible = true;
                txtNroCbteHasta.Visible = true;
            }
            else
            {
                lblNroCbteDesde.Visible = false;
                txtNroCbteDesde.Visible = false;
                lblNroCbteHasta.Visible = false;
                txtNroCbteHasta.Visible = false;

            }
        }

        /// <summary>
        /// Control Botón Filtrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrarCbtes_Click(object sender, EventArgs e)
        {
            //Asigno Punto de Venta
            int ptoVenta = Convert.ToInt32(cboPtosVenta.SelectedValue);
            //Asigno Tipo de Comprobante
            int tipoCbte = Convert.ToInt32(cboTipoCbte.SelectedValue);

            TraerTodos(ptoVenta, tipoCbte);
        }

        /// <summary>
        /// Control Botón Actualizar desde AFIP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTraerCbtes_Click(object sender, EventArgs e)
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();
            Logica.Tickets_Acceso objLogicaTicket_Acceso = new Logica.Tickets_Acceso();
            Entidades.Comprobantes objEntidadesComprobantes = new Entidades.Comprobantes();            

            objEntidadesTicket_Acceso = objLogicaTicket_Acceso.TraerTicketActivo();
          
            //Asigno Punto de Venta
            int ptoVenta = Convert.ToInt32(cboPtosVenta.SelectedValue);
            //Asigno Tipo de Comprobante
            int tipoCbte = Convert.ToInt32(cboTipoCbte.SelectedValue);

            //Llamo al Webservice para recuperar los Comprobantes Aprobados
            Logica.WebServices_AFIP objLogicaWebServiceAfip = new Logica.WebServices_AFIP();

            if (objEntidadesTicket_Acceso.TipoAprobacion == 'P') //Producción
            {
                
                if (chkFiltroNros.Checked == true)
                {
                    /*WebService Producción*/
                    if (objLogicaWebServiceAfip.FECompConsultar(objEntidadesTicket_Acceso, ptoVenta, tipoCbte, Convert.ToInt64(txtNroCbteDesde.Text), Convert.ToInt64(txtNroCbteHasta.Text)) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        MessageBox.Show("Comprobantes Autorizados desde el WebService");
                    }
                    else
                    {
                        MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                    }
                }
                else
                {
                    /*WebService Producción*/
                    if (objLogicaWebServiceAfip.FECompConsultar(objEntidadesTicket_Acceso, ptoVenta, tipoCbte) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        MessageBox.Show("Comprobantes Autorizados desde el WebService");
                    }
                    else
                    {
                        MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                    }
                }

            }
            else
            {
                if (chkFiltroNros.Checked == true)
                {
                    /*WebService Homologacion*/
                    if (objLogicaWebServiceAfip.FECompConsultar_Homologacion(objEntidadesTicket_Acceso, ptoVenta, tipoCbte, Convert.ToInt64(txtNroCbteDesde.Text), Convert.ToInt64(txtNroCbteHasta.Text)) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        MessageBox.Show("Comprobantes Autorizados desde el WebService");
                    }
                    else
                    {
                        MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                    }
                }
                else
                {                    
                    /*WebService Homologacion*/
                    if (objLogicaWebServiceAfip.FECompConsultar_Homologacion(objEntidadesTicket_Acceso, ptoVenta, tipoCbte) == Entidades.WebServices_AFIP.RespuestaWS.Correcta)
                    {
                        MessageBox.Show("Comprobantes Autorizados desde el WebService");
                    }
                    else
                    {
                        MessageBox.Show("El WebService devolvió un Error/Evento. Por favor revise los Logs");
                    }
                }

            }
            TraerTodos(ptoVenta, tipoCbte);
        }

        /// <summary>
        /// Control del botón Imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocCbtesAutorizados.Print();
        }

        /// <summary>
        /// Crea la Imagen a Imprimir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocCbtesAutorizados_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgvCbtesAutorizados.Width, this.dgvCbtesAutorizados.Height);
            dgvCbtesAutorizados.DrawToBitmap(bm, new Rectangle(0, 0, this.dgvCbtesAutorizados.Width, this.dgvCbtesAutorizados.Height));
            e.Graphics.DrawImage(bm, 0, 0);
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
