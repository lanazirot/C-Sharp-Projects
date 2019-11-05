using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LanaZirot
namespace Bebes {
    class Program {
        static void Main(string[] args) {

            //Variable que almacena la cantidad de bebes
            int intCantidadBebes;

            //Variables contadoras para los bebes de cada sexo
            int intCantidadBebesMasculinos = 0;
            int intCantidadBebesFemeninos = 0;

            //Declaro mi objeto de tipo Bebe
            Bebe miBebe;

            //Leyendo cuantos bebes se van a analizar 
            Console.Write("Ingrese la cantidad de bebes a analizar: ");
            intCantidadBebes = int.Parse(Console.ReadLine());

        

            //Ciclo para manejar la cantidad de bebes etc.
            for (int intControl = 1; intControl <=intCantidadBebes; intControl++) {
                //CREANDO el objeto de la declaracion en la linea 19
                miBebe = new Bebe();

                Console.WriteLine("Teclee el nombre del bebe numero "+intControl);
                miBebe.Nombre = Console.ReadLine();

                //Ciclo para validar el sexo del bebe, que solo sea M o F
                do {
                    Console.Write("Teclee el sexo del bebe (M) o (F): ");
                    miBebe.Sexo = char.Parse(Console.ReadLine());
                } while (miBebe.Sexo!='M' && miBebe.Sexo!='F');

                //Comparar el sexo introducido, para aumentar las variables correspondientes
                if (miBebe.Sexo == 'M') {
                    intCantidadBebesMasculinos++;
                } else {
                    intCantidadBebesFemeninos++;
                }

            }

            //Imprimir la cantidad de bebes de sexo masculino y de sexo femenino

           // Console.Clear();

            Console.WriteLine("Cantidad de bebes de sexo masculino "+intCantidadBebesMasculinos);
            Console.WriteLine("Cantidad de bebes de sexo femenino "+intCantidadBebesFemeninos);

            Console.ReadKey();

        }
    }
}
