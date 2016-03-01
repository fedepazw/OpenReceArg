using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Comprobantes_Autorizados
    {
        /// <summary>
        /// Agrega un registro de Comprobante Autorizado en la B.D.
        /// </summary>
        /// <param name="pCbteAutorizado">Objeto Tipo Moneda</param>
        public void Agregar(Entidades.Comprobantes_Autorizados pCbteAutorizado)
        {

            //Declaro variable con la sentencia SQL
            string strSQL;
            strSQL = "INSERT Comprobantes_Autorizados (Id_PtoVenta, Id_TipoCbte, Id_TipoConcepto, ";
            strSQL += "Id_TipoDoc, DocNro, Nro_CbteDesde, ";
            strSQL += "Nro_CbteHasta, CbteFch, ImpTotal, ";
            strSQL += "ImpTotConc, ImpNeto, ImpOpEx, ";
            strSQL += "ImpTrib, ImpIVA, FchServDesde,  ";
            strSQL += "FchServHasta, FchVtoPago, Id_TipoMoneda, ";
            strSQL += "MonCotiz, Resultado, CodAutorizacion, ";
            strSQL += "EmisionTipo, FchVto, FchProceso) ";
            strSQL += "VALUES (@id_PtoVenta, @id_TipoCbte, @id_TipoConcepto, ";
            strSQL += "@id_TipoDoc, @docNro, @nro_CbteDesde, ";
            strSQL += "@nro_CbteHasta, @cbteFch, @impTotal, ";
            strSQL += "@impTotConc, @impNeto, @impOpEx, ";
            strSQL += "@impTrib, @impIVA, @fchServDesde,";
            strSQL += "@fchServHasta, @fchVtoPago, @id_TipoMoneda, ";
            strSQL += "@monCotiz, @resultado, @codAutorizacion, ";
            strSQL += "@emisionTipo, @fchVto, @fchProceso)";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@id_PtoVenta", pCbteAutorizado.Id_PtoVenta);
            comAlta.Parameters.AddWithValue("@id_TipoCbte", pCbteAutorizado.Id_TipoCbte);
            comAlta.Parameters.AddWithValue("@id_TipoConcepto", pCbteAutorizado.Id_TipoConcepto);
            comAlta.Parameters.AddWithValue("@id_TipoDoc", pCbteAutorizado.Id_TipoDoc);
            comAlta.Parameters.AddWithValue("@docNro", pCbteAutorizado.DocNro);
            comAlta.Parameters.AddWithValue("@nro_CbteDesde", pCbteAutorizado.Nro_CbteDesde);
            comAlta.Parameters.AddWithValue("@nro_CbteHasta", pCbteAutorizado.Nro_CbteHasta);
            comAlta.Parameters.AddWithValue("@cbteFch", pCbteAutorizado.CbteFch);
            comAlta.Parameters.AddWithValue("@impTotal", pCbteAutorizado.ImpTotal);
            comAlta.Parameters.AddWithValue("@impTotConc", pCbteAutorizado.ImpTotConc);
            comAlta.Parameters.AddWithValue("@impNeto", pCbteAutorizado.ImpNeto);
            comAlta.Parameters.AddWithValue("@impOpEx", pCbteAutorizado.ImpOpEx);
            comAlta.Parameters.AddWithValue("@impTrib", pCbteAutorizado.ImpTrib);
            comAlta.Parameters.AddWithValue("@impIVA", pCbteAutorizado.ImpIVA);
            comAlta.Parameters.AddWithValue("@fchServDesde", pCbteAutorizado.FchServDesde);
            comAlta.Parameters.AddWithValue("@fchServHasta", pCbteAutorizado.FchServHasta);
            comAlta.Parameters.AddWithValue("@fchVtoPago", pCbteAutorizado.FchVtoPago);
            comAlta.Parameters.AddWithValue("@id_TipoMoneda", pCbteAutorizado.Id_TipoMoneda);
            comAlta.Parameters.AddWithValue("@monCotiz", pCbteAutorizado.MonCotiz);
            comAlta.Parameters.AddWithValue("@resultado", pCbteAutorizado.Resultado);
            comAlta.Parameters.AddWithValue("@codAutorizacion", pCbteAutorizado.CodAutorizacion);
            comAlta.Parameters.AddWithValue("@emisionTipo", pCbteAutorizado.EmisionTipo);
            comAlta.Parameters.AddWithValue("@fchVto", pCbteAutorizado.FchVto);
            comAlta.Parameters.AddWithValue("@fchProceso", pCbteAutorizado.FchProceso);

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
                throw new Exception("No pudo realizar el Alta del Cbte Autorizado");
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
        /// Retorna un DataTable con todos los Cbtes. Autorizados guardados
        /// en la B.D.
        /// </summary>
        /// <returns>Puntos de Venta en DataTable</returns>
        public DataTable TraerTodos()
        {
            DataTable dt = new DataTable();
            string strSql;
            strSql = "SELECT * ";
            strSql += "FROM Comprobantes_Autorizados";

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
        /// Retorna un DataTable con todos los Cbtes. Autorizados de un Punto de Venta 
        /// y Tipo Cbte Especificado
        /// </summary>
        /// <param name="pPtoVenta">Punto de Venta</param>
        /// <param name="pTipoCbte">Tipo de Comprobante</param>
        /// <returns>Puntos de Venta en DataTable</returns>
        public DataTable TraerCbtesEspecifico(int pPtoVenta, int pTipoCbte)
        {
            DataTable dt = new DataTable();
            string strSql;
            strSql = "SELECT * ";
            strSql += "FROM Comprobantes_Autorizados ";
            strSql += "WHERE Id_PtoVenta = " + pPtoVenta.ToString() + " AND Id_TipoCbte = " + pTipoCbte.ToString();

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
        /// Retorna un DataTable con los Cbtes. Autorizados de un Punto de Venta desde un Nro Hasta Otro
        /// y Tipo Cbte Especificado
        /// </summary>
        /// <param name="pPtoVenta">Punto de Venta</param>
        /// <param name="pTipoCbte">Tipo de Comprobante</param>
        /// <returns>Puntos de Venta en DataTable</returns>
        public DataTable TraerCbtesEspecificoNro(int pPtoVenta, int pTipoCbte, int pNroDesde, int pNroHasta)
        {
            DataTable dt = new DataTable();
            string strSql;
            strSql = "SELECT * ";
            strSql += "FROM Comprobantes_Autorizados ";
            strSql += "WHERE Id_PtoVenta = " + pPtoVenta.ToString() + " AND Id_TipoCbte = " + pTipoCbte.ToString();
            strSql += " AND Nro_CbteDesde >= " + pNroDesde.ToString() + " AND Nro_CbteHasta <= " + pNroHasta.ToString();

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
        /// Borra todos los registros de Cbtes. Autorizado en la B.D.
        /// </summary>
        public void BorrarTodos()
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM Comprobantes_Autorizados";

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
        /// Borra todos los registros de Cbtes. Autorizado  de un Punto de Venta y 
        /// Tipo Cbte Especificadoen la B.D.
        /// </summary>
        /// <param name="pPtoVenta">Punto de Venta</param>
        /// <param name="pTipoCbte">Tipo de Comprobante</param>
        public void BorrarCbtesEspecifico(int pPtoVenta, int pTipoCbte)
        {
            string strConsulta = "";

            strConsulta = "DELETE FROM Comprobantes_Autorizados WHERE Id_PtoVenta = " + pPtoVenta.ToString() + " AND Id_TipoCbte = " + pTipoCbte.ToString();

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
        /// Devuelve el Nro de Comprobante Máximo de un Punto de Venta y Tipo de Cbte
        /// </summary>
        /// <param name="pPtoVenta">Punto de Venta</param>
        /// <param name="pTipoCbte">Tipo de Comprobante</param>
        /// <returns></returns>
        public int MaximoNroCbteEspecifico(int pPtoVenta, int pTipoCbte)
        {
            int maxNroCbte=0;
            string strSql;

            strSql = "SELECT MAX(ISNULL(Nro_CbteHasta,0)) ";
            strSql += "FROM Comprobantes_Autorizados ";
            strSql += "WHERE Id_PtoVenta = " + pPtoVenta.ToString() + " AND Id_TipoCbte = " + pTipoCbte.ToString();

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            SqlCommand comMaxNroCbte = new SqlCommand(strSql, objConexion);

            try
            {
                objConexion.Open();

                maxNroCbte = Convert.ToInt32(comMaxNroCbte.ExecuteScalar());
            }
            catch (SqlException)
            {
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                throw new Exception("No pudo devolver el Nro Max de Cbte Autorizado");
            }

            return maxNroCbte;
        }

        /// <summary>
        /// Devuelve el Nro de Comprobante Minimo de un Punto de Venta y Tipo de Cbte
        /// </summary>
        /// <param name="pPtoVenta">Punto de Venta</param>
        /// <param name="pTipoCbte">Tipo de Comprobante</param>
        /// <returns></returns>
        public int MinimoNroCbteEspecifico(int pPtoVenta, int pTipoCbte)
        {
            int minNroCbte = 0;
            string strSql;

            strSql = "SELECT MIN(ISNULL(Nro_CbteDesde,0)) ";
            strSql += "FROM Comprobantes_Autorizados ";
            strSql += "WHERE Id_PtoVenta = " + pPtoVenta.ToString() + " AND Id_TipoCbte = " + pTipoCbte.ToString();

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            SqlCommand comMaxNroCbte = new SqlCommand(strSql, objConexion);

            try
            {
                objConexion.Open();

                minNroCbte = Convert.ToInt32(comMaxNroCbte.ExecuteScalar());
            }
            catch (SqlException)
            {
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                throw new Exception("No pudo devolver el Nro Max de Cbte Autorizado");
            }

            return minNroCbte;
        }
    }
}
