using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_4_3_8 {


    class Fraccion {
        double dblNumerador;
        double dblDenominador;
        
        public double Numerador {
            get {
                return dblNumerador;
            }
            set {
                dblNumerador = value;
            }
        }

        //Asi es como se pueden usar propiedades para verificar valores sin necesidad de ciclos
        public double Denominador {
            get {
                return dblDenominador;
            }
            set {
                /*
                 * Usando exceptions
                 * dblDenominador = (value > 0 ? value : throw new Exception("Division por cero"));
                 * 
                 */
                
                dblDenominador = value;
            }
        }

        public double ObtenerDivisionReal() {
            return (Numerador / Denominador);
        }

        public int ObtenerDivisionEntera() {
            return (int)(Numerador / Denominador);
        }

    }

    class Program {
        static void Main(string[] args) {

            Fraccion miFraccion = new Fraccion();

            Console.WriteLine("Ingrese el Numerador");
            miFraccion.Numerador = double.Parse(Console.ReadLine());
      
            //De esta forma validamos que el usuario no ingrese ceros en el denominador
            //Observa la linea 31, si usaras la exception no tendrias que hacer esto
            do {
                Console.WriteLine("Ingrese el Denominador");
                miFraccion.Denominador = double.Parse(Console.ReadLine());
            } while (miFraccion.Denominador<1);


           

            Console.WriteLine("Resultados\nEntera: "+miFraccion.ObtenerDivisionEntera() + "\nReal: " + miFraccion.ObtenerDivisionReal());

            Console.ReadKey();
        }
    }
}
