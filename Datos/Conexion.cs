using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Conexion
    {
        //Por Archivo de Configuracion
        public static string strConexion = ConfigurationManager.ConnectionStrings["strSQL"].ConnectionString;
    }
}
