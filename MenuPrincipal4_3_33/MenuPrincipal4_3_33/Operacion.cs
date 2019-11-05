using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MenuPrincipal {
    class Operacion {
         private int _intNumeroA;
        public int NumeroA {
            get {
                return _intNumeroA;
            }
            set {
                _intNumeroA = value;
            }
        }
        private int _intNumeroB;
        public int NumeroB {
            get {
                return _intNumeroB;
            }
            set {
                _intNumeroB = value;
            }
        }
        //Funciones
        public int Sumar() {
            return NumeroA + NumeroB;
        }
        public int Restar() {
            return NumeroA - NumeroB;
        }
        public int Multiplicar() {
            return NumeroA * NumeroB;
        }
        public int DividirEntero() {
            return NumeroA / NumeroB;
        }
        public float DividirReal() {
            return NumeroA / NumeroB;
        }
        public int Potenciar() {
            return (int) Math.Pow(NumeroA, NumeroB);
        }
    }
}
