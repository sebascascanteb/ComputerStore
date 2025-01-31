using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase ComputadoraDTO que contiene todos las propiedades pertenecientes a ComputadoraDTO
    /// </summary>
    class ComputadoraDTO
    {
        public int Id { get; set; }
        public int IdTipoComputadora { get; set; }
        public TipoComputadora tipoComputadora { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
