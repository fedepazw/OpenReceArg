using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class PtosVenta
    {
        /// <summary>
        /// Agrega un registro de Punto de Venta en la B.D.
        /// </summary>
        /// <param name="pPtoVenta">Objeto Tipo Moneda</param>
        public void Agregar(Entidades.PtosVenta pPtoVenta)
        {
            DateTime fchNula;
            fchNula = DateTime.ParseExact("19000101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT PtosVenta (Id_PtoVenta, EmisionTipo, Bloqueado, FchBaja) ";
            strSQL += "VALUES (@id_PtoVenta, @emisionTipo, @bloqueado, @fchBaja)";



            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@id_PtoVenta", pPtoVenta.Id_PtoVenta);
            comAlta.Parameters.AddWithValue("@emisionTipo", pPtoVenta.EmisionTipo);
            comAlta.Parameters.AddWithValue("@bloqueado", pPtoVenta.Bloqueado);

            if (DateTime.Compare(pPtoVenta.FchBaja, fchNula) > 0)
            {
                comAlta.Parameters.AddWithValue("@fchBaja", pPtoVenta.FchBaja);
            }
            else
            {
                comAlta.Parameters.AddWithValue("@fchBaja", DBNull.Value);

            }

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
                throw new Exception("No pudo realizar el Alta del Punto de Venta");
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
        /// Retorna un DataTable con todos los Puntos de Venta guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Puntos de Venta en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql = "SELECT * FROM PtosVenta";

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
                throw new Exception("No pudo listar los Puntos de Venta");
            }

            return dt;
        }

        /// <summary>
        /// Borra todos los registros de Puntos de Ventas en la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM PtosVenta";

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
