using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trivial
{
    enum Categoria
    {
        Geografia, ArteYLiteratura, Historia, Entretenimiento, CienciasYNaturaleza, DeportesYPasatiempos // Arte_y_Literatura
    }

    /// <summary>
    /// Representa una tarjeta con 6 preguntas y 6 respuestas (una de cada categoría).
    /// </summary>
    class TarjetaPreguntas
    {
        // Atributos

        private string[] preguntas;
        private string[] respuestas;

        // Constructores

        public TarjetaPreguntas()
        {
            Console.WriteLine("¡Vamos a crear una nueva tarjeta!");

            // string[] categorias = { "Geografía", "Arte y Literatura", "Historia", "Entretenimiento", "Ciencias y Naturaleza", "Deportes y Pasatiempos"};
            // para que quede más bonito
            // aunque una opción más profesional es esta:
            // string cat = ((Categoria)i.ToString()).Replace('_', ' ');
            // (saco el nombre del enumerado y cambio los guiones por espacios)

            // Guardo las preguntas y respuestas en arrays
            this.preguntas = new string[6];
            this.respuestas = new string[6];
            int i;
            string fichero;

            for(i = 0; i < 6; i++)
            {
                Console.WriteLine("¿Cuál es la pregunta de la categoría " + (Categoria)i + "?" ); // (Categoria)i.ToString().Replace('_', ' ')
                preguntas[i] = Console.ReadLine();
                Console.WriteLine("¿Cuál es la respuesta de la categoría " + (Categoria)i + "?");
                respuestas[i] = Console.ReadLine();
            }            

            // Las guardo en el fichero

            Console.WriteLine("¿Cuál es el nombre del fichero en el que quieres guardar la tarjeta?");
            fichero = Console.ReadLine();

            GuardaTarjeta(fichero);
        }

        public TarjetaPreguntas(string fichero)
        {
            this.preguntas = new string[6];
            this.respuestas = new string[6];
            LeeTarjeta(fichero);
        }

        // Métodos

        public void GuardaTarjeta(string fichero)
        {
            int i;
            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for(i = 0; i < 6; i++)
            {
                bw.Write(this.preguntas[i]);
                bw.Write(this.respuestas[i]);
            }

            bw.Close();
            fs.Close();
        }

        public void LeeTarjeta(string fichero)
        {
            int i;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            for(i = 0; i < 6; i++)
            {
                this.preguntas[i] = br.ReadString();
                this.respuestas[i] = br.ReadString();
            }

            br.Close();
            fs.Close();
        }

        public string LeePregunta(Categoria categoria)
        {
            string pregunta = "";
            int i;

            for(i = 0; i < 6; i++)
            {
                if( (Categoria)i == categoria)
                {
                    pregunta = this.preguntas[i];
                }
            }

            return pregunta;
        }
        
        public string LeeRespuesta(Categoria categoria)
        {
            string respuesta = "";
            int i;

            for(i = 0; i < 6; i++)
            {
                if((Categoria)i == categoria)
                {
                    respuesta = this.respuestas[i];
                }
            }
            return respuesta;
        }
    }
}
