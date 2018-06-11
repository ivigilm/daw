using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivial
{
    class Trivial
    {   
        // Atributo

        private List<TarjetaPreguntas> mazo;
        // private Random r = new Random(); el random lo hay que crear como un atributo estático para que todas las variables utilicen el mismo random

        // otra cosa

        public int CuantosFicherosPro(string extension)
        {
            int numeroficheros, i;
            string[] listaficheros;
            numeroficheros = 0;

            listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

            for (i = 0; i < listaficheros.Length; i++)
            {
                if (Path.GetExtension(listaficheros[i]) == extension)
                {
                    numeroficheros = numeroficheros + 1;
                }
            }

            return numeroficheros;
        }

        // Constructor

        public Trivial()
        {
            int i;
            string[] listaficheros;
            listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory()); // Directory.GetFiles(".", "*.trivial")
            TarjetaPreguntas nuevatarjeta;
            mazo = new List<TarjetaPreguntas>();

            if(CuantosFicherosPro(".trivial") != 0)
            {
                for (i = 0; i < listaficheros.Length; i++)
                {
                    if (Path.GetExtension(listaficheros[i]) == ".trivial")
                    {
                        nuevatarjeta = new TarjetaPreguntas(listaficheros[i]);
                        mazo.Add(nuevatarjeta);
                    }
                }
            }
            else
            {
                throw new Exception("No hay ficheros .trivial en el directorio indicado.");
            }
        }

        // Métodos

        public void DesordenaTarjetas()
        {
            List<TarjetaPreguntas> auxiliar = new List<TarjetaPreguntas>();
            TarjetaPreguntas extraida;
            int posicionextraida;
            Random r = new Random();

            while(mazo.Count > 0)
            {
                posicionextraida = r.Next(0, mazo.Count);
                extraida = mazo[posicionextraida];
                auxiliar.Add(extraida);
                mazo.RemoveAt(posicionextraida);
            }

            mazo.AddRange(auxiliar);
        }

        public TarjetaPreguntas RobaTarjeta()
        {
            TarjetaPreguntas auxiliar;
            auxiliar = mazo[0]; // tarjeta que robamos EL ÍNDICE FUERA DEL ITNERVALO
            mazo.RemoveAt(0); // la quito del principio
            mazo.Add(auxiliar); // la vuelve a meter al final del mazo

            return auxiliar;
        }
    }
}
