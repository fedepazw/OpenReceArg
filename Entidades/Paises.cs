using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Paises
    {
        private int id_Pais;
        /// <summary>
        /// Identifica un Código Único de Pais
        /// </summary>
        public int Id_Pais
        {
            get { return id_Pais; }
            set { id_Pais = value; }
        }

        private string descripcion;
        /// <summary>
        /// Nombre del Pais
        /// </summary>
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
