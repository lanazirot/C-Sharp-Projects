using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_12_de_septiembre {
    class Articulo {

        private int _intClaveNumerica;
        private string _strDescripcion;
        private double _dblPrecio;
        private double _dblCantidadEnExistencia;

        public int ClaveNumerica {
            get {
                return _intClaveNumerica;
            }
            set {
                _intClaveNumerica = value;
            }
       }

        public string Descripcion {
            get {
                return _strDescripcion;
            }
            set {
                _strDescripcion = value;
            }
        }

        public double Precio {
            get {
                return _dblPrecio;
            }
            set {
                _dblPrecio = value;
            }
        }

        public double CantidadEnExistencia {
            get {
                return _dblCantidadEnExistencia;
            }
            set {
                _dblCantidadEnExistencia = value;
            }
        }
       

    }
}
