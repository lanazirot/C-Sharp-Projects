using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PromedioNumeros {
    class ClaseNumeros {
        //Use autoproperty.....!
        private int _intValor1;
        private int _intValor2;
        private int _intValor3;
        private int _intValor4;
        private int _intValor5;
        public int Valor1 {
            get {
                return _intValor1;
            }
            set {
                _intValor1 = value;
            }
        }
        public int Valor2 {
            get {
                return _intValor2;
            }
            set {
                _intValor2 = value; 
            }
        }
        public int Valor3 {
            get {
                return _intValor3;
            }
            set {
                _intValor3 = value;
            }
        }
        public int Valor4 {
            get {
                return _intValor4;
            }
            set {
                _intValor4 = value;
            }
        }
        public int Valor5 {
            get {
                return _intValor5;
            }
            set {
                _intValor5 = value;
            }
        }
        public void EliminarMayorYMenor() {
            //Si ya no son iguales, determina el mayor
            if (Valor1 >= Valor2 && Valor1 >= Valor3 && Valor1 >= Valor4 && Valor1 >= Valor5) {
                //Valor1 = 0;
                Valor1 = 0;
            } else if (Valor2 >= Valor1 && Valor2 >= Valor3 && Valor2 >= Valor4 && Valor2 >= Valor5) {
                //Valor2 = 0;
                Valor2 = 0;
            } else if (Valor3 >= Valor1 && Valor3 >= Valor2 && Valor3 >= Valor4 && Valor3 >= Valor5) {
                //Valor3 = 0;
                Valor3 = 0;
            } else if (Valor4 >= Valor1 && Valor4 >= Valor2 && Valor4 >= Valor3 && Valor4 >= Valor5) {
                //Valor4 = 0;
                Valor4 = 0;
            } else {
                //Valor5 = 0;
                Valor5 = 0;
            }


            if (Valor1 <= Valor2 && Valor1 <= Valor3 && Valor1 <= Valor4 && Valor1 <= Valor5) {
                //Valor1 = 0;
                Valor1 = 0;
            } else if (Valor2 <= Valor1 && Valor2 <= Valor3 && Valor2 <= Valor4 && Valor2 <= Valor5) {
                //Valor2 = 0;
                Valor2 = 0;
            } else if (Valor3 <= Valor1 && Valor3 <= Valor2 && Valor3 <= Valor4 && Valor3 <= Valor5) {
                //Valor3 = 0;
                Valor3 = 0;
            } else if (Valor4 <= Valor1 && Valor4 <= Valor2 && Valor4 <= Valor3 && Valor4 <= Valor5) {
                //Valor4 = 0;
                Valor4 = 0;
            } else {
                //Valor5 = 0;
                Valor5 = 0;
            }
        }
            public int DeterminarPromedioRestantes() {
             return (Valor1 + Valor2 + Valor3 + Valor4 + Valor5) / 3;              
        }
    }
}
