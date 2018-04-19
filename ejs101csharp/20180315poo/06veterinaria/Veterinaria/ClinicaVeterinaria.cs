using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class ClinicaVeterinaria
    {
        // Atributos

        private List<Animal> listaAnimales; // donde meteremos todos los animales

        // Constructor

        /// <summary>
        /// Inicializa la lista de animales.
        /// </summary>
        public ClinicaVeterinaria()
        {
            listaAnimales = new List<Animal>();
        }

        // Métodos

        /// <summary>
        /// Inserta un animal en la lista de animales.
        /// </summary>
        /// <param name="animal">Animal que se va a insertar.</param>
        public void InsertaAnimal(Animal animal)
        {
            listaAnimales.Add(animal);
        }

        /// <summary>
        /// Dado el nombre del animal, devuelve sus datos.
        /// </summary>
        /// <param name="nombre">Nombre del animal buscado.</param>
        /// <returns>Objeto Animal cuyo nombre coincide con el pedido.</returns>
        public Animal BuscaAnimal(string nombre)
        {
            int i;
            Animal a = null;

            for(i = 0; i < listaAnimales.Count; i++)
            {
                if(listaAnimales[i].Nombre == nombre) // .Nombre porque solo nos devuelve el nombre a través de la propiedad (pública)
                {
                    a = listaAnimales[i];
                }
            }
            
                return a;
            if(a == null)
            {
                throw new Exception("No existe");
            }
        }

        /// <summary>
        /// Modifica el comentario en la ficha del animal.
        /// </summary>
        /// <param name="nombre">Nombre del animal cuya ficha queremos modificar.</param>
        /// <param name="comentario">Nuevo comentario que se guardará en la ficha del animal.</param>
        public void ModificaComentarioAnimal(string nombre, string comentario)
        {
            int i;

            for(i = 0; i < listaAnimales.Count; i++)
            {
                if(listaAnimales[i].Nombre == nombre)
                {
                    listaAnimales[i].Comentarios = comentario; // .Comentarios -> propiedad q devuelve los comentarios
                }
            }
        }

        /// <summary>
        /// Cadena con todos los datos de los animales de la lista.
        /// </summary>
        /// <returns>Cadena formateada para su impresión (un atributo por línea).</returns>
        public override string ToString()
        {
            string listafichas;
            int i;
            listafichas = "";

            for(i = 0; i < listaAnimales.Count; i++)
            {
                listafichas = listafichas + listaAnimales[i].ToString() + "\n\n" + "----------------" + "\n\n"; // El .ToString() me devuelve automáticamente la cadena con los datos el animal q sea.
            }

            return listafichas;
        }
        
    }
}
