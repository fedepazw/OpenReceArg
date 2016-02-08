using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Configuracion_Certificado
    {
        /// <summary>
        /// Agrega una configuración a la B.D. 
        /// Siempre esta en el registro Nro 1
        /// Se llama una sola vez para la primer carga, luego se actualiza
        /// con método modificar
        /// </summary>
        /// <param name="pConfigCertificado">Objeto Entidad Certificado</param>
        public void Agregar(Entidades.Configuracion_Certificado pConfigCertificado)
        {
            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT Configuracion_Certificado (Id_Configuracion, Cuit, ArchivoCertificadoPFX, PasswordPFX, TipoAprobacion)";
            strSQL += "VALUES (1, @cuit, @archivoCertificadoPFX, @passwordPFX, @tipoAprobacion)";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@cuit", pConfigCertificado.Cuit);
            comAlta.Parameters.AddWithValue("@archivoCertificadoPFX", pConfigCertificado.ArchivoCertificadoPFX);
            comAlta.Parameters.AddWithValue("@passwordPFX", pConfigCertificado.PasswordPFX);
            comAlta.Parameters.AddWithValue("@tipoAprobacion", pConfigCertificado.TipoAprobacion);

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
                throw new Exception("No pudo realizar el Alta de la configuracion");
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
        /// Modifica la configuración guardada en la B.D.
        /// </summary>
        /// <param name="pConfigCertificado">Objeto Entidad Certificado</param>
        public void Modificar(Entidades.Configuracion_Certificado pConfigCertificado)
        {
            //Declaro variable con la sentencia SQL
            string strSQL = "UPDATE Configuracion_Certificado SET ";
            strSQL += "Cuit = @cuit , ";
            strSQL += "ArchivoCertificadoPFX = @archivoCertificadoPFX , ";
            strSQL += "PasswordPFX = @passwordPFX, ";
            strSQL += "TipoAprobacion = @tipoAprobacion ";
            strSQL += "WHERE Id_Configuracion = 1";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@cuit", pConfigCertificado.Cuit);
            comAlta.Parameters.AddWithValue("@archivoCertificadoPFX", pConfigCertificado.ArchivoCertificadoPFX);
            comAlta.Parameters.AddWithValue("@passwordPFX", pConfigCertificado.PasswordPFX);
            comAlta.Parameters.AddWithValue("@tipoAprobacion", pConfigCertificado.TipoAprobacion);

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
                throw new Exception("No pudo realizar el Alta de la configuracion");
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
        /// Devuelve la configuración cargada en la B.D.
        /// </summary>
        /// <returns></returns>
        public Entidades.Configuracion_Certificado TraerConfiguracion()
        {
            Entidades.Configuracion_Certificado objEntidadesConfigCertificado = new Entidades.Configuracion_Certificado();

            string strSQL = "SELECT Cuit, ArchivoCertificadoPFX, PasswordPFX, TipoAprobacion FROM Configuracion_Certificado WHERE Id_Configuracion = 1";

            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraer = new SqlCommand(strSQL, objConexion);
            SqlDataReader drConfigCertificado;

            try
            {
                objConexion.Open();
                drConfigCertificado = comTraer.ExecuteReader();
                drConfigCertificado.Read();
                if (drConfigCertificado.HasRows)
                {
                    objEntidadesConfigCertificado.Cuit = Convert.ToInt64(drConfigCertificado["Cuit"]);
                    objEntidadesConfigCertificado.ArchivoCertificadoPFX = drConfigCertificado["ArchivoCertificadoPFX"].ToString();
                    objEntidadesConfigCertificado.PasswordPFX = drConfigCertificado["PasswordPFX"].ToString();
                    objEntidadesConfigCertificado.TipoAprobacion = Convert.ToChar(drConfigCertificado["TipoAprobacion"]);
                }

            }
            catch (SqlException)
            {
                //Se produjo un error SQL, SqlExcepcion es especifico de sql por eso va arriba de Excepcion
                throw new Exception("Error en la Base de Datos");
            }
            catch (Exception)
            {
                //Pasa la excepción a la capa de lógica
                throw new Exception("No pudo Listar la Configuracion");
            }
            finally
            {
                //Cierro la conexion solo si estaba abierto
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }

            }

            return objEntidadesConfigCertificado;
        }

    }
}
