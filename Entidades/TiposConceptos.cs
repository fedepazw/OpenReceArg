using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposConceptos
    {
        private int id_TipoConcepto;
        /// <summary>
        /// Identifica un Código Único de Tipo de Concepto
        /// </summary>
        public int Id_TipoConcepto
        {
            get { return id_TipoConcepto; }
            set { id_TipoConcepto = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Concepto
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Concepto
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Concepto
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
