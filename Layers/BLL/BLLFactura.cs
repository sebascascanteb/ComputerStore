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
    /// Clase BLLFactura que contiene todos los BLL de Factura, para llamar a los metodos DAL
    /// </summary>
    class BLLFactura
    {

        /// <summary>
        /// Método que llama a DALFactura e inserta una Factura en la base de datos si este no existe
        /// y lo edita si ya ese Id es existente
        /// </summary>
        /// <param name="fa">Objeto Factura para poder ser ingresado</param>
        public void Guardar(Factura fa)
        {
            //if (fa.Id <= 0)
            //    throw new ApplicationException("El id es necesario");
            if (fa.IdComputadora <= 0)
                throw new ApplicationException("El id de computadora es necesario");
            if (fa.IdUsuario <= 0)
                throw new ApplicationException("El id de usuario es necesario");
            if (string.IsNullOrEmpty(fa.Descripcion))
                throw new ApplicationException("La descripción es requerida");
            if (fa.Fecha == DateTime.MinValue)
                throw new ApplicationException("La fecha es requerida");
            if (fa.TotalColones <= 0)
                throw new ApplicationException("El total en colones es necesario");
            if (fa.TotalDolar <= 0)
                throw new ApplicationException("El total en dólares es necesario");

            DALFactura datos = new DALFactura();

            //verifica en la BD si id existe??
            if (DALFactura.SeleccionarPorId(fa.Id) == null)
            {
                //si no encuentra el id
                datos.Insertar(fa);
            }
            else
            {//si el id existe, entonces lo modifica
                datos.Actualizar(fa);
            }
        }


        /// <summary>
        /// Método que llama a DALFactura y recorre los Factura que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List Factura </returns>

        public static List<Factura> ObtenerFacturas()
        {
            return DALFactura.SeleccionarTodas();
        }


    }
}
