using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase Factura que contiene todos las propiedades pertenecientes a Factura
    /// </summary>
    class Factura
    {
        public int Id { get; set; }
        public int IdComputadora { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public float TotalColones { get; set; }
        public float TotalDolar { get; set; }

    }
}
