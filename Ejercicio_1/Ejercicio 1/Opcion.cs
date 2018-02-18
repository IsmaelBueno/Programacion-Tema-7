using System;

namespace ismael.MenuPrincipal
{
    public class Opcion
    {
        //Campos
        private const int MAXIMALONGITUDDEPALABRA = 46;
        private string _definicion;
        private char _tecla;
        private ConsoleColor _color;

        //Propiedades
        public string Definicion
        {
            get { return _definicion; }
            set 
            {
                //Aquí se delimita el tamaño de la definición a la máxima longitud de palabra
                string definicionlimitada = null;

                if (value.Length > MAXIMALONGITUDDEPALABRA)
                {
                    for (int i = 0; i < MAXIMALONGITUDDEPALABRA; i++)
                    {
                        definicionlimitada += value[i];
                    }
                    _definicion = definicionlimitada;
                }
                else _definicion = value;

            }
        }
        public char Tecla
        {
            get { return _tecla; }
            set { _tecla = value; }
        }
        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        //Constructores
        public Opcion(string Definicion, char Tecla, ConsoleColor Color)
        {
            string definicionlimitada = null;

            //Aquí se delimita el tamaño de la definición a la máxima longitud de palabra
            if (Definicion.Length > MAXIMALONGITUDDEPALABRA)
            {
                for (int i = 0; i < MAXIMALONGITUDDEPALABRA; i++)
                {
                    definicionlimitada += Definicion[i];
                }
                _definicion = definicionlimitada;
            }
            else _definicion = Definicion;

            _tecla = Tecla;
            _color = Color;
        }
        public Opcion(string Definicion, char Tecla)
        {
            string definicionlimitada = null;

            //Aquí se delimita el tamaño de la definición a la máxima longitud de palabra
            if (Definicion.Length > MAXIMALONGITUDDEPALABRA)
            {
                for (int i = 0; i < MAXIMALONGITUDDEPALABRA; i++)
                {
                    definicionlimitada += Definicion[i];
                }
                _definicion = definicionlimitada;
            }
            else _definicion = Definicion;

            _tecla = Tecla;
            _color = ConsoleColor.White;
        }
        public Opcion()
        {
            _definicion = "Opcion";
            _tecla = ' ';
            _color = ConsoleColor.White;
        }

        //Metodos
        public override string ToString()
        {
            //El valor máximo de longitud de este tostring será la MAXIMALONGITUDDEPLABRA + 4
            return "[" + _tecla +"] " +_definicion;
        }
    }
}