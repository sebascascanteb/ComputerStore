using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase ComputadoraComponente que contiene todos las propiedades pertenecientes a ComputadoraComponente
    /// </summary>
    class ComputadoraComponente
    {
        public int IdComputadora { get; set; }
        public int IdComponente { get; set; }
        public float PrecioComponente { get; set; }
        public int Cantidad { get; set; }
        public float Impuesto { get; set; }
        public float TotalColones { get; set; }
        public float TotalDolar { get; set; }
    }
}
