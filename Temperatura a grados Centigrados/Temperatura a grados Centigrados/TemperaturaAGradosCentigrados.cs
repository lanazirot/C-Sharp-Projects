using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_a_grados_Centigrados {
    class TemperaturaAGradosCentigrados {

        //Atributo privado que almacena la temperatura en grados Farenheit
        private double _dblGradosFarenheit;

        //Propiedad de solo escritura (set) para manipular el atributo _dblGradosFarenheit
        public double GradosFarenheit {
            set {
                _dblGradosFarenheit = value;
            }
        }

        /*Metodo (funcion) que calcula en base al atributo _dblGradosFarenheit, la conversion 
         * a grados centigrados*/
        public double ConvertirAGradosCentigrados() {
            return (_dblGradosFarenheit - 32) * 5 / 9;
        }
    


    }
}
