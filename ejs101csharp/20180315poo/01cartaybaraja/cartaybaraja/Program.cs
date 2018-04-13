using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartaybaraja
{
    class Program
    {
        
        static void Main(string[] args) // Juego de las 7 y media
        {
            // CREO BARAJA           

            Baraja b = new Baraja(1, true); // creo una baraja española y la barajo
            Carta c;
            string jugar;
            int turno;
            bool usuariofuera, pcfuera; // para recordar qué jugador ha dejado de jugar
            decimal puntosusuario, puntospc; // para comprobar si los jugadores se pasan de 7.5
            puntosusuario = 0;
            puntospc = 0;
            turno = 1; // empieza jugando el usuario
            usuariofuera = false;
            pcfuera = false;

            Console.WriteLine("¿Te apetece jugar a las 7 y media? Dime que sí. (s)");
            jugar = Console.ReadLine();
            Console.WriteLine();

            while (jugar == "s")
            {
                if(turno == 1) // turno del usuario
                {
                    // turno
                    c = b.Robar();
                    Console.WriteLine("Acabas de robar la siguiente carta: " + c.NombreCarta);
                    puntosusuario = puntosusuario + Convert.ToDecimal(c.Valor7ymedia);
                    Console.WriteLine("Tu puntuación actual es: " + puntosusuario);

                    if(puntosusuario > 7.5m) // si se pasa, deja de jugar
                    {
                        usuariofuera = true;
                        Console.WriteLine("Te has pasado.");
                    }
                    else
                    {
                        Console.WriteLine("¿Quieres plantarte? (s/n)"); // si se planta, deja de jugar

                        if (Console.ReadLine() == "s")
                        {
                            usuariofuera = true;
                        }
                    }                    

                    Console.WriteLine();

                    if (!pcfuera) // pasa el turno al otro jugador (si este sigue jugando)
                    {
                        turno = 2;
                    }
                }

                if(turno == 2) // turno del ordenador
                {
                    c = b.Robar(); // turno
                    Console.WriteLine("Tu oponente acaba de robar la siguiente carta: " + c.NombreCarta);
                    puntospc = puntospc + Convert.ToDecimal(c.Valor7ymedia);
                    Console.WriteLine("La puntuación actual de tu rival es: " + puntospc);

                    if(puntospc > 7.5m) // si se pasa, deja de jugar
                    {
                        pcfuera = true;
                        Console.WriteLine("El ordenador se ha pasado.");
                    }
                    
                    if((puntospc >= 5m) && (puntospc <= 7.5m)) // si llega a 5, se planta y deja de jugar
                    {
                        pcfuera = true;
                        Console.WriteLine("El ordenador se planta.");
                    }

                    if (!usuariofuera)
                    {
                        turno = 1;
                    }

                    Console.WriteLine();
                }

                if(usuariofuera && pcfuera)
                {
                    jugar = "n";
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("¡La partida ha acabado!");
            Console.WriteLine();

            if( (puntosusuario <= 7.5m && puntospc > 7.5m) || (puntosusuario <= 7.5m && puntosusuario > puntospc))
            {
                Console.WriteLine("¡Has ganado!");
            }
            else
            {
                if( puntosusuario <= 7.5m && puntosusuario == puntospc)
                {
                    Console.WriteLine("¡Habéis empatado!");
                }
                else
                {
                    Console.WriteLine("¡Has perdido!");
                }
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
