using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class PtosVenta
    {
        private short id_PtoVenta;
        /// <summary>
        /// Identifica un Punto de Venta
        /// </summary>
        public short Id_PtoVenta
        {
            get { return id_PtoVenta; }
            set { id_PtoVenta = value; }
        }

        private string emisionTipo;
        /// <summary>
        /// Tipo de Emisión
        /// Identifica si es punto de venta para CAE o CAEA
        /// </summary>
        public string EmisionTipo
        {
            get { return emisionTipo; }
            set { emisionTipo = value; }
        }

        private char bloqueado;
        /// <summary>
        /// Tipo de Emisión
        /// Indica si el punto de venta esta bloqueado. 
        /// De darse esta situación se deberá ingresar al 
        /// ABM de puntos de venta a regularizar la situación 
        /// Valores S o N
        /// </summary>
        public char Bloqueado
        {
            get { return bloqueado; }
            set { bloqueado = value; }
        }

        private DateTime fchBaja;
        /// <summary>
        /// Indica la fecha de baja en caso de estarlo
        /// </summary>
        public DateTime FchBaja
        {
            get { return fchBaja; }
            set { fchBaja = value; }
        }
    }
}
