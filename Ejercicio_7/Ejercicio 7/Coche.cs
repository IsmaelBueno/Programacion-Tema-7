using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Coche : ICarrera
    {
        //CAMPOS
        private string _marca;
        private string _modelo;
        private ConsoleColor _color;
        private int _potencia;

        //PROPIEDADES
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Potencia
        {
            get { return _potencia; }
            set 
            {
                if (_potencia < 0) _potencia = 0;
                _potencia = value; 
            }
        }

        //CONSTRUCTORES
        public Coche(string marca, string modelo, ConsoleColor color, int potencia)
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
            Potencia = potencia;
        }
        public void Correr()
        {
            Console.WriteLine("Datos");
            Console.WriteLine(".................................................");
            Console.WriteLine("Marca: "+_marca);
            Console.WriteLine("Modelo: "+_modelo);
            Console.WriteLine("Color: "+_color);
            Console.WriteLine("Potencia: "+_potencia);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEl coche está en marcha");
            Console.ResetColor();
        }
    }
}
