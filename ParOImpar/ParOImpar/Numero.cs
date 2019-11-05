using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParOImpar {
      
    class Numero {
        //Use autoproperty... 
        private int _intValor;
        public int Valor {
            get {
                return _intValor;
            }
            set {
                _intValor = value;
            }
        }
        public bool DeterminarPar() { 
            return Valor % 2 == 0;
        }
    }
}
