using System;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            var corte = false;
            while (!corte)
            {
                Console.WriteLine("Agregue nombre del vendedor");
                Vendedor v = new Vendedor(Console.ReadLine());
                vendedores.Add(v);
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("Ingrese venta numero " + (i + 1));
                    v.AgregarVenta(Convert.ToDouble(Console.ReadLine()));
                }
                Console.WriteLine("\n Ventas ingresadas para " + v.Nombre + " :");
                foreach (Venta venta in v.ObtenerVentas)
                {
                    Console.WriteLine(venta.Valor);
                }
                var salir = false;
                var contadorIntentosFallidos = 0;
                while (!salir)
                {
                    Console.WriteLine("Quiere salir? \n" + "S/N");
                    string respuesta = Console.ReadLine();
                    if (respuesta == "S")
                    {
                        salir = true;
                        corte = true;
                    }
                    else if (respuesta != "S" & respuesta != "N")
                    {
                        Console.WriteLine("Ingreso Incorrecto N" + (++contadorIntentosFallidos));
                    }
                    else if (respuesta == "N")
                    {
                        salir = true;
                    }
                }
            }
            var sum = 0.0;
            foreach (var vendedor in vendedores)
            {
                sum += vendedor.ObtenerTotalVentas();
            }

            Console.WriteLine("Ventas totales:" + sum);
        }
    }
}
