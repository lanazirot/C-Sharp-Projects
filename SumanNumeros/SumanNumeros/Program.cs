using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumanNumeros {


    
    class Program {
  
        static void Main(string[] args) {

            SumaNumeros miSumaNumeros = new SumaNumeros();
            Console.WriteLine("La suma del numero 1 al numero 20 es: "+miSumaNumeros.SumarUnoAlVeinte());
            Console.ReadKey();

        }
    }
}
