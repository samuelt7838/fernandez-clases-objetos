
using System;

namespace TecnoPunto_20251639
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE INVENTARIO TECNOPUNTO");

            Producto producto1 = LeerProducto(1);
            Producto producto2 = LeerProducto(2);
            Producto producto3 = LeerProducto(3);

            Console.WriteLine("\nLISTADO DE PRODUCTOS");

            producto1.MostrarInfo();
            producto2.MostrarInfo();
            producto3.MostrarInfo();

            Console.WriteLine("\nPresione una tecla para salir.");
            Console.ReadKey();
        }

        static Producto LeerProducto(int numero)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nRegistro del producto " + numero);

                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Precio: ");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    return new Producto(codigo, nombre, precio, cantidad);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Introduzca un número válido.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
