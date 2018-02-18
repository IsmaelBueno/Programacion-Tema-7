using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Numero
    {
        //CAMPOS
        private int _valor;

        //PROPOIEDADES
        public int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public double FactorialRecursivo
        {
            get { return CalcularFactorialRecursivo(_valor); }
        }
        public double FactorialIterativo
        {
            get { return CalcularFactorialIterativo(); }
        }
        public double FibonacciRecursivo
        {
            get { return CalcularFibonacciRecursivo(_valor); }
        }
        public double FibonacciIterativo
        {
            get { return CalcularFibonacciIterativo(); }
        }
        public double SumaNumerosIterativo
        {
            get { return CalcularSumaNumerosIterativo(); }
        }
        public double SumaNumerosRecursivo
        {
            get { return CalcularSumaNumerosRecursivo(_valor); }
        }
        public bool EsPrimo
        {
            get { return CalcularEsPrimo(); }
        }
        //CONSTRUCTOR
        public Numero(int numero)
        {
            if(numero<1) numero=1;
            _valor = numero;
        }
        
        //METODOS
        private double CalcularFactorialRecursivo(int numero)
        {
            try
            {
                if (numero == 1) return 1;
                return numero * CalcularFactorialRecursivo(numero-1);
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private double CalcularFactorialIterativo()
        {
            int resultado = 1;
            try
            {
                for (int i = _valor; i > 0; i--)
                {
                    resultado *= i;
                }
                return resultado;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private double CalcularFibonacciRecursivo(int numero)
        {
            if (numero == 1) return 0;
            if (numero == 2) return 1;
            return CalcularFibonacciRecursivo(numero - 1) + CalcularFibonacciRecursivo(numero - 2);
        }
        private double CalcularFibonacciIterativo()
        {
            if (_valor == 1) return 0;
            if (_valor == 2) return 1;
            int numero1 = 0;
            int numero2 = 1;
            int resultado = 0;
            for (int i = 2; i < _valor; i++)
            {
                resultado = numero1 + numero2;
                numero1 = numero2;
                numero2 = resultado; 
            }
            return resultado;
        }
        private double CalcularSumaNumerosIterativo()
        {
            int resultado = 0;
            for (int i = 1; i <= Valor; i++)
            {
                resultado += i;
            }
            return resultado;
        }
        private double CalcularSumaNumerosRecursivo(int numero)
        {
            if (numero == 1) return 1;
            else
            {
                return numero + CalcularSumaNumerosRecursivo(numero - 1);
            }
        }
        private bool CalcularEsPrimo()
        {
            if (_valor == 1) return false;
            else if (_valor == 2) return true;
            else
            {
                for (int i = 2; i < Valor; i++)
                {
                    if (_valor % i == 0) return false;
                }
                return true;
            }
        }
        public override string ToString()
        {
            return _valor.ToString();
        }
        public void ImprimirTodosDatos()
        {
            Console.WriteLine(" NUMERO: {0}", Valor);
            Console.WriteLine(" .....................................................");
            Console.WriteLine(" Factorial recursivo: {0}", FactorialRecursivo);
            Console.WriteLine(" Factorial iterativo: {0}", FactorialRecursivo);
            Console.WriteLine(" Fibonacci recursivo: {0}", FibonacciRecursivo);
            Console.WriteLine(" Fibonacci iterativo: {0}", FibonacciIterativo);
            Console.WriteLine(" Suma de números recursivo: {0}", SumaNumerosRecursivo);
            Console.WriteLine(" Suma de números iterativo: {0}", SumaNumerosIterativo);
            Console.WriteLine(" Primo: {0}", EsPrimo);
        }
    }
}
