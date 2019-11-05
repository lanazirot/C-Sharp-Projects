using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_pruebas
{
    public interface AccionesPersona {
        void hablar();
        void caminar();
        void respirar();

    }

    public class Persona : AccionesPersona {
        public string Nombre { get; set; }

        public Persona(string nombre){
            this.Nombre = nombre;
        }

        public void hablar() {
            Console.WriteLine("La persona habla");
        }

        public void caminar() {
            Console.WriteLine("La persona camina");
        }

        public void respirar() {
            Console.WriteLine("La persona respira");
        }
    }


    public class Enfermero : Persona {

        private string matricula;

        public Enfermero(string nombre, string matricula) {
            this.matricula = matricula;
        }
    }

    class Program{
        static void Main(string[] args){
        }
    }
}
