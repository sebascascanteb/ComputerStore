using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase ComponenteApartado que contiene todos las propiedades pertenecientes a ComponenteApartado
    /// </summary>
    class ComponenteApartado
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdComponente { get; set; }
        public int Cantidad { get; set; }
        public string ProvinciaApartado { get; set; }
        public bool Activo { get; set; }


        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
