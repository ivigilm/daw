using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartaybaraja
{
    class Baraja
    {
        // Atributos

        private List<Carta> lista_cartas; // creamos un atributo para guardar una lista de cartas

        // Constructores

        /// <summary>
        /// Crea una baraja vacía.
        /// </summary>
        public Baraja() // creo un nuevo objeto de la clase "Baraja" 
        {   
            this.lista_cartas = new List<Carta>(); // inicializamos el atributo lista_cartas para poder utilizarlo más adelante
        }

        /// <summary>
        /// Crea una baraja del tipo indicado (de 40 u 80 cartas).
        /// </summary>
        /// <param name="tipobaraja"></param>
        public Baraja(int tipobaraja) : this() // :this() hace q se ejecute en primer lugar el constructor Baraja()
        {
            // creo un nuevo objeto de la clase "Baraja" mediante : this()

            int i, j;
            Carta nuevacarta; // creo un nuevo objeto de la clase "Carta"

            if (tipobaraja == 1) // 40 cartas
            {
                for (i = 1; i <= 40; i++)
                {
                    nuevacarta = new Carta(i); // inicializo (o reinicializo) mi objeto (carta)
                                                // y guardo en él los valores dados por el constructor Carta(int id)
                    lista_cartas.Add(nuevacarta); // agrego esta carta al objeto (baraja) q estoy rellenando
                }
            }
            else
            {
                if(tipobaraja == 2) // 80 cartas
                {
                    for (j = 1; j <=2; j++) // introduzco en mi objeto de clase Baraja 2 barajas españolas seguidas
                    {
                        for (i = 1; i <= 40; i++) // cada vuelta de bucle agrega una baraja española de 40 cartas
                        {
                            nuevacarta = new Carta(i);
                            lista_cartas.Add(nuevacarta);
                        }
                    }
                }
                else
                {
                    throw new Exception("Valor inválido.");
                }
            }
        }

        /// <summary>
        /// Crea una baraja de 40 u 80 naipes y la baraja a petición.
        /// </summary>
        /// <param name="tipobaraja">Valor que representa el tipo de baraja: 1 para 40 naipes, 2 para 80. </param>
        /// <param name="barajar">"true" si se quiere barajar el mazo, "false" si no</param>
        public Baraja(int tipobaraja, bool barajar) : this(tipobaraja)
        {
            // En primer lugar se ejecuta el constructor Baraja(int tipobaraja) con el parámetro
            // que hayamos introducido al llamar al constructor actual.
                        
            if(barajar == true)
            {
                Barajar();
            }
        }

        // Métodos

        /// <summary>
        /// Baraja la baraja.
        /// </summary>
        public void Barajar()
        {
            List<Carta> auxiliar = new List<Carta>();
            Carta extraida;
            int posicionextraida;
            Random r = new Random();

            while(lista_cartas.Count > 0) // mientras queden cartas en mi baraja inicial
            {
                posicionextraida = r.Next(0, lista_cartas.Count); // guardo el nº aleatorio (q indica una posición de la baraja)

                extraida = lista_cartas[posicionextraida]; // guardo la carta elegida (en una variable Carta temporal)

                auxiliar.Add(extraida); // añado la carta a la lista nueva (donde iré guardando de forma desordenada las cartas de mi baraja)

                lista_cartas.RemoveAt(posicionextraida); // retiro la carta de la baraja original
            }

            // Una vez está vacía la primera baraja y llena la segunda, copio esta a la original.

            lista_cartas.AddRange(auxiliar); // ya tengo mi baraja original barajada            
        }

        /// <summary>
        /// Corta la baraja y pasa las cartas quitadas del principio al final.
        /// </summary>
        /// <param name="posicion">Posición por la que se corta.</param>
        public void Cortar(int posicion)
        {
            int i;
            List<Carta> auxiliar = new List<Carta>();

            for(i = posicion; i < lista_cartas.Count; i++) // copio las cartas q se quedan en el mazo (la mitad de abajo)
            {                                              // al principio de la lista auxiliar
                auxiliar.Add(lista_cartas[i]); // copio carta a carta
            }
            
            for(i = 0; i < posicion; i++) // copio las cartas cortadas (mitad superior) al final de la lista auxiliar
            {
                auxiliar.Add(lista_cartas[i]);
            }

            lista_cartas.Clear(); // vacío la lista original

            lista_cartas.AddRange(auxiliar); // copio la baraja con su nuevo orden a mi lista            
        }

        /// <summary>
        /// Roba una carta de la baraja.
        /// </summary>
        public Carta Robar()
        {            
            Carta auxiliar;

            if (lista_cartas.Count != 0) // si la baraja contiene alguna carta
            {
                auxiliar = lista_cartas[0];

                lista_cartas.RemoveAt(0);
            }
            else // si la baraja está vacía
            {
                throw new Exception("No quedan cartas en el mazo.");
            }            

            return auxiliar;            
        }

        /// <summary>
        /// Inserta al final de la baraja la carta cuyo id se indica.
        /// </summary>
        /// <param name="id_carta">Valor que representa una carta de la baraja española (del 1 al 40).</param>
        public void InsertaCartaFinal(int id_carta)
        {
            Carta nueva; // creo una nueva carta auxiliar
            nueva = new Carta(id_carta); // guardo en la variable "nueva" (de tipo Carta) los datos de la carta de id dado

            lista_cartas.Add(nueva); // meto la carta indicada al final mi baraja
        }

        /// <summary>
        /// Inserta al principio de la baraja la carta cuyo id se indica.
        /// </summary>
        /// <param name="id_carta">Valor que representa una carta de la baraja española (del 1 al 40).</param>
        public void InsertaCartaPrincipio(int id_carta)
        {
            Carta nueva; // creo carta auxiliar
            nueva = new Carta(id_carta); // guardo los datos de la carta de id dado en mi auxiliar

            lista_cartas.Insert(0, nueva); // pongo la carta indicada al principio de mi baraja/mazo
        }

        /// <summary>
        /// Introduce la carta dada al principio del mazo de naipes.
        /// </summary>
        /// <param name="c">Variable de la clase Carta.</param>
        public void InsertaCartaFinal(Carta c)
        {
            lista_cartas.Add(c);
        }

        /// <summary>
        /// Introduce la carta dada al final del mazo de naipes.
        /// </summary>
        /// <param name="c">Variable de la clase Carta.</param>
        public void InsertaCartaPrincipio(Carta c)
        {
            lista_cartas.Insert(0, c);
        }

        // Propiedades

        /// <summary>
        /// Devuelve el número de cartas que hay en la baraja.
        /// </summary>
        public int NumeroCartas
        {
            get
            {
                return this.lista_cartas.Count;
            }
        }

        /// <summary>
        /// Devuelve "true" si la baraja está vacía y "false" si no.
        /// </summary>
        public bool Vacia
        {
            get
            {
                if(NumeroCartas == 0) // baraja vacía
                {
                    return true;
                }
                else // baraja con alguna carta
                {
                    return false;
                }
            }
        }
    }
}
