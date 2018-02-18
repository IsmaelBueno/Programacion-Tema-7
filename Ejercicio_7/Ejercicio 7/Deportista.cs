using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Deportista : ICarrera
    {
        //CAMPOS
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNacimiento;
        private int _edad;
        private float _peso;

        //PROPIEDADES
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set 
            { 
                _fechaNacimiento = value;
                _edad = CalcularEdad(value);
            }
        }
        public int Edad
        {
            get { return _edad; }
        }
        public float Peso
        {
            get { return _peso; }
            set 
            {
                if (value < 0) _peso = 0;
                _peso = value; 
            }
        }

        //CONSTRUCTORES
        public Deportista(string nombre, string apellidos, DateTime fechaNacimiento, float peso)
        {
            _nombre = nombre;
            _apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
        }


        public void Correr()
        {
            Console.WriteLine("Datos");
            Console.WriteLine(".................................................");
            Console.WriteLine("Nombre: "+_nombre);
            Console.WriteLine("Apellidos "+_apellidos);
            Console.WriteLine("Edad: "+ _edad);
            Console.WriteLine("Peso: "+_peso);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEl corredor de fondo está en ello");
            Console.ResetColor();
        }

        private int CalcularEdad(DateTime fecha)
        {
            if (DateTime.Now.Month - fecha.Month < 0) return DateTime.Now.Year - fecha.Year - 1;
            else 
            {
                if (DateTime.Now.Day - fecha.Day >= 0) return DateTime.Now.Year - fecha.Year;
                else return DateTime.Now.Year - fecha.Year - 1;
            }
        }
    }
}
