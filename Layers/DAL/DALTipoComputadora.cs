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
    /// Clase DALTipoComputadora que contiene todos los DAL de TipoComputadora
    /// </summary>
    class DALTipoComputadora
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que recorre los tipos de Computadora que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List TipoComputadora </returns>
        public static List<TipoComputadora> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<TipoComputadora> lista = new List<TipoComputadora>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarTipoComputadoras";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        TipoComputadora tc = new TipoComputadora();
                        tc.Id = (int)dr["Id"];
                        tc.Descripcion = dr["Descripcion"].ToString();
                        lista.Add(tc);
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
        /// Método que recorre los tipos de computadora que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>TipoComputadora</returns>
        public static TipoComputadora SeleccionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarTipoComputadoraPorId";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        TipoComputadora tc = new TipoComputadora();
                        tc.Id = (int)dr["Id"];
                        tc.Descripcion = dr["Descripcion"].ToString();
                        return tc;
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
