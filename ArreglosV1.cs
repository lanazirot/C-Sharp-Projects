using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasArreglos {

    class Program {
        static void Main(string[] args) {

            int intCantidadElementos;
            Console.Write("Teclee la cantidad de elementos: ");
            intCantidadElementos = int.Parse(Console.ReadLine());
            int[] intVector = new int[intCantidadElementos];

            for (int intControl = 0; intControl < intCantidadElementos; intControl++) {
                Console.WriteLine("Teclee el elemento {0}",(intControl+1));
                intVector[intControl] = int.Parse(Console.ReadLine());
            }

            ModificarArreglo(ref intVector);

            foreach(int intElemento in intVector)
                Console.WriteLine(intElemento);

            Console.ReadKey();
        }

        private static void ModificarArreglo(ref int[] intVector) {
            for (int intControl = 0; intControl < intVector.Length; intControl++) {
                if (intVector[intControl] < 0)
                    intVector[intControl] = 0;
            }
        }
    }
}
