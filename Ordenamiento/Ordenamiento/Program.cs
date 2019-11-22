using System;
namespace Ordenamiento {
    public static  class LeftBubbleSort {
        private static void Intercambiar(ref int[] intMiArregloReferencia, int intI, int intJ) {
            int intTemporal = intMiArregloReferencia[intI];
            intMiArregloReferencia[intI] = intMiArregloReferencia[intJ];
            intMiArregloReferencia[intJ] = intTemporal;
        }

        public static void Ordenar(ref int[] intMiArregloReferencia) {
            for (int intControl1 = 0; intControl1 < intMiArregloReferencia.Length - 1; intControl1++) {
                for (int intControl2 = intMiArregloReferencia.Length - 1; intControl2 > intControl1; intControl2--) {
                    if (intMiArregloReferencia[intControl2] < intMiArregloReferencia[intControl2 - 1]) {
                        Intercambiar(ref intMiArregloReferencia, intControl2, intControl2 - 1);
                    }
                }
            }
        }
    }
    class Program {
        static void Intercambiar(ref int[] intMiArregloReferencia, int intI, int intJ) {
            int intTemporal = intMiArregloReferencia[intI];
            intMiArregloReferencia[intI] = intMiArregloReferencia[intJ];
            intMiArregloReferencia[intJ] = intTemporal;
        }

        static void Ordenar(ref int[] intMiArregloReferencia) {
            for(int intControl1 = 0; intControl1 < intMiArregloReferencia.Length-1; intControl1++) {
                for(int intControl2 = intMiArregloReferencia.Length-1; intControl2 > intControl1; intControl2--) {
                    if (intMiArregloReferencia[intControl2] < intMiArregloReferencia[intControl2-1]) {
                        Intercambiar(ref intMiArregloReferencia, intControl2, intControl2-1);
                    }
                }
            }
        }


        static void Main(string[] args) {

            //Declarar el arreglo 
            int[] intMiArreglo;
            //Declarar variable para almacenar/reservar memoria en el arreglo
            int intCantidadElementos;
            Console.Write("Teclee la cantidad de elementos del arreglo ");
            //Leer la cantidad
            intCantidadElementos = int.Parse(Console.ReadLine());
            //Crear el arreglo y asignarle el espacio
            intMiArreglo = new int[intCantidadElementos];
            //Implementar el ciclo y leer
            for (int intControl = 0; intControl < intCantidadElementos; intControl++) {
                Console.Write("Teclee el valor miArreglo[{0}]:",intControl);
                intMiArreglo[intControl] = int.Parse(Console.ReadLine());
            }
            //Ordenar los datos del arreglo


            //Metodo de la class Program
            Ordenar(ref intMiArreglo);


            //Metodo estatico de la class LeftBubbleSort
          //  LeftBubbleSort.Ordenar(ref intMiArreglo);

            Console.WriteLine("Arreglo ordenado");
            //Mostrar los datos ordenados
            foreach(int intValor in intMiArreglo) {
                Console.Write(intValor+" ");
            }
            Console.ReadKey();

        }
    }
}
