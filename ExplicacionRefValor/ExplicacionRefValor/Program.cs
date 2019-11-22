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



            //VOY A USAR X PARA REFERENCIA
            int x = 10;
            //VOY A USAR Y PARA VALOR
            int y = 20;

            //OBSERVA LO QUE SUCEDE, X AUMENTA, PERO Y NO AUMENTA!

            MetodoPorReferencia(ref x);
            Console.WriteLine("El valor de X es "+x);
            //ATT AQUI
            MetodoPorValor(y);
            Console.WriteLine("El valor de Y  fuera del metodo es "+y);


            //NOTA QUE LA VARIABLE X FUE MODIFICADA, SIENDO QUE ES UNA VARIABLE POR REFERENCIA, LO QUE HACE REF ES MODIFICAR SU VALOR EN BASE
            //A SU DIRECCION DE MEMORIA, EN CAMBIO LA VARIABLE Y SOLO FUE UNA COPIA, SU VALOR NO AUMENTA, DEBIDO A QUE ES UNA COPIA, LO
            // QUE AUMENTA ES DENTRO DEL METODO
            Console.ReadKey();
        }
    }
}
