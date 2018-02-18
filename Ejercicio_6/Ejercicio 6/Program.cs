using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        public delegate int Delegado1(int x);
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";

            Console.WriteLine("Muestra de formatos de la clase CFechas");
            CFechas fecha1 = new CFechas();

            Console.WriteLine(fecha1.FechaFormatoCorto);
            Console.WriteLine(fecha1.FechaFormatolargo);
            Console.WriteLine("\n");


            Console.WriteLine("Introduce tu una fecha");
            Console.Write("El año:");
            int anio = ComprobarNumero();
            Console.Write("El mes:");
            int mes = ComprobarNumero();
            Console.Write("El día:");
            int dia = ComprobarNumero();
            CFechas fecha2 = new CFechas(anio,mes,dia);
            Console.WriteLine(fecha2.FechaFormatoCorto);
            Console.WriteLine(fecha2.FechaFormatolargo);
            Console.ReadKey();
        }

        public static int ComprobarNumero()
        {
            bool salir = false;
            int numero = 0;
            do
            {
                salir = int.TryParse(Console.ReadLine(), out numero);
                if (!salir) Console.WriteLine("Error, debes introducir un número entero");
            } while (!salir);
            return numero;
        }
    }
}
