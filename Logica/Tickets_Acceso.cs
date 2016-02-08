using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Tickets_Acceso
    {
        Datos.Tickets_Acceso objDatosTickets_Acceso = new Datos.Tickets_Acceso();

        /// <summary>
        /// Delega a la Capa de Datos Agregar un Ticket de Acceso en la B.D.
        /// </summary>
        /// <param name="pTicket">Objeto Ticket</param>
        public void Agregar(Entidades.Tickets_Acceso pTicket)
        {
            objDatosTickets_Acceso.Agregar(pTicket);
        }

        /// <summary>
        /// Delega a la Capa de Datos devolver un Ticket de Acceso Vigente de la B.D.
        /// </summary>
        /// <returns></returns>
        public Entidades.Tickets_Acceso TraerTicketActivo()
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();

            objEntidadesTicket_Acceso = objDatosTickets_Acceso.TraerTicketActivo();

            return objEntidadesTicket_Acceso;
        }

    }
}
