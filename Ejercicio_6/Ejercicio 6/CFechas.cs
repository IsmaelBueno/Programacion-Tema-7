using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    //Es divisible entre 4.
    //Si termina en 00, es divisible entre 400 (2000 y 2400 sí son bisiestos. 2100, 2200 y 2300 no lo son).
    class CFechas
    {
        //CAMPOS
        private int _anio;
        private int _mes;
        private int _dia;
        private bool _bisiesto;
        private int _maximodia;
        private const int  _MAXIMOANIO = 9999;
        private const int _MAXIMOMES = 12;
        private const int _MINIMOANIO = 0;
        private const int _MINIMOMES = 1;
        private const int _MINIMODIA = 1;

        //PROPIEDADES
        public int Anio
        {
            set
            {
                _bisiesto = Bisiesto(value);
                _anio = CorregirAnio(value);
                _dia = CorregirDia(_dia);
            }
            get { return _anio; }
        }
        public int Mes
        {
            set 
            {
                _mes = CorregirMes(value);
                _dia = CorregirDia(_dia);
            }
            get { return _mes; }
        }
        public int Dia
        {
            get { return _dia; }
            set 
            { 
                _dia = CorregirDia(value); 
            }
        }
        public string FechaFormatoCorto
        {
            get { return string.Format("{0:D4}/{1:D2}/{2:D2}", _anio,_mes,_dia); }
        }
        public string FechaFormatolargo
        {
            get { return Dia + " del " + Mes + " del " + Anio; }
        }
        public string FechaMinima
        {
            get { return "0001/01/01"; }
        }
        public string FechaMaxima
        {
            get { return "9999/12/31"; }
        }


        //CONSTRUCTOR
        public CFechas(int anio, int mes, int dia)
        {
            Anio = anio;
            Mes = mes;
            Dia = dia;
        }

        public CFechas()
        {
            Random rnd = new Random();
            Anio = rnd.Next(0, 10000);
            Mes = rnd.Next(1, 13);
            Dia = rnd.Next(1, 31);
        }

        private int CorregirAnio(int valor)
        {
            if (valor < _MINIMOANIO) return _MINIMOANIO;
            if (valor > _MAXIMOANIO) return _MAXIMOANIO;
            return valor;
        }

        private int CorregirMes(int valor)
        {
            if (valor < _MINIMOMES) return _MINIMOMES;
            if (valor > _MAXIMOMES) return _MAXIMOMES;
            return valor;
        }
        private int CorregirDia(int valor)
        {
            _maximodia = CalcularMaximoDia(_bisiesto, _mes);
            if (valor < _MINIMODIA) return _MINIMODIA;
            if (valor > _maximodia) return _maximodia ;
            return valor;
        }
        private bool Bisiesto(int valor)
        {
            if (valor % 400 == 0) return true;                      //Si un año es divisible entre 400 es bisiesto
            if (valor % 4 == 0 && valor % 100 != 0) return true;    //Si es divisible entre 4 pero no entre 100 es bisiesto también
            return false;                                           //Para el resto de casos es falso;
        }
        private int CalcularMaximoDia(bool bisiesto, int valormes)
        {
            switch (valormes)
            {
                //Valor de los meses que tienen como máximo 30 días
                case 4:     
                    return 30; 
                case 6:
                    return 30;
                case 9:
                    return 30;
                case 11:
                    return 30;
                case 2:
                    if (bisiesto == true) return 29;    //Si es bisiesto retorna 29 días
                    else return 28;                     //Si no el máximo es 28 días
                default:                                //Valor de los meses que tienen como máximo 31 días 
                    return 31;                          //Retorno de 31 días
            }
        }

    }
}
