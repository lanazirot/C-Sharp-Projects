using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasArreglos {


   

    class Program {
        static void Factorial(int n) {
        int f = 1;
        for (int i = 1; i <= n; i++) {
            f = f * i;
        }
        Console.WriteLine("Factorial es "+f);
    }
        static void Main(string[] args) {

            int n;
            Console.WriteLine("Introduzca el n pal factorial");
            n = int.Parse(Console.ReadLine());

            Factorial(n);

            Console.ReadKey();
        }


    }
}
