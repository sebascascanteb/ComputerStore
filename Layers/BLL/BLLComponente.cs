using ComputerStore.Layers.DAL;
using ComputerStore.Layers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.BLL
{
    /// <summary>
    /// Clase BLLComponente que contiene todos los BLL de Componente, para llamar a los metodos DAL
    /// </summary>
    class BLLComponente
    {

        /// <summary>
        /// Método que llama a DALComponente e inserta un ComponenteDTO en la base de datos si este no existe
        /// y lo edita si ya ese Id es existente
        /// </summary>
        /// <param name="com">Objeto ComponenteDTO para poder ser ingresado</param>
        public void Guardar(ComponenteDTO com)
        {
            if (com == null)
                throw new ApplicationException("No existe el componenteA");
            //if (com.Id <= 0)
            //    throw new ApplicationException("El número de identificacion es necesario");
            if (com.IdTipoComputadora <= 0)
                throw new ApplicationException("El tipo de computadora es necesario");
            if (com.IdTipoComponente <= 0)
                throw new ApplicationException("El tipo de componenteA es necesario");
            if (com.Nombre == null)
                throw new ApplicationException("El nombre del componenteA es requerido");
            if (com.Imagen == null)
                throw new ApplicationException("La Imagen es requerida");
            if (com.LinkFabricante == null)
                throw new ApplicationException("El link del fabricante para el componenteA es requerido");
            if (com.FechaIngreso == null)
                throw new ApplicationException("La fecha de ingreso del componenteA es requerida");
            if (com.FechaIngreso == null)
                throw new ApplicationException("El del componenteA es requerido");
            if (com.Cantidad == null)
                throw new ApplicationException("La cantidad es necesaria");
            if (com.Activo == null)
                throw new ApplicationException("La informacion de Activo es requerido");

            DALComponente datos = new DALComponente();

            //verifica en la BD si id existe??
            if (DALComponente.SeleccionarPorId(com.Id) == null)
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
        /// Método que llama a DALComponente y desactiva un ComponenteDTO ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id)
        {
            DALComponente datos = new DALComponente();

            if (DALComponente.SeleccionarPorId(id) == null)
                throw new ApplicationException("El número de identificación no existe");

            datos.Desactivar(id);
        }

        /// <summary>
        /// Método que llama a DALComponente y recorre los ComponenteDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> ObtenerComponentes()
        {
            return DALComponente.SeleccionarTodas();
        }

        /// <summary>
        /// Método que llama a DALComponente y recorre los ComponenteDTO que existen en la base de datos
        /// para retornarlos en una lista y su Activo == true
        /// </summary>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> ObtenerComponentesActivo()
        {
            return DALComponente.SeleccionarTodasActivo();
        }

        /// <summary>
        /// Método que llama a DALComponente y recorre los ComponenteDTO que existen en la base de datos
        /// para retornar los que coincidan con el parametro del metodo 
        /// </summary>
        /// <param name="idTipoComponente">valor para filtrar</param>
        /// <returns>List ComponenteDTO </returns>
        public static List<ComponenteDTO> ObtenerComponentesActivoPorTipoComponente(int idTipoComponente)
        {
            return DALComponente.SeleccionarComponenteActivoPorTipoComponente(idTipoComponente);
        }

        
    }
}
