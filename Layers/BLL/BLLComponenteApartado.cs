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
    /// Clase BLLComponenteApartado que contiene todos los BLL de ComponenteApartado, para llamar a los metodos DAL
    /// </summary>
    class BLLComponenteApartado
    {

        /// <summary>
        /// Método que llama a DALComponenteApartado e inserta un ComponenteApartado en la base de datos si este no existe
        /// y lo edita si ya ese Id,IdComponente es existente
        /// </summary>
        /// <param name="com">Objeto ComponenteApartado para poder ser ingresado</param>
        public void Guardar(ComponenteApartado com)
        {
            if (com == null)
                throw new ApplicationException("No existe el componenteApartado");
            if (com.Id <= 0)
                throw new ApplicationException("El número de identificacion es necesario");
            if (com.IdUsuario <= 0)
                throw new ApplicationException("El usuario es necesario");
            if (com.IdComponente <= 0)
                throw new ApplicationException("El componenteA es necesario");
            if (com.Cantidad == null)
                throw new ApplicationException("La cantidad es necesaria");
            if (com.ProvinciaApartado == null)
                throw new ApplicationException("La Provincia es necesaria");
            if (com.Activo == null)
                throw new ApplicationException("La informacion de Activo es requerido");

            DALComponenteApartado datos = new DALComponenteApartado();

            //verifica en la BD si id existe??
            if (DALComponenteApartado.SeleccionarPorId(com.Id,com.IdComponente) == null)
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
        /// Método que llama a DALComponenteApartado y actualiza un ComponenteApartado ya existente en la base de datos
        /// se ingresa el objeto componenteApartado para reemplazar e identificar cual registro va a ser afectado
        /// y el Id del componente que va a ser remplazado
        /// </summary>
        /// <param name="com">Objeto para poder hacer la actualizacion</param>
        /// <param name="idComponenteOLD">identificacion del objeto anterior para poder hacer la actualizacion</param>
        public void ActualizarComponenteApartadoReemplazarComponente(ComponenteApartado com, int idComponenteOLD)
        {
            DALComponenteApartado datos = new DALComponenteApartado();
            datos.ActualizarComponenteApartadoReemplazarComponente(com, idComponenteOLD);
        }


        /// <summary>
        /// Método que llama a DALComponenteApartado y desactiva un ComponenteApartado ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a  modificar</param>
        /// <param name="IdComponente">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id, int idComponente)
        {
            DALComponenteApartado datos = new DALComponenteApartado();

            if (DALComponenteApartado.SeleccionarPorId(id, idComponente) == null)
                throw new ApplicationException("El número de identificación no existe");

            datos.Desactivar(id, idComponente);
        }

        /// <summary>
        /// Método que llama a DALComponenteApartado y desactiva un ComponenteApartado ya existente en la base de datos,
        /// desactiva todos, ya que puede ser mas de un componente apartado
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void DesactivarPorId(int id)
        {
            DALComponenteApartado datos = new DALComponenteApartado();

            if (DALComponenteApartado.SeleccionarPorIdApartado(id) == null)
                throw new ApplicationException("El número de identificación no existe");

            datos.DesactivarPorId(id);
        }


        /// <summary>
        /// Método que llama a DALComponenteApartado y recorre los ComponenteApartado que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComponenteApartado </returns>
        public static List<ComponenteApartado> ObtenerComponentesApartados()
        {
            return DALComponenteApartado.SeleccionarTodas();
        }

        /// <summary>
        /// Método que llama a DALComponenteApartado y recorre los ComponenteApartado que existen en la base de datos
        /// para retornarlos en una lista, siempre y cuando su Activo == true
        /// </summary>
        /// <returns>List ComponenteApartado </returns>
        public static List<ComponenteApartado> ObtenerComponentesApartadosActivo()
        {
            return DALComponenteApartado.SeleccionarTodasActivo();
        }

        /// <summary>
        /// Método que llama a DALComponente y recorre los ComponenteApartado que existen en la base de datos
        /// para retornar los que coinciden con el parametro del metodo,
        /// para tomar los ComponenteApartado por el Id del usuario que realizo el apartado
        /// </summary>
        /// <param name="id">valor para filtrar</param>
        /// <returns>List ComponenteDTO</returns>
        public static List<ComponenteDTO> ObtenerComponentesApartadosPorUsuario (int id)
        {
            return DALComponenteApartado.SeleccionarComponentesApartadosPorUsuario(id);
        }


        /// <summary>
        /// Método que llama a DALComponenteApartado y recorre los ComponenteApartado que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo,
        /// para tomar el ComponenteApartado por el Id del usuario que realizo el apartado
        /// y el componente que apartó
        /// </summary>
        /// <param name="idUsuario">valor para filtrar</param>
        /// <param name="idComponente">valor para filtrar</param>
        /// <returns>ComponenteApartado</returns>
        public static ComponenteApartado ObtenerComponentesApartadosPorUsuarioYComponente(int idUsuario, int idComponente)
        {
            return DALComponenteApartado.SeleccionarComponentesApartadosPorUsuarioYComponente(idUsuario,idComponente);
        }

    }
}
