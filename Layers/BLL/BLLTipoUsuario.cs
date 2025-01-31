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
    /// Clase BLLTipoUsuario que contiene todos los BLL de TipoUsuario, para llamar a los metodos DAL
    /// </summary>
    class BLLTipoUsuario
    {


        /// <summary>
        /// Método que llama a DALTipoUsuario y recorre los tipos de usuario que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List TipoUsuario </returns>
        public static List<TipoUsuario> ObtenerTipoUsuarios()
        {
            return DALTipoUsuario.SeleccionarTodas();
        }

        /// <summary>
        /// Método que llama a DALTipoUsuario y recorre los tipos de usuario que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>TipoUsuario</returns>
        public static TipoUsuario ObtenerTipoUsuarioPorId(int id)
        {
            return DALTipoUsuario.SeleccionarPorId(id);
        }
    }
}
