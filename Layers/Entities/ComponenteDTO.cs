using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase ComponenteDTO que contiene todos las propiedades pertenecientes a ComponenteDTO
    /// </summary>
    class ComponenteDTO : ICloneable
    {
        public int Id { get; set; }
        public int IdTipoComputadora { get; set; }
        public TipoComputadora tipoComputadora { get; set; }
        public int IdTipoComponente { get; set; }
        public TipoComponente tipoComponente { get; set; }
        public string Nombre { get; set; }
        public byte[] Imagen { get; set; }
        public string LinkFabricante { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return "Nombre: "+Nombre+"|| Tipo Componente: "+tipoComponente+" || Cantidad: "+ Cantidad + " || Precio: ₡" +Precio;
        }


        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
