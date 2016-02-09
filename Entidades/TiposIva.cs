using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposIva
    {
        private string id_TipoIva;
        /// <summary>
        /// Identifica un Código Único de Tipo de Iva
        /// </summary>
        public string Id_TipoIva
        {
            get { return id_TipoIva; }
            set { id_TipoIva = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Iva
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Iva
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Iva
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
