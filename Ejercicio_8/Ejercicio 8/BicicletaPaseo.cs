using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    sealed class BicicletaPaseo : Bicicleta
    {
        //CAMPOS
        private int _nCestas;
        private string _modelo;
        private string _marca;

        //PROPOIEDADES
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
        public float Precio
        {
            get { return this._precio; }
        }
        public DateTime FechaCompra
        {
            get { return this._fechaCompra; }
        }
        public int NCestas
        {
            get { return this._nCestas; }
        }
        public string Modelo
        {
            get { return this._modelo; }
        }
        public string Marca
        {
            get { return this._marca; }
        }

        //CONSTRUCTOR
        public BicicletaPaseo(string nombre, ConsoleColor color, TipoTraccion traccion, float precio, DateTime fechaCompra, int nCestas, string modelo, string marca)
        {
            this._nombre = nombre;
            this._nruedas = 2;  //Todas las bicis tienen 2 ruedas
            this._color = color;
            this._traccion = traccion;
            this._precio = precio;
            this._fechaCompra = fechaCompra;
            this._nCestas = nCestas;
            this._modelo = modelo;
            this._marca = marca;
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
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Fecha de la compra: " + FechaCompra);
            Console.WriteLine("Nº de cestas: " + NCestas);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Marca: " + Marca);
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
