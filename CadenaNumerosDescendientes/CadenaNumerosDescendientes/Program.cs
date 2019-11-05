using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaNumerosDescendientes {
    class Program {
        static void Main(string[] args) {

            CadenaDeNumerosDescendientes miCadenaDeNumerosDescendientes = new CadenaDeNumerosDescendientes();
            Console.WriteLine("La impresion es la siguiente\n"+miCadenaDeNumerosDescendientes.ImprimirDel25Al15());
            Console.ReadKey();
        }
    }
}
