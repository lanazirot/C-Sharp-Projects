using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela {


    class Estudiante {
        private string _strNombre;
        private string _strNumeroDeControl;
        private int[] _intArregloCalificaciones = new int[3];

        public string Nombre {
            get => _strNombre;
            set => _strNombre = value;
        }

        public string NumeroDeControl {
            get => _strNumeroDeControl;
            set => _strNumeroDeControl = value;
        }

        public int this[int intCelda] {
            get => _intArregloCalificaciones[intCelda];
            set => _intArregloCalificaciones[intCelda] = value;
        }

     

        public double CalcularPromedio() {
            double dblPromedio = 0.0d;
            for (int intControl = 0; intControl < 3; intControl++) {
                dblPromedio += _intArregloCalificaciones[intControl];
            }
            return dblPromedio;
        }
    }



    class Program {


        //Global array
        static Estudiante[] misEstudiantes;

        static void CapturarArreglo() {

            Console.Clear();

            int intCantidadEstudiantes;
            Console.Write("Teclee la cantidad de estudiantes deseada: ");
            intCantidadEstudiantes = int.Parse(Console.ReadLine());


            //Creates the global array
            misEstudiantes = new Estudiante[intCantidadEstudiantes];


            for (int intControl = 0; intControl < intCantidadEstudiantes; intControl++) {

                misEstudiantes[intControl] = new Estudiante();    

                Console.Write("Nombre del estudiante ", (intControl + 1) + ": ");
                misEstudiantes[intControl].Nombre = Console.ReadLine();

                Console.Write("Numero de control del estudiante :", (intControl + 1)+": ");
                misEstudiantes[intControl].NumeroDeControl = Console.ReadLine();

                for(int intControlCalificaciones = 0; intControlCalificaciones < 3; intControlCalificaciones++) {
                    Console.WriteLine("Calificacion {0}: ",(intControlCalificaciones+1));
                    misEstudiantes[intControl][intControlCalificaciones] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
        }

        static string BuscarNombreMayorPromedio() {
            string strNombreEstudianteMayorPromedio = misEstudiantes[0].Nombre;
            double dblMayorPromedio = misEstudiantes[0].CalcularPromedio();
            for (int intControl = 1; intControl < misEstudiantes.Length; intControl++) {
                if (misEstudiantes[intControl].CalcularPromedio() > dblMayorPromedio) {
                    dblMayorPromedio = misEstudiantes[intControl].CalcularPromedio();
                    strNombreEstudianteMayorPromedio = misEstudiantes[intControl].Nombre;
                }
            }

            return strNombreEstudianteMayorPromedio;
        }

        static void Main(string[] args) {



            int intOpcion;
            bool blnArregloLleno = false; ;

            do {

                Console.WriteLine("1. Capturar estudiantes\n2. Obtener el nombre del estudiante con mayor promedio\n0.- Salir");
                intOpcion = int.Parse(Console.ReadLine());

                switch (intOpcion) {
                    case 1:
                        CapturarArreglo();
                        blnArregloLleno = true;
                        break;
                    case 2:
                        if (blnArregloLleno) {
                            Console.WriteLine("El estudiante con mayor promedio se llama " + BuscarNombreMayorPromedio());
                            System.Threading.Thread.Sleep(3000);
                        } else {
                            Console.Clear();
                        }
             
                            
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
