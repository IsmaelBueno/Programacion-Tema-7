using System;

namespace ismael.MenuPrincipal
{
    public static class MenuPrincipal
    {
        //Métodos
        public static void CrearMenu(Marco marco, Opcion[] opciones)
        {
            Opcion[] opcionescomprobadas = new Opcion[opciones.Length];

            if (marco.Ancho < 8) throw new Exception("En un menú con al menos una opción el ancho mínimo debe ser de 8");

            //Con el bucle llenamos el array de opcionescomprobadas igual que el de opciones salvo que alguna opción supere el ancho del marco
            for (int i = 0; i < opciones.Length; i++)
			{
                if (opciones[i].ToString().Length < marco.Ancho - 3) // 1 por el espacio que deja entre el marco y empezar a escribir la opcion y 2 porque en el ancho se incluyen los caracteres del borde
                    opcionescomprobadas[i] = opciones[i];
                else
                {
                    char tecla;
                    string definicion = null;
                    ConsoleColor color;

                    tecla = opciones[i].Tecla;
                    color = opciones[i].Color;
                    for (int j = 0; j < marco.Ancho-7; j++) //1 por el espacio entre el marco y empezar a escribir la opcion, 2 porque en el ancho se incluyen los caracteres laterales y 4 porque es donde escribie [tecla] + " "
                    {
                        definicion += opciones[i].Definicion[j];
                    }
                    opcionescomprobadas[i] = new Opcion(definicion, tecla, color);
                }

			}

            //Una vez comprobas las opciones imprime el marco y luego estas
            marco.Visualizar();

            int contador = 0;
            for (int i = marco.V1y+1; i < marco.V3y; i++)
            {

                if (contador < opcionescomprobadas.Length)
                {
                    Console.SetCursorPosition(marco.V1x + 1, i);
                    Console.ForegroundColor = opcionescomprobadas[contador].Color;
                    Console.Write(" " + opcionescomprobadas[contador].ToString());
                }
                else i = marco.V3y;

                Console.ResetColor();
                contador++;
            }

        }
    }
}