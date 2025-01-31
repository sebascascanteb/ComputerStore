using ComputerStore.Layers.DAL;
using ComputerStore.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.BLL
{
    /// <summary>
    /// Clase BLLTipoComputadora que contiene todos los BLL de TipoComputadora, para llamar a los metodos DAL
    /// </summary>
    class BLLTipoComputadora
    {

        /// <summary>
        /// Método que llama a DALTipoComputadora y recorre los tipos de computadora que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List TipoComputadora </returns>
        public static List<TipoComputadora> ObtenerTipoComputadoras()
        {
            return DALTipoComputadora.SeleccionarTodas();
        }


        /// <summary>
        /// Método que llama a DALTipoComputadora y recorre los tipos de computadora que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>TipoComputadora</returns>
        public static TipoComputadora ObtenerTipoComputadorasPorId(int id)
        {
            return DALTipoComputadora.SeleccionarPorId(id);
        }
    }
}
