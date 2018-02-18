using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    abstract class Vehiculo : IComparable<Vehiculo>
    {
        public enum TipoTraccion { FWD, RWD, _4WD }; //Delantera (FWD), Trasera (RWD), 4x4(4WD)

        //CAMPOS
        protected string _nombre;
        protected int _nruedas;
        protected ConsoleColor _color;
        protected TipoTraccion _traccion;

        //METODOS
        public abstract void MostrarDatos();
        //public abstract string Nombre();

        public int CompareTo(Vehiculo other)
        {
            return string.Compare(this._nombre,other._nombre);
        }
       

    }
}
