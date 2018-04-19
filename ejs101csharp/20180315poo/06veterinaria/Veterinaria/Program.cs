using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ClinicaVeterinaria cv = new ClinicaVeterinaria(); // inicializa la clínica: crea una nueva lista de animales
            int opcion, salir;
            salir = -1;

            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("0.- Salir del programa");
            Console.WriteLine("1.- Añadir un animal nuevo");
            Console.WriteLine("2.- Modificar los comentarios de un animal");
            Console.WriteLine("3.- Mostrar por pantalla los datos de los animales");
            Console.WriteLine();
            Console.WriteLine();

            opcion = int.Parse(Console.ReadLine());

            while(salir != 0)
            {
                switch (opcion)
                {
                    case 1:                        
                        Animal a = LeeAnimal(); // recoge los datos introducidos por teclado
                        cv.InsertaAnimal(a); // guarda el animal introducido en la base de datos (lista de animales)
                        break;
                    case 2:
                        string nombre, comentario;
                        Console.WriteLine("Dime el nombre del animal.");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Escribe el nuevo comentario sobre este animal. (Se borrará el comentario anterior.)");
                        comentario = Console.ReadLine();
                        cv.ModificaComentarioAnimal(nombre, comentario); // agrego el nuevo comentario a la ficha del animal
                        break;
                    case 3:
                        Console.WriteLine(cv.ToString()); // imprime por pantalla toda la lista de animales
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Elige una nueva opción del menú, por favor.");

                opcion = int.Parse(Console.ReadLine());
            }            
            Console.ReadKey();
        }

        
        /// <summary>
        /// Lee los datos introducidos por el usuario sobre un nuevo animal.
        /// </summary>
        /// <returns>Objeto de la clase Animal con todos sus datos.</returns>
        private static Animal LeeAnimal()
        {
            Animal nuevoanimal = null;
            string nombre;
            DateTime fecha;
            double peso;
            Console.WriteLine("Te voy a pedir que introduzcas una serie de datos. Tras cada uno de ellos deberás pulsar el Intro.");
            Console.WriteLine("Dime el nombre, fecha de nacimiento (dd/mm/aaaa) y peso del animal.");
            nombre = Console.ReadLine();
            fecha = DateTime.Parse(Console.ReadLine());
            peso = double.Parse(Console.ReadLine());

            char animal;
            Console.WriteLine("¿Qué tipo de animal quieres añadir? (p = perro, g = gato, j = pájaro, r = reptil)");
            animal = char.Parse(Console.ReadLine());            

            switch (animal)
            {
                case 'p':
                    {
                        string chip;
                        RazaPerro raza;
                        int numraza;
                        Console.WriteLine("Escribe la raza del perro mediante su código numérico (1: pastor alemán, 2: husky, 3: fox terrier, 4: dálmata, 5: san bernardo).");
                        Console.WriteLine("Dime qué microchip lleva el perro.");
                        numraza = int.Parse(Console.ReadLine());
                        raza = (RazaPerro)numraza; // introduce el código escrito por el usuario en el enumerado para encontrar la raza correspondiente                    
                        chip = Console.ReadLine();
                        Perro p = new Perro(nombre, fecha, peso, raza, chip);
                        nuevoanimal = p;
                    }
                    break;
                case 'g':
                    {
                        string chip;
                        RazaGato raza;
                        int numraza;
                        Console.WriteLine("Escribe la raza del gato mediante su código numérico (1: común, 2: siamés, 3: persa, 4: angora, 5: scottish fold).");
                        Console.WriteLine("Dime qué microchip lleva el gato.");
                        numraza = int.Parse(Console.ReadLine());
                        raza = (RazaGato)numraza;                  
                        chip = Console.ReadLine();
                        Gato g = new Gato(nombre, fecha, peso, raza, chip);
                        nuevoanimal = g;
                    }
                    break;
                case 'j':
                    {
                        EspeciePajaro especie;
                        bool cantor;
                        int numsp;
                        Console.WriteLine("¿Cuál es la especie del pájaro? (0: canario, 1: periquito, 2: agapornis)");
                        Console.WriteLine("¿Canta mucho el pájaro? (true: sí, false: no)");
                        numsp = int.Parse(Console.ReadLine());
                        especie = (EspeciePajaro)numsp;
                        cantor = bool.Parse(Console.ReadLine());
                        Pajaro j = new Pajaro(nombre, fecha, peso, especie, cantor);
                        nuevoanimal = j;
                    }                        
                    break;
                case 'r':
                    {
                        EspecieReptil especie;
                        bool venenoso;
                        int numsp;
                        Console.WriteLine("¿Cuál es la especie del reptil? (0: tortuga, 1: iguana, 2: dragón de Komodo)");
                        Console.WriteLine("¿Es venenoso el reptil? (true: sí, false: no)");
                        numsp = int.Parse(Console.ReadLine());
                        especie = (EspecieReptil)numsp;
                        venenoso = bool.Parse(Console.ReadLine());
                        Reptil r = new Reptil(nombre, fecha, peso, especie, venenoso);
                        nuevoanimal = r;
                    }
                    break;
                default:
                    break;
            }

            return nuevoanimal;
        }
        

        //
    }
}
