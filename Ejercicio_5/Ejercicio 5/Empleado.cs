using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public struct Empleado
    {
        //CAMPOS
        private int _codigo;
        private string _apellidos;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private float _sueldoReal;

        public int Codigo
        {
            get { return _codigo; }
            set {_codigo = value; }
        }
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public float SueldoReal
        {
            get { return _sueldoReal; }
            set 
            {
                if (value < 0F) _sueldoReal = 0F;
                else _sueldoReal = value; 
            }
        }


        //CONSTRUCTOR
        public Empleado(string nombre, string apellidos, DateTime fechadenacimiento, float sueldoreal)
        {
            this._codigo = -1;
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._fechaNacimiento = fechadenacimiento;

            if (sueldoreal < 0F) this._sueldoReal = 0F;
            else this._sueldoReal = sueldoreal;
        }

        //METODOS
        public override string ToString()
        {
            return _codigo.ToString().PadLeft(8) +  (_apellidos + ", " + _nombre).PadLeft(40) + _fechaNacimiento.ToShortDateString().PadLeft(16) + _sueldoReal.ToString().PadLeft(10);
        }
        public void VerdatosPersona()
        {
            Console.WriteLine("DATOS DEL EMPLEADO");
            Console.WriteLine("..................");
            Console.WriteLine("CODIGO: "+_codigo);
            Console.WriteLine("NOMBRE: "+_nombre);
            Console.WriteLine("APELLIDOS: "+_apellidos);
            Console.WriteLine("FECHA DE NACIMIENTO: "+_fechaNacimiento.ToShortDateString());
            Console.WriteLine("SUELDO: "+_sueldoReal);
        }
    }
}
