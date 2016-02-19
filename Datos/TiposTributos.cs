using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class TiposTributos
    {
        /// <summary>
        /// Agrega un registro de Tipos de Tributos en la B.D.
        /// </summary>
        /// <param name="pTipoTributo">Objeto Tipo de Tributo</param>
        public void Agregar(Entidades.TiposTributos pTipoTributo)
        {
            DateTime fchNula;
            fchNula = DateTime.ParseExact("19000101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT TiposTributos (Id_TipoTributo, Descripcion, FchDesde, FchHasta)";
            strSQL += "VALUES (@id_TipoTributo, @descripcion, @fchDesde , @fchHasta)";



            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@id_TipoTributo", pTipoTributo.Id_TipoTributo);
            comAlta.Parameters.AddWithValue("@descripcion", pTipoTributo.Descripcion);

            if (DateTime.Compare(pTipoTributo.FchDesde, fchNula) > 0)
            {
                comAlta.Parameters.AddWithValue("@fchDesde", pTipoTributo.FchDesde);
            }
            else
            {
                comAlta.Parameters.AddWithValue("@fchDesde", DBNull.Value);

            }

            if (DateTime.Compare(pTipoTributo.FchHasta, fchNula) > 0)
            {
                comAlta.Parameters.AddWithValue("@fchHasta", pTipoTributo.FchHasta);
            }
            else
            {
                comAlta.Parameters.AddWithValue("@fchHasta", DBNull.Value);

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
                throw new Exception("No pudo realizar el Alta del Tipo de Tributos");
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
        /// Retorna un DataTable con todos los Tipos de Tributos guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Tipos de Tributos en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql = "SELECT * FROM TiposTributos";

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
                throw new Exception("No pudo listar los Tipos de Tributos");
            }

            return dt;
        }

        /// <summary>
        /// Borra todos los registros de Tipos de Monedas en la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM TiposTributos";

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
