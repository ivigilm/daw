using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejscadenas
{
    class Program
    {
        /// <summary>
        /// Halla el número de espacios que contiene una cadena.
        /// </summary>
        /// <param name="a">Cadena introducida por parámetro.</param>
        /// <returns>Valor entero que representa el número de espacios que hay en la cadena.</returns>
        static int NumeroEspacios(string a) // Ejercicio 1
        {
            int i, espacios;

            espacios = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    espacios = espacios + 1;
                }
            }

            return espacios;
        }

        /// <summary>
        /// Halla el número de vocales que contiene una cadena.
        /// </summary>
        /// <param name="a">Cadena introducida por parámetro.</param>
        /// <returns>Valor entero que representa el número de vocales que hay en la cadena.</returns>
        static int NumeroVocales(string a) // Ejercicio 2
        {
            int i, vocales;

            vocales = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    vocales = vocales + 1;
                }
            }

            return vocales;

        }

        /// <summary>
        /// Resuelve si una cadena es palíndromo o no.
        /// </summary>
        /// <param name="a">Cadena introducida por parámetro.</param>
        /// <returns>Valor booleano que nos dice si la cadena es palíndromo o no.</returns>
        static bool EsPalindromo(string a) // Ejercicio 3
        {
            bool palindromo = true;
            int i, j;

            j = a.Length - 1;

            for(i = 0; i < a.Length; i++)
            {
                if(a[i] != a[j])
                {
                    palindromo = false;
                }

                j--;
            }

            return palindromo;
        }

        /// <summary>
        /// Comprueba si una cadena contiene un caracter.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="a">Caracter introducido por parámetro.</param>
        /// <returns>True si contiene el caracter, false si no.</returns>
        static bool Contiene(string cadena, char a) // Ejercicio 4
        {
            int i;

            bool locontiene;

            locontiene = false;

            for (i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == a)
                {
                    locontiene = true;
                }
            }

            return locontiene;
        }

        /// <summary>
        /// Crea una cadena formada por un carácter dado repetido el número de veces deseado.
        /// </summary>
        /// <param name="caracter">Carácter introducido por parámetro.</param>
        /// <param name="repeticiones">Número de repeticiones deseado introducido por parámetro como un entero.</param>
        /// <returns>Nueva cadena que representa el caracter tantas veces como repeticiones se le hayan pedido.</returns>
        static string RepiteCaracter(char caracter, int repeticiones) // Ejercicio 5
        {
            string cadena = "";

            int i;

            for (i = 0; i < repeticiones; i++)
            {
                cadena = cadena + caracter;
            }

            return cadena;
        }

        /// <summary>
        /// Crea una cadena idéntica a la que le llega pero quitando todos los espacios.
        /// </summary>
        /// <param name="cadena">Cadena inicial introducida por parámetro.</param>
        /// <returns>Cadena igual a la recibida pero sin espacios.</returns>
        static string QuitaEspacios(string cadena) // Ejercicio 6
        {
            cadena = cadena.Trim(); // le quito los espacios anteriores y posteriores

            string[] array; // array de cadenas vacío

            array = cadena.Split(' '); // parto por los espacios

            cadena = string.Join("", array);

            return cadena;

        }

        /// <summary>
        /// Crea una cadena idéntica a la que le llega pero quitándolo los espacios anteriores y posteriores que pudiera tener.
        /// </summary>
        /// <param name="cadena">Cadena inicial introducida por parámetro.</param>
        /// <returns>Cadena igual a la recibida pero sin espacios delante ni detrás de las letras o símbolos que contenga.</returns>
        static string QuitaEspaciosTrim(string cadena) // Ejercicio 7
        {
            string resultado;

            int i, posultimaletra;

                        
            for (i = 0; i < cadena.Length; i++) // Borro los espacios iniciales
            {
                if(cadena[i] == ' ') // Desde el principio, si hay un espacio, lo borro.
                {
                    cadena = cadena.Remove(i, 1);
                    i = i - 1;
                }
                else // cuando me encuentro con el principio del texto, salgo del for
                {
                    i = cadena.Length;
                }
            }
            /* ESTO ES MÁS CORRECTO 
            while(cadena[0] == ' ')
            {
                cadena = cadena.Remove(0, 1);
            }
            */
            // BORRAR LOS ESPACIOS DEL FINAL

            posultimaletra = 0;

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                if(cadena[i] != ' ') // cuando deje de haber espacios seguidos desde el final habré llegado a la última letra o carácter escrito
                {
                    posultimaletra = i;
                    i = -1;
                }
            }

            //i = cadena.Length - 1;
            //while(i >= 0 && i == ' ')
            //{
            //    i--;
            //}

            resultado = cadena.Substring(0, posultimaletra + 1);            
                        
            return resultado;
        }

        /// <summary>
        /// Sustituye un caracter de una cadena por otro (cada vez que aparece).
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro</param>
        /// <param name="caracterinicial">Carac</param>
        /// <param name="caracterfinal"></param>
        /// <returns></returns>
        static string SustituyeCaracter(string cadena, char caracterinicial, char caracterfinal) // Ejercicio 8
        {
            string resultado;
            string cadena2;

            int indice;

            while (cadena.IndexOf(caracterinicial) != -1) // si la cadena contiene el caracter a sustituir
            {                
                    indice = cadena.IndexOf(caracterinicial);
                    cadena2 = cadena.Substring(0, indice);
                    cadena2 = cadena2 + caracterfinal;
                    cadena2 = cadena2 + cadena.Substring(indice + 1, cadena.Length - indice);
                cadena = cadena2;

                // Método 1: cadena = cadena.Substring(0, indice) + caracterfinal + cadena.Substring(indice + 1);
                // Método 2: cadena = cadena.Remove(indice, 1).Insert(indice, caracterfinal.ToString());
            }

            resultado = cadena;

            return resultado;
        }

        /// <summary>
        /// Cuenta las palabras que tiene una cadena.
        /// </summary>
        /// <param name="frase">Cadena introducida por parámetro.</param>
        /// <returns>Número de palabras.</returns>
        static int CuentaPalabras(string frase) // Ejercicio 9
        {
            int i, palabras;
            palabras = 0;

            string[] array; // creo un array de cadenas vacío

            array = frase.Split(' '); // lo relleno con las palabras de mi frase

            for (i = 0; i < array.Length; i++) // recorro el array posición a posición
            {
                if(array[i] != "") // si la posición contiene algo (y no es que haya dos espacios juntos en mi frase)
                {
                    palabras = palabras + 1; // cuento una palabra
                }
            }

            return palabras;

        }

        /// <summary>
        /// Dice si una cadena está formada exclusivamente por números.
        /// </summary>
        /// <param name="cadena">Cadena para analizar, introducida por parámetro.</param>
        /// <returns>true si la cadena es un número (false en caso contrario)</returns>
        static bool EsNumero(string cadena) // Ejercicio 10
        {
            int i;
            bool respuesta;
            respuesta = true;
            string numeros = "0123456789";
            //char.IsDigit()

            for (i = 0; i < cadena.Length; i++)
            {
                if(Contiene(numeros, cadena[i]) == false)
                {
                    respuesta = false;
                }            
            }
            return respuesta;
        }

        /// <summary>
        /// Borra un valor de una posición dada de un array y desplaza los valores posteriores hacia atrás, restando 1 al tamaño del array.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="posicion">Posición del array que se quiere eliminar.</param>
        static void BorraDeArray(ref string[] a, int posicion)
        {
            int i;

            for (i = posicion; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Array.Resize(ref a, a.Length - 1);
        }

        /// <summary>
        /// Elimina todos los espacios de una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Copia de la cadena original pero sin espacios.</returns>
        static string QuitaEspaciosPro(string cadena)
        {
            string resultado;
            int i;
            string[] array; // array de cadenas vacío

            array = cadena.Split(' '); // parto por los espacios

            for (i = 0; i < array.Length; i++)
            {
                if(array[i] == "") // si la posición (lo que había entre dos espacios) está vacía (no contiene nada)
                {
                    BorraDeArray(ref array, i); // elimino esa posición del array
                }
            }

            // Ahora tendré el array relleno solo con las palabras o caracteres que había en mi cadena original.

            resultado = string.Join("", array);

            return resultado;

        }

        /// <summary>
        /// Elimina todas las ocurrencias de un caracter determinado de una cadena dada.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="caracter">Caracter introducido por parámetro.</param>
        /// <returns>Una copia de la cadena original pero sin el caracter indicado.</returns>
        static string QuitaCaracter(string cadena, char caracter) // Ejercicio 11
        {
            int i;

            for (i = 0; i < cadena.Length; i++)
            {
                if(cadena[i] == caracter)
                {
                    cadena = cadena.Remove(i, 1);
                    i = i - 1;
                }
            }

            return cadena;
        }

        /// <summary>
        /// Vuelve mayúscula la primera letra de cada palabra de una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Cadena copia de la original en la que todas las palabras empiezan por mayúscula.</returns>
        static string MayusculasPrimera(string cadena) // Ejercicio 12
        {
            int i;
            string[] array;
            array = cadena.Split(' ');

            for(i = 0; i < array.Length; i++) // pongo mayúscula al principio de cada palabra
            {
                if(array[i] != "") // si la posición contiene algún caracter
                {
                    /*
                    palabra = array[i];
                    palabra = char.ToUpper(palabra[0]) + palabra.Remove(0, 1);
                    palabra = char.ToUpper(palabra[0]) + palabra.Substring(1);
                    palabra = palabra.Substring(0, 1).ToUpper() + palabra.Substring(1);

                    palabra2 = palabra.ToUpper();                    
                    palabra.Replace(palabra[0], palabra2[0]); // hago mayúscula el primer caracter
                    array[i] = palabra; // guardo la nueva palabra en el array
                    */

                    array[i] = char.ToUpper(array[i][0]) + array[i].Substring(1);
                }
            }

            cadena = string.Join(" ", array);
            
            return cadena;
        }
        
        /// <summary>
        /// Quita los acentos de una cadena.
        /// </summary>
        /// <param name="cadena">Cadena original introducida por parámetro.</param>
        /// <returns>Cadena copia de la original pero donde los caracteres acentuados ya no tienen acento.</returns>
        static string QuitaAcentos(string cadena) // Ejercicio 13
        {
            int i;
            //char[] arrayacentos = { 'á', 'é', 'í', 'ó', 'ú'};
            //char[] arraysinacentos = { 'a', 'e', 'i', 'o', 'u' };
            string arrayacentos = "áéíóúÁÉÍÓÚ";
            string arraysinacentos = "aeiouAEIOU";

            for(i = 0; i < 5; i++)
            {
                cadena = cadena.Replace(arrayacentos[i], arraysinacentos[i]);
            }
            
            return cadena;
        }

        /// <summary>
        /// Invierte los caracteres de una cadena (el primero pasará a ser el último, etc.).
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Copia de la cadena original con el contenido invertido.</returns>
        static string InvierteCadena(string cadena) // Ejercicio 14
        {
            string resultado;
            resultado = "";
            int i;

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                resultado = resultado + cadena.Substring(i, 1);
            }
            
            return resultado;
        }

        /// <summary>
        /// Halla el número de repeticiones de un caracter en una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="caracter">Caracter introducido por parámetro.</param>
        /// <returns>Número de repeticiones.</returns>
        static int VecesCaracter(string cadena, char caracter) // Ejercicio 15
        {
            int repeticiones;
            string[] palabrasqueempiezanporcaracter;
            palabrasqueempiezanporcaracter = cadena.Split(caracter); // array separado por donde estaba el carácter

            repeticiones = palabrasqueempiezanporcaracter.Length - 1;

            return repeticiones;
        }

        /// <summary>
        /// Halla el número de veces que aparece una palabra en una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="palabra">Palabra introducida por parámetro.</param>
        /// <returns>Número de repeticiones de la palabra.</returns>
        static int VecesPalabra(string cadena, string palabra) // Ejercicio 16
        {
            int repeticiones, i;
            repeticiones = 0;
            
            for (i = 0; i < cadena.Length - palabra.Length + 1; i++)
            {
               if (palabra == cadena.Substring(i, palabra.Length))
               {
                     repeticiones = repeticiones + 1;
               }
            }      
                        
            return repeticiones;
        }

        /// <summary>
        /// Sustituye cada ocurrencia de una palabra en una cadena por una nueva palabra.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="palabrainicial">Palabra que queremos sustituir introducida por parámetro.</param>
        /// <param name="palabrafinal">Palabra nueva introducida por parámetro.</param>
        /// <returns>Cadena modificada.</returns>
        static string SustituyePalabra(string cadena, string palabrainicial, string palabrafinal) // Ejercicio 17
        {
            int i;            

            for (i = 0; i < cadena.Length - palabrainicial.Length + 1; i++)
            {
                if (palabrainicial == cadena.Substring(i, palabrainicial.Length))
                {
                    cadena = cadena.Remove(i, palabrainicial.Length);
                    cadena = cadena.Insert(i, palabrafinal);
                    i = i - palabrainicial.Length;
                }
            }

            return cadena;
        }

        /// <summary>
        /// Marca la subcadena buscada con un asterisco en la primera letra de esta cada vez que aparece en la cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <param name="subcadena">Subcadena buscada que se quiere marcar.</param>
        /// <returns>Cadena inicial modificada para marcar la subcadena en cada ocurrencia.</returns>
        static string MarcaSubCadena(string cadena, string subcadena) // Ejercicio 18
        {
            int i;

            for (i = 0; i < cadena.Length - subcadena.Length; i++)
            {
                if(subcadena == cadena.Substring(i, subcadena.Length))
                {
                    cadena = cadena.Remove(i, 1);
                    cadena = cadena.Insert(i, "*");
                }
            }

            return cadena;
        }

        /// <summary>
        /// Invierte las palabras de una frase (se le da la vuelta a cada palabra).
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Cadena original con las palabras invertidas.</returns>
        static string InviertePalabras(string cadena) // Ejercicio 19
        {
            int i, j;
            string palabraactual;
            string[] arraydepalabras;
            palabraactual = "";

            arraydepalabras = cadena.Split(' ');

            for (i = 0; i < arraydepalabras.Length; i++)
            {
                for(j = arraydepalabras[i].Length - 1; j >= 0; j--) // recorro cada palabra girándola
                {
                    palabraactual = palabraactual + arraydepalabras[i][j];
                }

                arraydepalabras[i] = palabraactual;
                palabraactual = "";
            }

            cadena = string.Join(" ", arraydepalabras);

            return cadena;
            
        }

        /// <summary>
        /// Elimina los espacios anteriores y posteriores a una cadena y los dobles entre palabras.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Cadena copia de la original sin los espacios sobrantes.</returns>
        static string QuitaEspaciosSobrantes(string cadena) // Ejercicio 20
        {
            cadena = QuitaEspaciosTrim(cadena); // quito los espacios que rodean a mi frase

            int i;

            for (i = 1; i < cadena.Length; i++)
            {
                if(cadena[i] == ' ' && cadena[i-1] == ' ') // si hay dos espacios seguidos, borro el segundo
                {
                    cadena = cadena.Remove(i, 1);

                    i = i - 1;
                }
            }

            return cadena;
        }

        /// <summary>
        /// Escribe una serie de nombres contenidos en una cadena ("apellido1 apellido2 nombre apellido1 apellido2 nombre ...")
        /// en el formato Nombre Apellido1 Apellido2 y ocupando una línea cada persona.
        /// </summary>
        /// <param name="cadena">Cadena introducida contenedora de la lista de nombres.</param>
        static void EscribeNombres(string cadena) // Ejercicio 1 de la relación adicional
        {
            // Entiendo que la cadena está correctamente escrita: no hay espacios delante ni detrás ni más de uno entre palabras.

            // Paso 1: Split para convertir la cadena en array de palabras

            string[] array;

            array = cadena.Split(' ');

            // Paso 2: escribo los nombres directamente desde el array

            int i;

            for (i = 0; i < array.Length - 2; i = i + 3) // recorro el array en grupos de tres (i = apellido1)
            {
                Console.Write(array[i + 2] + " "); // Escribo el nombre.
                Console.Write(array[i] + " "); // Escribo el primer apellido.
                Console.WriteLine(array[i + 1]); // Escribo el segundo apellido y doy salto de línea.
            }
            
        }

        /// <summary>
        /// Escribe un array de tipo entero de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(int[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }

        /// <summary>
        /// Escribe un array de tipo cadena de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(string[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }
        
        /// <summary>
        /// Halla las repeticiones de las cinco primeras letras del abecedario que aparecen en una cadena dada.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Un array de enteros con el número de repeticiones de a, b, c, d y e.</returns>
        static int[] CuentaLetras(string cadena) // Ejercicio 2 de la relación adicional
        {
            int i, j;
            int[] repeticionesletrasabcde = new int[5];

            char[] letrasabcdeABCDE = new char[10] { 'a', 'b', 'c', 'd', 'e', 'A', 'B', 'C', 'D', 'E' };

            for(i = 0; i < cadena.Length; i++) // recorro la cadena caracter a caracter (i = posición del caracter actual)
            {
                for(j = 0; j < 5; j++) // recorro letrasabcdeABCDE comprobando si el caracter actual de la cadena coincide
                {
                    if( (cadena[i] == letrasabcdeABCDE[j]) || (cadena[i] == letrasabcdeABCDE[j+5]))
                    {
                        repeticionesletrasabcde[j] = repeticionesletrasabcde[j] + 1;
                    }
                }
            }

            return repeticionesletrasabcde;
        }

        /// <summary>
        /// Halla las repeticiones de cada letra en una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Array de enteros con el número de repeticiones de las letras A/a a la Z/z (incluída la Ñ/ñ).</returns>
        static int[] CuentaLetrasPro(string cadena) // Ejercicio 2b de la relación adicional
        {            
            // Utilizando las correspondencias ASCII (A = 65, a = 97, N = 78, n = 110, O = 79, o = 111, Z = 90, z = 122)
            // La "n" es la letra número 14 (estará en la posición 13 de mi array), la "ñ" la 15 (posición 14)
            // y la "o" la 16 (posición 15).

            int i, j;
            int[] repeticionesletrasabecedarioespanyol = new int[27];


            for (i = 0; i < cadena.Length; i++) // recorro la cadena, examinando cada caracter
            {
                for(j = 0; j < 14; j++) // recorro mi array solución sumándole las ocurrencias de cada letra, de A a N
                {
                    if( (cadena[i] == 'a' + j) || (cadena[i] == 'A' + j) ) // ¿¿¿Se puede combinar esto mejor???
                    {
                        repeticionesletrasabecedarioespanyol[j] = repeticionesletrasabecedarioespanyol[j] + 1;
                    }
                }

                if( (cadena[i] == 'ñ') || (cadena[i] == 'Ñ')) // Introduzco la Ñ en su posición
                {
                    repeticionesletrasabecedarioespanyol[14] = repeticionesletrasabecedarioespanyol[14] + 1;
                }

                for(j = 15; j < 27; j++) // Recorro las posiciones correspondientes a O-Z en el array solución.
                {
                    if ((cadena[i] == 'a' + j - 1) || (cadena[i] == 'A' + j - 1)) // resto uno para llegar a la letra ASCII
                                                                                  // correspondiente con la posición "j"
                    {
                        repeticionesletrasabecedarioespanyol[j] = repeticionesletrasabecedarioespanyol[j] + 1;
                    }
                }
            }

            return repeticionesletrasabecedarioespanyol;
                        
        }
        
        /// <summary>
        /// Convierte una cadena de texto a letra minúscula (1), mayúscula (2), la primera letra de cada palabra en mayúscula (3) o la primera letra de cada frase en mayúscula. (4)
        /// </summary>
        /// <param name="cadena">Cadena original.</param>
        /// <param name="opcion">Opción que se quiere obtener (1-4).</param>
        /// <returns>Cadena original transformada en el formato de letra elegido.</returns>
        static string MayusculasMinusculas (string cadena, int opcion) // Ejercicio 3 de la relación adicional
        {
            string nuevacadena = "";

            switch (opcion)
            {
                case 1:
                    nuevacadena = cadena.ToLower();
                    break;
                case 2:
                    nuevacadena = cadena.ToUpper();
                    break;
                case 3:
                    nuevacadena = MayusculasPrimera(cadena);
                    break;
                case 4:
                    int i;
                    string[] frases;
                    frases = cadena.Split('.'); // guardo cada frase en una posición del array

                    for(i = 0; i < frases.Length; i++)
                    {
                        if (frases[i] != "")
                        {
                            if(frases[i][0] == ' ') // al principio de cada frase (menos la primera) hay un espacio
                            {
                                frases[i] = char.ToUpper(frases[i][1]) + frases[i].Substring(2);
                            }
                            else // al principio de la frase (en la primera frase) hay una letra
                            {
                                frases[i] = char.ToUpper(frases[i][0]) + frases[i].Substring(1);
                            }
                        }
                    }

                    nuevacadena = string.Join(". ", frases); 
                    
                    break;
                default:
                    throw new Exception("Opción no contemplada.");
            }

            return nuevacadena;
        }
        
        /// <summary>
        /// Le pasamos  una cadena  que contiene  tags (como los de XML) y los elimina, dejando sólo el texto.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Cadena con el texto de la original pero sin los tags.</returns>
        static string EliminaTags (string cadena) // Ejercicio 4 de la relación adicional
        {
            int iniciosubcadena, finsubcadena;
            
            while(cadena.Contains('<')) // mientras haya elementos HTML/XML
            {
                iniciosubcadena = cadena.IndexOf('<'); // hallo las posiciones del primer elemento
                finsubcadena = cadena.IndexOf('>');
                cadena = cadena.Remove(iniciosubcadena, finsubcadena - iniciosubcadena + 1); // borro el elemento                
            }

            return cadena;
        }

        /// <summary>
        /// Halla la posición de un array en la que se aloja el valor mínimo del mismo.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Posición del array que guarda el valor más pequeño.</returns>
        static int PosMinArray(int[] a)
        {
            int posicionminimo, i;

            posicionminimo = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < a[posicionminimo])
                {
                    posicionminimo = i;
                }
            }

            return posicionminimo;
        }

        /// <summary>
        /// Inserta un elemento nuevo al final de un array, agrandando este en una posición.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="elemento">Valor del elemento que se quiere añadir al array.</param>
        static void InsertaAlFinalArray(ref string[] a, string elemento)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = elemento;
        }

        /// <summary>
        /// Compara dos palabras para encontrar la anterior por orden alfabético.
        /// </summary>
        /// <param name="palabra1">Primera palabra introducida por parámetro.</param>
        /// <param name="palabra2">Segunda palabra introducida por parámetro.</param>
        /// <returns>La palabra que va primero por orden alfabético.</returns>
        static string ComparaPalabrasAnglosajonas(string palabra1, string palabra2)
        {
            int i;
            string menor, mayor, anterior;
            anterior = "";

            // menor = palabra más corta
            if(palabra1.Length < palabra2.Length)
            {
                menor = palabra1;
                mayor = palabra2;
            }
            else
            {
                menor = palabra2;
                mayor = palabra1;
            }

            for(i = 0; i < menor.Length; i++) // por cada letra de la palabra más corta
            {
                if(menor[i] < mayor[i]) // si la letra de menor es anterior a la de mayor (C# compara las letras mediante la tabla ASCII)
                {
                    anterior = menor; // la palabra q irá antes es la menor
                    i = menor.Length; // y se corta el bucle
                }
                else
                {
                    if(mayor[i] < menor[i]) // si la letra de mayor es anterior a la de menor
                    {
                        anterior = mayor; // la palabra q irá antes es la mayor
                        i = menor.Length; // y se corta el bucle
                    }
                }

                // si las dos letras coinciden, continúa el bucle
            }

            // Si todas las letras de la palabra más pequeña coinciden con las primeras letras de la otra palabra, la anterior será la menor.

            if(anterior == "")
            {
                anterior = menor;
            }

            return anterior;
        }

        /// <summary>
        /// Compara dos palabras para encontrar la anterior por orden alfabético. Solo funciona con minúsculas no acentuadas.
        /// </summary>
        /// <param name="palabra1">Primera palabra introducida por parámetro.</param>
        /// <param name="palabra2">Segunda palabra introducida por parámetro.</param>
        /// <returns>La palabra que va primero por orden alfabético.</returns>
        static string ComparaPalabras(string palabra1, string palabra2)
        {
            int i, minlength;

            string abecedario, palabratriunfadora, menor;
            palabratriunfadora = "";
            abecedario = "abcdefghijklmnñopqrstuvwxyz"; // contemplo solo las minúsculas normales

            // minlength es la longitud de la palabra más corta
            if ( palabra1.Length >= palabra2.Length)
            {
                minlength = palabra2.Length;
                menor = palabra2;
            }
            else
            {
                minlength = palabra1.Length;
                menor = palabra1;
            }

            for(i = 0; i < minlength; i++) // recorro las palabras letra a letra
            {
                if( abecedario.IndexOf(palabra1[i]) < abecedario.IndexOf(palabra2[i]) )
                {
                    palabratriunfadora = palabra1;
                    i = minlength;
                }
                else
                {
                    if(abecedario.IndexOf(palabra1.ToLower()[i]) > abecedario.IndexOf(palabra2.ToLower()[i]))
                    {
                        palabratriunfadora = palabra2;
                        i = minlength;
                    }
                }
            }

            if(palabratriunfadora == "")
            {
                palabratriunfadora = menor;
            }

            return palabratriunfadora;
        }

        /// <summary>
        /// Halla la posición del array de cadenas donde se encuentra la primera palabra en orden alfabético.
        /// </summary>
        /// <param name="palabras">Array de cadenas que contiene palabras.</param>
        /// <returns>Número de la posición de la primera palabra.</returns>
        static int PosicionPrimeraPalabraAlfabeticamente(string[] palabras)
        {
            int posicion, i;
            posicion = 0;

            for (i = 0; i < palabras.Length; i++) // recorro el array palabra a palabra
            {
                if ( ComparaPalabras(palabras[i], palabras[posicion]) == palabras[i] ) // si la palabra actual es anterior a la que tenía guardada
                {
                    posicion = i; // establezco i como nueva posición 1ª
                }
            }

            return posicion; // devuelvo la posición de la palabra que va en primer lugar alfabéticamente

        }

        /// <summary>
        /// Borra un valor de una posición dada de un array y desplaza los valores posteriores hacia atrás, restando 1 al tamaño del array.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="posicion">Posición del array que se quiere eliminar.</param>
        static void BorraDeArray(ref int[] a, int posicion)
        {
            int i;

            for (i = posicion; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Array.Resize(ref a, a.Length - 1);
        }

        /// <summary>
        /// Ordena por orden alfabético una serie de palabras separadas por comas de una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Cadena similar a la original pero con las palabras de esta en orden alfabético.</returns>
        static string OrdenaPalabrasComas (string cadena) // Ejercicio 5 de la relación adicional
        {
            string[] palabras;
            string[] palabrasordenadas = new string[0];
            int posicionprimera;

            palabras = cadena.Split(','); // convierto la cadena en un array con las palabras de esta

            while(palabras.Length > 0) // mientras el array "palabras" tenga algún elemento
            {
                posicionprimera = PosicionPrimeraPalabraAlfabeticamente(palabras); // posición de la primera palabra en orden alfabético

                InsertaAlFinalArray(ref palabrasordenadas, palabras[posicionprimera]); // agrego la palabra al nuevo array

                BorraDeArray(ref palabras, posicionprimera); // borro el elemento copiado del array "palabras"
            }

            // Ahora "palabrasordenadas" tendrá todas las palabras en orden alfabético

            cadena = string.Join(",", palabrasordenadas);
            
            return cadena;

            // ¿Se podrían ordenar los elementos según el código ASCII de las letras?
        }

        /// <summary>
        /// Sustituye los caracteres acentuados de una cadena por sus códigos HTML.
        /// </summary>
        /// <param name="cadena">Cadena original.</param>
        /// <returns>Cadena con códigos de caracteres especiales intercalados.</returns>
        static string AcentosHTML(string cadena) // Ejercicio 6 relación adicional
        {
            string nuevacadena = "";
            int i;

            for(i = 0; i < cadena.Length; i++) // recorro la cadena caracter a caracter
            {
                switch (cadena[i])
                {
                    case '<':
                        nuevacadena = nuevacadena + "&lt;";
                        break;
                    case '>':
                        nuevacadena = nuevacadena + "&gt;";
                        break;
                    case '&':
                        nuevacadena = nuevacadena + "&amp;";
                        break;
                    case '"':
                        nuevacadena = nuevacadena + "&quot;";
                        break;
                    case 'á':
                        nuevacadena = nuevacadena + "&aacute;";
                        break;
                    case 'Á':
                        nuevacadena = nuevacadena + "&Aacute;";
                        break;
                    case 'é':
                        nuevacadena = nuevacadena + "&aecute;";
                        break;
                    case 'É':
                        nuevacadena = nuevacadena + "&Eacute;";
                        break;
                    case 'í':
                        nuevacadena = nuevacadena + "&iacute;";
                        break;
                    case 'Í':
                        nuevacadena = nuevacadena + "&Iacute;";
                        break;
                    case 'ó':
                        nuevacadena = nuevacadena + "&oacute;";
                        break;
                    case 'Ó':
                        nuevacadena = nuevacadena + "&Oacute;";
                        break;
                    case 'ú':
                        nuevacadena = nuevacadena + "&uacute;";
                        break;
                    case 'Ú':
                        nuevacadena = nuevacadena + "&Uacute;";
                        break;
                    case 'ñ':
                        nuevacadena = nuevacadena + "&ntilde;";
                        break;
                    case 'Ñ':
                        nuevacadena = nuevacadena + "&Ntilde;";
                        break;
                    case 'ü':
                        nuevacadena = nuevacadena + "&uuml;";
                        break;
                    case 'Ü':
                        nuevacadena = nuevacadena + "&Uuml;";
                        break;
                    default:
                        nuevacadena = nuevacadena + cadena[i];
                        break;
                }
            }

            return nuevacadena;
        }

        /// <summary>
        /// Halla las palabras que empiezan y terminan por la misma letra de una cadena.
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Array con las palabras que cumplen el requisito buscado.</returns>
        static string[] PalabrasMismaLetra(string cadena) // Ejercicio 7 relación adicional
        {
            string[] palabrasmismaletra, todaslaspalabras;
            int i;
            palabrasmismaletra = new string[0];

            cadena = cadena.ToLower();

            for (i = 0; i < cadena.Length; i++) // elimino los símbolos de puntuación
            {
                if(cadena[i] == ',' || cadena[i] == '.' || cadena[i] == ';' || cadena[i] == ':')
                {
                    cadena = cadena.Remove(i, 1);
                    i--;
                }
            }

            todaslaspalabras = cadena.Split(' ');

            for(i = 0; i < todaslaspalabras.Length; i++)
            {
                if(todaslaspalabras[i][0] == todaslaspalabras[i][ todaslaspalabras[i].Length - 1 ])
                {
                    InsertaAlFinalArray(ref palabrasmismaletra, todaslaspalabras[i]); // añado la palabra al array resultado
                }
            }

            return palabrasmismaletra;
        }

        /// <summary>
        /// Convierte un número a texto.
        /// </summary>
        /// <param name="numero">Número entero entre 0 y 9.</param>
        /// <returns>Nombre del número en texto.</returns>
        static string NumeroTexto9(int numero)
        {
            string nombrenumero;

            switch (numero)
            {
                case 0:
                    nombrenumero = "cero"; break;
                case 1:
                    nombrenumero = "uno"; break;
                case 2:
                    nombrenumero = "dos"; break;
                case 3:
                    nombrenumero = "tres"; break;
                case 4:
                    nombrenumero = "cuatro"; break;
                case 5:
                    nombrenumero = "cinco"; break;
                case 6:
                    nombrenumero = "seis"; break;
                case 7:
                    nombrenumero = "siete"; break;
                case 8:
                    nombrenumero = "ocho"; break;
                case 9:
                    nombrenumero = "nueve"; break;
                default: throw new Exception("Caso no contemplado");
            }

            return nombrenumero;
        }

        /// <summary>
        /// Convierte un número a texto.
        /// </summary>
        /// <param name="numero">Número entero entre 0 y 99.</param>
        /// <returns>Nombre del número en texto.</returns>
        static string NumeroTexto99(int numero) // Ejercicio 8 adicionales
        {
            int decena;
            string nombrenumero, prefijo;
            prefijo = "";

            switch (numero)
            {
                case 10: nombrenumero = "diez"; break;
                case 11: nombrenumero = "once"; break;
                case 12: nombrenumero = "doce"; break;
                case 13: nombrenumero = "trece"; break;
                case 14: nombrenumero = "catorce"; break;
                case 15: nombrenumero = "quince"; break;
                case 20: nombrenumero = "veinte"; break;
                case 22: nombrenumero = "veintidós"; break;
                case 23: nombrenumero = "veintitrés"; break;
                case 26: nombrenumero = "veintiséis"; break;
                default: nombrenumero = ""; break;
            }

            if(numero < 10) // 0-9
            {
                nombrenumero = NumeroTexto9(numero); // Hallo los nombres de los números 0-9.
            }
            else // Adjudico los prefijos especiales (16-19 & 21-29)
            {
                if(numero >= 16 && numero < 20) // 16-19
                {
                    prefijo = "diec";
                    nombrenumero = prefijo + "i" + NumeroTexto9(numero - 10);
                }
                else
                {
                    if(numero > 20 && numero < 30 && numero != 22 && numero != 23 && numero != 26) // 21-29
                    {
                        prefijo = "veint";
                        nombrenumero = prefijo + "i" + NumeroTexto9(numero - 20);
                    }
                    else // 30-99
                    {
                        if(numero >= 30 && numero <= 99)
                        {
                            decena = numero - (numero % 10); // = 30, 40, 50...

                            switch (decena)
                            {
                                case 30: prefijo = "treinta"; break;
                                case 40: prefijo = "cuarenta"; break;
                                case 50: prefijo = "cincuenta"; break;
                                case 60: prefijo = "sesenta"; break;
                                case 70: prefijo = "setenta"; break;
                                case 80: prefijo = "ochenta"; break;
                                case 90: prefijo = "noventa"; break;
                            }

                            nombrenumero = prefijo + " y " + NumeroTexto9(numero - decena);
                        }
                    }
                }
            }            

            return nombrenumero;
        }

        static void Main(string[] args)
        {
            int opcion;

            {
                Console.WriteLine();

            }


            Console.WriteLine("MENÚ: EJERCICIOS DE CADENAS");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine("1.- Número de espacios");
            Console.WriteLine("2.- Número de vocales");
            Console.WriteLine("3.- Es palíndromo");
            Console.WriteLine("4.- Contiene");
            Console.WriteLine("5.- Repite carácter");
            Console.WriteLine("6.- Quita espacios");
            Console.WriteLine("7.- Quita espacios trim");
            Console.WriteLine("8.- Sustituye carácter");
            Console.WriteLine("9.- Cuenta palabras");
            Console.WriteLine("10.- Es número");
            Console.WriteLine("11.- Quita carácter");
            Console.WriteLine("12.- Mayúsculas primera");
            Console.WriteLine("13.- Quita acentos");
            Console.WriteLine("14.- Invierte Cadena");
            Console.WriteLine("15.- Veces carácter");
            Console.WriteLine("16.- Veces palabra");
            Console.WriteLine("17.- Sustituye palabra");
            Console.WriteLine("18.- Marca subcadena");
            Console.WriteLine("19.- Invierte palabras");
            Console.WriteLine("20.- Quita espacios sobrantes");
            Console.WriteLine();
            Console.WriteLine("EJERCICIOS ADICIONALES");
            Console.WriteLine("======================");
            Console.WriteLine("21.- Escribe nombres");
            Console.WriteLine("22.- Cuenta letras");
            Console.WriteLine("222.- Cuenta letras pro");
            Console.WriteLine("23.- A mayúsculas/minúsculas/primera letra");
            Console.WriteLine("24.- Elimina tags");
            Console.WriteLine("25.- Ordena palabras alfabéticamente");
            Console.WriteLine("26.- Sustituye caracteres especiales por su código HTML");
            Console.WriteLine("27.- Halla las palabras que empiezan y terminan por la misma letra de una cadena");
            Console.WriteLine("28.- Nombre de un número");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            opcion = int.Parse(Console.ReadLine());

            while(opcion != 0)
            {

                switch (opcion)
                {
                    case 1:
                        {
                            string hola = "Hola, Luis, ¿estás ocupado?";

                            int a = NumeroEspacios(hola);

                            Console.WriteLine("El número de espacios de la cadena {" + hola + "} es: " + a);
                        }
                        break;
                    case 2:
                        {
                            string hola = "Hola, Luis, ¿estás ocupado?";

                            int a = NumeroVocales(hola);

                            Console.WriteLine("El número de vocales sin acentuar de la cadena {" + hola + "} es: " + a);
                        }
                        break;
                    case 3:
                        {
                            string palin;

                            palin = "somos";

                            Console.WriteLine(EsPalindromo(palin));
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine(Contiene("hola", 'h'));
                        }
                        break;
                    case 5:
                        {
                            string cadenanueva;
                            char caracter;
                            caracter = 'F';
                            int repeticiones;
                            repeticiones = 6;

                            cadenanueva = RepiteCaracter(caracter, repeticiones);

                            Console.WriteLine("El resultado de escribir " + caracter + " " + repeticiones + " veces es: " + cadenanueva);
                        }
                        break;
                    case 6:
                        {
                            string texto;

                            texto = "     Hola, ¿qué pasa? Aquí estoy haciendo ejercicios       ";

                            Console.WriteLine("Mi cadena inicial es: " + texto);

                            Console.WriteLine("La longitud inicial de mi cadena es de " + texto.Length + " caracteres.");

                            texto = QuitaEspacios(texto);

                            Console.WriteLine("Mi cadena final es: " + texto);

                            Console.WriteLine("La longitud final de mi cadena es de " + texto.Length + " caracteres.");
                        }
                        break;
                    case 7:
                        {
                            string texto = "     Hola, ¿qué pasa? Aquí estoy haciendo ejercicios       ";

                            Console.WriteLine(">" + texto + "<");

                            Console.WriteLine(">" + QuitaEspaciosTrim(texto) + "<");
                        }
                        break;
                    case 8:
                        {
                            string frase;

                            frase = "hola ola caracola";

                            Console.WriteLine("Texto original: " + frase);

                            frase = SustituyeCaracter(frase, 'o', '0');

                            Console.WriteLine("Texto final: " + frase);
                        }
                        break;
                    case 9:
                        {
                            string frase;
                            int numeropalabras;

                            frase = "hola ola caracola";

                            numeropalabras = CuentaPalabras(frase);

                            Console.WriteLine("Mi frase {" + frase + "} tiene " + numeropalabras + " palabras.");
                        }
                        break;
                    case 10:
                        {

                            string micadena = "123495";

                            bool esnumeroono;

                            esnumeroono = EsNumero(micadena);

                            Console.WriteLine("¿Es un número la cadena: " + micadena + "?");
                            Console.WriteLine(esnumeroono);

                        }
                        break;
                    case 11:
                        {
                            char caracter2;
                            caracter2 = 'a';

                            string hola1, hola2;
                            hola1 = "hola hola caracola de la ola marina";

                            Console.WriteLine(hola1);

                            hola2 = QuitaCaracter(hola1, caracter2);

                            Console.WriteLine(hola2);
                        }
                        break;
                    case 12:
                        {
                            string hola;
                            hola = "hola hola caracola de la ola marina";
                            Console.WriteLine(hola);

                            Console.WriteLine(MayusculasPrimera(hola));
                        }
                        break;
                    case 13:
                        {
                            string cadena = "Papá cayó por un túnel y se acabó el títere";
                            Console.WriteLine(cadena);

                            cadena = QuitaAcentos(cadena);
                            Console.WriteLine(cadena);
                        }
                        break;
                    case 14:
                        {
                            string cadena = "abcdef";

                            Console.WriteLine(cadena);

                            cadena = InvierteCadena(cadena);

                            Console.WriteLine(cadena);
                        }
                        break;
                    case 15:
                        {
                            string cadena = "Hola, ola marina, ¿qué tal, ola?";
                            Console.WriteLine(cadena);
                            int numerocaracter = VecesCaracter(cadena, 'a');
                            Console.WriteLine(numerocaracter);
                        }
                        break;
                    case 16:
                        {
                            string cadena1, palabra1;
                            cadena1 = "hola carachola hol a h ola hola adiós";
                            palabra1 = "hola";
                            Console.WriteLine("La palabra " + palabra1 + " se repite " + VecesPalabra(cadena1, palabra1) + " en la frase siguiente: ");
                            Console.WriteLine(cadena1);
                        }
                        break;
                    case 17:
                        {
                            string cadena, palabraparaquitar, palabraparaagregar;
                            cadena = "Volverán las oscuras golondrinas";
                            palabraparaquitar = "oscuras";
                            palabraparaagregar = "veladas";

                            Console.WriteLine(cadena);
                            Console.WriteLine(SustituyePalabra(cadena, palabraparaquitar, palabraparaagregar));
                        }
                        break;
                    case 18:
                        {
                            string cadena, subcadena;
                            cadena = "mi perro y mi gato se llevan mis cosas al mirador";
                            subcadena = "mi";

                            Console.WriteLine(cadena);
                            Console.WriteLine(MarcaSubCadena(cadena, subcadena));

                            Console.WriteLine();
                        }
                        break;
                    case 19:
                        {
                            string cadena;

                            cadena = "El extintor está en la pared.";
                            Console.WriteLine(cadena);
                            Console.WriteLine(InviertePalabras(cadena));
                        }
                        break;
                    case 20:
                        {
                            string cadena;
                            cadena = "     hola  2   tres    4     ";
                            Console.WriteLine(cadena);
                            Console.WriteLine(QuitaEspaciosSobrantes(cadena));
                        }
                        break;
                    case 21:
                        {
                            string cadena;
                            cadena = "López Díaz Natalia Álvarez Pazos Carol Sevilla García David";

                            EscribeNombres(cadena);
                        }
                        break;
                    case 22:
                        {
                            string cadena;
                            cadena = "Abrí la Boca y desDe el balcón grité.";
                            Console.WriteLine(cadena);

                            EscribeArray(CuentaLetras(cadena));
                        }
                        break;
                    case 222:
                        {
                            string cadena = "abcdefghijklmnñopqrstuvwxyz ABCDEFGHIJKLMNÑOPQRSTUVWXYZ abc Z Ñ ñ";

                            Console.WriteLine(cadena);

                            EscribeArray(CuentaLetrasPro(cadena));
                        }
                        break;
                    case 23:
                        {
                            int opcion2;
                            string cadena;
                            Console.WriteLine("Escribe tu frase o párrafo.");
                            cadena = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("¿A qué quieres pasar tu frase? (1: minúsculas, 2: mayúsculas, 3: primera letra de cada palabra mayúsculas, 4: primera letra de cada frase mayúscula)");
                            opcion2 = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            cadena = MayusculasMinusculas(cadena, opcion2);
                            Console.WriteLine(cadena);
                        }
                        break;
                    case 24:
                        {
                            string cadenacontags;
                            cadenacontags = "prueba <tag>esto</tag> es una <etiqueta>prueba</etiqueta>";
                            Console.WriteLine(cadenacontags);
                            Console.WriteLine(EliminaTags(cadenacontags));
                        }
                        break;
                    case 25:
                        {
                            string animalesdeafrica;

                            animalesdeafrica = "gacela,león,jirafa,nutria,elefante,guepardo,hiena,ñu,cocodrilo,cacatúa,cebra";
                            Console.WriteLine(animalesdeafrica);
                            Console.WriteLine(OrdenaPalabrasComas(animalesdeafrica));

                            Console.WriteLine();
                        }
                        break;
                    case 26:
                        {
                            string cadena;
                            Console.WriteLine("Introduce tu cadena.");
                            cadena = Console.ReadLine();
                            Console.WriteLine("Tu cadena formateada es:");
                            Console.WriteLine(AcentosHTML(cadena));
                        }
                        break;
                    case 27:
                        {
                            string cadena;
                            Console.WriteLine("Introduce tu cadena.");
                            cadena = Console.ReadLine();
                            Console.WriteLine("Estas son las palabras de tu cadena que empiezan y terminan por la misma letra:");
                            EscribeArray(PalabrasMismaLetra(cadena));
                        }
                        break;
                    case 28:
                        {
                            int numero;
                            Console.WriteLine("Dime un número.");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("Tu número se llama: " + NumeroTexto99(numero));
                        }
                        break;
                    default:
                        Console.WriteLine("Este ejercicio no está en la relación de ejercicios de cadenas.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Puedes elegir otra opción.");
                opcion = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();

        }
    }
}
