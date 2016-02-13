using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposOpcionales
    {
        private string id_TipoOpcional;
        /// <summary>
        /// Identifica un Código Único de Tipo Opcional
        /// </summary>
        public string Id_TipoOpcional
        {
            get { return id_TipoOpcional; }
            set { id_TipoOpcional = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Tipo Opcional
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fchDesde;
        /// <summary>
        /// Nombre del Tipo Opcional
        /// </summary>
        public DateTime FchDesde
        {
            get { return fchDesde; }
            set { fchDesde = value; }
        }

        private DateTime fchHasta;
        /// <summary>
        /// Nombre del Tipo Opcional
        /// </summary>
        public DateTime FchHasta
        {
            get { return fchHasta; }
            set { fchHasta = value; }
        }
    }
}
