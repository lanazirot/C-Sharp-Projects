using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caja_Examen {
    class Caja {

        //Atributo privado que almacenara el lado de la caja
        private double _dblLado;

        //Propiedad con la cual se accedera al atributo _dblLado SOLO ESCRITURA
        public double Lado {
            set {
                _dblLado = value;
            }
        }

        //Metodo (funcion) que calcula el volumen
        public double CalcularVolumen() {
            return _dblLado * _dblLado * _dblLado;
        }
    }
}
