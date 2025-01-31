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
    /// Clase DALComponente que contiene todos los DAL de Componente
    /// </summary>
    class DALComponente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que inserta un ComponenteDTO en la base de datos
        /// </summary>
        /// <param name="com">Objeto ComponenteDTO para poder ser ingresado</param>
        public void Insertar(ComponenteDTO com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_InsertarComponente";
                    comando.Parameters.AddWithValue("@IdTipoComputadora", com.IdTipoComputadora);
                    comando.Parameters.AddWithValue("@IdTipoComponente", com.IdTipoComponente);
                    comando.Parameters.AddWithValue("@Nombre", com.Nombre);
                    comando.Parameters.AddWithValue("@Imagen", com.Imagen);
                    comando.Parameters.AddWithValue("@LinkFabricante", com.LinkFabricante);
                    comando.Parameters.AddWithValue("@FechaIngreso", com.FechaIngreso);
                    comando.Parameters.AddWithValue("@Precio", com.Precio);
                    comando.Parameters.AddWithValue("@Cantidad", com.Cantidad);
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
        /// Método que actualiza un ComponenteDTO ya existente en la base de datos
        /// </summary>
        /// <param name="com">Objeto para poder hacer la actualizacion</param>
        public void Actualizar(ComponenteDTO com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_ActualizarComponente";
                    comando.Parameters.AddWithValue("@Id", com.Id);
                    comando.Parameters.AddWithValue("@IdTipoComputadora", com.IdTipoComputadora);
                    comando.Parameters.AddWithValue("@IdTipoComponente", com.IdTipoComponente);
                    comando.Parameters.AddWithValue("@Nombre", com.Nombre);
                    comando.Parameters.AddWithValue("@Imagen", com.Imagen);
                    comando.Parameters.AddWithValue("@LinkFabricante", com.LinkFabricante);
                    comando.Parameters.AddWithValue("@FechaIngreso", com.FechaIngreso);
                    comando.Parameters.AddWithValue("@Precio", com.Precio);
                    comando.Parameters.AddWithValue("@Cantidad", com.Cantidad);
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
        /// Método que desactiva un ComponenteDTO ya existente en la base de datos
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
                    comando.CommandText = "PA_DesactivarComponente";
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
        /// Método que recorre los ComponenteDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteDTO> lista = new List<ComponenteDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponentes]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteDTO com = new ComponenteDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.IdTipoComponente = (int)dr["IdTipoComponente"];
                        com.tipoComponente = DALTipoComponente.SeleccionarPorId(com.IdTipoComponente);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Imagen = (byte[])dr["Imagen"];
                        com.LinkFabricante = dr["LinkFabricante"].ToString();
                        com.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                        com.Precio = float.Parse(dr["Precio"].ToString());
                        com.Cantidad = (int)dr["Cantidad"];
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
        /// Método que recorre los ComponenteDTO que existen en la base de datos
        /// para retornarlos en una lista y estos tengan Activo == true
        /// </summary>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> SeleccionarTodasActivo()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteDTO> lista = new List<ComponenteDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponentesActivo]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteDTO com = new ComponenteDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.IdTipoComponente = (int)dr["IdTipoComponente"];
                        com.tipoComponente = DALTipoComponente.SeleccionarPorId(com.IdTipoComponente);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Imagen = (byte[])dr["Imagen"];
                        com.LinkFabricante = dr["LinkFabricante"].ToString();
                        com.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                        com.Precio = float.Parse(dr["Precio"].ToString());
                        com.Cantidad = (int)dr["Cantidad"];
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
        /// Método que recorre los ComponenteDTO que existen en la base de datos
        /// para retornar los que coincidan con el parametro del metodo 
        /// </summary>
        /// <param name="IdTipoComponente">valor para filtrar</param>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> SeleccionarComponenteActivoPorTipoComponente(int IdTipoComponente)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteDTO> lista = new List<ComponenteDTO>();


                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComponenteActivoPorTipoComponente";
                    comando.Parameters.AddWithValue("@IdTipoComponente", IdTipoComponente);

                    IDataReader reader = db.ExecuteReader(comando);

                    while (reader.Read())
                    {
                        ComponenteDTO com = new ComponenteDTO();
                        com.Id = (int)reader["Id"];
                        com.IdTipoComputadora = (int)reader["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.IdTipoComponente = (int)reader["IdTipoComponente"];
                        com.tipoComponente = DALTipoComponente.SeleccionarPorId(com.IdTipoComponente);
                        com.Nombre = reader["Nombre"].ToString();
                        com.Imagen = (byte[])reader["Imagen"];
                        com.LinkFabricante = reader["LinkFabricante"].ToString();
                        com.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                        com.Precio = float.Parse(reader["Precio"].ToString());
                        com.Cantidad = (int)reader["Cantidad"];
                        com.Activo = (bool)reader["Activo"];

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
        /// Método que recorre los ComponenteDTO que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>ComponenteDTO</returns>
        public static ComponenteDTO SeleccionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComponentePorId";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteDTO com = new ComponenteDTO();
                        com.Id = (int)dr["Id"];
                        com.IdTipoComputadora = (int)dr["IdTipoComputadora"];
                        com.tipoComputadora = DALTipoComputadora.SeleccionarPorId(com.IdTipoComputadora);
                        com.IdTipoComponente = (int)dr["IdTipoComponente"];
                        com.tipoComponente = DALTipoComponente.SeleccionarPorId(com.IdTipoComponente);
                        com.Nombre = dr["Nombre"].ToString();
                        com.Imagen = (byte[])dr["Imagen"];
                        com.LinkFabricante = dr["LinkFabricante"].ToString();
                        com.FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"]);
                        com.Precio = float.Parse(dr["Precio"].ToString());
                        com.Cantidad = (int)dr["Cantidad"];
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
