using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNumeros {
    class Program {
        static void Main(string[] args) {
            ClaseNumeros miClaseNumeros = new ClaseNumeros();
            Console.WriteLine("Ingrese el numero 1 ");
            miClaseNumeros.Valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2 ");
            miClaseNumeros.Valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3 ");
            miClaseNumeros.Valor3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 4 ");
            miClaseNumeros.Valor4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 5 ");
            miClaseNumeros.Valor5 = int.Parse(Console.ReadLine());
            //Invoco para eliminar el num. mayor y el num. menor
            miClaseNumeros.EliminarMayorYMenor();
            Console.WriteLine("El promedio de los numeros restantes es "+miClaseNumeros.DeterminarPromedioRestantes()); 
            Console.ReadKey();
        }
    }
}
