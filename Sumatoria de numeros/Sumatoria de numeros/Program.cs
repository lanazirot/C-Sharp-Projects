using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumatoria_de_numeros {

    class ClaseNumero {
        private int _intValor1;
        private int _intValor2;
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
        public int Sumar() {
            return Valor1 + Valor2;
        }
        public int Restar() {
            return Valor1 - Valor2;
        }
        public int Multiplicar() {
            return Valor1 * Valor2;
        }
        public int DividirEntero(){
            return Valor1 / Valor2;
        }
        public float DividirReal() {
            return Valor1 / (float)Valor2;
        }
        public double Elevar() {
            return Math.Pow(Valor1, Valor2);
        }
    }
    class Program {
        static void Main(string[] args) {
            ClaseNumero miClaseNumero = new ClaseNumero();
            int intOpcion;
            bool blnNumerosIngresados = false;
            do {
                Console.WriteLine("MENU PRINCIPAL\n1.- Capturar números A y B\n2.- Suma\n3.- Resta\n" +
                    "4.- Multiplicación\n5.- División entera\n6.- División real\n7.- Potencia A ^ B" +
                    "\n0.- Salir\n\nTeclee su opcion");
                intOpcion = int.Parse(Console.ReadLine());
                if (!blnNumerosIngresados && intOpcion!=1 ) {
                    Console.WriteLine("No se han capturado los numeros A y B");
                } else {
                    switch (intOpcion) {
                        case 1:
                            Console.WriteLine("Ingrese el valor A ");
                            miClaseNumero.Valor1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor B ");
                            miClaseNumero.Valor2 = int.Parse(Console.ReadLine());

                            blnNumerosIngresados = true;
                            break;
                        case 2:
                            Console.WriteLine("La suma es "+miClaseNumero.Sumar());
                            break;
                        case 3:
                            Console.WriteLine("La resta es"+miClaseNumero.Restar());
                            break;
                        case 4:
                            Console.WriteLine("La multiplicacion es "+miClaseNumero.Multiplicar());
                            break;
                        case 5:
                            try {
                                Console.WriteLine("La division entera es "+miClaseNumero.DividirEntero());
                            } catch (Exception) {
                                Console.WriteLine("No se puede dividir entre cero");
                            }
                            break;
                        case 6:
                            try {
                                Console.WriteLine("La division real es "+miClaseNumero.DividirReal());
                            } catch (Exception) {
                                Console.WriteLine("No se puede dividir entre cero");
                            }
                            break;
                        case 7:
                            Console.WriteLine("A elevado a B es "+miClaseNumero.Elevar());
                            break;
                        case 0: 
                            break;
                    }

                    Console.WriteLine("Presione cualquier tecla para contunuar...");
                    Console.ReadKey(); 
                    Console.Clear();

                }        
            } while (intOpcion!=0);

            Console.ReadKey();

        }
    }
}
