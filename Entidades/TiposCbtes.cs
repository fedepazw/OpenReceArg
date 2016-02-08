using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposCbtes
    {
        private int id_TipoCbte;
        /// <summary>
        /// Identifica un Código Único de Tipo de Comprobante
        /// </summary>
        public int Id_TipoCbte
        {
            get { return id_TipoCbte; }
            set { id_TipoCbte = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Comprobante
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Comprobante
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Comprobante
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
