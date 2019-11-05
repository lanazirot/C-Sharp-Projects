using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paleteria {
    class Nota {
        private int _intCantidad;
        private string _strSabor;
        public int Cantidad {
            get {
                return _intCantidad;
            }
            set {
                _intCantidad = value;
            }
        }
        public string Sabor {
            get {
                return _strSabor;
            }
            set {
                _strSabor = value;
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            //Cantidad de paletas
            int intCantidadPaletasLimon = 0, intCantidadPaletasTamarindo = 0, intCantidadPaletasNuez = 0, intCantidadPaletasJamaica = 0,
                intCantidadPaletasEsquimal = 0;
            //Importe de cada paleta
            int intImportePaletasLimon, intImportePaletasTamarindo, intImportePaletasNuez, intImportePaletasJamaica,
                intImportePaletasEsquimal;
            //Venta total
            int intVentatotal;
            //Opcion continuar o no
            char chrOpcion = 'S';
            Nota miNota;
            do { 
                do {
                    Console.Write("A.- Agregar nota\nS.- Salir\nTeclee su opcion: ");
                    chrOpcion = char.Parse(Console.ReadLine());
                } while (chrOpcion != 'S' && chrOpcion != 'A');
                if (chrOpcion == 'A') {
                    //Creo la nota nueva
                    miNota = new Nota();
                    Console.Write("Ingrese la cantidad de paletas: ");
                    miNota.Cantidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sabor de las paletas");
                    miNota.Sabor = Console.ReadLine();
                    switch (miNota.Sabor.ToUpper()) {
                        case "TAMARINDO":
                            intCantidadPaletasTamarindo += miNota.Cantidad;
                            break;
                        case "NUEZ":
                            intCantidadPaletasNuez += miNota.Cantidad;
                            break;
                        case "JAMAICA":
                            intCantidadPaletasJamaica += miNota.Cantidad;
                            break;
                        case "LIMON":
                            intCantidadPaletasLimon += miNota.Cantidad;
                            break;
                        case "ESQUIMAL":
                            intCantidadPaletasEsquimal += miNota.Cantidad;
                            break;
                        default: break;
                    }
                }
            } while (chrOpcion != 'S');
            //Calculo los importes de las paletas
            intImportePaletasEsquimal = intCantidadPaletasEsquimal * 10;
            intImportePaletasNuez = intCantidadPaletasNuez * 8;
            intImportePaletasLimon = intCantidadPaletasLimon * 5;
            intImportePaletasJamaica = intCantidadPaletasJamaica * 6;
            intImportePaletasTamarindo = intCantidadPaletasTamarindo * 6;
            //Calculo la venta total
            intVentatotal = intImportePaletasTamarindo + intImportePaletasNuez + intImportePaletasLimon + intImportePaletasJamaica +
                intImportePaletasEsquimal;
            //Imprimo todos los datos
            Console.WriteLine("\nINFORME DE VENTAS DE LA SEMANA");
            Console.WriteLine(intCantidadPaletasTamarindo+" paletas de tamarindo: "+intImportePaletasTamarindo.ToString("C"));
            Console.WriteLine(intCantidadPaletasNuez + " paletas de nuez: "+intImportePaletasNuez.ToString("C"));
            Console.WriteLine(intCantidadPaletasLimon+" paletas de limon: "+intImportePaletasLimon.ToString("C"));
            Console.WriteLine(intCantidadPaletasJamaica+" paletas de jamaica: "+intImportePaletasJamaica.ToString("C"));
            Console.WriteLine(intCantidadPaletasEsquimal+" paletas de esquimal: "+intImportePaletasEsquimal.ToString("C"));
            Console.WriteLine("LA VENTA TOTAL DE LA SEMANA ES DE: "+intVentatotal.ToString("C"));
            Console.ReadKey();
        }
    }
}
