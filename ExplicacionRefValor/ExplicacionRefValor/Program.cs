using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionRefValor {


    /*
     Cuando se tienen variables (de cualquier tipo) en un metodo, se consideran variables locales
     y es solamente posible modificarlas en este mismo metodo, sin embargo, para poder modificar alguna
     variable por fuera de ese metodo, utilizamos variables mandadas y recibidas por referencia

        Observa este ejemplo
         
         */

    class Program {

        static void MetodoPorReferencia(ref int variablePorReferencia) {
            variablePorReferencia++;
        }

        static void MetodoPorValor(int variablePorValor) {
            variablePorValor++;
            Console.WriteLine("EL VALOR DE Y DENTRO DEL METODO ES "+variablePorValor);
        }

        static void Main(string[] args) {


            int[,,] m = new int[2, 2, 2];

            for (int i = 0; i < m.GetLength(0); i++) {
                Console.WriteLine("Alumno " + (i + 1));
                for (int j = 0; j < m.GetLength(1); j++) {
                    Console.WriteLine("Materia " + (j + 1));
                    for (int k = 0; k < m.GetLength(2); k++) {
                        Console.Write("Parcial " + (k + 1)+": ");
                        m[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
