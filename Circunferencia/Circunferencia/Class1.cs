using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circunferencia {
    class Circunferencia {
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

        public double CalcularLongitud() {
            return ((2 *Math.PI *Radio * Angulo) / 360);
        }
    }
}
