using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpi1w3.Dominio
{
    internal class Presupuesto
    {
        public int PresupuestoNro { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Cliente { get; set; }
        public float Descuento { get; set; }
        public float Total { get; set; }

        public List<DetallePresupuesto> Detalles { get; }
        public Presupuesto(string cliente, float descuento, int numero)
        {
            PresupuestoNro = numero;
            FechaAlta = DateTime.Now;
            Cliente = cliente;
            Descuento = descuento;
            Total = 0;
            Detalles = new List<DetallePresupuesto>();
        }
        public void AgregarDetalle(DetallePresupuesto detalle)
        {
            if (detalle != null)
            {
                Detalles.Add(detalle);
            }
        }
        public void BorrarDetalle(DetallePresupuesto detalle)
        {
            Detalles.Remove(detalle);
        }
    }
}
