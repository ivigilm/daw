using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresenraya
    {
            /*    
            0-1-2
            3-4-5
            6-7-8
            */

    class Tresenraya
    {
        // Atributos

        // Opción 1: array de enteros de 9 posiciones

        private int[] posiciones; // casillas del tablero (0: vacía, 1: X, 2: O)

        // Opción 2: array de enteros bidimensional de 3x3. Por ahora no la utilizaremos.


        // Constructor

        /// <summary>
        /// Constructor que inicializa el tablero (vacío).
        /// </summary>
        public Tresenraya()
        {
            this.posiciones = new int[9];

            int i;
            for (i = 0; i < 9; i++)
            {
                this.posiciones[i] = 0;
            }
        }

        // Métodos

        /// <summary>
        /// Comprueba si una casilla del tablero está ocupada o vacía.
        /// </summary>
        /// <param name="pos">Casilla del tablero (1-9).</param>
        /// <returns>"true" si la casilla está vacía, "false" si está ocupada</returns>
        public bool MovimientoValido(int pos)
        {
            bool estadocasilla;

            if (this.posiciones[pos - 1] == 0) // si está vacía
            {
                estadocasilla = true;
            }
            else // si está ocupada
            {
                estadocasilla = false;
            }

            return estadocasilla;
        }

        /*
         Podría ser mejor utilizar tan solo los métodos MueveJugadorN y MueveOrdenadorN, pero como las instrucciones
         del proyecto decían claramente que debían utilizarse los métodos MueveJugador1, MueveJugador2, etc., estos son los
         únicos que se deben utilizar en el Main del proyecto (los únicos que deben ser públicos).
             */

        /// <summary>
        /// Pone un 1 o un 2 en la casilla indicada. (Un jugador realiza un movimiento.)
        /// </summary>
        /// <param name="pos">Posición del tablero (1-9).</param>
        /// <param name="numerojugador">Jugador que mueve (1 si juega con X, 2 si juega con O.)</param>
        public void MueveJugadorN(int pos, int numerojugador)
        {              
            if (MovimientoValido(pos)) // comprueba que la casilla está vacía
            {
                this.posiciones[pos - 1] = numerojugador; // si está vacía, coloca la ficha
            }
            else
            {
                throw new Exception("Casilla ocupada. No es posible realizar este movimiento.");
            }
        }

        /// <summary>
        /// Pone una '1' en la casilla indicada. (Lo que se traduce en un movimiento del jugador 1.)
        /// </summary>
        /// <param name="pos">Posición del tablero (1-9).</param>
        public void MueveJugador1(int pos)
        {
            MueveJugadorN(pos, 1);
        }

        /// <summary>
        /// Pone una '2' en la casilla indicada. (Lo que se traduce en un movimiento del jugador 2.)
        /// </summary>
        /// <param name="pos">Posición del tablero (1-9).</param>
        public void MueveJugador2(int pos)
        {
            MueveJugadorN(pos, 2);           
        }

        /// <summary>
        /// El ordenador pone un 1 (X) o 2 (O) en una posición libre aleatoria.
        /// </summary>
        /// <param name="">Número que representa a la ficha elegida por el jugador (X o O).</param>
        private void MueveOrdenadorN(int numerojugador)
        {
            int pos;
            Random r = new Random();
            pos = r.Next(1, 10); // genera posición aleatoria 1-9

            while (!MovimientoValido(pos)) // comprueba que el movimiento es válido (la casilla está vacía, si no, elige una nueva casilla)
            {
                pos = r.Next(1, 10);
            }

            if (MovimientoValido(pos)) // Si la casilla está vacía, mueve.
            {
                this.posiciones[pos - 1] = numerojugador;
            }
        }

        /// <summary>
        /// El ordenador pone un 1 (X) donde crea mejor. Por ahora, elegirá aleatoriamente la posición.
        /// </summary>
        public void MueveOrdenador1()
        {
            MueveOrdenadorN(1);
        }

        /// <summary>
        /// El ordenador pone un 2 (O) donde crea mejor. Por ahora, elegirá aleatoriamente la posición.
        /// </summary>
        public void MueveOrdenador2()
        {
            MueveOrdenadorN(2);
        }

        /// <summary>
        /// Limpia el tablero (inserta un 0 en todas las posiciones).
        /// </summary>
        public void Iniciar()
        {
            int i;
            for (i = 0; i < 9; i++)
            {
                this.posiciones[i] = 0;
            }
        }

        /// <summary>
        /// Comprueba si quedan casillas libres para seguir jugando.
        /// </summary>
        /// <returns>"true" si queda alguna casilla libre, "false" si están todas ocupadas.</returns>
        public bool QuedanMovimientos()
        {
            int i;
            bool seguirjugando;
            seguirjugando = false;
            
            for(i = 0; i < 9; i++)
            {
                if(this.posiciones[i] == 0) // si la casilla actual está libre
                {
                    seguirjugando = true; // se puede seguir jugando (con q haya una casilla libre)
                }
            }

            return seguirjugando;
        }

        /// <summary>
        /// Comprueba si hay alguna línea del tablero con 3 fichas del jugador N.
        /// </summary>
        /// <returns>"true" si hay 3 fichas iguales en raya, "false" si no.</returns>
        public bool GanaJugadorN(int jugador)
        {
            int i, j, contadorfichas;
            bool gana;
            gana = false;

            // COMPRUEBO FILAS

            for (i = 0; i < 9; i = i + 3)
            {
                contadorfichas = 0;

                for (j = i; j < i + 3; j++) // compruebo los 3 elementos de una fila
                {
                    if (this.posiciones[j] == jugador) // si hay una ficha del jugador en la posición actual
                    {
                        contadorfichas = contadorfichas + 1;
                    }
                }

                if (contadorfichas == 3) // si una fila tiene 3 fichas iguales, el jugador actual gana
                {
                    gana = true;
                }
            }

            // COMPRUEBO COLUMNAS

            for (i = 0; i < 3; i++)
            {
                contadorfichas = 0;

                for (j = i; j < i + 7; j = j + 3)
                {
                    if (this.posiciones[j] == jugador)
                    {
                        contadorfichas = contadorfichas + 1;
                    }

                }
                if (contadorfichas == 3) // si una fila tiene 3 X, el jugador 1 gana
                {
                    gana = true;
                }

            }

            // COMPRUEBO DIAGONALES

            if ((this.posiciones[0] == jugador && this.posiciones[4] == jugador && this.posiciones[8] == jugador) || (this.posiciones[2] == jugador && this.posiciones[4] == jugador && this.posiciones[6] == jugador))
            {
                gana = true;
            }

            return gana;
        }

        /// <summary>
        /// Comprueba si hay alguna línea del tablero con 3 fichas de X.
        /// </summary>
        /// <returns>"true" si hay 3 X en raya, "false" si no.</returns>
        public bool GanaJugador1()
        {
            bool gana;
            gana = GanaJugadorN(1);
            return gana;
        }

        /// <summary>
        /// Comprueba si hay alguna línea del tablero con 3 fichas de O.
        /// </summary>
        /// <returns>"true" si hay 3 O en raya, "false" si no.</returns>
        public bool GanaJugador2()
        {
            bool gana;
            gana = GanaJugadorN(2);
            return gana;
        }

        /// <summary>
        /// Convierte el entero guardado en una casilla del tablero al caracter que aparecerá al imprimir el tablero.
        /// </summary>
        /// <param name="contenidocasilla">Número entero guardado en una casilla del tablero.</param>
        /// <returns>Caracter que representa el entero guardado.</returns>
        public char CaracterImprimible(int contenidocasilla)
        {
            char elemento; 

            if(contenidocasilla == 0) // casilla vacía
            {
                elemento = ' ';
            }
            else
            {
                if(contenidocasilla == 1) // casilla con una X
                {
                    elemento = 'X';
                }
                else // casilla con una O
                {
                    elemento = 'O';
                }
            }

            return elemento;
        }

        /// <summary>
        /// Dibuja el tablero en pantalla.
        /// </summary>
        public void DibujaTablero()
        {
            int i, j;
            
            Console.Write("  -----------");
            Console.WriteLine();

            for (i = 0; i < 9; i = i + 3)
            {
                Console.Write(" | ");
                for (j = i; j < i + 2; j++)
                {
                    Console.Write(CaracterImprimible(posiciones[j]));

                    Console.Write(" | ");
                }

                Console.Write(CaracterImprimible(posiciones[j]));
                Console.Write(" | ");
                Console.WriteLine();
                Console.Write("  -----------");
                Console.WriteLine();
            }
        }
        

    }
}
