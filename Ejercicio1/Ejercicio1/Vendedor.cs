using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio1
{
    public class Vendedor
    {
        public string Nombre { get; set; }
        private List<Venta> ventas;
        public Vendedor(string nombre)
        {
            this.Nombre = nombre;
            ventas = new List<Venta>();
        }

        public void AgregarVenta(double valor)
        {
            ventas.Add(new Venta(valor));
        }

        public List<Venta> ObtenerVentas => ventas;

        public double ObtenerTotalVentas()
        {
            var sum = 0.0;
            foreach (var venta in ventas)
            {
                sum += venta.Valor;
            }

            return sum;
        }
    }
}

