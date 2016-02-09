using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class TiposIva
    {
        /// <summary>
        /// Agrega un registro de Tipos de Iva en la B.D.
        /// </summary>
        /// <param name="pTipoIva">Objeto Tipo Iva</param>
        public void Agregar(Entidades.TiposIva pTipoIva)
        {
            DateTime fchNula;
            fchNula = DateTime.ParseExact("19000101", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT TiposIva (Id_TipoIva, Descripcion, FchDesde, FchHasta)";
            strSQL += "VALUES (@id_TipoIva, @descripcion, @fchDesde , @fchHasta)";



            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@id_TipoIva", pTipoIva.Id_TipoIva);
            comAlta.Parameters.AddWithValue("@descripcion", pTipoIva.Descripcion);

            if (DateTime.Compare(pTipoIva.FchDesde, fchNula) > 0)
            {
                comAlta.Parameters.AddWithValue("@fchDesde", pTipoIva.FchDesde);
            }
            else
            {
                comAlta.Parameters.AddWithValue("@fchDesde", DBNull.Value);

            }

            if (DateTime.Compare(pTipoIva.FchHasta, fchNula) > 0)
            {
                comAlta.Parameters.AddWithValue("@fchHasta", pTipoIva.FchHasta);
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
                throw new Exception("No pudo realizar el Alta del Tipo de Iva");
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
        /// Retorna un DataTable con todos los Tipos de Iva guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Tipos de Iva en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql = "SELECT * FROM TiposIva";

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
                throw new Exception("No pudo listar los Tipos de Iva");
            }

            return dt;
        }
    }
}
