using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPrincipal {
    class Program {
        static void Main(string[] args) {

            char chrOpcion = ' ';
            bool blnPrimeraVez = true;

            Operacion miOperacion = new Operacion();


            do {
                Console.WriteLine("MENU PRINCIPAL\n1.- Capturar numeros A y B\n2.- Suma" +
                    "\n3.- Resta\n4.- Multiplicacion\n5.- Division entera\n6.- Division real\n" +
                    "7.- Potencia A^B\n0.- Salir");
                Console.Write("Teclee su opcion: ");
                chrOpcion = char.Parse(Console.ReadLine());

                switch (chrOpcion) {

                }

            } while (chrOpcion != '0' );

            Console.ReadKey();

        }
    }
}
