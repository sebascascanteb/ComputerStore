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
    /// Clase DALComponenteApartado que contiene todos los DAL de ComponenteApartado
    /// </summary>
    class DALComponenteApartado
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que inserta un ComponenteApartado en la base de datos
        /// </summary>
        /// <param name="com">Objeto ComponenteApartado para poder ser ingresado</param>
        public void Insertar(ComponenteApartado com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_InsertarComponenteApartado";
                    comando.Parameters.AddWithValue("@Id", com.Id);
                    comando.Parameters.AddWithValue("@IdUsuario", com.IdUsuario);
                    comando.Parameters.AddWithValue("@IdComponente", com.IdComponente);
                    comando.Parameters.AddWithValue("@Cantidad", com.Cantidad);
                    comando.Parameters.AddWithValue("@ProvinciaApartado", com.ProvinciaApartado);
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
        /// Método que actualiza un ComponenteApartado ya existente en la base de datos
        /// </summary>
        /// <param name="com">Objeto para poder hacer la actualizacion</param>
        public void Actualizar(ComponenteApartado com)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_ActualizarComponenteApartado";
                    comando.Parameters.AddWithValue(@"Id", com.Id);
                    comando.Parameters.AddWithValue("@IdUsuario", com.IdUsuario);
                    comando.Parameters.AddWithValue("@IdComponente", com.IdComponente);
                    comando.Parameters.AddWithValue("@Cantidad", com.Cantidad);
                    comando.Parameters.AddWithValue("@ProvinciaApartado", com.ProvinciaApartado);
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
        /// Método que actualiza un ComponenteApartado ya existente en la base de datos
        /// se ingresa el objeto componenteApartado para reemplazar e identificar cual registro va a ser afectado
        /// y el Id del componente que va a ser remplazado
        /// </summary>
        /// <param name="com">Objeto para poder hacer la actualizacion</param>
        /// <param name="idComponenteOLD">identificacion del objeto anterior para poder hacer la actualizacion</param>
        public void ActualizarComponenteApartadoReemplazarComponente(ComponenteApartado com, int idComponenteOLD)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_ActualizarComponenteApartadoReemplazarComponente]";
                    comando.Parameters.AddWithValue(@"Id", com.Id);
                    comando.Parameters.AddWithValue("@IdUsuario", com.IdUsuario);
                    comando.Parameters.AddWithValue("@IdComponenteOLD", idComponenteOLD);
                    comando.Parameters.AddWithValue("@IdComponenteNEW", com.IdComponente);
                    comando.Parameters.AddWithValue("@Cantidad", com.Cantidad);
                    comando.Parameters.AddWithValue("@ProvinciaApartado", com.ProvinciaApartado);
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
        /// Método que desactiva un ComponenteApartado ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a  modificar</param>
        /// <param name="IdComponente">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id, int IdComponente)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_DesactivarComponenteApartado";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@IdComponente", IdComponente);

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
        /// Método que desactiva un ComponenteApartado ya existente en la base de datos,
        /// desactiva todos, ya que puede ser mas de un componente apartado
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void DesactivarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_DesactivarComponenteApartadoId]";
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
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComponenteApartado </returns>
        public static List<ComponenteApartado> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteApartado> lista = new List<ComponenteApartado>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComponentesApartados";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteApartado com = new ComponenteApartado();
                        com.Id = (int)dr["Id"];
                        com.IdUsuario = (int)dr["IdUsuario"];
                        com.IdComponente = (int)dr["IdComponente"];
                        com.Cantidad = (int)dr["Cantidad"];
                        com.ProvinciaApartado = dr["ProvinciaApartado"].ToString();
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
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornarlos en una lista, siempre y cuando su Activo == true
        /// </summary>
        /// <returns>List ComponenteApartado </returns>
        public static List<ComponenteApartado> SeleccionarTodasActivo()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteApartado> lista = new List<ComponenteApartado>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponentesApartadosActivo]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteApartado com = new ComponenteApartado();
                        com.Id = (int)dr["Id"];
                        com.IdUsuario = (int)dr["IdUsuario"];
                        com.IdComponente = (int)dr["IdComponente"];
                        com.Cantidad = (int)dr["Cantidad"];
                        com.ProvinciaApartado = dr["ProvinciaApartado"].ToString();
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
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <param name="idComponente">valor para filtrar</param>
        /// <returns>ComponenteApartado</returns>
        public static ComponenteApartado SeleccionarPorId(int id, int idComponente)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponenteApartadoPorId]";
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@IdComponente", idComponente);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteApartado com = new ComponenteApartado();
                        com.Id = (int)dr["Id"];
                        com.IdUsuario = (int)dr["IdUsuario"];
                        com.IdComponente = (int)dr["IdComponente"];
                        com.Cantidad = (int)dr["Cantidad"];
                        com.ProvinciaApartado = dr["ProvinciaApartado"].ToString();
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


        /// <summary>
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo,
        /// para tomar los ComponenteApartado por el Id del apartado
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>ComponenteApartado</returns>
        public static ComponenteApartado SeleccionarPorIdApartado(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponenteApartadoPorIdApartado]";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteApartado com = new ComponenteApartado();
                        com.Id = (int)dr["Id"];
                        com.IdUsuario = (int)dr["IdUsuario"];
                        com.IdComponente = (int)dr["IdComponente"];
                        com.Cantidad = (int)dr["Cantidad"];
                        com.ProvinciaApartado = dr["ProvinciaApartado"].ToString();
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

        /// <summary>
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornar los que coinciden con el parametro del metodo,
        /// para tomar los ComponenteApartado por el Id del usuario que realizo el apartado
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>List ComponenteDTO</returns>
        public static List<ComponenteDTO> SeleccionarComponentesApartadosPorUsuario(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComponenteDTO> lista = new List<ComponenteDTO>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponentesApartadosPorUsuario]";
                    comando.Parameters.AddWithValue("@idUsuario", id);


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
        /// Método que recorre los ComponenteApartado que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo,
        /// para tomar el ComponenteApartado por el Id del usuario que realizo el apartado
        /// y el componente que apartó
        /// </summary>
        /// <param name="idUsuario">valor para filtrar</param>
        /// <param name="idComponente">valor para filtrar</param>
        /// <returns>ComponenteApartado</returns>
        public static ComponenteApartado SeleccionarComponentesApartadosPorUsuarioYComponente(int idUsuario, int idComponente)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComponentesApartadosPorUsuarioYComponente]";
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@idComponente", idComponente);


                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComponenteApartado com = new ComponenteApartado();
                        com.Id = (int)dr["Id"];
                        com.IdUsuario = (int)dr["IdUsuario"];
                        com.IdComponente = (int)dr["IdComponente"];
                        com.Cantidad = (int)dr["Cantidad"];
                        com.ProvinciaApartado = dr["ProvinciaApartado"].ToString();
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
