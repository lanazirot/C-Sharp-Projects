using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agua {


    class X {

    }

    class Y {
        public int X;


    }




    class Program {

        static void Main(string[] args) {

   

            Cilindro miCilindro = new Cilindro();
            
            Console.WriteLine("teclee el valor del radio del cilindro: ");
            miCilindro.Radio = double.Parse(Console.ReadLine());

            Console.WriteLine("Teclee la altura del cilindro: ");
            miCilindro.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Volumen del cilindro es = "+miCilindro.CalcularVolumen().ToString("N4"));

            Console.ReadKey();
        }
    }
}
