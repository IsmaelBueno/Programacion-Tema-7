using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    sealed class Coche : Vehiculo
    {
        public enum EstadoVehiculo { Marchando, Parado };

        //CAMPOS
        private int _velocidadMaxima; //Kms/hora
        private EstadoVehiculo _estado;

        //PROPIEDADES
        public string Nombre
        {
            get { return this._nombre; }
        }
        public int NRuedas
        {
            get { return this._nruedas; }
        }
        public ConsoleColor Color
        {
            get { return this._color; }
        }
        public TipoTraccion Traccion
        {
            get { return this._traccion; }
        }
        public int VelocidadMaxima
        {
            get { return _velocidadMaxima; }
        }
        internal EstadoVehiculo Estado
        {
            get { return _estado; }
        }

        //CONSTRUCTORES
        public Coche(string nombre, int nRuedas, ConsoleColor color, TipoTraccion traccion, int velocidadmaxima, EstadoVehiculo estado)
        {
            this._nombre = nombre;
            this._nruedas = nRuedas;
            this._color = color;
            this._traccion = traccion;
            this._velocidadMaxima = velocidadmaxima;
            this._estado = estado;
        }

        //Constructor vacío para crear un coche por defecto
        public Coche()
        {
            this._nombre = "Nissan";
            this._nruedas = 4;
            this._color = ConsoleColor.DarkGray;
            this._traccion = TipoTraccion._4WD;
            this._velocidadMaxima = 315;
            this._estado = EstadoVehiculo.Marchando;
        }

        //METODOS
        public override void MostrarDatos()
        {
            Console.WriteLine("Datos");
            Console.WriteLine("........................................................................");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Nº Ruedas: " + NRuedas);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tipo de tracción: " + Traccion);
            Console.WriteLine("Velocidad máxima: " + VelocidadMaxima + " kms/h");
            Console.WriteLine("Estado actual del vehículo: " + Estado);
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
