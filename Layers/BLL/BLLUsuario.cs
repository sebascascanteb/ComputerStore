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
    /// Clase BLLUsuario que contiene todos los BLL de Usuario, para llamar a los metodos DAL
    /// </summary>
    class BLLUsuario
    {


        /// <summary>
        /// Método que llama a DALUsuario e inserta un UsuarioDTO en la base de datos si este no existe
        /// y lo edita si ya ese Id es existente
        /// </summary>
        /// <param name="us">Objeto UsuarioDTO para poder ser ingresado</param>
        public void Guardar(UsuarioDTO us)
        {
            if (us == null)
                throw new ApplicationException("No existe el Usuario");
            if (us.Id <= 0)
                throw new ApplicationException("La identificacion debe tener el formato correspondiente");
            if (us.Id.ToString().Length < 9)
                throw new ApplicationException("La identificacion debe tener el formato correspondiente");
            if (us.IdTipoUsuario <= 0)
                throw new ApplicationException("El tipo de usuario es necesario");
            if (us.Nombre == null)
                throw new ApplicationException("El nombre es requerido");
            if (us.Apellido1 == null)
                throw new ApplicationException("El Apellido1 es requerido");
            if (us.Apellido2 == null )
                throw new ApplicationException("El Apellido2 es requerido");
            if (us.Email == null )
                throw new ApplicationException("El Email es requerido");
            if (us.Contrasena == null)
                throw new ApplicationException("La contraseña es requerida");
            if (us.Foto == null)
                throw new ApplicationException("La Foto es requerida");
            if (us.Activo == null)
                throw new ApplicationException("La informacion de Activo es necesaria");

            DALUsuario datos = new DALUsuario();

            if (DALUsuario.SeleccionarPorId(us.Id) == null)
            {
                //si no encuentra el id
                datos.Insertar(us);
            }
            else
            {//si el id existe, entonces lo modifica
                datos.Actualizar(us);
            }
        }


        /// <summary>
        /// Método que llama a DALUsuario y desactiva un UsuarioDTO ya existente en la base de datos
        /// </summary>
        /// <param name="id">valor para identificar que registro de la base de datos a modificar</param>
        public void Desactivar(int id)
        {
            DALUsuario datos = new DALUsuario();

            if (DALUsuario.SeleccionarPorId(id) == null)
                throw new ApplicationException("La identificación no existe");

            datos.Desactivar(id);
        }


        /// <summary>
        /// Método que llama a DALUsuario y recorre los UsuarioDTO que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> ObtenerUsuarios()
        {
            return DALUsuario.SeleccionarTodas();
        }

        /// <summary>
        /// Método que llama a DALUsuario y recorre los UsuarioDTO que existen en la base de datos
        /// para retornarlos en una lista y estos tengan sus contraseñas descencriptadas
        /// </summary>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> ObtenerUsuariosDes()
        {
            return DALUsuario.SeleccionarTodasDes();
        }

        /// <summary>
        /// Método que llama a DALUsuario y recorre los UsuarioDTO que existen en la base de datos
        /// para retornar los que coincidan con el parametro del metodo 
        /// </summary>
        /// <param name="Tipo">valor para filtrar</param>
        /// <returns>List UsuarioDTO </returns>
        public static List<UsuarioDTO> ObtenerUsuariosPorTipo(int tipo)
        {
            return DALUsuario.SeleccionarTodasPorTipo(tipo);
        }
    }
}
