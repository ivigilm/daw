using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tresenraya
{
    class Program
    {
        static void Main(string[] args)
        {            
            char iniciarpartida;

            // Creo el tablero, pregunto si quiere jugar

            int fichausuario, posicion;
            Tresenraya tablero = new Tresenraya();

            Console.WriteLine("¡Qué día tan estupendo hace! ¿Te apetece una partida de tres en raya? (s/n)");
            iniciarpartida = char.Parse(Console.ReadLine());

            while(iniciarpartida == 's') // desarrollo de una partida
            {
                tablero.Iniciar(); // limpio el tablero (retiro las fichas de la última partida)

                Console.WriteLine();
                Console.WriteLine("¡Mira qué tablero tan bonito he hecho para ti!");
                Console.WriteLine();
                tablero.DibujaTablero(); // muestro mi tablero en pantalla

                // SE LE DA A ELEGIR FICHA AL JUGADOR

                Console.WriteLine();
                Console.WriteLine("¡Vamos a empezar! ¿Qué quieres jugar con X o O? (inroduce 1 para X, 2 para O)");
                fichausuario = int.Parse(Console.ReadLine());
                Console.WriteLine();

                // EL ORDENADOR COLOCA SU PRIMERA FICHA

                Console.WriteLine("");
                Console.WriteLine("Comienza moviendo tu oponente. Este es su movimiento:");
                Console.WriteLine("");

                if (fichausuario == 1) // El usuario juega con X. El ordenador juega con O.
                {
                    tablero.MueveOrdenador2(); // el ordenador es el "Jugador 2" y coloca su ficha
                }
                else // El usuario juega con O. El ordenador juega con X.
                {
                    tablero.MueveOrdenador1(); // el ordenador es el "Jugador 1"
                }

                tablero.DibujaTablero(); // muestro el tablero con la ficha colocada

                // AHORA LE TOCA JUGAR AL USUARIO, Y LA PARTIDA SIGUE HASTA QUE SE ACABE

                while (tablero.QuedanMovimientos() && !tablero.GanaJugador1() && !tablero.GanaJugador2()) // mientras la partida no se acabe
                {
                    // juega usuario

                    if (fichausuario == 1) // ordenador: 2
                    {
                        Console.WriteLine();
                        Console.WriteLine("Es tu turno. ¿En qué casilla quieres colocar tu ficha? (1-9)");
                        posicion = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        tablero.MueveJugador1(posicion);
                        tablero.DibujaTablero(); // muestro el tablero con las fichas

                        if (tablero.QuedanMovimientos() && !tablero.GanaJugador1() && !tablero.GanaJugador2()) // no se acabó la partida
                        {
                            Console.WriteLine();
                            Console.WriteLine("Turno de tu rival.");
                            Console.WriteLine();

                            tablero.MueveOrdenador2();
                            tablero.DibujaTablero();

                            if (!(tablero.QuedanMovimientos() && !tablero.GanaJugador1() && !tablero.GanaJugador2())) // la partida se acabó
                            {
                                if (tablero.GanaJugador2()) // ganó el ordenador
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine("¡Has perdido!");
                                }
                                else // no quedan movimientos
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine("No quedan movimientos.");
                                }
                            }
                        }
                        else // se acabó la partida
                        {
                            if (tablero.GanaJugador1()) // gana el usuario
                            {
                                Console.WriteLine();
                                Console.WriteLine("¡¡¡FELICIDADES!!! ¡¡¡HAS GANADO A LA MÁQUINA!!! *Fuegos artificiales* ");
                            }
                            else // no quedan movimientos
                            {
                                Console.WriteLine();
                                Console.WriteLine("GAME OVER");
                                Console.WriteLine("No quedan movimientos.");
                            }
                        }
                    }
                    else // usuario: 2, ordenador: 1
                    {
                        Console.WriteLine();
                        Console.WriteLine("Es tu turno. ¿En qué casilla quieres colocar tu ficha? (1-9)");
                        posicion = int.Parse(Console.ReadLine());

                        tablero.MueveJugador2(posicion);
                        tablero.DibujaTablero();

                        if (tablero.QuedanMovimientos() && !tablero.GanaJugador1() && !tablero.GanaJugador2()) // no se acabó la partida
                        {
                            Console.WriteLine();
                            Console.WriteLine("Turno de tu rival.");
                            Console.WriteLine();

                            tablero.MueveOrdenador1();
                            tablero.DibujaTablero();

                            if (!(tablero.QuedanMovimientos() && !tablero.GanaJugador1() && !tablero.GanaJugador2())) // la partida se acabó
                            {
                                if (tablero.GanaJugador1()) // ganó el ordenador
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine("¡Has perdido!");
                                }
                                else // no quedan movimientos
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("GAME OVER");
                                    Console.WriteLine("No quedan movimientos.");
                                }
                            }
                        }
                        else // se acabó la partida
                        {
                            if (tablero.GanaJugador2()) // gana el usuario
                            {
                                Console.WriteLine();
                                Console.WriteLine("¡¡¡FELICIDADES!!! ¡¡¡HAS GANADO A LA MÁQUINA!!! *Fuegos artificiales* ");
                            }
                            else // no quedan movimientos
                            {
                                Console.WriteLine();
                                Console.WriteLine("GAME OVER");
                                Console.WriteLine("No quedan movimientos.");
                            }
                        }
                    }

                }

                Console.WriteLine();
                Console.WriteLine("¡Ha sido divertido! ¿Quieres jugar otra partida? (s/n)");
                Console.WriteLine();

                iniciarpartida = char.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine("Lamentamos ver que te vas. ¡Vuelve pronto!");

            Console.ReadKey();

        }
    }
}
