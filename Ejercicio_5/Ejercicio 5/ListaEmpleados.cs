using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class ListaEmpleado
    {
        //CAMPOS
        private int _codigo = 1;
        private List<Empleado> _empleados = null;
        private string _nombrelista;
        private const int LONGITUDMAXIMADENOMBRELISTA = 26;

        public string Nombrelista
        {
            get { return _nombrelista; }
        }
        
        //CONSTRUCTOR
        public ListaEmpleado(string nombrelista)
        {
            string nombrerecortado = string.Empty;

            if(nombrelista.Length <= LONGITUDMAXIMADENOMBRELISTA) _nombrelista = nombrelista;
            else
            {
                for (int i = 0; i < LONGITUDMAXIMADENOMBRELISTA; i++)
                {
                    nombrerecortado += nombrelista[i];
                }

                _nombrelista = nombrerecortado;
            }
            _empleados = new List<Empleado>();
        }

        //METODOS PARA MANIPULAR DATOS
        public bool AnadirEmpleadosAleatorios(int cantidad)
        {
            string[] apellidos = { "Prieto", "Perez", "González", "Toro", "Roldán", "Moya", "Rivas", "Tilla", "Menta", "García", "Shylyayev", "Bueno", "Turbado", "Sánchez", "Zúñiga", "Molina","Torres","Godoy","Muñoz" };
            string[] nombres = {"Raul", "Bilal", "Fran","Manuel","Ignacio", "Eustaquio", "Eliseo", "Aitor","Vyacheslav", "Ismael", "Sebas", "Ana", "Muzska","Rubén","Alejandro","Pablo","Adrián"};
            Random rnd = new Random();

            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    AnadirEmpleado(new Empleado(nombres[rnd.Next(0, nombres.Length)], apellidos[rnd.Next(0, apellidos.Length)] + " " +
                        apellidos[rnd.Next(0, apellidos.Length)], DateTime.Parse(rnd.Next(1960,2000).ToString() + "/" + rnd.Next(1,13).ToString() + "/" + rnd.Next(1,29).ToString())
                        , (float)rnd.Next(600, 2000)));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool AnadirEmpleado(Empleado p)
        {
            try
            {
                p.Codigo = _codigo++;
                _empleados.Add(p);
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool EliminarEmpleado(int codigo)
        {
            try
            {
                for (int i = 0; i < _empleados.Count; i++)
                {
                    if (codigo == _empleados[i].Codigo)
                    {
                        _empleados.RemoveAt(i);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }      

        //METODOS PARA CONSULTAR DATOS
        public bool VerEmpleado(int codigo)
        {
            for (int i = 0; i < _empleados.Count; i++)
            {
                if (codigo == _empleados[i].Codigo)
                {
                    _empleados[i].VerdatosPersona();
                    return true;
                }
            }
            return false;
        }
        public void BuscarEmpleadoNombreCompleto(string nombre, string apellidos)
        {
            string buscado = string.Empty;
            int contador = 1;

            //Sistema para que ignore los espacios a la hora de buscar entre nombre y apellidos
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != ' ') buscado += nombre[i];
            }
            for (int i = 0; i < apellidos.Length; i++)
            {
                if (apellidos[i] != ' ') buscado += apellidos[i];
            }

            Console.WriteLine("\nCódigo de la/s persona/s llamadas {0} {1}:", nombre, apellidos);
            //Una vez acabado compara en el listado con todos los nombres y apellidos que hay
            for (int i = 0; i < _empleados.Count; i++)
            {
                string personaenlista = string.Empty;
                for (int j = 0; j < _empleados[i].Nombre.Length; j++)
                {
                    if (_empleados[i].Nombre[j] != ' ') personaenlista += _empleados[i].Nombre[j];
                }
                for (int j = 0; j < _empleados[i].Apellidos.Length; j++)
                {
                    if (_empleados[i].Apellidos[j] != ' ') personaenlista += _empleados[i].Apellidos[j];
                }

                if (buscado.ToLower() == personaenlista.ToLower())
                {
                    Console.Write("{0,6}", _empleados[i].Codigo);
                    if (contador++ % 10 == 0) Console.WriteLine();
                }
            }
        }//mejor con out y salida bool
        public void BuscarEmpleadoNombre(string nombre)
        {
            string buscado = string.Empty;
            int contador = 1;

            //Sistema para que ignore los espacios a la hora de buscar entre nombre y apellidos
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] != ' ') buscado += nombre[i];
            }


            Console.WriteLine("\nCódigo de la/s persona/s llamadas {0}:", nombre);
            //Una vez acabado compara en el listado con todos los nombres y apellidos que hay
            for (int i = 0; i < _empleados.Count; i++)
            {
                string personaenlista = string.Empty;
                for (int j = 0; j < _empleados[i].Nombre.Length; j++)
                {
                    if (_empleados[i].Nombre[j] != ' ') personaenlista += _empleados[i].Nombre[j];
                }

                if (buscado.ToLower() == personaenlista.ToLower())
                {
                    Console.Write("{0,6}",_empleados[i].Codigo);
                    if (contador++%10 == 0) Console.WriteLine();
                }
            }
        }//mejor con out y salida bool
        public void BuscarEmpleadoApellidos(string apellidos)
        {
            string buscado = string.Empty;
            int contador = 1;

            //Sistema para que ignore los espacios a la hora de buscar entre nombre y apellidos
            for (int i = 0; i < apellidos.Length; i++)
            {
                if (apellidos[i] != ' ') buscado += apellidos[i];
            }

            Console.WriteLine("\nCódigo de la/s persona/s apellidadas {0}:", apellidos);
            //Una vez acabado compara en el listado con todos los nombres y apellidos que hay
            for (int i = 0; i < _empleados.Count; i++)
            {
                string personaenlista = string.Empty;
                for (int j = 0; j < _empleados[i].Apellidos.Length; j++)
                {
                    if (_empleados[i].Apellidos[j] != ' ') personaenlista += _empleados[i].Apellidos[j];
                }

                if (buscado.ToLower() == personaenlista.ToLower())
                {
                    Console.Write("{0,6}", _empleados[i].Codigo);
                    if (contador++ % 10 == 0) Console.WriteLine();
                }
            }
        }//mejor con out y salida bool
        public void ListarEmpleados()
        {
            ConsoleKey salirlistado = ConsoleKey.Escape;        
            const int ANCHOLISTADO = 80;
            int nLineasPorPagina = 25;
            int nLineaActual = 0;
            int nPaginaActual = 1;
            int nPaginaDeListado = (int)Math.Ceiling((double)_empleados.Count / (double)nLineasPorPagina);

            foreach (Empleado tmp in _empleados)
            {
                //Muestra la cabecera
                if (nLineaActual == 0)
                {
                    //Centrar el título en la cabecera
                    Console.Clear();
                    Console.CursorLeft = (ANCHOLISTADO / 2) - (_nombrelista.Length / 2);
                    Console.WriteLine(_nombrelista);
                    Console.WriteLine("".PadRight(ANCHOLISTADO, '-'));
                    Console.WriteLine("Codigo".PadLeft(8) + "Apellidos, nombre".PadLeft(40) + "Fecha de nac.".PadLeft(16) + "Sueldo".PadLeft(10));
                    Console.WriteLine("".PadRight(ANCHOLISTADO,'-'));
                    //return _codigo.ToString().PadLeft(5) +  (_apellidos + ", " + _nombre).PadLeft(40) + "   " + _fechaNacimiento.ToShortDateString() + _sueldoReal.ToString().PadLeft(10);
                }
                
                //Muestra el cuerpo del listado
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(tmp.ToString());
                nLineaActual++;
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                //Mostrar el pie de página
                if (nLineasPorPagina == nLineaActual)
                {
                    Console.WriteLine("".PadRight(ANCHOLISTADO, '-'));
                    Console.WriteLine("[ESC] Volver al menu.              Página: {0}/{1}...", nPaginaActual++, nPaginaDeListado);
                    nLineaActual = 0;

                    //Al pulsar Escape abortar el listado
                    if (Console.ReadKey(true).Key == salirlistado) return;
                }
            }
            //Excepcion para cuando este la lista vacía
            if(_empleados.Count==0)
                {
                    Console.WriteLine("No hay empleados para listar");
                    Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                    Console.ReadKey();
                }

            //última página
            Console.WriteLine("".PadRight(ANCHOLISTADO, '='));
            Console.WriteLine(" Página {0}/{1}", nPaginaActual, nPaginaDeListado);
            Console.Write("   FIN DEL LISTADO");
            if (nPaginaActual == nPaginaDeListado) Console.ReadKey();
        }
    }
}
