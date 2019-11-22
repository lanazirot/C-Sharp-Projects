using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasArreglos {




    class Program {
        static void Main(string[] args) {

            string strDiaDeLaSemana;
            Console.Write("Teclee el nombre del dia de la semana: ");
            strDiaDeLaSemana = Console.ReadLine();


            double[] dblHorasDelDia = new double[24];
            for (int intControl = 0; intControl < dblHorasDelDia.Length; intControl++) {
                Console.WriteLine("Temperatura de la hora {0}:00",(intControl+1));
                dblHorasDelDia[intControl] = double.Parse(Console.ReadLine());
            }

            int intCeldaMayorTemperatura, intCeldaMenorTemperatura;


            Console.WriteLine("Promedio de temperatura del dia: "+PromediarTemperatura(ref dblHorasDelDia));
            Console.WriteLine("Valor de celda con la temperatura mas fria: "+ObtenerCeldaYValorMasFrios(ref dblHorasDelDia, out intCeldaMayorTemperatura));
            Console.WriteLine("Numero de celda temperatura mas fria: "+intCeldaMayorTemperatura);
            Console.WriteLine("Valor de celda con la temperatura menos fria: " + ObtenerCeldaYValorMenosFrios(ref dblHorasDelDia, out intCeldaMenorTemperatura));
            Console.WriteLine("Numero de celda temperatura mas fria: " + intCeldaMenorTemperatura);

            Console.ReadKey();
        }

        private static double PromediarTemperatura(ref double [] dblVector) {
            double dblSumaTemperaturas = 0.0d;
            for (int intControl = 0; intControl < dblVector.Length; intControl++) {
                dblSumaTemperaturas += dblVector[intControl];
            }
            return dblSumaTemperaturas / 24;
        }

        private static double ObtenerCeldaYValorMasFrios (ref double[] dblVector, out int intCelda) {

            double dblMayorTemperatura = 0.0d;
            int intCeldaAsignar = 0;
            for (int intControl = 0; intControl < dblVector.Length; intControl++) {
                if (intControl == 0) {
                    dblMayorTemperatura = dblVector[intControl];
                    intCeldaAsignar = intControl;
                } else {
                    if (dblVector[intControl] > dblMayorTemperatura) {
                        dblMayorTemperatura = dblVector[intControl];
                        intCeldaAsignar = intControl;
                    }
                }
            }

            intCelda = intCeldaAsignar;
            return dblMayorTemperatura;
        }

        private static double ObtenerCeldaYValorMenosFrios(ref double[] dblVector, out int intCelda) {

            double dblMenorTemperatura = 0.0d;
            int intCeldaAsignar = 0;
            for (int intControl = 0; intControl < dblVector.Length; intControl++) {
                if (intControl == 0) {
                    dblMenorTemperatura = dblVector[intControl];
                    intCeldaAsignar = intControl;
                } else {
                    if (dblVector[intControl] < dblMenorTemperatura) {
                        dblMenorTemperatura = dblVector[intControl];
                        intCeldaAsignar = intControl;
                    }
                }
            }

            intCelda = intCeldaAsignar;
            return dblMenorTemperatura;
        }

    }
}
