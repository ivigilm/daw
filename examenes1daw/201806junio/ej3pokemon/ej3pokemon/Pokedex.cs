using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ej3pokemon
{
    class Pokedex
    {
        // Atributos

        List<Pokemon> lista_pokemons;

        // Constructores

        /// <summary>
        /// Inicializa la lista de pokemons.
        /// </summary>
        public Pokedex()
        {
            lista_pokemons = new List<Pokemon>();
        }

        /// <summary>
        /// Carga la lista de pokemons con los valores guardados en un fichero.
        /// </summary>
        /// <param name="fichero">Fichero del que se sacan los valores.</param>
        public Pokedex(string fichero)
        {
            LeeCSV(fichero);
        }
        
        // Métodos

        /// <summary>
        /// Carga la lista de pokemons con los valores guardados en un fichero.
        /// </summary>
        /// <param name="fichero">Fichero del que se sacan los valores.</param>
        public void LeeCSV(string fichero)
        {
            string[] valores;
            lista_pokemons = new List<Pokemon>();
            StreamReader sr = new StreamReader(fichero, Encoding.Default);

            // lista_pokemons = new List<Pokemon>();

            while (!sr.EndOfStream) // leo cada línea
            {
                // Guardo los valores (como cadenas) en un array
                valores = sr.ReadLine().Split(',');

                // Creo el pokemon con estos valores (pasados a int/bool/etc)
                Pokemon p = new Pokemon(Convert.ToInt32(valores[0]), valores[1], valores[2], Convert.ToInt32(valores[3]), Convert.ToInt32(valores[4]), Convert.ToInt32(valores[5]), Convert.ToInt32(valores[6]), Convert.ToInt32(valores[7]), Convert.ToInt32(valores[8]), valores[9], Convert.ToBoolean(valores[10]));

                // Agrego el nuevo pokemon a la lista
                lista_pokemons.Add(p);
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda la lista de pokemons en un fichero.
        /// </summary>
        /// <param name="fichero">Fichero en el que se guardará la lista.</param>
        public void GuardaCSV(string fichero)
        {
            int i;
            StreamWriter sw = new StreamWriter(fichero, false, Encoding.Default);

            for(i = 0; i < lista_pokemons.Count; i++)
            {
                sw.Write(lista_pokemons[i].Id);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Nombre);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Tipo);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Ataque);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Defensa);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Vida);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Ataqueespecial);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Defensaespecial);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Velocidad);
                sw.Write(",");
                sw.Write(lista_pokemons[i].Habilidad);
                sw.Write(",");
                sw.WriteLine(lista_pokemons[i].Capturado);
            }

            sw.Close();
        }

        /// <summary>
        /// Marca un pokemon como capturado en la lista.
        /// </summary>
        /// <param name="nombre">Atributo "nombre" del pokemon en cuestión.</param>
        public void CapturaPokemon(string nombre)
        {
            int i;

            for(i = 0; i < lista_pokemons.Count; i++)
            {
                if(lista_pokemons[i].Nombre == nombre)
                {
                    lista_pokemons[i].Capturado = true;
                }
            }
        }

        /// <summary>
        /// Calcula el porcentaje de pokemons capturados que hay en la lista.
        /// </summary>
        /// <returns>Porcentaje de pokemons capturados de la lista.</returns>
        public double PorcentajeCapturas()
        {
            int i, contador;
            double porcentaje;
            contador = 0;

            for(i = 0; i < lista_pokemons.Count; i++)
            {
                if(lista_pokemons[i].Capturado)
                {
                    contador = contador + 1;
                }
            }

            porcentaje = contador * 100 / lista_pokemons.Count;

            return porcentaje;
        }

        /// <summary>
        /// Halla el pokemon de id indicado.
        /// </summary>
        /// <param name="id">id del pokemon que se busca</param>
        /// <returns>El pokemon.</returns>
        public Pokemon BuscaPokemon(int id)
        {
            int i;
            Pokemon p = null;

            for(i = 0; i < lista_pokemons.Count; i++)
            {
                if(lista_pokemons[i].Id == id)
                {
                    p = lista_pokemons[i];
                }
            }            

            return p;
        }

        /// <summary>
        /// Halla el pokemon de nombre indicado.
        /// </summary>
        /// <param name="id">Nombre del pokemon que se busca</param>
        /// <returns>El pokemon.</returns>
        public Pokemon BuscaPokemon(string nombre)
        {
            int i;
            Pokemon p = null;

            for (i = 0; i < lista_pokemons.Count; i++)
            {
                if (lista_pokemons[i].Nombre == nombre)
                {
                    p = lista_pokemons[i];
                }
            }

            return p;
        }

        
    }
}
