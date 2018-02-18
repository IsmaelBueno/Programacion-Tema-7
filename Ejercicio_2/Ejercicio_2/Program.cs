using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ismael.MenuPrincipal;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opcion opcion1 = new Opcion("salir",'S');
            Marco marco1 = new Marco(4,4,30,14);
            MenuPrincipal.CrearMenu(marco1,new Opcion[] {opcion1});

            Console.ReadKey();
        }
    }
}
