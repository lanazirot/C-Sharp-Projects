using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_4_3_19 {

    class Paciente {
        private string _strNombre;
        private double _dblPeso;

        public string Nombre {
            get {
                return _strNombre;
            }
            set {
                _strNombre = value;
            }
        }

        public double Peso {
            get {
                return _dblPeso;
            }
            set {
                _dblPeso = value;
            }
        }


    }


    class Program {
        static void Main(string[] args) {

            string strNombrePersonaConMayorPeso="", strNombrePersonaConMenorPeso="";
            double dblPersonaConMayorPeso=0, dblPersonaConMenorPeso=0;

            int intOpcion;
            int intControlPacientes = 0;

            Paciente miPaciente;
            do {

                Console.WriteLine("1. Agregar paciente\n0. Salir");
                intOpcion = int.Parse(Console.ReadLine());

                if (intOpcion == 1) {
                    miPaciente = new Paciente();
                    intControlPacientes++;

                    Console.Write("Ingrese el nombre del paciente: ");
                    miPaciente.Nombre = Console.ReadLine();
                    Console.Write("\nIngrese el peso del paciente " + miPaciente.Nombre + " :");
                    miPaciente.Peso = double.Parse(Console.ReadLine());

                    if (intControlPacientes == 1) { //Es el primer paciente?

                        strNombrePersonaConMayorPeso = miPaciente.Nombre;
                        strNombrePersonaConMenorPeso = miPaciente.Nombre;

                        dblPersonaConMayorPeso = miPaciente.Peso;
                        dblPersonaConMenorPeso = miPaciente.Peso;

                    } else {

                        if (miPaciente.Peso > dblPersonaConMayorPeso) {
                            dblPersonaConMayorPeso = miPaciente.Peso;
                            strNombrePersonaConMayorPeso = miPaciente.Nombre;
                        }

                        if(miPaciente.Peso < dblPersonaConMenorPeso) {
                            dblPersonaConMenorPeso = miPaciente.Peso;
                            strNombrePersonaConMenorPeso = miPaciente.Nombre;
                        }
                    }
                }
            } while (intOpcion != 0);

            Console.WriteLine("Persona con mayor peso " + strNombrePersonaConMayorPeso+": "+dblPersonaConMayorPeso);
            Console.WriteLine("Persona con menor peso " + strNombrePersonaConMenorPeso+": "+dblPersonaConMenorPeso);

            Console.ReadKey();

        }
    }
}
