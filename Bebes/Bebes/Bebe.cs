using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LanaZirot
namespace Bebes {
    class Bebe {
        //Atributos de la clase
        private string _strNombre;
        private char _chrSexo;
        //Propiedades
        public string Nombre {
            set {
                _strNombre = value;
            }
        }
        public char Sexo {
            set {
                _chrSexo = value;
            }
            get {
                return _chrSexo;
            }
        }
    }
}
