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
    /// Clase BLLComputadoraComponente que contiene todos los BLL de ComputadoraComponente, para llamar a los metodos DAL
    /// </summary>
    class BLLComputadoraComponente
    {

        /// <summary>
        /// Método que llama a DALComputadoraComponente e inserta un ComputadoraComponente en la base de datos si este no existe
        /// </summary>
        /// <param name="compComp">Objeto ComputadoraComponente para poder ser ingresado</param>
        public void Guardar(ComputadoraComponente compComp)
        {
            if (compComp == null)
                throw new ApplicationException("No existe la relación entre la Computadora y el Componente");
            if (compComp.IdComputadora <= 0)
                throw new ApplicationException("El Id de la Computadora debe tener el formato correspondiente");
            if (compComp.IdComponente <= 0)
                throw new ApplicationException("El Id del Componente debe tener el formato correspondiente");
            if (compComp.Cantidad <= 0)
                throw new ApplicationException("La cantidad debe ser mayor a cero");
            if (compComp.PrecioComponente <= 0)
                throw new ApplicationException("El precio del computadora debe ser mayor a cero");
            if (compComp.Impuesto < 0)
                throw new ApplicationException("El impuesto no puede ser un valor negativo");
            if (compComp.TotalColones <= 0)
                throw new ApplicationException("El monto total debe ser mayor a cero");
            if (compComp.TotalDolar <= 0)
                throw new ApplicationException("El monto total debe ser mayor a cero");


            DALComputadoraComponente datos = new DALComputadoraComponente();

            // Verifica en la BD si la relación existe
            if (DALComputadoraComponente.SeleccionarPorId(compComp.IdComputadora, compComp.IdComponente) == null)
            {
                // Si no encuentra la relación, inserta la ComputadoraComponente
                datos.Insertar(compComp);
            }
            
        }



        /// <summary>
        /// Método que llama a DALComputadoraComponente y recorre los ComputadoraComponente que existen en la base de datos
        /// para retornarlos en una lista
        /// </summary>
        /// <returns>List ComputadoraComponente </returns>
        public static List<ComputadoraComponente> ObtenerComputadoraComponentes()
        {
            return DALComputadoraComponente.SeleccionarTodas();
        }


        /// <summary>
        /// Método que llama a DALComputadoraComponente recorre los ComputadoraComponentes que existen en la base de datos
        /// para retornar el que coincide con el parametro del metodo 
        /// </summary>
        /// <param name="idComputadora">valore para filtrar</param>
        /// <returns>ComputadoraComponente</returns>
        public static List<ComputadoraComponente> ObtenerComputadoraComponentesPorIdComputadora(int IdComputadora)
        {
            return DALComputadoraComponente.SeleccionarPorIdComputadora(IdComputadora);
        }
    }
}
