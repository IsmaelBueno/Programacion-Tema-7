using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public static class Listados
    {
        //CAMPOS
        private static ListaEmpleado[] listadosPosibles = new ListaEmpleado[6];
        private static int ndatos = 0;
        private const int NUMMAXIMOLISTADOS = 5;

        //PROPIEDADES
        public static int Ndatos
        {
            get { return Listados.ndatos; }
        }
        public static ListaEmpleado[] ListadosPosibles
        {
            get { return Listados.listadosPosibles; }
        }

        //METODOS
        public static bool CrearListado(string nombrelistado)
        {
            if (ndatos < NUMMAXIMOLISTADOS)
            {
                listadosPosibles[ndatos] = new ListaEmpleado(nombrelistado);
                ndatos++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool BorrarListado(int opcion)
        {
            int posicionarray;

            if (opcion<1 || opcion>ndatos)
            {
                return false;
            }
            else
            {                
                posicionarray = opcion - 1;
                for (int i = 0; i < ndatos; i++)
                {
                    listadosPosibles[posicionarray] = listadosPosibles[posicionarray + 1];
                }
                ndatos--;
                return true;
            }           
        }
    }
}
