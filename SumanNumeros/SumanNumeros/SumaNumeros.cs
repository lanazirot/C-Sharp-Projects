using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumanNumeros {
    class SumaNumeros {

        public int SumarUnoAlVeinte() {
            int intSuma = 0, intControl = 1;
            while (intControl <= 20)
                intSuma += intControl++;
            return intSuma;
        }

    }
}
