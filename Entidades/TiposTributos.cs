using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposTributos
    {
        private short id_TipoTributo;
        /// <summary>
        /// Identifica un Código Único de Tipo de Tributo
        /// </summary>
        public short Id_TipoTributo
        {
            get { return id_TipoTributo; }
            set { id_TipoTributo = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Tributo
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Tributo
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Tributo
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
