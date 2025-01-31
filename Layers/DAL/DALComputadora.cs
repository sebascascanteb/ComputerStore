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
    /// Clase DALComputadora que contiene todos los DAL de Computadora
    /// </summary>
    class DALComputadora
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// Método que inserta un ComputadoraDTO en la base de datos
        /// </summary>
        /// <param name="com">Objeto ComputadoraDTO para poder ser ingresado</param>
        public void Insertar(ComputadoraDTO com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_InsertarComputadora";
                    comando.Parameters.AddWithValue("@IdTipoComputadora", com.IdTipoComputadora);
                    comando.Parameters.AddWithValue("@Nombre", com.Nombre);
                    comando.Parameters.AddWithValue("@Activo", com.Activo);
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
        /// Método que actualiza un ComputadoraDTO ya existente en la base de datos
        /// </summary>
        /// <param name="com">Objeto para poder hacer la actualizacion</param>
        public void Actualizar(ComputadoraDTO com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_ActualizarComputadora";
                    comando.Parameters.AddWithValue("@Id", com.Id);
                    comando.Parameters.AddWithValue("@IdTipoComputadora", com.IdTipoComputadora);
                    comando.Parameters.AddWithValue("@Nombre", com.Nombre);
                    comando.Parameters.AddWithValue("@Activo", com.Activo);
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
        /// Método que desactiva un ComputadoraDTO ya existente en la base de datos
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
                    comando.CommandText = "PA_DesactivarComputadora";
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
        /// Método que recorre los ComputadoraDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComputadoraDTO </returns>
        public static List<ComputadoraDTO> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComputadoraDTO> lista = new List<ComputadoraDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComputadoras";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraDTO com = new ComputadoraDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Activo = (bool)dr["Activo"];
                        lista.Add(com);
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
        /// Método que recorre los ComputadoraDTO que existen en la base de datos
        /// para retornarlos en una lista y esten Activos
        /// </summary>
        /// <returns>List ComputadoraDTO </returns>
        public static List<ComputadoraDTO> SeleccionarTodasActivo()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComputadoraDTO> lista = new List<ComputadoraDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComputadorasActivo]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraDTO com = new ComputadoraDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Activo = (bool)dr["Activo"];
                        lista.Add(com);
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
        /// Método que recorre los ComputadoraDTO que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>ComputadoraDTO</returns>
        public static ComputadoraDTO SeleccionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComputadoraPorId";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraDTO com = new ComputadoraDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Activo = (bool)dr["Activo"];
                        return com;
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
