using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Tickets_Acceso
    {
        //Atributos del Ticket de Acceso Guardado en B.D.             

        private UInt32 id_Ticket;
        /// <summary>
        /// Identifica un Código Único de peticion (Ej. 435666565)
        /// </summary>
        public UInt32 Id_Ticket
        {
            get { return id_Ticket; }
            set { id_Ticket = value; }
        }

        private DateTime fecha_Generacion;
        /// <summary>
        /// Fecha en la cual se genera el acceso del ticket
        /// </summary>
        public DateTime Fecha_Generacion
        {
            get { return fecha_Generacion; }
            set { fecha_Generacion = value; }
        }

        private DateTime fecha_Expiracion;
        /// <summary>
        /// Fecha en la cual expira el acceso del ticket
        /// </summary>
        public DateTime Fecha_Expiracion
        {
            get { return fecha_Expiracion; }
            set { fecha_Expiracion = value; }
        }

        private string sign;
        /// <summary>
        /// Firma de seguridad recibida en la respuesta
        /// </summary>
        public string Sign
        {
            get { return sign; }
            set { sign = value; }
        }

        private string token;
        /// <summary>
        /// Token de seguridad recibido en la respuesta
        /// </summary>
        public string Token
        {
            get { return token; }
            set { token = value; }
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

        private long cuit;
        /// <summary>
        /// Cuit de la Entidad
        /// </summary>
        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
    }
}
