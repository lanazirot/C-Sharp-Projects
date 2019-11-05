using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesLeo {
    class Temperatura {


        private int _intVentaEnero;
        private int _intVentaFebrero;
        private int _intVentaMarzo;
        private int _intVentaAbril;
        private int _intVentaMayo;
        private int _intVentaJunio;
        private int _intVentaJulio;
        private int _intVentaAgosto;
        private int _intVentaSeptiembre;
        private int _intVentaOctubre;
        private int _intVentaNoviembre;
        private int _intVentaDiciembre;


        public int VentaEnero {
            get {
                return _intVentaEnero;
            }
            set {
                _intVentaEnero = value;
            }
        }

    }
}
