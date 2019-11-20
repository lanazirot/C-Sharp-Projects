using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante {
    class Mesero {

        private string _strNombre;
        public string Nombre {
            get {
                return _strNombre;
            }
            set {
                _strNombre = value;
            }
        }

        private int _intCantidadMesasAtendidas;
        public int CantidadMesasAtendidas {
            get {
                return _intCantidadMesasAtendidas;
            }
            set {
                _intCantidadMesasAtendidas = value;
            }
        }



    }
}
