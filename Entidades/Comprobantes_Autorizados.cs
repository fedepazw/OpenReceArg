using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Comprobantes_Autorizados
    {
        private short id_PtoVenta;
        /// <summary>
        /// Punto de Venta del comprobante que se está informando. 
        /// Si se informa más de un comprobante, todos deben corresponder 
        /// al mismo punto de venta
        /// Tabla: PTOSVENTA
        /// </summary>
        public short Id_PtoVenta
        {
            get { return id_PtoVenta; }
            set { id_PtoVenta = value; }
        }

        private int id_TipoCbte;
        /// <summary>
        /// Tipo de comprobante que se está informando. 
        /// Si se informa más de un comprobante, todos deben ser 
        /// del mismo tipo.
        /// Tabla: TIPOSCBTES
        /// </summary>
        public int Id_TipoCbte
        {
            get { return id_TipoCbte; }
            set { id_TipoCbte = value; }
        }

        private int id_TipoConcepto;
        /// <summary>
        /// Concepto del Comprobante. 
        /// Tabla: TIPOSCONCEPTOS
        /// </summary>
        public int Id_TipoConcepto
        {
            get { return id_TipoConcepto; }
            set { id_TipoConcepto = value; }
        }

        private int id_TipoDoc;
        /// <summary>
        /// Código de Tipo de Documento        
        /// Tabla: TIPOSDOCUMENTOS
        /// </summary>
        public int Id_TipoDoc
        {
            get { return id_TipoDoc; }
            set { id_TipoDoc = value; }
        }

        private long docNro;
        /// <summary>
        /// Número de Documento del Cliente               
        /// </summary>
        public long DocNro
        {
            get { return docNro; }
            set { docNro = value; }
        }

        private long nro_CbteDesde;
        /// <summary>
        /// Nro. De comprobante desde
        /// Rango 1- 99999999 
        /// </summary>
        public long Nro_CbteDesde
        {
            get { return nro_CbteDesde; }
            set { nro_CbteDesde = value; }
        }

        private long nro_CbteHasta;
        /// <summary>
        /// Nro. De comprobante hasta
        /// Rango 1- 99999999 
        /// </summary>
        public long Nro_CbteHasta
        {
            get { return nro_CbteHasta; }
            set { nro_CbteHasta = value; }
        }

        private DateTime cbteFch;
        /// <summary>
        /// Fecha del comprobante (yyyymmdd). Para concepto igual a 1, 
        /// la fecha de emisión del comprobante puede ser hasta 5 días anteriores 
        /// o posteriores respecto de la fecha de generación; si se indica Concepto 
        /// igual a 2 ó 3 puede ser hasta 10 días anteriores o posteriores a la fecha de generación. 
        /// Si no se envía la fecha del comprobante se asignará la fecha de proceso.
        /// </summary>
        public DateTime CbteFch
        {
            get { return cbteFch; }
            set { cbteFch = value; }
        }

        private double impTotal;
        /// <summary>
        /// Importe total del comprobante, 
        /// Debe ser igual a Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.
        /// </summary>
        public double ImpTotal
        {
            get { return impTotal; }
            set { impTotal = value; }
        }

        private double impTotConc;
        /// <summary>
        /// Importe neto no gravado.
        /// Debe ser menor o igual a Importe total y no puede ser menor a cero.
        /// No puede ser mayor al Importe total de la operación ni menor a cero (0).
        /// Para comprobantes tipo C debe ser igual a cero (0).
        /// Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo 
        /// corresponde al importe subtotal        
        /// </summary>
        public double ImpTotConc
        {
            get { return impTotConc; }
            set { impTotConc = value; }
        }

        private double impNeto;
        /// <summary>
        /// Importe neto gravado. 
        /// Debe ser menor o igual a Importe total y no puede ser menor a cero. 
        /// Para comprobantes tipo C este campo corresponde al Importe del Sub Total.
        /// Para comprobantes tipo Bienes Usados – Emisor Monotributista no debe informarse 
        /// o debe ser igual a cero (0). 
        /// </summary>
        public double ImpNeto
        {
            get { return impNeto; }
            set { impNeto = value; }
        }

        private double impOpEx;
        /// <summary>
        /// Importe exento. 
        /// Debe ser menor o igual a Importe total y no puede ser menor a cero.
        /// Para comprobantes tipo C debe ser igual a cero (0).
        /// Para comprobantes tipo Bienes Usados – Emisor Monotributista no debe informarse 
        /// o debe ser igual a cero (0).
        /// </summary>
        public double ImpOpEx
        {
            get { return impOpEx; }
            set { impOpEx = value; }
        }

        private double impTrib;
        /// <summary>
        /// Suma de los importes del array de tributos
        /// </summary>
        public double ImpTrib
        {
            get { return impTrib; }
            set { impTrib = value; }
        }

        private double impIVA;
        /// <summary>
        /// Suma de los importes del array de IVA.
        /// Para comprobantes tipo C debe ser igual a cero (0).
        /// Para comprobantes tipo Bienes Usados – Emisor Monotributista no debe informarse 
        /// o debe ser igual a cero (0).
        /// </summary>
        public double ImpIVA
        {
            get { return impIVA; }
            set { impIVA = value; }
        }

        private DateTime fchServDesde;
        /// <summary>
        /// Fecha de inicio del abono para el servicio a facturar. 
        /// Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). 
        /// Formato yyyymmdd
        /// </summary>
        public DateTime FchServDesde
        {
            get { return fchServDesde; }
            set { fchServDesde = value; }
        }

        private DateTime fchServHasta;
        /// <summary>
        /// Fecha de fin del abono para el servicio a facturar. 
        /// Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). 
        /// Formato yyyymmdd. 
        /// FchServHasta no puede ser menor a FchServDesde
        /// </summary>
        public DateTime FchServHasta
        {
            get { return fchServHasta; }
            set { fchServHasta = value; }
        }

        private DateTime fchVtoPago;
        /// <summary>
        /// Fecha de vencimiento del pago servicio a facturar. 
        /// Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). 
        /// Formato yyyymmdd. 
        /// Debe ser igual o posterior a la fecha del comprobante.
        /// </summary>
        public DateTime FchVtoPago
        {
            get { return fchVtoPago; }
            set { fchVtoPago = value; }
        }

        private string id_TipoMoneda;
        /// <summary>
        /// Código de moneda del comprobante. 
        /// Tabla: TIPOSMONEDAS
        /// </summary>
        public string Id_TipoMoneda
        {
            get { return id_TipoMoneda; }
            set { id_TipoMoneda = value; }
        }

        private double monCotiz;
        /// <summary>
        /// Cotización de la moneda informada. 
        /// Para PES, pesos argentinos la misma debe ser 1
        /// </summary>
        public double MonCotiz
        {
            get { return monCotiz; }
            set { monCotiz = value; }
        }

        private string resultado;
        /// <summary>
        /// Resultado del procesamiento del comprobante. 
        /// </summary>
        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        private string codAutorizacion;
        /// <summary>
        /// Código de Autorización (CAE)         
        /// </summary>
        public string CodAutorizacion
        {
            get { return codAutorizacion; }
            set { codAutorizacion = value; }
        }

        private string emisionTipo;
        /// <summary>
        /// Tipo de emisión, si corresponde a CAE o CAEA        
        /// </summary>
        public string EmisionTipo
        {
            get { return emisionTipo; }
            set { emisionTipo = value; }
        }

        private DateTime fchVto;
        /// <summary>
        /// Vencimiento del código de autorización. Si tipo de emisión es igual a CAE 
        /// esta es la fecha de vencimiento obtenida cuando se autorizó el comprobante. 
        /// Si tipo de emisión es igual a CAEA esta es la fecha de “vigencia hasta” 
        /// del CAEA obtenida cuando gestionó el CAEA.
        /// </summary>
        public DateTime FchVto
        {
            get { return fchVto; }
            set { fchVto = value; }
        }

        private DateTime fchProceso;
        /// <summary>
        /// Fecha de procesamiento del comprobante 
        /// Formato yyyymmdd. 
        /// </summary>
        public DateTime FchProceso
        {
            get { return fchProceso; }
            set { fchProceso = value; }
        }
    }
}
