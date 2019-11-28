using System;

namespace OrdenarRandom {
    class Program {

        private Program() {
        }

        private static void Intercambiar(ref int[] intArregloReferencia, int intI, int intJ) {
            int intTemporal = intArregloReferencia[intI];
            intArregloReferencia[intI] = intArregloReferencia[intJ];
            intArregloReferencia[intJ]= intTemporal;
        }
        static void OrdenarArreglo(ref int[] intArregloReferencia) {
            for (int intControl1  = 0; intControl1 < intArregloReferencia.Length; intControl1++) {
                for (int intControl2 = intArregloReferencia.Length-1; intControl2 > intControl1; intControl2--) {
                    if (intArregloReferencia[intControl2] < intArregloReferencia[intControl2 - 1]) {
                        Intercambiar(ref intArregloReferencia, intControl2, intControl2 - 1);
                    }
                }
            }
        }
        static void ImprimirArreglo(int[] intArregloReferencia) {
            foreach(int intElemento in intArregloReferencia) {
                Console.WriteLine(intElemento);
            }
        }
         static void GenerarArregloAleatorio(ref int[] intArregloReferencia) {
            Random miRandom = new Random();
            int intCantidadElementosArreglo;
            int intRandom;
            Console.Write("Teclee la cantidad de elementos del arreglo: ");
            intCantidadElementosArreglo = int.Parse(Console.ReadLine());
            //Creates the array
            intArregloReferencia = new int[intCantidadElementosArreglo];
            for (int intControl = 0; intControl < intCantidadElementosArreglo; intControl++) {
                 intRandom = miRandom.Next();
                    intArregloReferencia[intControl] = intRandom;
            }
        }
        static void Main(string[] args) {
            int intOpcion;
            bool blnArregloLleno = false;
            //Just create ref send
            int[] intMiArreglo = null;
            do {
                Console.WriteLine("1.- Generar arreglo con numeros aleatorios\n2.- Imprimir arreglo\n3.- Ordenar arreglo\n0.- Salir");
                intOpcion = int.Parse(Console.ReadLine());
                switch (intOpcion) {
                    case 1:
                        GenerarArregloAleatorio(ref intMiArreglo);
                        blnArregloLleno = true;
                        break;
                    case 2:
                        if(blnArregloLleno)
                            ImprimirArreglo(intMiArreglo);
                        break;
                    case 3:
                        if (blnArregloLleno)
                            OrdenarArreglo(ref intMiArreglo);
                        break;
                    case 0:
                        break;
                    default:
                        Console.Clear();
                        break;
                }        
            } while (intOpcion != 0);
            Console.ReadKey();
        }
    }
}
