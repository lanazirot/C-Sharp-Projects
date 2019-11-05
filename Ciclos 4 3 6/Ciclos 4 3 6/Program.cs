using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_4_3_6 {

    class Serie {
        public double ObtenerSuma() {
            double dblSuma = 1;
            int intDenominador = 2;
            for (int intControl=2;intControl<=100;intControl++) {
               if (intControl % 2 == 0) { //Cuando es par
                    dblSuma -= 1 / (double) intDenominador;
                } else { //Cuando es impar
                    dblSuma += 1 / (double) intDenominador;
                }
                intDenominador += 2;
            }
            return dblSuma;

        }
    }



    class Program {
        static void Main(string[] args) {

            Serie miSerie = new Serie();
            Console.WriteLine(miSerie.ObtenerSuma());

            Console.ReadKey();
        }
    }
}
