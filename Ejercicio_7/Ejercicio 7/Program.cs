using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            ICarrera [] coleccionICarrera = new ICarrera[] {new Deportista("ismael", "Bueno Molina", DateTime.Parse("02/04/1995"), 65F),
                                                            new Deportista("Vyacheslav", "no tiene", DateTime.Parse("15/02/1999"), 123.50F),
                                                            new Coche("Toyota","AE86",ConsoleColor.White, 300),
                                                            new Coche("Citroen","2 Caballos",ConsoleColor.Magenta,2),
                                                            new Deportista("Adri","Sánchez Fernández",DateTime.Parse("30,12,1990"), 122.30F)};
            
            //Mostrar datos
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Usar la funcion (Correr() de la interfaz) de los elementos del array de ICarrera");
            Console.ResetColor();
            foreach (ICarrera item in coleccionICarrera)
            {
                item.Correr();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mostrar la marca del coche o el nombre del deportista");
            Console.ResetColor();
            foreach (ICarrera item in coleccionICarrera)
            {
                if (item.GetType() == typeof(Deportista))
                {
                    Console.WriteLine(((Deportista)item).Nombre);
                }
                else
                {
                    Console.WriteLine(((Coche)item).Marca);
                }                
            }
            Console.ReadKey();
        }
    }
}
