using System;

namespace ismael.MenuPrincipal
{
    public class Marco
    {
        //Campos
        private int _v1x;
        private int _v1y;
        private int _v3x;
        private int _v3y;
        private int _ancho;
        private int _largo;
        private bool _marcodoble;
        private ConsoleColor _color;

        //Propiedades
        public int V1x
        {
          get { return _v1x; }
        }
        public int V1y
        {
            get { return _v1y; }
        }
        public int V3x
        {
          get { return _v3x; }
        }
        public int V3y
        {
          get { return _v3y; }
        }
        public int Ancho
        {
            get { return _ancho; }
        }
        public int Largo
        {
            get { return _largo; }
        }
        public bool Marcodoble
        {
            get { return _marcodoble; }
            set { _marcodoble = value; }
        }
        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        //Constructores
        public Marco(int V1x, int V1y, int V3x, int V3y, bool Marcodoble, ConsoleColor Color)
        {
            int ancho = V3x - V1x;
            int largo = V3y - V1y;

            //Aquí llama a todos los métodos para solucionar errores o en su defecto lanzar una excepción.
            #region
            CoordenadaNegativa(V1x,V1y,V3x,V3y);                                                        //Excepcion
            DimensionNegativaNula(ancho,largo);                                                         //Excepcion
            ReajustarCoordenadasGrandes(ref ancho, ref largo, ref V1x, ref V1y, ref V3x, ref V3y);      //Reajuste
            #endregion
            _ancho = ancho;
            _largo = largo;
            _v1x = V1x;
            _v1y = V1y;
            _v3x = V3x;
            _v3y = V3y;
            _color = Color;
            _marcodoble = Marcodoble;         
        }
        /// <summary>
        /// Crear un marco a partir de 2 coordenadas y un color
        /// </summary>
        /// <param name="V1x"></param>
        /// <param name="V1y"></param>
        /// <param name="V3x"></param>
        /// <param name="V3y"></param>
        /// <param name="Color"></param>
        public Marco(int V1x, int V1y, int V3x, int V3y, ConsoleColor Color)
        {
            int ancho = V3x - V1x;
            int largo = V3y - V1y;

            //Aquí llama a todos los métodos para solucionar errores o en su defecto lanzar una excepción.
            #region
            CoordenadaNegativa(V1x, V1y, V3x, V3y);                                                        //Excepcion
            DimensionNegativaNula(ancho, largo);                                                         //Excepcion
            ReajustarCoordenadasGrandes(ref ancho, ref largo, ref V1x, ref V1y, ref V3x, ref V3y);      //Reajuste
            #endregion
            _ancho = ancho;
            _largo = largo;
            _v1x = V1x;
            _v1y = V1y;
            _v3x = V3x;
            _v3y = V3y;
            _color = Color;
            _marcodoble = false;
        }
        /// <summary>
        /// Crear un marco a partir de dos coordenadas y un tipo de marco
        /// </summary>
        /// <param name="V1x"></param>
        /// <param name="V1y"></param>
        /// <param name="V3x"></param>
        /// <param name="V3y"></param>
        /// <param name="Marcodoble"></param>
        public Marco(int V1x, int V1y, int V3x, int V3y, bool Marcodoble)
        {
            int ancho = V3x - V1x;
            int largo = V3y - V1y;

            //Aquí llama a todos los métodos para solucionar errores o en su defecto lanzar una excepción.
            #region
            CoordenadaNegativa(V1x, V1y, V3x, V3y);                                                        //Excepcion
            DimensionNegativaNula(ancho, largo);                                                           //Excepcion
            ReajustarCoordenadasGrandes(ref ancho, ref largo, ref V1x, ref V1y, ref V3x, ref V3y);         //Reajuste
            #endregion
            _ancho = ancho;
            _largo = largo;
            _v1x = V1x;
            _v1y = V1y;
            _v3x = V3x;
            _v3y = V3y;
            _color = ConsoleColor.White;
            _marcodoble = Marcodoble;       
        }
        /// <summary>
        /// Crear un marco a partir de dos coordenadas
        /// </summary>
        /// <param name="V1x"></param>
        /// <param name="V1y"></param>
        /// <param name="V3x"></param>
        /// <param name="V3y"></param>
        public Marco(int V1x, int V1y, int V3x, int V3y)
        {
            int ancho = V3x - V1x;
            int largo = V3y - V1y;

            //Aquí llama a todos los métodos para solucionar errores o en su defecto lanzar una excepción.
            #region
            CoordenadaNegativa(V1x, V1y, V3x, V3y);                                                        //Excepcion
            DimensionNegativaNula(ancho, largo);                                                           //Excepcion
            ReajustarCoordenadasGrandes(ref ancho, ref largo, ref V1x, ref V1y, ref V3x, ref V3y);         //Reajuste
            #endregion
            _ancho = ancho;
            _largo = largo;
            _v1x = V1x;
            _v1y = V1y;
            _v3x = V3x;
            _v3y = V3y;
            _color = ConsoleColor.White;
            _marcodoble = false;
        }

