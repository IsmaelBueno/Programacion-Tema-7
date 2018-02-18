using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    sealed class Moto : Vehiculo
    {
        public enum TipoCombustible { Mezcla, Normal };

        //CAMPOS
        private int _potencia; //Como normal general la potencia irá en caballos
        private TipoCombustible _conbustible;

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
        public int Potencia
        {
            get { return this._potencia; }
        }
        public TipoCombustible Combustible
        {
            get { return _conbustible; }
        }

        //CONSTRUCTORES
        public Moto(string nombre, int nRuedas, ConsoleColor color, int potencia, TipoCombustible combustible)
        {
            this._nombre = nombre;
            this._nruedas = nRuedas;
            this._color = color;
            this._traccion = TipoTraccion.RWD; //Todas las motos tienen por defecto tipo de tracción trasera (RWD)
            this._potencia = potencia;
            this._conbustible = combustible;
        }
        //Constructor vacío para crear una moto por defecto
        public Moto()
        {
            this._nombre = "Honda";
            this._nruedas = 2;
            this._color = ConsoleColor.Red;
            this._traccion = TipoTraccion.RWD;
            this._potencia = 125;
            this._conbustible = TipoCombustible.Normal;
        }

        //METODOS
        public override void MostrarDatos()
        {
            Console.WriteLine("Datos");
            Console.WriteLine("........................................................................");
            Console.WriteLine("Nombre: "+ Nombre);
            Console.WriteLine("Nº Ruedas: " + NRuedas);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tipo de tracción: "+ Traccion);
            Console.WriteLine("Potencia: "+ Potencia + "cv");
            Console.WriteLine("Tipo de combustible: " + Combustible);
        }

        public override string ToString()
        {
            return _nombre;
        }

    }
}
