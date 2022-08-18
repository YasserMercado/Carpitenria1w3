using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpi1w3.Dominio
{
    internal class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public bool Activo { get; set; }

       public Producto(int id, string nombre, float precio, bool activo)
        {
            IdProducto = id;
            Nombre = nombre;
            Precio = precio;
            Activo = activo;
        }
    }
}
