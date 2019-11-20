using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante {
    class Program {
        static void Main(string[] args) {

            int intCantidadMeseros;
            int intMayorCantidadDeMesasAtendidas = 0;
            string strNombreMeseroConMayorMesasAtendidas = "";

            Mesero miMesero;

            Console.Write("Teclee la cantidad de meseros ");
            intCantidadMeseros = int.Parse(Console.ReadLine());

            for (int intControl = 1; intControl <= intCantidadMeseros; intControl++) {
                miMesero = new Mesero();
                Console.WriteLine("Teclee el nombre del mesero "+intControl);
                miMesero.Nombre = Console.ReadLine();
                Console.WriteLine("Teclee la cantidad de mesas atendidas de "+miMesero.Nombre);
                miMesero.CantidadMesasAtendidas = int.Parse(Console.ReadLine());

                //First waiter
                if (intControl == 1) {
                    intMayorCantidadDeMesasAtendidas = miMesero.CantidadMesasAtendidas;
                    strNombreMeseroConMayorMesasAtendidas = miMesero.Nombre;
                } else {
                    if (miMesero.CantidadMesasAtendidas > intMayorCantidadDeMesasAtendidas) {
                        intMayorCantidadDeMesasAtendidas = miMesero.CantidadMesasAtendidas;
                        strNombreMeseroConMayorMesasAtendidas = miMesero.Nombre;
                    }
                }

            }

            Console.WriteLine("Nombre del mesero con mayor cantidad de mesas atendidas: "+strNombreMeseroConMayorMesasAtendidas);
            Console.WriteLine("Cantidad de mesas atendidas por el mesero "+intMayorCantidadDeMesasAtendidas);

            Console.ReadKey();

        }
    }
}
