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
    public partial class frmConfiguracionCertificado : Form
    {
        Entidades.Configuracion_Certificado objEntidadesConfiguracionCertificado = new Entidades.Configuracion_Certificado();

        public frmConfiguracionCertificado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del Form
        /// Busca en la Base si ya hay una configuración cargada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConfiguracionCertificado_Load(object sender, EventArgs e)
        {
            Logica.Configuracion_Certificado objLogicaConfiguracionCertificado = new Logica.Configuracion_Certificado();
            
            openArchCertificadoPFX.Title = "Elegir Certificado";
            openArchCertificadoPFX.Filter = "Archivo de Certificado (*.pfx)|*.pfx";
            openArchCertificadoPFX.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            objEntidadesConfiguracionCertificado = objLogicaConfiguracionCertificado.TraerConfiguracion();

            if (objEntidadesConfiguracionCertificado.Cuit != 0)
            {
                txtCuit.Text = objEntidadesConfiguracionCertificado.Cuit.ToString();
                txtArchCertificadoPFX.Text = objEntidadesConfiguracionCertificado.ArchivoCertificadoPFX;
                txtPFXPassword.Text = objEntidadesConfiguracionCertificado.PasswordPFX;
                
                if(objEntidadesConfiguracionCertificado.TipoAprobacion == 'P')
                {
                    rbServidorProduccion.Checked = true;
                }
            }


        }

        /// <summary>
        /// Valida que solo se carguen números en el Campo CUIT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Control del botón de Examinar Carpetas para buscar el Archivo Certificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchCertificadoPFX_Click(object sender, EventArgs e)
        {
            openArchCertificadoPFX.ShowDialog();
            txtArchCertificadoPFX.Text = openArchCertificadoPFX.FileName;    
        }

        /// <summary>
        /// Guarda la configuración en la B.D.
        /// La Agrega si es la primera vez o la actualiza si ya existe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarConf_Click(object sender, EventArgs e)
        {
            
            if (txtCuit.Text != "0" || txtArchCertificadoPFX.Text != "")
            {
                Logica.Configuracion_Certificado objLogicaConfiguracionCertificado = new Logica.Configuracion_Certificado();
                Entidades.Configuracion_Certificado objEntidadesConfiguracionCertificadoForm = new Entidades.Configuracion_Certificado();

                objEntidadesConfiguracionCertificadoForm.Cuit = Convert.ToInt64(txtCuit.Text);
                objEntidadesConfiguracionCertificadoForm.ArchivoCertificadoPFX = txtArchCertificadoPFX.Text;
                objEntidadesConfiguracionCertificadoForm.PasswordPFX = txtPFXPassword.Text;
                if (rbServidorProduccion.Checked == true)
                {
                    objEntidadesConfiguracionCertificadoForm.TipoAprobacion = 'P';
                }
                else
                {
                    objEntidadesConfiguracionCertificadoForm.TipoAprobacion = 'H';
                }

                if (objEntidadesConfiguracionCertificado.Cuit == 0) //No habia nada guardado previamente en la B.D.
                {
                    objLogicaConfiguracionCertificado.Agregar(objEntidadesConfiguracionCertificadoForm);
                    MessageBox.Show("Configuración Guardada");
                }
                else
                {
                    objLogicaConfiguracionCertificado.Modificar(objEntidadesConfiguracionCertificadoForm);
                    MessageBox.Show("Configuración Actualizada");
                }
            }
        }

        /// <summary>
        /// Cierra la Ventana Actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
