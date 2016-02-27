using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OpenRECE
{
    public partial class frmRptComprobantesAprobados : Form
    {
        public frmRptComprobantesAprobados()
        {
            InitializeComponent();
        }

        private void frmRptComprobantesAprobados_Load(object sender, EventArgs e)
        {            
            this.rvCbtesAutorizados.RefreshReport();
        }
    }
}
