using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de la lista
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Creo una lista de vehículos y defino una moto, un coche, una bici de montaña y una bici de paseo");
            Console.ResetColor();
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            vehiculos.Add( new Moto("Yamaha", 2, ConsoleColor.DarkGreen, 1000, Moto.TipoCombustible.Mezcla));
            vehiculos.Add( new Coche("Seat Ibiza", 4, ConsoleColor.Yellow, Vehiculo.TipoTraccion.FWD, 100, Coche.EstadoVehiculo.Parado));
            vehiculos.Add( new BicicletaMontania("BMX", ConsoleColor.White, Vehiculo.TipoTraccion.RWD, 799.95F, DateTime.Now, "aire", true, 110));
            vehiculos.Add( new BicicletaPaseo("Ciclismo", ConsoleColor.Magenta, Vehiculo.TipoTraccion.RWD, 230.50F, DateTime.Parse("06/01/2018"), 3, "MTB", "Monty"));

            //Mostrar datos con metodo abstracto de vehiculos
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Aquí muestro los datos de cada vehiculo en la lista con un método abstracto que se hereda de la clase vehículo");
            Console.ResetColor();
            foreach (var tmp in vehiculos)
            {
                tmp.MostrarDatos();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine();

            //Ordenar lista de vehiculos
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("La clase vehiculo tiene el interfaz implementado IComprable(Compara usando el nombre como criterio, por lo que podemos usar con esta lista un Sort() y ver como queda la lista ordenada alfabéticamente");
            Console.ResetColor();
            vehiculos.Sort();
            foreach (var tmp in vehiculos)
            {
                Console.WriteLine(tmp.ToString());
            }
                
            Console.WriteLine();

            //Lista de motos
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Se crea ahora una lista de motos y muestro los nombres de las motos como están en la lista");
            Console.ResetColor();
            List<Moto> motos = new List<Moto>();
            motos.Add(new Moto("zmoto",2,ConsoleColor.Blue,20,Moto.TipoCombustible.Normal));
            motos.Add(new Moto("bmoto", 2, ConsoleColor.Blue, 20, Moto.TipoCombustible.Normal));
            motos.Add(new Moto("hmoto", 2, ConsoleColor.Blue, 20, Moto.TipoCombustible.Normal));
            motos.Add(new Moto("emoto", 2, ConsoleColor.Blue, 20, Moto.TipoCombustible.Normal));
            motos.Add(new Moto("amoto", 2, ConsoleColor.Blue, 20, Moto.TipoCombustible.Normal));

            foreach (var tmp in motos)
            {
                Console.WriteLine(tmp.ToString());
            }
            Console.WriteLine();

            //Ordenar lista de motos
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Ahora ordeno las motos con el método que implementa la interfaz IComparable que implementaba vehìculo y ahora se hereda en moto");
            Console.ResetColor();
            motos.Sort();
            foreach (var tmp in motos)
            {
                Console.WriteLine(tmp.ToString());
            }

            Console.ReadKey();

        }
    }
}
