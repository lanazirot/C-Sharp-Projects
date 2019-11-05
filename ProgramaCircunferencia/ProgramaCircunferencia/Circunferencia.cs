using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia
    {
    class Circunferenica {

        private double _dblRadio;

        public double Radio {
            get {
                return _dblRadio;
            }
            set {
                _dblRadio = value;
            }
        }

        private double _dblAngulo;

        public double Angulo {
            get {
                return _dblAngulo;
            }
            set {
                _dblAngulo = value;
            }

        }

        CalcularLongitud() {
            return ((2 * _dblAngulo * _dblRadio) / 360);
        }


    }
}
