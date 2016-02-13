using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Errores_WS
    {
        private int id_Error;
        /// <summary>
        /// Identifica un Código Único de Error
        /// </summary>
        public int Id_Error
        {
            get { return id_Error; }
            set { id_Error = value; }
        }

        private int codigo;
        /// <summary>
        /// Código del Error del WS
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string mensaje;
        /// <summary>
        /// Descripción del Error
        /// </summary>
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private DateTime fecha;
        /// <summary>
        /// Fecha en la cual ocurrió el Error
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string observaciones;
        /// <summary>
        /// Observaciones adicionales
        /// </summary>
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
    }
}