        //Metodos de correción de errores, son privados
        /// <summary>
        /// Excepción para coordenada negativa
        /// </summary>
        /// <param name="v1x"></param>
        /// <param name="v1y"></param>
        /// <param name="v3x"></param>
        /// <param name="v3y"></param>
        private static void CoordenadaNegativa(int v1x, int v1y, int v3x, int v3y)
        {
            if (v1x < 0 || v1y < 0 || v3x < 0 || v3y < 0) throw new Exception("Coordenada negativa");
        }    
        /// <summary>
        /// Comprueba que el ancho o largo generados no sean negativos, es decir, debe cumplirse que v1x < v3x y v1y < v3y
        /// </summary>
        /// <param name="ancho"></param>
        /// <param name="largo"></param>
        private static void DimensionNegativaNula(int ancho, int largo)
        {
            if (ancho < 1 || largo < 1) throw new Exception("Las coordenadas crean un un ancho o largo del marco negativo o de valor 0");
        }
        /// <summary>
        /// Reajusta el las coordenadas por si superan el máximo de consola de largo o ancho
        /// </summary>
        /// <param name="ancho"></param>
        /// <param name="largo"></param>
        /// <param name="v1x"></param>
        /// <param name="v1y"></param>
        /// <param name="v3x"></param>
        /// <param name="v3y"></param>
        private static void ReajustarCoordenadasGrandes(ref int ancho, ref int largo,ref int v1x,ref int v1y,ref int v3x,ref int v3y)
        {
            if (v3x > Console.WindowWidth)
            {
                v3x = Console.WindowWidth-1;
                if(v1x > v3x) v1x = v3x - 2;
                ancho = v3x - v1x;
            }
            if (v3y > Console.WindowHeight)
            {
                v3y = Console.WindowHeight;
                if (v1y > v3y) v1y = v3y - 1;
                largo = v3y - v1y;
            }
        }

        //Métodos
        /// <summary>
        /// Visualiza como queda el marco en pantalla
        /// </summary>
        public void Visualizar ()
        {
            char[] marco;
            if (_marcodoble == true) marco = new char[] { '╔', '╗', '╝', '╚', '═', '║' };
            else marco = new char[] { '┌', '┐', '┘', '└', '─', '│' };

            Console.ForegroundColor = _color;
           
            //Primera fila del marco
            Console.SetCursorPosition(_v1x,_v1y);
            Console.Write(marco[0]);
            for (int i = 0; i < _ancho - 2; i++)
            {
                Console.Write(marco[4]);
            }
            Console.Write(marco[1]);

            //Contenido interior
            for (int i = 1; i < _largo; i++)
            {
                Console.SetCursorPosition(_v1x, _v1y + i); //Colocamos el cursor en su posición, con el bucle irá aumentado la posición de la i hasta cumplir el largo
                Console.Write(marco[5]);
                for (int j = 0; j < _ancho -2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(marco[5]);
            }

            //Última fila del marco
            Console.SetCursorPosition(_v1x, _v3y);
            Console.Write(marco[3]);
            for (int i = 0; i < _ancho - 2; i++)
            {
                Console.Write(marco[4]);
            }
            Console.Write(marco[2]);

            Console.ResetColor();
        }

    }
}
