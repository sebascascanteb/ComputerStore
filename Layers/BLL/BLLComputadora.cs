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
    /// Clase BLLComputadora que contiene todos los BLL de Computadora, para llamar a los metodos DAL
    /// </summary>
    class BLLComputadora
    {

        /// <summary>
        /// Método que llama a DALComputadora e inserta un ComputadoraDTO en la base de datos si este no existe
        /// y lo edita si ya ese Id es existente
        /// </summary>
        /// <param name="com">Objeto ComputadoraDTO para poder ser ingresado</param>
        public void Guardar(ComputadoraDTO com)
        {
            if (com == null)
                throw new ApplicationException("No existe el componenteA");
            
            if (com.IdTipoComputadora <= 0)
                throw new ApplicationException("El tipo de computadora es necesario");
          
            if (com.Nombre == null)
                throw new ApplicationException("El nombre del componenteA es requerido");
            
            if (com.Activo == null)
                throw new ApplicationException("La informacion de Activo es requerido");

            DALComputadora datos = new DALComputadora();

            //verifica en la BD si id existe??
            if (DALComputadora.SeleccionarPorId(com.Id) == null)
            {
                //si no encuentra el id
                datos.Insertar(com);
            }
            else
            {//si el id existe, entonces lo modifica
                datos.Actualizar(com);
            }
        }


        /// <summary>
        /// Método que llama a DALComputadora y desactiva un ComputadoraDTO ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id)
        {
            DALComputadora datos = new DALComputadora();

            if (DALComputadora.SeleccionarPorId(id) == null)
                throw new ApplicationException("El número de identificación no existe");

            datos.Desactivar(id);
        }


        /// <summary>
        /// Método que llama a DALComputadora y recorre los ComputadoraDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComputadoraDTO </returns>
        public static List<ComputadoraDTO> ObtenerComputadoras()
        {
            return DALComputadora.SeleccionarTodas();
        }

        /// <summary>
        /// Método que llama a DALComputadora y recorre los ComputadoraDTO que existen en la base de datos
        /// para retornar los que tengan su Activo == true
        /// </summary>
        /// <returns>List ComputadoraDTO </returns>
        public static List<ComputadoraDTO> ObtenerComputadorasActivo()
        {
            return DALComputadora.SeleccionarTodasActivo();
        }
    }
}
