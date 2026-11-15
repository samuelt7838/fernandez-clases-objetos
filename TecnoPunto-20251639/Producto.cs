
using System;

namespace TecnoPunto_20251639
{
    public class Producto
    {
        private string nombre;
        private decimal precio;
        private int cantidad;

        public string Codigo { get; set; }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");

                nombre = value;
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");

                precio = value;
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("La cantidad no puede ser negativa.");

                cantidad = value;
            }
        }

        public decimal ValorTotal
        {
            get { return Precio * Cantidad; }
        }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + Precio.ToString("C"));
            Console.WriteLine("Cantidad: " + Cantidad);
            Console.WriteLine("Valor total: " + ValorTotal.ToString("C"));
            Console.WriteLine("-----------------------------");
        }
    }
}
