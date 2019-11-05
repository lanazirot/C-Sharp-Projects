using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia {
    class Program {
        static void Main(string[] args) {
            Circunferencia miCircunferencia = new Circunferencia();

            Console.WriteLine("Ingrese el radio de la circunferencia");
            miCircunferencia.Radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio de la circunferencia");
            miCircunferencia.Angulo = double.Parse(Console.ReadLine());

            Console.WriteLine("La longitud del arco es: "+miCircunferencia.CalcularLongitud());
            Console.ReadKey();    
        }
    }
}
