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
    /// Clase DALFactura que contiene todos los DAL de Factura
    /// </summary>
    class DALFactura
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");


        /// <summary>
        /// Método que inserta una Factura en la base de datos
        /// </summary>
        /// <param name="fa">Objeto Factura para poder ser ingresado</param>
        public void Insertar(Factura fa)
        {
            SqlCommand comando = new SqlCommand();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_InsertarFactura]";
                    comando.Parameters.AddWithValue("@IdComputadora", fa.IdComputadora);
                    comando.Parameters.AddWithValue("@IdUsuario", fa.IdUsuario);
                    comando.Parameters.AddWithValue("@Descripcion", fa.Descripcion);
                    comando.Parameters.AddWithValue("@Fecha", fa.Fecha);
                    comando.Parameters.AddWithValue("@TotalColones", fa.TotalColones);
                    comando.Parameters.AddWithValue("@TotalDolar", fa.TotalDolar);


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
        /// Método que actualiza una Factura ya existente en la base de datos
        /// </summary>
        /// <param name="fa">Objeto para poder hacer la actualizacion</param>
        public void Actualizar(Factura fa)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_ActualizarFactura]";
                    comando.Parameters.AddWithValue("@Id", fa.Id);
                    comando.Parameters.AddWithValue("@IdComputadora", fa.IdComputadora);
                    comando.Parameters.AddWithValue("@IdUsuario", fa.IdUsuario);
                    comando.Parameters.AddWithValue("@Descripcion", fa.Descripcion);
                    comando.Parameters.AddWithValue("@Fecha", fa.Fecha);
                    comando.Parameters.AddWithValue("@TotalColones", fa.TotalColones);
                    comando.Parameters.AddWithValue("@TotalDolar", fa.TotalDolar);
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
        /// Método que recorre las Facturas que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List Factura </returns>
        public static List<Factura> SeleccionarTodas()
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                List<Factura> lista = new List<Factura>();
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarFacturas]";

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Factura fa = new Factura();
                        fa.Id = (int)dr["Id"];
                        fa.IdComputadora = (int)dr["IdComputadora"];
                        fa.IdUsuario = (int)dr["IdUsuario"];
                        fa.Descripcion = dr["Descripcion"].ToString();
                        fa.Fecha = (DateTime)dr["Fecha"];
                        fa.TotalColones = float.Parse(dr["TotalColones"].ToString());
                        fa.TotalDolar = float.Parse(dr["TotalDolar"].ToString());

                        lista.Add(fa);
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
        /// Método que recorre las Facturas que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>Factura</returns>
        public static Factura SeleccionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "[PA_SeleccionarFacturaPorId]";
                    comando.Parameters.AddWithValue("@id", id);

                    DataSet ds = db.ExecuteDataSet(comando);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Factura fa = new Factura();
                        fa.Id = (int)dr["Id"];
                        fa.IdComputadora = (int)dr["IdComputadora"];
                        fa.IdUsuario = (int)dr["IdUsuario"];
                        fa.Descripcion = dr["Descripcion"].ToString();
                        fa.Fecha = (DateTime)dr["Fecha"];
                        fa.TotalColones = float.Parse(dr["TotalColones"].ToString());
                        fa.TotalDolar = float.Parse(dr["TotalDolar"].ToString());

                        return fa;
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
