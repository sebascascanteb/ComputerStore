using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Entities
{
    /// <summary>
    /// Clase UsuarioDTO que contiene todos las propiedades pertenecientes al Usuario
    /// </summary>
    class UsuarioDTO
    {
        public int Id { get; set; }
        public int IdTipoUsuario { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }


        public override string ToString()
        {
            return "Identificacion: " + Id + " || Nombre: " + Nombre+" "+Apellido1+" "+Apellido2;
        }
    }
}
