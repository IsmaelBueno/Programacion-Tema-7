using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio_5
{
    class Program
    {
       //Datos compartidos
        public static ConsoleKeyInfo tecla;

        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        //METODOS
        public static void MenuPrincipal()
        {
            bool salir = false;

            //BUCLE DEL MENU
            do
            {
                Console.Clear();
                const int POSICIONX = 36;
                int posiciony = 6;


                //Impresión del menú
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("  ╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("  ║                         MENU PRINCIPAL                         ║");
                Console.WriteLine("  ╠════════════════════════════════╦═══════════════════════════════╣");
                Console.WriteLine("  ║                                ║      Listados existentes      ║");
                Console.WriteLine("  ║ [C] Crear un nuevo listado     ║                               ║");
                Console.WriteLine("  ║ [B] Borrar un listado          ║                               ║");
                Console.WriteLine("  ║                                ║                               ║");
                Console.WriteLine("  ║ [ESC] Salir                    ║                               ║");
                Console.WriteLine("  ║                                ║                               ║");
                Console.WriteLine("  ╚════════════════════════════════╩═══════════════════════════════╝");
                Console.WriteLine("      ELIGE UNA OPCIÓN: ");


                //Impresión de los listados creados
                for (int i = 0; i < Listados.Ndatos; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(POSICIONX, posiciony++);
                    Console.Write("[{0}] {1}", i + 1, Listados.ListadosPosibles[i].Nombrelista);
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;


                //Lectura de la opción del usuario
                Console.SetCursorPosition(23, 12);
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    #region CREAR NUEVO LISTADO
                    case ConsoleKey.C:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Introduce el nombre del nuevo listado que quieres crear");
                        if (!Listados.CrearListado(Console.ReadLine()))
                        {
                            Console.WriteLine("El número máximo de listados son 5, si quieres crear un nuevo listado primero borra alguno ya existente");
                            Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                            Console.ReadKey();
                        }
                        break;
                    #endregion
                    #region BORRAR LISTADO EXISTENTE
                    case ConsoleKey.B:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (Listados.Ndatos == 0)
                        {
                            Console.WriteLine("No hay listados para borrar");
                            Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            for (int i = 0; i < Listados.Ndatos; i++)
                            {
                                Console.WriteLine("    [{0}] {1}", i + 1, Listados.ListadosPosibles[i].Nombrelista);
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Introduce el número del listado que quieres borrar");
                            if (!Listados.BorrarListado(GenerarInt()))
                            {
                                Console.WriteLine("Error, opción inexistente");
                                Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                                Console.ReadKey();
                            }
                        }
                        break;
                    #endregion
                    #region SELECCION DE LISTADOS
                    //0,1,2,3,4 representan la posición de cada listado de empleados en el array listado
                    case ConsoleKey.D1:
                        if (Listados.Ndatos < 1) OpcionIncorrecta();
                        else
                        {
                            SubMenu(0);
                        }
                        break;
                    case ConsoleKey.D2:
                        if (Listados.Ndatos < 2) OpcionIncorrecta();
                        else
                        {
                            SubMenu(1);
                        }
                        break;
                    case ConsoleKey.D3:
                        if (Listados.Ndatos < 3) OpcionIncorrecta();
                        else
                        {
                            SubMenu(2);
                        }
                        break;
                    case ConsoleKey.D4:
                        if (Listados.Ndatos < 4) OpcionIncorrecta();
                        else
                        {
                            SubMenu(3);
                        }
                        break;
                    case ConsoleKey.D5:
                        if (Listados.Ndatos < 5) OpcionIncorrecta();
                        else
                        {
                            SubMenu(4);
                        }
                        break;
                    #endregion
                    case ConsoleKey.Escape:
                        salir = true;
                        break;
                    default:
                        OpcionIncorrecta();
                        break;
                }
            } while (!salir);  
        }
        /// <summary>
        /// Pauta para seguir por defecto cuando una opción es incorrecta en un menú
        /// </summary>
        public static void OpcionIncorrecta()
        {
            Console.SetCursorPosition(2, 14);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Opción incorrecta");
            Thread.Sleep(500);
        }
        /// <summary>
        /// Comprueba que el usuario introduzca un valor numérico entero positivo
        /// </summary>
        /// <returns></returns>
        public static int GenerarInt()
        {
            bool salir = false;
            int numero = 0;
            do
            {
                salir = int.TryParse(Console.ReadLine(), out numero);
                if (!salir || numero < 0)
                {
                    Console.WriteLine("Error, debes introducir un número entero positivo");
                    salir = false;
                }
            } while (!salir);

            return numero;
        }
        /// <summary>
        /// Imprime la parte visual del submenu o menu de cada listado
        /// </summary>
        /// <param name="nombrelista"></param>
        public static void ImprimirSubMenu(string nombrelista)
        {
            int mitadpalabra = nombrelista.Length / 2;
            const int MITADTITULO = 26;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("  ╔════════════════════════════════════════════╗");
            Console.WriteLine("  ║                                            ║");
            Console.WriteLine("  ╠════════════════════════════════════════════╣");
            Console.WriteLine("  ║ [1] Añadir empleado                        ║");
            Console.WriteLine("  ║ [2] Eliminar empleado                      ║");
            Console.WriteLine("  ║ [3] Ver datos del empleado (Con el código) ║");
            Console.WriteLine("  ║ [4] Buscar empleado                        ║");
            Console.WriteLine("  ║ [5] Listar todos los empleados             ║");
            Console.WriteLine("  ║ [A] Introducir empleados aleatorios        ║");
            Console.WriteLine("  ║ [ESC] Volver                               ║");
            Console.WriteLine("  ╚════════════════════════════════════════════╝");
            Console.WriteLine("      ELIGE UNA OPCIÓN: ");

            Console.SetCursorPosition(MITADTITULO - mitadpalabra, 3);
            Console.WriteLine(nombrelista);

        }
        /// <summary>
        /// Gestiona el sub menu del listado
        /// </summary>
        /// <param name="numeroLista"></param>
        public static void SubMenu(int numeroLista)
        {
            bool volver = false;
            bool correcto = false;
            do
            {
                //Impresion del menú
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ImprimirSubMenu(Listados.ListadosPosibles[numeroLista].Nombrelista);


                //Lectura de la opción del usuario
                Console.SetCursorPosition(23, 13);
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    #region AÑADIR EMPLEADO
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.WriteLine("Introduce el nombre");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Introduce los apellidos");
                        string apellidos = Console.ReadLine();

                        DateTime fecha = DateTime.MinValue;
                        Console.WriteLine("Ahora introduce su fecha de nacimiento (dd/mm/aaaa)");
                        do
	                    {
	                        correcto = DateTime.TryParse(Console.ReadLine(), out fecha);
                            if(!correcto) Console.WriteLine("Error, debes introducir una fecha con el formato dd/mm/aaaa");
	                    } while (!correcto);
                        correcto = false;

                        float sueldo = 0F;
                        Console.WriteLine("Por último introduce su sueldo");
                        do
	                    {
	                        correcto = float.TryParse(Console.ReadLine(), out sueldo);
                            if(!correcto || sueldo <0F)
                            {
                                Console.WriteLine("Error debes introducir un valor positivo");
                                correcto = false;
                            }
	                    } while (!correcto);
                        correcto = false;

                        Listados.ListadosPosibles[numeroLista].AnadirEmpleado(new Empleado(nombre, apellidos, fecha, sueldo));
                        break;
                    #endregion
                    #region BORRAR EMPLEADO
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Introduce el código de la persona que quieras borrar");
                        if (!Listados.ListadosPosibles[numeroLista].EliminarEmpleado(GenerarInt()))
                        {
                            Console.WriteLine("No se pudo borrar la persona introducida");
                            Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                            Console.ReadKey();
                        }
                        break;
                    #endregion
                    #region VER DATOS DE UN EMPLEADO
                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Introduce el código del empleado que quieres consultar sus datos");
                        if (!Listados.ListadosPosibles[numeroLista].VerEmpleado(GenerarInt()))
                        {
                            Console.WriteLine("No existe nadie con este código");
                        }
                        Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                        Console.ReadKey();
                        break;
                    #endregion
                    #region BUSCAR EMPLEADO
                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        PruebaMenuBusqueda(numeroLista);
                        break;
                    #endregion
                    #region LISTAR
                    case ConsoleKey.D5:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Listados.ListadosPosibles[numeroLista].ListarEmpleados();
                        break;
                    #endregion
                    #region AÑADIR EMPLEADOS ALEATORIOS
                    case ConsoleKey.A:
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Introduce cuantos empleados aleatorios quieres añadir");
                            Listados.ListadosPosibles[numeroLista].AnadirEmpleadosAleatorios(GenerarInt());
                        break;
                    #endregion
                    case ConsoleKey.Escape:
                        volver = true;
                        break;
                    default:
                        OpcionIncorrecta();
                        break;
                }
            } while (!volver);
        }
        /// <summary>
        /// Menu de prueba para los distintos tipos de busqueda de empleado
        /// </summary>
        /// <param name="numeroLista"></param>
        public static void PruebaMenuBusqueda(int numeroLista)
        {
            bool salir = false;
            bool limpiarpantalla = false;
            const int XMENU = 0;              //Posicion x inicial del menu
            const int YMENU = 0;              //Posicion y inicial del menu
            const int CURSORX = 4;            //Posicion del eje x para el cursor
            const int CURSORY = 3;            //Posicion inicial del eje y para el cursor
            const int NUMEROOPCIONES = 3;     //Número de filas con opciones
            int yactual = CURSORY;          
            const int MITADMENU = 25;
            int mitadtitulo = Listados.ListadosPosibles[numeroLista].Nombrelista.Length / 2;

            do
            {
                Console.CursorVisible = false;
                //Impresion del menu
                Console.SetCursorPosition(XMENU, YMENU);
                Console.WriteLine("  ╔════════════════════════════════════════════╗");
                Console.WriteLine("  ║                                            ║");
                Console.WriteLine("  ╠════════════════════════════════════════════╣");
                Console.WriteLine("  ║   Busqueda por nombre                      ║     Mueve el cursor (») con la flechas arriba/abajo"); 
                Console.WriteLine("  ║   Busqueda por apellidos                   ║     Pulsa intro para seleccionar una opción"); 
                Console.WriteLine("  ║   Busqueda por nombre y apellidos          ║"); 
                Console.WriteLine("  ║   Volver                                   ║"); 
                Console.WriteLine("  ╚════════════════════════════════════════════╝");

                //Impresion del titulo
                Console.SetCursorPosition(MITADMENU - mitadtitulo, 1);
                Console.WriteLine(Listados.ListadosPosibles[numeroLista].Nombrelista);



                //Posición del cursor
                Console.SetCursorPosition(CURSORX, yactual);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("»");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (yactual == CURSORY) yactual = CURSORY + NUMEROOPCIONES;
                        else yactual--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (yactual == NUMEROOPCIONES + CURSORY) yactual = CURSORY;
                        else yactual++;
                        break;
                    case ConsoleKey.Enter:
                        limpiarpantalla = true;
                        switch (yactual)
                        {
                            case CURSORY:
                                Console.CursorVisible = true;
                                Console.Clear();
                                Console.WriteLine("Introduce el nombre del empleado");
                                string nombresolo = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Listados.ListadosPosibles[numeroLista].BuscarEmpleadoNombre(nombresolo);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                                Console.ReadKey();
                                break;
                            case CURSORY+1:
                                Console.CursorVisible = true;
                                Console.Clear();
                                string apellidossolo = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Listados.ListadosPosibles[numeroLista].BuscarEmpleadoApellidos(apellidossolo);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                                Console.ReadKey();
                                break;
                            case CURSORY+2:
                                Console.CursorVisible = true;
                                Console.Clear();
                                Console.WriteLine("Introduce el nombre");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Ahora introduce los apellidos");
                                string apellidos = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Listados.ListadosPosibles[numeroLista].BuscarEmpleadoNombreCompleto(nombre, apellidos);
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("\n\nPulsa cualquier tecla para volver...");
                                Console.ReadKey();                       
                                break;
                            case CURSORY+3:
                                salir = true;
                                break;
                        }
                        break;
                }
                if (limpiarpantalla)
                {
                    Console.Clear();
                    limpiarpantalla = false;
                }
            } while (!salir);
            Console.CursorVisible = true;
        }
    }
}