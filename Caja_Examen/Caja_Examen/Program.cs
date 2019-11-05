using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Examen {
    class Program {
        static void Main(string[] args) {

        
            Caja miCaja = new Caja();

            Console.Write("Ingrese la medida del lado de la caja: ");
            miCaja.Lado = double.Parse(Console.ReadLine());
            Console.Write("El volumen de la caja es: " + miCaja.CalcularVolumen());
            Console.ReadKey();
        }
    }
}
