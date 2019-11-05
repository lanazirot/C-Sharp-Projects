using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaNumerosDescendientes {
    class CadenaDeNumerosDescendientes {

        public string ImprimirDel25Al15() {
            string strCadenaDeNumeros = "";
            int intControl = 25;

            while (intControl >= 15)
                strCadenaDeNumeros += intControl-- + "\n";
            return strCadenaDeNumeros;
        }

    }
}
