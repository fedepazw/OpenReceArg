using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Configuracion_Certificado
    {
        private long cuit;
        /// <summary>
        /// Cuit de la Entidad
        /// </summary>
        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        private string archivoCertificadoPFX;
        /// <summary>
        /// Ruta donde se encuentra guardado el archivo
        /// </summary>
        public string ArchivoCertificadoPFX
        {
            get { return archivoCertificadoPFX; }
            set { archivoCertificadoPFX = value; }
        }

        private string passwordPFX;
        /// <summary>
        /// Password del Certificado
        /// </summary>
        public string PasswordPFX
        {
            get { return passwordPFX; }
            set { passwordPFX = value; }
        }

        private char tipoAprobacion;
        /// <summary>
        /// Tipo de Aprobación (H=Homologación; P=Produccion)
        /// </summary>
        public char TipoAprobacion
        {
            get { return tipoAprobacion; }
            set { tipoAprobacion = value; }
        }
    }
}
