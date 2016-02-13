using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposMonedas
    {
        private string id_TipoMoneda;
        /// <summary>
        /// Identifica un Código Único de Tipo de Moneda
        /// </summary>
        public string Id_TipoMoneda
        {
            get { return id_TipoMoneda; }
            set { id_TipoMoneda = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Moneda
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Moneda
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Moneda
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
