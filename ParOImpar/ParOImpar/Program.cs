using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParOImpar {
    class Program { 
        static void Main(string[] args) {
            Numero miNumero = new Numero();
            Console.Write("Ingrese el valor del numero: ");
            miNumero.Valor = int.Parse(Console.ReadLine());
            Console.WriteLine(miNumero.DeterminarPar() ? "El numero es par" : "El numero es impar");
            Console.ReadKey();



            /* Forma clasica
            if (miNumero.DeterminarPar())
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es impar");
                */

        }
    }
}
