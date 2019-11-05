using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12_de_septiembre {
    class Program {
        static void Main(string[] args) {

            Articulo miArticulo = new Articulo();

           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Escriba la clave numerica: ");
            miArticulo.ClaveNumerica = int.Parse(Console.ReadLine());
            Console.Write("Escriba la clave descripcion: ");
            miArticulo.Descripcion = Console.ReadLine();
            Console.Write("Escriba el precio: ");
            miArticulo.Precio = double.Parse(Console.ReadLine());
            Console.Write("Escriba la cantidad en existencia: ");
            miArticulo.CantidadEnExistencia = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Datos de miArticulo\n" + "Clave numerica: " + miArticulo.ClaveNumerica + "" +
                "\nDescripcion: " + miArticulo.Descripcion + "\nPrecio: $" + miArticulo.Precio + "\n" +
                "Cantidad en existencia: " + miArticulo.CantidadEnExistencia);




            Console.ReadKey();

        }
    }
}
