using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class UltCbtesAutorizados
    {
        private int id_PtoVenta;
        /// <summary>
        /// Identifica un Punto de Venta
        /// </summary>
        public int Id_PtoVenta
        {
            get { return id_PtoVenta; }
            set { id_PtoVenta = value; }
        }

        private int id_TipoCbte;
        /// <summary>
        /// Identifica un Código Único de Tipo de Comprobante
        /// </summary>
        public int Id_TipoCbte
        {
            get { return id_TipoCbte; }
            set { id_TipoCbte = value; }
        }

        private long nro_Cbte;
        /// <summary>
        /// Último Nro. De comprobante registrado
        /// Rango 1- 99999999 
        /// </summary>
        public long Nro_Cbte
        {
            get { return nro_Cbte; }
            set { nro_Cbte = value; }
        }
    }
}
