using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposDocumentos
    {
        private int id_TipoDocumento;
        /// <summary>
        /// Identifica un Código Único de Tipo de Documento
        /// </summary>
        public int Id_TipoDocumento
        {
            get { return id_TipoDocumento; }
            set { id_TipoDocumento = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo de Documento
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo de Documento
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo de Documento
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
