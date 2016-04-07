using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Eventos_WS
    {
        /// <summary>
        /// Agrega un registro de Eventos en la B.D.
        /// </summary>
        /// <param name="pEventosWS">Objeto Eventos WS</param>
        public void Agregar(Entidades.Eventos_WS pEventosWS)
        {
            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT Eventos_WS (Codigo, Mensaje, Fecha, Observaciones)";
            strSQL += "VALUES (@codigo, @mensaje, @fecha, @observaciones)";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@codigo", pEventosWS.Codigo);
            comAlta.Parameters.AddWithValue("@mensaje", pEventosWS.Mensaje);
            comAlta.Parameters.AddWithValue("@fecha", pEventosWS.Fecha);
            comAlta.Parameters.AddWithValue("@observaciones", pEventosWS.Observaciones);

            try
            {
                //Abro conexion
                objConexion.Open();

                //Ejecuto el comando con NonQuery cuando es transaccional (Insert, update o delete)
                comAlta.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                //Se produjo un error SQL, SqlExcepcion es especifico de sql por eso va arriba de Excepcion
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                //Pasa la excepción a la capa de lógica
                throw new Exception("No pudo realizar el Alta del Eventos WS");
            }
            finally
            {
                //Cierro la conexion solo si estaba abierto
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }

            }
        }

        /// <summary>
        /// Retorna un DataTable con todos los Eventos WS guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Eventos WS en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql = "SELECT * FROM Eventos_WS";

            try
            {
                //Creo un objeto DataAdapter (ADO Desconectado, lo pasa a memoria) y le paso el SELECT a ejecutar
                SqlDataAdapter daTraer = new SqlDataAdapter(strSql, Conexion.strConexion);

                //Cargo el DataTable con la estructura que tiene el DataAdapter
                daTraer.Fill(dt);
            }
            catch (SqlException)
            {
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                throw new Exception("No pudo listar los Eventos WS");
            }

            return dt;
        }

        /// <summary>
        /// Borra todos los registros de Errores en la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM Eventos_WS";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            SqlCommand comBorrar = new SqlCommand(strConsulta, objConexion);

            try
            {
                objConexion.Open();

                //Ejecuto el comando con NonQuery cuando es transaccional (Insert, update o delete)
                comBorrar.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //Se produjo un error SQL, SqlExcepcion es especifico de sql por eso va arriba de Excepcion
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                //Pasa la excepción a la capa de lógica                
                throw new Exception("Error en la Capa de Datos");
            }
            finally
            {
                //Cierro la conexion solo si estaba abierto
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }

            }
        }
    }
}
