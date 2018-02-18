using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    sealed class BicicletaMontania : Bicicleta
    {
        //CAMPOS
        private string _tipoAmortiguacion;
        private bool _kitReparacion;
        private float _diametroRuedas; //En milímetros

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
        public string TipoAmortiguacion
        {
            get { return _tipoAmortiguacion; }
        }
        public bool KitReparacion
        {
            get { return _kitReparacion; }
        }
        public float DiametroRuedas
        {
            get { return _diametroRuedas; }
        }

        //CONSTRUCTORES
         public BicicletaMontania(string nombre, ConsoleColor color, TipoTraccion traccion, float precio, DateTime fechaCompra, string amortiguacion, bool kitReparacion, float diametroRuedas)
        {
            this._nombre = nombre;
            this._nruedas = 2;  //Todas las bicis tienen 2 ruedas
            this._color = color;
            this._traccion = traccion;
            this._precio = precio;
            this._fechaCompra = fechaCompra;
            this._tipoAmortiguacion = amortiguacion;
            this._kitReparacion = kitReparacion;
            this._diametroRuedas = diametroRuedas;
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
             Console.WriteLine("Tipo de amortiguación: " + TipoAmortiguacion);
             Console.WriteLine("Kit de reparación: " + KitReparacion);
             Console.WriteLine("Diametro de las ruedas: " + DiametroRuedas);
         }

         public override string ToString()
         {
            return _nombre;
         }
    }   
}
