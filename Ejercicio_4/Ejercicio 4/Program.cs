using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            Numero n = new Numero(CrearNumero());
            Console.Clear();
            n.ImprimirTodosDatos();
            Console.WriteLine("\n\n\n\tPulsa cualquier tecla para salir...");
            Console.ReadKey();
        }
        public static int CrearNumero()
        {
            int numero;
            bool salir = false;

            Console.WriteLine("Introduce un número entero positivo");
            do
            {
                salir = int.TryParse(Console.ReadLine(), out numero);
                if (!salir || numero < 0)
                {
                    Console.WriteLine("Error, debes introducir un número entero positivo");
                    salir = false;
                }
            } while (!salir);

            return numero;
        }
    }       
}
