using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_a_grados_Centigrados {
    class Program {
        //Metodo principal (ejecucion del programa)
        static void Main(string[] args) {

            //Instancia de un objeto de tipo TemperaturaAGradosCentigrados
            TemperaturaAGradosCentigrados miTemperaturaAGradosCentigrados = new TemperaturaAGradosCentigrados();

            //Escritura de la propiedad GradosFarenheit
            Console.Write("Teclee la temperatura en grados Farenheit: ");
            miTemperaturaAGradosCentigrados.GradosFarenheit = double.Parse(Console.ReadLine());

            //Llamada a la funcion que retornara el valor asignado en la linea 18 a temperatura en grados
            // centigrados
            Console.WriteLine("La temperatura en grados centigrados es de "+
                miTemperaturaAGradosCentigrados.ConvertirAGradosCentigrados());

            //Esperar respuesta del usuario
            Console.ReadKey();
           

        }
    }
}
