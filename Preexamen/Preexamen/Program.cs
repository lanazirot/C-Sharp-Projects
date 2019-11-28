using System;
namespace Preexamen {
    class DesviacionEstandar {
        private int _intCantidadDatos;
        private double[] _dblMiArreglo;
        public double this[int intCelda] {
            get => _dblMiArreglo[intCelda];
            set => _dblMiArreglo[intCelda] = value;
        }
        public int CantidadDatos {
            get => _intCantidadDatos;
            set => _intCantidadDatos = value;
        }
        public DesviacionEstandar(int intCantidadDatos) {
            _dblMiArreglo = new double[intCantidadDatos];
        }
        public double CalcularPromedio() {
            double dblSuma = 0.0d;
            foreach (double dblControl in _dblMiArreglo) {
                dblSuma += dblControl;
            }
            return dblSuma / _dblMiArreglo.Length;
        }
        public double CalcularDesviacionEstandar() {
            double dblSuma = 0.0d;
            foreach(double dblControl in _dblMiArreglo) {
                dblSuma += Math.Pow(dblControl - CalcularPromedio(), 2);
            }
            return Math.Sqrt(dblSuma / (CantidadDatos - 1));
        }
    }
    class Program {
        static void Main(string[] args) {
            Console.Write("Numero de elementos: ");
            int intElementos = int.Parse(Console.ReadLine());
            DesviacionEstandar miDesviacionEstandar = new DesviacionEstandar(intElementos) {
                CantidadDatos = intElementos
            };
            for (int intControl = 0; intControl < intElementos; intControl++) {
                Console.WriteLine("Escriba el dato {0}",(intControl+1));
                miDesviacionEstandar[intControl] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Promedio: "+miDesviacionEstandar.CalcularPromedio());
            Console.Write("Desviacion estandar: " + miDesviacionEstandar.CalcularDesviacionEstandar());
            Console.ReadKey();
        }
    }
}
