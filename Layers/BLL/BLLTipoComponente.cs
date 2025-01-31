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
    /// Clase BLLTipoComponente que contiene todos los BLL de TipoComponente, para llamar a los metodos DAL
    /// </summary>
    class BLLTipoComponente
    {
        /// <summary>
        /// Método que llama a DALTipoComponente y recorre los tipos de componente que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List TipoComponente </returns>
        public static List<TipoComponente> ObtenerTipoComponentes()
        {
            return DALTipoComponente.SeleccionarTodas();
        }


        /// <summary>
        /// Método que llama a DALTipoComponente y recorre los tipos de Componente que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>TipoComponente</returns>
        public static TipoComponente ObtenerTipoComponentePorId(int id)
        {
            return DALTipoComponente.SeleccionarPorId(id);
        }
    }
}
