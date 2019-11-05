using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agua {
    class Cilindro {
        private double _dblRadio;
        
         public double Radio {
            get {
                return _dblRadio;
            }

            set {
                _dblRadio = value;
            }
        }

        private double  _dblAltura;

        public double  Altura {
            get {
                return _dblAltura;
            }
            set {
                _dblAltura = value;
            }
        }

        public double CalcularVolumen() {
            return Math.PI * Math.Pow(Radio, 2)*Altura;
        }

    }
}
