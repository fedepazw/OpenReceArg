using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class UltCbtesAutorizados
    {

        /// <summary>
        /// Agrega un registro de Ultimo Nro de Cbtes. Autorizado en la B.D.
        /// </summary>
        /// <param name="pPtoVenta">Objeto Tipo Moneda</param>
        public void Agregar(Entidades.UltCbtesAutorizados pUltNroCbteAprob)
        {

            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT UltCbtesAutorizados (Id_PtoVenta, Id_TipoCbte, Nro_Cbte) ";
            strSQL += "VALUES (@id_PtoVenta, @id_TipoCbte, @nro_Cbte)";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@id_PtoVenta", pUltNroCbteAprob.Id_PtoVenta);
            comAlta.Parameters.AddWithValue("@id_TipoCbte", pUltNroCbteAprob.Id_TipoCbte);
            comAlta.Parameters.AddWithValue("@nro_Cbte", pUltNroCbteAprob.Nro_Cbte);

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
                throw new Exception("No pudo realizar el Alta del Ultimo Nro Cbte");
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
        /// Retorna un DataTable con todos los de Ultimos Nro de Cbtes. Autorizado guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Ultimos Cbtes Autorizados en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql = "SELECT UL.Id_TipoCbte, CT.Descripcion, UL.Nro_Cbte FROM UltCbtesAutorizados UL, TiposCbtes CT "
                            +"WHERE UL.Id_TipoCbte = CT.Id_TipoCbte AND UL.Nro_Cbte<>0";

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
                throw new Exception("No pudo listar los Últimos Nros de Cbtes");
            }

            return dt;
        }

        /// <summary>
        /// Borra todos los registros de de Ultimos Nro de Cbtes. Autorizado en la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM UltCbtesAutorizados";

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

        /// <summary>
        /// Retorna el Ultimo Nro de Cbte Autorizado de un Punto de Venta y Tipo de Cbte especifico
        /// desde la B.D.
        /// </summary>
        /// <returns>Ultimo Nro Cbte</returns>
        public long TraerUltNro(int pPtoVenta, int pTipoCbte)
        {
            long UltNroCbte = 0;

            string strSql = "SELECT MAX(Nro_Cbte) FROM UltCbtesAutorizados WHERE Id_PtoVenta="+pPtoVenta.ToString()+" AND Id_TipoCbte="+pTipoCbte.ToString();

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            SqlCommand comUltNroCbte = new SqlCommand(strSql, objConexion);    

            try
            {
                objConexion.Open();

                UltNroCbte = Convert.ToInt32(comUltNroCbte.ExecuteScalar());
            }
            catch (SqlException)
            {
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                throw new Exception("No pudo traer el Últimos Nro de Cbte");
            }

            return UltNroCbte;
        }
    }
}
