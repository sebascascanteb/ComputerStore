using ComputerStore.Layers.Entities;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace ComputerStore.Layers.DAL
{
    /// <summary>
    /// Clase DALUsuario que contiene todos los DAL de Usuario
    /// </summary>
    class DALUsuario
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que inserta un UsuarioDTO en la base de datos
        /// </summary>
        /// <param name="us">Objeto UsuarioDTO para poder ser ingresado</param>
        public void Insertar(UsuarioDTO us)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_InsertarUsuario";
                    comando.Parameters.AddWithValue("@Id", us.Id);
                    comando.Parameters.AddWithValue("@IdTipoUsuario", us.IdTipoUsuario);
                    comando.Parameters.AddWithValue("@Nombre", us.Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", us.Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", us.Apellido2);
                    comando.Parameters.AddWithValue("@Email", us.Email);
                    comando.Parameters.AddWithValue("@Contrasena", us.Contrasena);
                    comando.Parameters.AddWithValue("@Foto", us.Foto);
                    comando.Parameters.AddWithValue("@Activo", us.Activo);
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método que actualiza un UsuarioDTO ya existente en la base de datos
        /// </summary>
        /// <param name="us">Objeto para poder hacer la actualizacion</param>
        public void Actualizar(UsuarioDTO us)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {

                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_ActualizarUsuario";
                    comando.Parameters.AddWithValue("@Id", us.Id);
                    comando.Parameters.AddWithValue("@IdTipoUsuario", us.IdTipoUsuario);
                    comando.Parameters.AddWithValue("@Nombre", us.Nombre);
                    comando.Parameters.AddWithValue("@Apellido1", us.Apellido1);
                    comando.Parameters.AddWithValue("@Apellido2", us.Apellido2);
                    comando.Parameters.AddWithValue("@Email", us.Email);
                    comando.Parameters.AddWithValue("@Contrasena", us.Contrasena);
                    comando.Parameters.AddWithValue("@Foto", us.Foto);
                    comando.Parameters.AddWithValue("@Activo", us.Activo);
                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }


        /// <summary>
        /// Método que desactiva un UsuarioDTO ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_DesactivarUsuario";
                    comando.Parameters.AddWithValue("@id", id);

                    db.ExecuteNonQuery(comando);
                }
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método que recorre los UsuarioDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarUsuarios]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UsuarioDTO us = new UsuarioDTO();
                        us.Id = (int)dr["Id"];
                        us.IdTipoUsuario = (int)dr["IdTipoUsuario"];
                        us.tipoUsuario = DALTipoUsuario.SeleccionarPorId(us.IdTipoUsuario);
                        us.Nombre = dr["Nombre"].ToString();
                        us.Apellido1 = dr["Apellido1"].ToString();
                        us.Apellido2 = dr["Apellido2"].ToString();
                        us.Email = dr["Email"].ToString();
                        us.Contrasena = dr["Contrasena"].ToString();
                        us.Foto = (byte[])dr["Foto"];
                        us.Activo = (bool)dr["Activo"];
                        lista.Add(us);
                    }
                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Método que recorre los UsuarioDTO que existen en la base de datos
        /// para retornarlos en una lista y estos tengan sus contraseñas descencriptadas
        /// </summary>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> SeleccionarTodasDes()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarUsuariosDes]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UsuarioDTO us = new UsuarioDTO();
                        us.Id = (int)dr["Id"];
                        us.IdTipoUsuario = (int)dr["IdTipoUsuario"];
                        us.tipoUsuario = DALTipoUsuario.SeleccionarPorId(us.IdTipoUsuario);
                        us.Nombre = dr["Nombre"].ToString();
                        us.Apellido1 = dr["Apellido1"].ToString();
                        us.Apellido2 = dr["Apellido2"].ToString();
                        us.Email = dr["Email"].ToString();
                        us.Contrasena = dr["Contrasena"].ToString();
                        us.Foto = (byte[])dr["Foto"];
                        us.Activo = (bool)dr["Activo"];
                        lista.Add(us);
                    }
                }

                return lista;

            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }


        /// <summary>
        /// Método que recorre los UsuarioDTO que existen en la base de datos
        /// para retornar los que coincidan con el parametro del metodo 
        /// </summary>
        /// <param name="Tipo">valor para filtrar</param>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> SeleccionarTodasPorTipo(int Tipo)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<UsuarioDTO> lista = new List<UsuarioDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarUsuariosPorTipo]";
                    comando.Parameters.AddWithValue("@Tipo", Tipo);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UsuarioDTO us = new UsuarioDTO();
                        us.Id = (int)dr["Id"];
                        us.IdTipoUsuario = (int)dr["IdTipoUsuario"];
                        us.tipoUsuario = DALTipoUsuario.SeleccionarPorId(us.IdTipoUsuario);
                        us.Nombre = dr["Nombre"].ToString();
                        us.Apellido1 = dr["Apellido1"].ToString();
                        us.Apellido2 = dr["Apellido2"].ToString();
                        us.Email = dr["Email"].ToString();
                        us.Contrasena = dr["Contrasena"].ToString();
                        us.Foto = (byte[])dr["Foto"];
                        us.Activo = (bool)dr["Activo"];
                        lista.Add(us);
                    }
                }

                return lista;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }


        /// <summary>
        /// Método que recorre los UsuarioDTO que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>UsuarioDTO</returns>
        public static UsuarioDTO SeleccionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarUsuarioPorId";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UsuarioDTO us = new UsuarioDTO();
                        us.Id = (int)dr["Id"];
                        us.IdTipoUsuario = (int)dr["IdTipoUsuario"];
                        us.tipoUsuario = DALTipoUsuario.SeleccionarPorId(us.IdTipoUsuario);
                        us.Nombre = dr["Nombre"].ToString();
                        us.Apellido1 = dr["Apellido1"].ToString();
                        us.Apellido2 = dr["Apellido2"].ToString();
                        us.Email = dr["Email"].ToString();
                        us.Contrasena = dr["Contrasena"].ToString();
                        us.Foto = (byte[])dr["Foto"];
                        us.Activo = (bool)dr["Activo"];

                        return us;
                    }
                }
                return null;
            }
            catch (SqlException sqlError)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("{0}\n", Utilitarios.CreateSQLExceptionsErrorDetails(MethodBase.GetCurrentMethod(), comando, sqlError));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

    }
}
