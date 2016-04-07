namespace OpenRECE
{
    partial class frmFichaComprobante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaComprobante));
            this.lblTipoCbte = new System.Windows.Forms.Label();
            this.cmbTipoCbte = new System.Windows.Forms.ComboBox();
            this.lblNroCbte = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.txtNroCbteDesde = new System.Windows.Forms.TextBox();
            this.txtNroCbteHasta = new System.Windows.Forms.TextBox();
            this.lblNroDesde = new System.Windows.Forms.Label();
            this.lblNroHasta = new System.Windows.Forms.Label();
            this.lblFchCbte = new System.Windows.Forms.Label();
            this.dtpFchCbte = new System.Windows.Forms.DateTimePicker();
            this.lblFchVtoPago = new System.Windows.Forms.Label();
            this.dtpFchVencPago = new System.Windows.Forms.DateTimePicker();
            this.lblTipoConcepto = new System.Windows.Forms.Label();
            this.cmbTipoConcepto = new System.Windows.Forms.ComboBox();
            this.lblFchServicio = new System.Windows.Forms.Label();
            this.dtpFchServDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFchServHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFchServicioDesde = new System.Windows.Forms.Label();
            this.lblFchServicioHasta = new System.Windows.Forms.Label();
            this.lblImpTotal = new System.Windows.Forms.Label();
            this.mtxtImpTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblImpTotConc = new System.Windows.Forms.Label();
            this.mtxtImpTotConc = new System.Windows.Forms.MaskedTextBox();
            this.mtxtImpNeto = new System.Windows.Forms.MaskedTextBox();
            this.lblImpNeto = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblImpIva = new System.Windows.Forms.Label();
            this.mtxtImpOpEx = new System.Windows.Forms.MaskedTextBox();
            this.lblImpOpEx = new System.Windows.Forms.Label();
            this.mtxtImpTrib = new System.Windows.Forms.MaskedTextBox();
            this.lblImpTrib = new System.Windows.Forms.Label();
            this.tabCDetalle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbCliPais = new System.Windows.Forms.ComboBox();
            this.lblCliPais = new System.Windows.Forms.Label();
            this.txtCliProvincia = new System.Windows.Forms.TextBox();
            this.lblCliProvincia = new System.Windows.Forms.Label();
            this.txtCliLocalidad = new System.Windows.Forms.TextBox();
            this.lblCliLocalidad = new System.Windows.Forms.Label();
            this.txtCliDireccion = new System.Windows.Forms.TextBox();
            this.lblCliDireccion = new System.Windows.Forms.Label();
            this.txtCliDocNro = new System.Windows.Forms.TextBox();
            this.lblCliDocNro = new System.Windows.Forms.Label();
            this.lblCliDocTipo = new System.Windows.Forms.Label();
            this.cmbCliDocTipo = new System.Windows.Forms.ComboBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliRazonSocial = new System.Windows.Forms.TextBox();
            this.lblCliRazonSocial = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabCDetalle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoCbte
            // 
            this.lblTipoCbte.AutoSize = true;
            this.lblTipoCbte.Location = new System.Drawing.Point(28, 35);
            this.lblTipoCbte.Name = "lblTipoCbte";
            this.lblTipoCbte.Size = new System.Drawing.Size(112, 13);
            this.lblTipoCbte.TabIndex = 0;
            this.lblTipoCbte.Text = "Tipo de Comprobante:";
            // 
            // cmbTipoCbte
            // 
            this.cmbTipoCbte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCbte.FormattingEnabled = true;
            this.cmbTipoCbte.Location = new System.Drawing.Point(146, 32);
            this.cmbTipoCbte.Name = "cmbTipoCbte";
            this.cmbTipoCbte.Size = new System.Drawing.Size(144, 21);
            this.cmbTipoCbte.TabIndex = 1;
            // 
            // lblNroCbte
            // 
            this.lblNroCbte.AutoSize = true;
            this.lblNroCbte.Location = new System.Drawing.Point(28, 59);
            this.lblNroCbte.Name = "lblNroCbte";
            this.lblNroCbte.Size = new System.Drawing.Size(47, 13);
            this.lblNroCbte.TabIndex = 2;
            this.lblNroCbte.Text = "Número:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(81, 56);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(49, 21);
            this.cmbSucursal.TabIndex = 3;
            // 
            // txtNroCbteDesde
            // 
            this.txtNroCbteDesde.Location = new System.Drawing.Point(190, 61);
            this.txtNroCbteDesde.MaxLength = 8;
            this.txtNroCbteDesde.Name = "txtNroCbteDesde";
            this.txtNroCbteDesde.Size = new System.Drawing.Size(100, 20);
            this.txtNroCbteDesde.TabIndex = 4;
            // 
            // txtNroCbteHasta
            // 
            this.txtNroCbteHasta.Location = new System.Drawing.Point(190, 87);
            this.txtNroCbteHasta.MaxLength = 8;
            this.txtNroCbteHasta.Name = "txtNroCbteHasta";
            this.txtNroCbteHasta.Size = new System.Drawing.Size(100, 20);
            this.txtNroCbteHasta.TabIndex = 5;
            // 
            // lblNroDesde
            // 
            this.lblNroDesde.AutoSize = true;
            this.lblNroDesde.Location = new System.Drawing.Point(143, 64);
            this.lblNroDesde.Name = "lblNroDesde";
            this.lblNroDesde.Size = new System.Drawing.Size(41, 13);
            this.lblNroDesde.TabIndex = 6;
            this.lblNroDesde.Text = "Desde:";
            // 
            // lblNroHasta
            // 
            this.lblNroHasta.AutoSize = true;
            this.lblNroHasta.Location = new System.Drawing.Point(146, 90);
            this.lblNroHasta.Name = "lblNroHasta";
            this.lblNroHasta.Size = new System.Drawing.Size(38, 13);
            this.lblNroHasta.TabIndex = 7;
            this.lblNroHasta.Text = "Hasta:";
            // 
            // lblFchCbte
            // 
            this.lblFchCbte.AutoSize = true;
            this.lblFchCbte.Location = new System.Drawing.Point(308, 48);
            this.lblFchCbte.Name = "lblFchCbte";
            this.lblFchCbte.Size = new System.Drawing.Size(40, 13);
            this.lblFchCbte.TabIndex = 8;
            this.lblFchCbte.Text = "Fecha:";
            // 
            // dtpFchCbte
            // 
            this.dtpFchCbte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFchCbte.Location = new System.Drawing.Point(416, 41);
            this.dtpFchCbte.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFchCbte.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFchCbte.Name = "dtpFchCbte";
            this.dtpFchCbte.Size = new System.Drawing.Size(95, 20);
            this.dtpFchCbte.TabIndex = 9;
            // 
            // lblFchVtoPago
            // 
            this.lblFchVtoPago.AutoSize = true;
            this.lblFchVtoPago.Location = new System.Drawing.Point(308, 72);
            this.lblFchVtoPago.Name = "lblFchVtoPago";
            this.lblFchVtoPago.Size = new System.Drawing.Size(99, 13);
            this.lblFchVtoPago.TabIndex = 10;
            this.lblFchVtoPago.Text = "Fecha Venc. Pago:";
            // 
            // dtpFchVencPago
            // 
            this.dtpFchVencPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFchVencPago.Location = new System.Drawing.Point(416, 69);
            this.dtpFchVencPago.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFchVencPago.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFchVencPago.Name = "dtpFchVencPago";
            this.dtpFchVencPago.Size = new System.Drawing.Size(95, 20);
            this.dtpFchVencPago.TabIndex = 11;
            // 
            // lblTipoConcepto
            // 
            this.lblTipoConcepto.AutoSize = true;
            this.lblTipoConcepto.Location = new System.Drawing.Point(537, 28);
            this.lblTipoConcepto.Name = "lblTipoConcepto";
            this.lblTipoConcepto.Size = new System.Drawing.Size(80, 13);
            this.lblTipoConcepto.TabIndex = 12;
            this.lblTipoConcepto.Text = "Tipo Concepto:";
            // 
            // cmbTipoConcepto
            // 
            this.cmbTipoConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConcepto.FormattingEnabled = true;
            this.cmbTipoConcepto.Location = new System.Drawing.Point(623, 25);
            this.cmbTipoConcepto.Name = "cmbTipoConcepto";
            this.cmbTipoConcepto.Size = new System.Drawing.Size(205, 21);
            this.cmbTipoConcepto.TabIndex = 13;
            // 
            // lblFchServicio
            // 
            this.lblFchServicio.AutoSize = true;
            this.lblFchServicio.Location = new System.Drawing.Point(647, 56);
            this.lblFchServicio.Name = "lblFchServicio";
            this.lblFchServicio.Size = new System.Drawing.Size(95, 13);
            this.lblFchServicio.TabIndex = 14;
            this.lblFchServicio.Text = "Fecha del Servicio";
            // 
            // dtpFchServDesde
            // 
            this.dtpFchServDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFchServDesde.Location = new System.Drawing.Point(584, 76);
            this.dtpFchServDesde.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFchServDesde.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFchServDesde.Name = "dtpFchServDesde";
            this.dtpFchServDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpFchServDesde.TabIndex = 15;
            // 
            // dtpFchServHasta
            // 
            this.dtpFchServHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFchServHasta.Location = new System.Drawing.Point(733, 76);
            this.dtpFchServHasta.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpFchServHasta.MinDate = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dtpFchServHasta.Name = "dtpFchServHasta";
            this.dtpFchServHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpFchServHasta.TabIndex = 16;
            // 
            // lblFchServicioDesde
            // 
            this.lblFchServicioDesde.AutoSize = true;
            this.lblFchServicioDesde.Location = new System.Drawing.Point(537, 82);
            this.lblFchServicioDesde.Name = "lblFchServicioDesde";
            this.lblFchServicioDesde.Size = new System.Drawing.Size(41, 13);
            this.lblFchServicioDesde.TabIndex = 17;
            this.lblFchServicioDesde.Text = "Desde:";
            // 
            // lblFchServicioHasta
            // 
            this.lblFchServicioHasta.AutoSize = true;
            this.lblFchServicioHasta.Location = new System.Drawing.Point(689, 82);
            this.lblFchServicioHasta.Name = "lblFchServicioHasta";
            this.lblFchServicioHasta.Size = new System.Drawing.Size(38, 13);
            this.lblFchServicioHasta.TabIndex = 18;
            this.lblFchServicioHasta.Text = "Hasta:";
            // 
            // lblImpTotal
            // 
            this.lblImpTotal.AutoSize = true;
            this.lblImpTotal.Location = new System.Drawing.Point(660, 518);
            this.lblImpTotal.Name = "lblImpTotal";
            this.lblImpTotal.Size = new System.Drawing.Size(57, 13);
            this.lblImpTotal.TabIndex = 19;
            this.lblImpTotal.Text = "Imp. Total:";
            // 
            // mtxtImpTotal
            // 
            this.mtxtImpTotal.Location = new System.Drawing.Point(723, 515);
            this.mtxtImpTotal.Mask = "9999999999999,99";
            this.mtxtImpTotal.Name = "mtxtImpTotal";
            this.mtxtImpTotal.Size = new System.Drawing.Size(105, 20);
            this.mtxtImpTotal.TabIndex = 20;
            // 
            // lblImpTotConc
            // 
            this.lblImpTotConc.AutoSize = true;
            this.lblImpTotConc.Location = new System.Drawing.Point(71, 452);
            this.lblImpTotConc.Name = "lblImpTotConc";
            this.lblImpTotConc.Size = new System.Drawing.Size(102, 13);
            this.lblImpTotConc.TabIndex = 21;
            this.lblImpTotConc.Text = "Imp. Neto No Grav.:";
            // 
            // mtxtImpTotConc
            // 
            this.mtxtImpTotConc.Location = new System.Drawing.Point(179, 449);
            this.mtxtImpTotConc.Mask = "9999999999999,99";
            this.mtxtImpTotConc.Name = "mtxtImpTotConc";
            this.mtxtImpTotConc.Size = new System.Drawing.Size(105, 20);
            this.mtxtImpTotConc.TabIndex = 22;
            // 
            // mtxtImpNeto
            // 
            this.mtxtImpNeto.Location = new System.Drawing.Point(416, 449);
            this.mtxtImpNeto.Mask = "9999999999999,99";
            this.mtxtImpNeto.Name = "mtxtImpNeto";
            this.mtxtImpNeto.Size = new System.Drawing.Size(105, 20);
            this.mtxtImpNeto.TabIndex = 24;
            // 
            // lblImpNeto
            // 
            this.lblImpNeto.AutoSize = true;
            this.lblImpNeto.Location = new System.Drawing.Point(325, 452);
            this.lblImpNeto.Name = "lblImpNeto";
            this.lblImpNeto.Size = new System.Drawing.Size(85, 13);
            this.lblImpNeto.TabIndex = 23;
            this.lblImpNeto.Text = "Imp. Neto Grav.:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(303, 486);
            this.maskedTextBox2.Mask = "9999999999999,99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox2.TabIndex = 28;
            // 
            // lblImpIva
            // 
            this.lblImpIva.AutoSize = true;
            this.lblImpIva.Location = new System.Drawing.Point(220, 489);
            this.lblImpIva.Name = "lblImpIva";
            this.lblImpIva.Size = new System.Drawing.Size(77, 13);
            this.lblImpIva.TabIndex = 27;
            this.lblImpIva.Text = "Imp. Total IVA:";
            // 
            // mtxtImpOpEx
            // 
            this.mtxtImpOpEx.Location = new System.Drawing.Point(663, 449);
            this.mtxtImpOpEx.Mask = "9999999999999,99";
            this.mtxtImpOpEx.Name = "mtxtImpOpEx";
            this.mtxtImpOpEx.Size = new System.Drawing.Size(105, 20);
            this.mtxtImpOpEx.TabIndex = 26;
            // 
            // lblImpOpEx
            // 
            this.lblImpOpEx.AutoSize = true;
            this.lblImpOpEx.Location = new System.Drawing.Point(591, 452);
            this.lblImpOpEx.Name = "lblImpOpEx";
            this.lblImpOpEx.Size = new System.Drawing.Size(66, 13);
            this.lblImpOpEx.TabIndex = 25;
            this.lblImpOpEx.Text = "Imp. Exento:";
            // 
            // mtxtImpTrib
            // 
            this.mtxtImpTrib.Location = new System.Drawing.Point(540, 486);
            this.mtxtImpTrib.Mask = "9999999999999,99";
            this.mtxtImpTrib.Name = "mtxtImpTrib";
            this.mtxtImpTrib.Size = new System.Drawing.Size(105, 20);
            this.mtxtImpTrib.TabIndex = 30;
            // 
            // lblImpTrib
            // 
            this.lblImpTrib.AutoSize = true;
            this.lblImpTrib.Location = new System.Drawing.Point(436, 489);
            this.lblImpTrib.Name = "lblImpTrib";
            this.lblImpTrib.Size = new System.Drawing.Size(98, 13);
            this.lblImpTrib.TabIndex = 29;
            this.lblImpTrib.Text = "Imp. Total Tributos:";
            // 
            // tabCDetalle
            // 
            this.tabCDetalle.Controls.Add(this.tabPage1);
            this.tabCDetalle.Location = new System.Drawing.Point(31, 123);
            this.tabCDetalle.Name = "tabCDetalle";
            this.tabCDetalle.SelectedIndex = 0;
            this.tabCDetalle.Size = new System.Drawing.Size(797, 310);
            this.tabCDetalle.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbCliPais);
            this.tabPage1.Controls.Add(this.lblCliPais);
            this.tabPage1.Controls.Add(this.txtCliProvincia);
            this.tabPage1.Controls.Add(this.lblCliProvincia);
            this.tabPage1.Controls.Add(this.txtCliLocalidad);
            this.tabPage1.Controls.Add(this.lblCliLocalidad);
            this.tabPage1.Controls.Add(this.txtCliDireccion);
            this.tabPage1.Controls.Add(this.lblCliDireccion);
            this.tabPage1.Controls.Add(this.txtCliDocNro);
            this.tabPage1.Controls.Add(this.lblCliDocNro);
            this.tabPage1.Controls.Add(this.lblCliDocTipo);
            this.tabPage1.Controls.Add(this.cmbCliDocTipo);
            this.tabPage1.Controls.Add(this.btnBuscarCliente);
            this.tabPage1.Controls.Add(this.txtCliRazonSocial);
            this.tabPage1.Controls.Add(this.lblCliRazonSocial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbCliPais
            // 
            this.cmbCliPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliPais.FormattingEnabled = true;
            this.cmbCliPais.Location = new System.Drawing.Point(549, 127);
            this.cmbCliPais.Name = "cmbCliPais";
            this.cmbCliPais.Size = new System.Drawing.Size(169, 21);
            this.cmbCliPais.TabIndex = 14;
            // 
            // lblCliPais
            // 
            this.lblCliPais.AutoSize = true;
            this.lblCliPais.Location = new System.Drawing.Point(505, 133);
            this.lblCliPais.Name = "lblCliPais";
            this.lblCliPais.Size = new System.Drawing.Size(32, 13);
            this.lblCliPais.TabIndex = 13;
            this.lblCliPais.Text = "País:";
            // 
            // txtCliProvincia
            // 
            this.txtCliProvincia.Location = new System.Drawing.Point(332, 128);
            this.txtCliProvincia.Name = "txtCliProvincia";
            this.txtCliProvincia.Size = new System.Drawing.Size(144, 20);
            this.txtCliProvincia.TabIndex = 12;
            // 
            // lblCliProvincia
            // 
            this.lblCliProvincia.AutoSize = true;
            this.lblCliProvincia.Location = new System.Drawing.Point(270, 132);
            this.lblCliProvincia.Name = "lblCliProvincia";
            this.lblCliProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblCliProvincia.TabIndex = 11;
            this.lblCliProvincia.Text = "Provincia:";
            // 
            // txtCliLocalidad
            // 
            this.txtCliLocalidad.Location = new System.Drawing.Point(111, 127);
            this.txtCliLocalidad.Name = "txtCliLocalidad";
            this.txtCliLocalidad.Size = new System.Drawing.Size(144, 20);
            this.txtCliLocalidad.TabIndex = 10;
            // 
            // lblCliLocalidad
            // 
            this.lblCliLocalidad.AutoSize = true;
            this.lblCliLocalidad.Location = new System.Drawing.Point(49, 131);
            this.lblCliLocalidad.Name = "lblCliLocalidad";
            this.lblCliLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblCliLocalidad.TabIndex = 9;
            this.lblCliLocalidad.Text = "Localidad:";
            // 
            // txtCliDireccion
            // 
            this.txtCliDireccion.Location = new System.Drawing.Point(111, 92);
            this.txtCliDireccion.Name = "txtCliDireccion";
            this.txtCliDireccion.Size = new System.Drawing.Size(365, 20);
            this.txtCliDireccion.TabIndex = 8;
            // 
            // lblCliDireccion
            // 
            this.lblCliDireccion.AutoSize = true;
            this.lblCliDireccion.Location = new System.Drawing.Point(50, 95);
            this.lblCliDireccion.Name = "lblCliDireccion";
            this.lblCliDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblCliDireccion.TabIndex = 7;
            this.lblCliDireccion.Text = "Dirección:";
            // 
            // txtCliDocNro
            // 
            this.txtCliDocNro.Location = new System.Drawing.Point(349, 57);
            this.txtCliDocNro.MaxLength = 11;
            this.txtCliDocNro.Name = "txtCliDocNro";
            this.txtCliDocNro.Size = new System.Drawing.Size(126, 20);
            this.txtCliDocNro.TabIndex = 6;
            this.txtCliDocNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCliDocNro
            // 
            this.lblCliDocNro.AutoSize = true;
            this.lblCliDocNro.Location = new System.Drawing.Point(296, 60);
            this.lblCliDocNro.Name = "lblCliDocNro";
            this.lblCliDocNro.Size = new System.Drawing.Size(47, 13);
            this.lblCliDocNro.TabIndex = 5;
            this.lblCliDocNro.Text = "Número:";
            // 
            // lblCliDocTipo
            // 
            this.lblCliDocTipo.AutoSize = true;
            this.lblCliDocTipo.Location = new System.Drawing.Point(6, 60);
            this.lblCliDocTipo.Name = "lblCliDocTipo";
            this.lblCliDocTipo.Size = new System.Drawing.Size(104, 13);
            this.lblCliDocTipo.TabIndex = 4;
            this.lblCliDocTipo.Text = "Tipo de Documento:";
            // 
            // cmbCliDocTipo
            // 
            this.cmbCliDocTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliDocTipo.FormattingEnabled = true;
            this.cmbCliDocTipo.Location = new System.Drawing.Point(111, 57);
            this.cmbCliDocTipo.Name = "cmbCliDocTipo";
            this.cmbCliDocTipo.Size = new System.Drawing.Size(179, 21);
            this.cmbCliDocTipo.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(677, 15);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(41, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // txtCliRazonSocial
            // 
            this.txtCliRazonSocial.Location = new System.Drawing.Point(111, 18);
            this.txtCliRazonSocial.Name = "txtCliRazonSocial";
            this.txtCliRazonSocial.Size = new System.Drawing.Size(560, 20);
            this.txtCliRazonSocial.TabIndex = 1;
            // 
            // lblCliRazonSocial
            // 
            this.lblCliRazonSocial.AutoSize = true;
            this.lblCliRazonSocial.Location = new System.Drawing.Point(68, 21);
            this.lblCliRazonSocial.Name = "lblCliRazonSocial";
            this.lblCliRazonSocial.Size = new System.Drawing.Size(42, 13);
            this.lblCliRazonSocial.TabIndex = 0;
            this.lblCliRazonSocial.Text = "Cliente:";
            // 
            // frmFichaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 547);
            this.Controls.Add(this.tabCDetalle);
            this.Controls.Add(this.mtxtImpTrib);
            this.Controls.Add(this.lblImpTrib);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.lblImpIva);
            this.Controls.Add(this.mtxtImpOpEx);
            this.Controls.Add(this.lblImpOpEx);
            this.Controls.Add(this.mtxtImpNeto);
            this.Controls.Add(this.lblImpNeto);
            this.Controls.Add(this.mtxtImpTotConc);
            this.Controls.Add(this.lblImpTotConc);
            this.Controls.Add(this.mtxtImpTotal);
            this.Controls.Add(this.lblImpTotal);
            this.Controls.Add(this.lblFchServicioHasta);
            this.Controls.Add(this.lblFchServicioDesde);
            this.Controls.Add(this.dtpFchServHasta);
            this.Controls.Add(this.dtpFchServDesde);
            this.Controls.Add(this.lblFchServicio);
            this.Controls.Add(this.cmbTipoConcepto);
            this.Controls.Add(this.lblTipoConcepto);
            this.Controls.Add(this.dtpFchVencPago);
            this.Controls.Add(this.lblFchVtoPago);
            this.Controls.Add(this.dtpFchCbte);
            this.Controls.Add(this.lblFchCbte);
            this.Controls.Add(this.lblNroHasta);
            this.Controls.Add(this.lblNroDesde);
            this.Controls.Add(this.txtNroCbteHasta);
            this.Controls.Add(this.txtNroCbteDesde);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblNroCbte);
            this.Controls.Add(this.cmbTipoCbte);
            this.Controls.Add(this.lblTipoCbte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFichaComprobante";
            this.Text = "Ficha del Comprobante";
            this.Load += new System.EventHandler(this.frmFichaComprobante_Load);
            this.tabCDetalle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCbte;
        private System.Windows.Forms.ComboBox cmbTipoCbte;
        private System.Windows.Forms.Label lblNroCbte;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.TextBox txtNroCbteDesde;
        private System.Windows.Forms.TextBox txtNroCbteHasta;
        private System.Windows.Forms.Label lblNroDesde;
        private System.Windows.Forms.Label lblNroHasta;
        private System.Windows.Forms.Label lblFchCbte;
        private System.Windows.Forms.DateTimePicker dtpFchCbte;
        private System.Windows.Forms.Label lblFchVtoPago;
        private System.Windows.Forms.DateTimePicker dtpFchVencPago;
        private System.Windows.Forms.Label lblTipoConcepto;
        private System.Windows.Forms.ComboBox cmbTipoConcepto;
        private System.Windows.Forms.Label lblFchServicio;
        private System.Windows.Forms.DateTimePicker dtpFchServDesde;
        private System.Windows.Forms.DateTimePicker dtpFchServHasta;
        private System.Windows.Forms.Label lblFchServicioDesde;
        private System.Windows.Forms.Label lblFchServicioHasta;
        private System.Windows.Forms.Label lblImpTotal;
        private System.Windows.Forms.MaskedTextBox mtxtImpTotal;
        private System.Windows.Forms.Label lblImpTotConc;
        private System.Windows.Forms.MaskedTextBox mtxtImpTotConc;
        private System.Windows.Forms.MaskedTextBox mtxtImpNeto;
        private System.Windows.Forms.Label lblImpNeto;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblImpIva;
        private System.Windows.Forms.MaskedTextBox mtxtImpOpEx;
        private System.Windows.Forms.Label lblImpOpEx;
        private System.Windows.Forms.MaskedTextBox mtxtImpTrib;
        private System.Windows.Forms.Label lblImpTrib;
        private System.Windows.Forms.TabControl tabCDetalle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCliRazonSocial;
        private System.Windows.Forms.Label lblCliRazonSocial;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtCliDocNro;
        private System.Windows.Forms.Label lblCliDocNro;
        private System.Windows.Forms.Label lblCliDocTipo;
        private System.Windows.Forms.ComboBox cmbCliDocTipo;
        private System.Windows.Forms.TextBox txtCliDireccion;
        private System.Windows.Forms.Label lblCliDireccion;
        private System.Windows.Forms.ComboBox cmbCliPais;
        private System.Windows.Forms.Label lblCliPais;
        private System.Windows.Forms.TextBox txtCliProvincia;
        private System.Windows.Forms.Label lblCliProvincia;
        private System.Windows.Forms.TextBox txtCliLocalidad;
        private System.Windows.Forms.Label lblCliLocalidad;
    }
}