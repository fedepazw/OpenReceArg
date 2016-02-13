using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Eventos_WS
    {
        private int id_Evento;
        /// <summary>
        /// Identifica un Código Único de Evento
        /// </summary>
        public int Id_Evento
        {
            get { return id_Evento; }
            set { id_Evento = value; }
        }

        private int codigo;
        /// <summary>
        /// Código del Evento del WS
        /// </summary>
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string mensaje;
        /// <summary>
        /// Descripción del Evento
        /// </summary>
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private DateTime fecha;
        /// <summary>
        /// Fecha en la cual ocurrió el Evento
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
