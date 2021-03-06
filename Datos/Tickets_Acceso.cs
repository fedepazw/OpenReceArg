﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class Tickets_Acceso
    {
        /// <summary>
        /// Agrega un Ticket de Acceso en la base de Datos
        /// </summary>
        /// <param name="pTicket">Objeto Ticket</param>
        public void Agregar(Entidades.Tickets_Acceso pTicket)
        {
            //Declaro variable con la sentencia SQL
            string strSQL = "INSERT tickets_acceso (fecha_generacion, fecha_expiracion, sign, token, tipoAprobacion, cuit)";
            strSQL += "VALUES (@fecha_generacion, @fecha_expiracion, @sign, @token, @tipoAprobacion, @cuit)";

            //Crear objeto de la clase SQLConnection
            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);

            //Crear objeto de SQLCommand
            SqlCommand comAlta = new SqlCommand(strSQL, objConexion);

            //Cargo los valores de los parametros
            comAlta.Parameters.AddWithValue("@fecha_generacion", pTicket.Fecha_Generacion);
            comAlta.Parameters.AddWithValue("@fecha_expiracion", pTicket.Fecha_Expiracion);
            comAlta.Parameters.AddWithValue("@sign", pTicket.Sign);
            comAlta.Parameters.AddWithValue("@token", pTicket.Token);
            comAlta.Parameters.AddWithValue("@tipoAprobacion", pTicket.TipoAprobacion);
            comAlta.Parameters.AddWithValue("@cuit", pTicket.Cuit);

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
                throw new Exception("No pudo realizar el Alta del Ticket");
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
        /// Devuelve de la B.D. un Ticket de Acceso Vigente
        /// </summary>
        /// <returns></returns>
        public Entidades.Tickets_Acceso TraerTicketActivo()
        {
            Entidades.Tickets_Acceso objEntidadesTicket_Acceso = new Entidades.Tickets_Acceso();

            string strSQL = "SELECT id_ticket, fecha_generacion, fecha_expiracion, sign, token, tipoAprobacion, cuit FROM Tickets_Acceso WHERE id_ticket = (SELECT ISNULL(MAX(id_ticket),0) FROM Tickets_Acceso WHERE fecha_expiracion>GETDATE())";

            SqlConnection objConexion = new SqlConnection(Conexion.strConexion);
            SqlCommand comTraer = new SqlCommand(strSQL, objConexion);
            SqlDataReader drTicket;

            try
            {
                objConexion.Open();
                drTicket = comTraer.ExecuteReader();
                drTicket.Read();
                if (drTicket.HasRows)
                {
                    objEntidadesTicket_Acceso.Id_Ticket = Convert.ToUInt32(drTicket["id_ticket"]);
                    objEntidadesTicket_Acceso.Fecha_Generacion = Convert.ToDateTime(drTicket["fecha_generacion"].ToString());
                    objEntidadesTicket_Acceso.Fecha_Expiracion = Convert.ToDateTime(drTicket["fecha_expiracion"].ToString());
                    objEntidadesTicket_Acceso.Sign = drTicket["sign"].ToString();
                    objEntidadesTicket_Acceso.Token = drTicket["token"].ToString();
                    objEntidadesTicket_Acceso.TipoAprobacion = Convert.ToChar(drTicket["tipoAprobacion"]);
                    objEntidadesTicket_Acceso.Cuit = Convert.ToInt64(drTicket["cuit"]);
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
                throw new Exception("No pudo Listar un Ticket");
            }
            finally
            {
                //Cierro la conexion solo si estaba abierto
                if (objConexion.State == ConnectionState.Open)
                {
                    objConexion.Close();
                }

            }

            return objEntidadesTicket_Acceso;
        }

        /// <summary>
        /// Inactiva un Ticket de Acceso Activo
        /// </summary>
        public void DesactivarTicketActivo()
        {
            string strConsulta = "";

            strConsulta = "UPDATE Tickets_Acceso SET fecha_expiracion = GETDATE() WHERE fecha_expiracion > GETDATE()";

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
