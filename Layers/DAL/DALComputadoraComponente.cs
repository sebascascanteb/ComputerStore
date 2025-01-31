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
    /// Clase DALComputadoraComponente que contiene todos los DAL de ComputadoraComponente
    /// </summary>
    class DALComputadoraComponente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que inserta un ComputadoraComponente en la base de datos
        /// </summary>
        /// <param name="compComp">Objeto ComputadoraComponente para poder ser ingresado</param>
        public void Insertar(ComputadoraComponente compComp)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_InsertarComputadoraComponente]";
                    comando.Parameters.AddWithValue("@IdComputadora", compComp.IdComputadora);
                    comando.Parameters.AddWithValue("@IdComponente", compComp.IdComponente);
                    comando.Parameters.AddWithValue("@PrecioComponente", compComp.PrecioComponente);
                    comando.Parameters.AddWithValue("@Cantidad", compComp.Cantidad);
                    comando.Parameters.AddWithValue("@Impuesto", compComp.Impuesto);
                    comando.Parameters.AddWithValue("@TotalColones", compComp.TotalColones);
                    comando.Parameters.AddWithValue("@TotalDolares", compComp.TotalDolar);

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
        /// Método que recorre los ComputadoraComponentes que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComputadoraComponente </returns>
        public static List<ComputadoraComponente> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComputadoraComponente> lista = new List<ComputadoraComponente>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarComputadorasComponentes]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraComponente compComp = new ComputadoraComponente();
                        compComp.IdComputadora = (int)dr["IdComputadora"];
                        compComp.IdComponente = (int)dr["IdComponente"];
                        compComp.PrecioComponente = float.Parse(dr["PrecioComponente"].ToString());
                        compComp.Cantidad = (int)dr["Cantidad"];
                        compComp.Impuesto = float.Parse(dr["Impuesto"].ToString());
                        compComp.TotalColones = float.Parse(dr["TotalColones"].ToString());
                        compComp.TotalDolar = float.Parse(dr["TotalDolar"].ToString());

                        lista.Add(compComp);
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
        /// Método que recorre los ComputadoraComponentes que existen en la base de datos
        /// para retornar el que coincide con los parametros del metodo 
        /// </summary>
        /// <param name="idComputadora">valore para filtrar</param>
        /// <param name="idComponente">valore para filtrar</param>
        /// <returns>ComputadoraComponente</returns>
        public static ComputadoraComponente SeleccionarPorId(int idComputadora, int idComponente)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComputadoraComponentePorId";
                    comando.Parameters.AddWithValue("@idComputadora", idComputadora);
                    comando.Parameters.AddWithValue("@idComponente", idComponente);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraComponente compComp = new ComputadoraComponente();
                        compComp.IdComputadora = (int)dr["IdComputadora"];
                        compComp.IdComponente = (int)dr["IdComponente"];
                        compComp.PrecioComponente = float.Parse(dr["PrecioComponente"].ToString());
                        compComp.Cantidad = (int)dr["Cantidad"];
                        compComp.Impuesto = float.Parse(dr["Impuesto"].ToString());
                        compComp.TotalColones = float.Parse(dr["TotalColones"].ToString());
                        compComp.TotalDolar = float.Parse(dr["TotalDolar"].ToString());
                        return compComp;
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
        /// Método que recorre los ComputadoraComponentes que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="idComputadora">valore para filtrar</param>
        /// <returns>ComputadoraComponente</returns>
        public static List<ComputadoraComponente> SeleccionarPorIdComputadora(int idComputadora)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<ComputadoraComponente> lista = new List<ComputadoraComponente>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "PA_SeleccionarComputadoraComponentePorIdComputadora";
                    comando.Parameters.AddWithValue("@idComputadora", idComputadora);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ComputadoraComponente compComp = new ComputadoraComponente();
                        compComp.IdComputadora = (int)dr["IdComputadora"];
                        compComp.IdComponente = (int)dr["IdComponente"];
                        compComp.PrecioComponente = float.Parse(dr["PrecioComponente"].ToString());
                        compComp.Cantidad = (int)dr["Cantidad"];
                        compComp.Impuesto = float.Parse(dr["Impuesto"].ToString());
                        compComp.TotalColones = float.Parse(dr["TotalColones"].ToString());
                        compComp.TotalDolar = float.Parse(dr["TotalDolar"].ToString());

                        lista.Add(compComp);
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

    }
}
