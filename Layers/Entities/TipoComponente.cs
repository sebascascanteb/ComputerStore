using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase TipoComponente que contiene todos las propiedades pertenecientes al TipoComponente
    /// </summary>
    class TipoComponente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
