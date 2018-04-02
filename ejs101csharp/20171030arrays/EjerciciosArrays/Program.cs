using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays
{
    class Program
    {
        /// <summary>
        /// Escribe un array de tipo entero de 5 elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray5(int[] a) // Ejercicio 1
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < 4; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[4]);

            Console.WriteLine("]");

        }

        /// <summary>
        /// Escribe un array de tipo entero de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(int[] a) // Ejercicio 2
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
        /// Se le introduce un array de enteros de 5 elementos ya definido y lo rellena con los valores introducidos por el usuario.
        /// </summary>
        /// <param name="a">Array que se va a rellenar.</param>
        static void LeeArray5(int[] a) // Ejercicio 3
        {
            int i;
            Console.WriteLine("Dame cinco valores numéricos.");
            for (i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Se le introduce un array de enteros ya definido y lo rellena con los valores introducidos por el usuario.
        /// </summary>
        /// <param name="a">Array que se va a rellenar.</param>
        static void LeeArray(int[] a) // Ejercicio 4
        {
            int i;
            Console.WriteLine("Dame una serie de valores numéricos.");
            for (i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

        }

        /// <summary>
        /// Sustituye los valores de un array de 5 elementos por 0.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para ser rellenado con ceros.</param>
        static void PonCeros5(int[] a) // Ejercicio 5
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                a[i] = 0;
            }
        }

        /// <summary>
        /// Sustituye los valores de los elementos de un array por 0.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para ser rellenado con ceros.</param>
        static void PonCeros(int[] a) // Ejercicio 6
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }

        /// <summary>
        /// Suma los elementos de un array de 5 elementos.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para sumar sus elementos.</param>
        /// <returns>Suma de los elementos del array introducido por parámetro.</returns>
        static int SumaArray5(int[] a) // Ejercicio 7
        {
            int i, suma;
            suma = 0;

            for (i = 0; i < 5; i++)
            {
                suma = suma + a[i];
            }

            return suma;
        }

        /// <summary>
        /// Suma los elementos de un array.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para sumar sus elementos.</param>
        /// <returns>Suma de los elementos del array introducido por parámetro.</returns>
        static int SumaArray(int[] a) // Ejercicio 8
        {
            int i, suma;
            suma = 0;

            for (i = 0; i < a.Length; i++)
            {
                suma = suma + a[i];
            }

            return suma;
        }

        /// <summary>
        /// Hace la media de los elementos de un array de 5 elementos.
        /// </summary>
        /// <param name="a">Array introducido por parámetro del que se calcula la media de sus elementos.</param>
        /// <returns>Media de los elementos del array introducido por parámetro.</returns>
        static int MediaArray5(int[] a) // Ejercicio 9
        {
            int media, suma;
            suma = SumaArray5(a);
            media = suma / 5;
            return media;
        }

        /// <summary>
        /// Hace la media de los elementos de un array.
        /// </summary>
        /// <param name="a">Array introducido por parámetro del que se calcula la media de sus elementos.</param>
        /// <returns>Media de los elementos del array introducido por parámetro.</returns>
        static int MediaArray(int[] a) // Ejercicio 10
        {
            int media, suma;
            suma = SumaArray(a);
            media = suma / a.Length;
            return media;
        }

        /// <summary>
        /// Rellena un array con números enteros ascendentes, empezando por 1.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para ser rellenado.</param>
        static void RellenaEnOrden(int[] a) // Ejercicio 11
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
        }

        /// <summary>
        /// Rellena un array con números enteros descendentes hasta llegar al 1.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para ser rellenado.</param>
        static void RellenaEnOrdenDesc(int[] a) // Ejercicio 12
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = a.Length - i;
            }
        }

        /// <summary>
        /// Rellena un array con números aleatorios entre 1 y 10.
        /// </summary>
        /// <param name="a">Array introducido por parámetro a rellenar.</param>
        static void RellenaAleatorio(int[] a) // Ejercicio 13
        {
            int i;

            Random numeroaleatorio = new Random();

            for (i = 0; i < a.Length; i++)
            {
                a[i] = numeroaleatorio.Next(1, 10);
            }
        }

        /// <summary>
        /// Comprueba si un array de enteros está ordenado.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Un valor booleano: true si el array está ordenado y false en caso contrario.</returns>
        static bool EstaOrdenado(int[] a) // Ejercicio 14
        {
            int i, j;
            bool ordenado;
            j = 0;

            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    j = j + 1;
                }

            }

            if (j == 0)
            {
                ordenado = true;
            }
            else
            {
                ordenado = false;
            }

            return ordenado;
        }

        /// <summary>
        /// Cuenta los números impares de un array de enteros.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Número de elementos del array que son impares.</returns>
        static int NumeroImpares(int[] a) // Ejercicio 15
        {
            int contadorimpares, i;
            contadorimpares = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    contadorimpares = contadorimpares + 1;
                }
            }

            return contadorimpares;
        }

        /// <summary>
        /// Halla el valor mínimo de los contenidos en un array de enteros.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Menor valor del array.</returns>
        static int MinArray(int[] a) // Ejercicio 16
        {
            int i, min;

            min = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        /// <summary>
        ///  Halla el valor máximo de los contenidos en un array de enteros
        /// </summary>
        /// <param name="a"Array introducido por parámetro.></param>
        /// <returns>Mayor valor del array</returns>
        static int MaxArray(int[] a) // Ejercicio 17
        {
            int i, max;

            max = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Calcula el número de aprobados de una serie de notas introducidas como un array.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Número de aprobados.</returns>
        static int NumeroAprobados(int[] a) // Ejercicio 18
        {
            int i, aprobados;

            aprobados = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5)
                {
                    aprobados = aprobados + 1;
                }
            }

            return aprobados;
        }

        /// <summary>
        /// Halla el número de valores del array que son igual o superior a un límite dado.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <param name="limite">Límite introducido por parámetro.</param>
        /// <returns>Número de elementos del array que superan el límite.</returns>
        static int PorEncimaDe(int[] a, int limite) // Ejercicio 19
        {
            int i, contador;

            contador = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= limite)
                {
                    contador = contador + 1;
                }
            }

            return contador;
        }

        /// <summary>
        /// Halla el número de elementos del array de enteros que son igual a 0.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Número de elementos del array que tienen valor '0'.</returns>
        static int CuantosCeros(int[] a) // Ejercicio 20
        {
            int i, contador;
            contador = 0;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    contador = contador + 1;
                }
            }

            return contador;
        }

        /// <summary>
        /// Copia un array en otro.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro, será el que se copie.</param>
        /// <param name="b">Segundo array introducido por parámetro, será donde se copie el primero.</param>
        static void CopiaArray(int[] a, int[] b) // Ejercicio 21
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                Console.WriteLine("¿Cómo quieres que copie un array en otro si son de distinto tamaño? Vuelve a probar.");
            }
        }

        /// <summary>
        /// Copia un array en otro dándole la vuelta: [1,2,3] pasa a ser [3,2,1].
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro, será el que se copie.</param>
        /// <param name="b">Segundo array introducido por parámetro, será donde se copie el primero.</param>
        static void CopiaArrayInvertido(int[] a, int[] b) // Ejercicio 22
        {
            int i, j;

            j = a.Length - 1;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[j] = a[i];
                    j = j - 1;
                }
            }
            else
            {
                Console.WriteLine("¿Cómo quieres que copie un array en otro si son de distinto tamaño? Vuelve a probar.");
            }
        }

        /// <summary>
        /// Suma dos arrays y guarda el resultado en un tercero.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro.</param>
        /// <param name="suma">Tercer array introducido por parámetro, donde se guardará la suma de los dos primeros.</param>
        static void SumaArrays(int[] a, int[] b, int[] suma) // Ejercicio 23
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                suma[i] = a[i] + b[i];
            }

        }

        /// <summary>
        /// Resta, multiplica o divide dos arrays (a elección) y guarda el resultado en un tercero.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro.</param>
        /// <param name="resta">Tercer array introducido por parámetro, donde se guardará el resultado de la operación de los dos primeros.</param>
        static void RestaMultiDiviArrays(int[] a, int[] b, int[] resultado) // Ejercicio 24
        {
            string eleccion;
            int i;

            Console.WriteLine("Elige una opción: resta (r), multiplicación (m) o división (d).");
            eleccion = Console.ReadLine();

            if (eleccion == "r")
            {
                for (i = 0; i < a.Length; i++)
                {
                    resultado[i] = a[i] - b[i];
                }
            }
            else
            {
                if (eleccion == "m")
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        resultado[i] = a[i] * b[i];
                    }
                }
                else // eleccion == "d"
                {
                    for (i = 0; i < a.Length; i++)
                    {
                        resultado[i] = a[i] / b[i];
                    }
                }
            }

        }

        /// <summary>
        /// Invierte los elementos de un array. (Ej. el array [1,2,3] pasará a ser [3,2,1])
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void InvierteArray(int[] a) // Ejercicio 25
        {
            int[] b = new int[a.Length];

            CopiaArrayInvertido(a, b);

            CopiaArray(b, a);
        }

        /// <summary>
        /// Comprueba si dos arrays son idénticos.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro.</param>
        /// <returns>true/false en función de si los arrays son idénticos.</returns>
        static bool ComparaArrays(int[] a, int[] b) // Ejercicio 26
        {
            bool iguales;
            int i, fallo;
            fallo = 0;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        fallo = 1;
                    }
                }
            }
            else
            {
                fallo = 1;
            }

            if (fallo == 0)
            {
                iguales = true;
            }
            else
            {
                iguales = false;
            }

            return iguales;
        }

        /// <summary>
        /// Asigna valores booleanos a las notas guardadas en un array de enteros, guardándolos en un nuevo array.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro, contenedor de las notas.</param>
        /// <param name="b">Segundo array introducido por parámetro, donde se guardarán los valores booleanos.</param>
        static void PonNotasArray(double[] a, bool[] b) // Ejercicio 27
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] >= 5)
                {
                    b[i] = true;
                }
                else
                {
                    b[i] = false;
                }
            }
        }

        /// <summary>
        /// Une dos arrays de enteros de 5 elementos en un tercer array de 10 elementos.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro.</param>
        /// <param name="c">Tercer array introducido por parámetro, donde se guardará la unión de los otros dos.</param>
        static void ConcatenaArray55(int[] a, int[] b, int[] c) // Ejercicio 28
        {
            int i;

            for (i = 0; i < 5; i++)
            {
                c[i] = a[i];
            }

            for (i = 5; i < 10; i++)
            {
                c[i] = b[i - 5];
            }
        }

        /// <summary>
        ///  Une dos arrays de enteros en un tercer array de tantos elementos como la suma de los dos primeros.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro.</param>
        /// <param name="c">Tercer array introducido por parámetro, donde se guardará la unión de los otros dos.</param>
        static void ConcatenaArrays(int[] a, int[] b, int[] c) // Ejercicio 29
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for (i = a.Length; i < c.Length; i++)
            {
                c[i] = b[i - a.Length];
            }
        }

        /// <summary>
        /// Comprueba si un array de enteros contiene un número entero concreto.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <param name="b">Número entero introducido por parámetro.</param>
        /// <returns></returns>
        static bool Contiene(int[] a, int b) // Ejercicio 30
        {
            bool contienenumero;
            int i;
            contienenumero = false;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    contienenumero = true;
                }
            }

            return contienenumero;
        }

        /// <summary>
        /// Une dos arrays y guarda el resultado en un tercero.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro.</param>
        /// <param name="b">Segundo array introducido por parámetro</param>
        /// <returns>Array que contiene los elementos de los dos primeros arrays en el orden en que llegaron.</returns>
        static int[] ConcatenaArraysPro(int[] a, int[] b) // Ejercicio 31
        {
            int[] c = new int[a.Length + b.Length];

            ConcatenaArrays(a, b, c);

            return c;
        }

        /// <summary>
        /// Copia un array en uno nuevo.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Array "copia", un nuevo array idéntico al primero.</returns>
        static int[] CopiaArrayPro(int[] a) // Ejercicio 32
        {
            int[] b = new int[a.Length];

            CopiaArray(a, b);

            return b;
        }

        /// <summary>
        /// Inserta un valor en una posición dada de un array, desplazando los demás una posición hacia adelante.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="b">Valor introducido por parámetro para insertar.</param>
        /// <param name="c">Posición del array donde se quiere insertar el valor.</param>
        static void InsertaEnArray(ref int[] a, int b, int c) // Ejercicio 33
        {
            int[] arraycopia = CopiaArrayPro(a);

            Array.Resize(ref a, a.Length + 1);

            int i;

            a[c] = b;

            for (i = c + 1; i < a.Length; i++)
            {
                a[i] = arraycopia[i - 1];
            }

        }

        /// <summary>
        /// Borra un valor de una posición dada de un array y desplaza los valores posteriores hacia atrás, restando 1 al tamaño del array.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="posicion">Posición del array que se quiere eliminar.</param>
        static void BorraDeArray(ref int[] a, int posicion) // Ejercicio 34
        {
            int i;

            for (i = posicion; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Array.Resize(ref a, a.Length - 1);
        }

        /// <summary>
        /// Elimina el primer elemento que tenga un valor dado de un array.
        /// </summary>
        /// <param name="a">Array introducido por referencia</param>
        /// <param name="elemento">Valor del elemento a eliminar.</param>
        static void Elimina1ElementoArray(ref int[] a, int elemento) // Ejercicio 35
        {
            int i, j;

            for (i = 0; i < a.Length; i++) // recorro el array hasta encontrar el elemento
            {
                if (a[i] == elemento)
                {
                    a[i] = 0;

                    for (j = i; j < a.Length - 1; j++) // recorro el resto del array recolocándolo para dejar vacía la última posición
                    {
                        a[j] = a[j + 1];
                    }

                    Array.Resize(ref a, a.Length - 1);
                }
            }
        }

        /// <summary>
        /// Elimina el elemento "x" de un array de enteros.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <param name="elemento">Valor numérico a eliminar del array.</param>
        static void EliminaElementosArray(ref int[] a, int elemento) // Ejercicio 36
        {
            int i;
                        
                for (i = 0; i < a.Length; i++)
                {
                    if (a[i] == elemento)
                    {
                        Elimina1ElementoArray(ref a, elemento);

                        i = i - 1;
                    }
                }
            
            
        }

        /// <summary>
        /// Inserta un array en otro en la posición indicada.
        /// </summary>
        /// <param name="a">Array introducido por referencia en el que se insertará el segundo array.</param>
        /// <param name="posicion">Posición del array insertado por referencia en la que se insertará el segundo.</param>
        /// <param name="b">Array introducido por parámetro que se va a insertar en el primer array.</param>
        static void InsertaArrayEnArray(ref int[] a, int posicion, int[] b) // Ejercicio 37
        {            
            Array.Resize(ref a, a.Length + b.Length);

            int i, j;

            for(i = a.Length - 1; i >= posicion + b.Length; i--) // muevo los elementos de "a" posteriores a la inserción un espacio
            {
                a[i] = a[i - b.Length];
            }

            j = 0;

            for(i = posicion; i < posicion + b.Length; i++)
            {
                a[i] = b[0 + j];

                j++;
            }
        }

        /// <summary>
        /// Crea un nuevo array que contiene los valores de un primer array comprendidos entre dos posiciones de este.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro del que se sacarán los valores para rellenar el nuevo array.</param>
        /// <param name="pos1">Primera posición del array "a" donde comienza el intervalo de valores.</param>
        /// <param name="pos2">Segunda posición del array "a" donde termina el intervalo de valores.</param>
        /// <returns>Nuevo array creado con los valores contenidos en "a" entre las posiciones "pos1" y "pos2".</returns>
        static int[] SubArray(int[]a, int pos1, int pos2) // Ejercicio 38
        {
            int[] b = new int[pos2 - pos1 + 1];

            int i;
            int j = 0;

            for (i = pos1; i <= pos2; i++)
            {
                b[j] = a[i];

                j = j + 1;
            }

            return b;
        }

        /// <summary>
        /// Recorta un array, dejando solo las posiciones del intervalo indicado.
        /// </summary>
        /// <param name="a">Array introducido por referencia que se va a modificar.</param>
        /// <param name="pos1">Primera posición del intervalo de valores que queremos conservar.</param>
        /// <param name="pos2">Segunda posición del intervalo de valores que queremos conservar.</param>
        static void RecortaArray(ref int[]a, int pos1, int pos2) // Ejercicio 39
        {
            int i, j;

            int tamanionuevo = pos2 - pos1 + 1;

            j = pos1;

            for(i = 0; i < tamanionuevo; i++)
            {
                a[i] = a[j];

                j++;
            }

            Array.Resize(ref a, tamanionuevo);
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
                if(a[i] < a[posicionminimo])
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
        static void InsertaAlFinalArray(ref int[] a, int elemento)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = elemento;
        }

        /// <summary>
        /// Ordena los elementos de un array de menor a mayor y los introduce en un nuevo array, dejando el primero vacío.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <returns>Un nuevo array con los elementos del primero ordenados.</returns>
        static int[] OrdenaSeleccion(ref int[] a) // Ejercicio 40
        {
            int[] b = new int[0];
            int i;
            
            while(a.Length > 0)
            { 
                for (i = 0; i < a.Length; i++)
                {
                    InsertaAlFinalArray(ref b, a[PosMinArray(a)]);

                    BorraDeArray(ref a, PosMinArray(a));
                }
             }

            return b;

        }
                
        static void Main(string[] args)
        {            
            
            int opcion;

            Console.WriteLine("MENÚ DE ARRAYS");
            Console.WriteLine("==============");
            Console.WriteLine(" 1- EscribeArray5");
            Console.WriteLine(" 2- EscribeArray");
            Console.WriteLine(" 3- LeeArray5");
            Console.WriteLine(" 4- LeeArray");
            Console.WriteLine(" 5- PonCeros5");
            Console.WriteLine(" 6- PonCeros");
            Console.WriteLine(" 7- SumaArray5");
            Console.WriteLine(" 8- SumaArray");
            Console.WriteLine(" 9- MediaArray5");
            Console.WriteLine(" 10- MediaArray");
            Console.WriteLine(" 11- RellenaEnOrden");
            Console.WriteLine(" 12- RellenaEnOrdenDesc");
            Console.WriteLine(" 13- RellenaAleatorio");
            Console.WriteLine(" 14- EstaOrdenado");
            Console.WriteLine(" 15- NumeroImpares");
            Console.WriteLine(" 16- MinArray");
            Console.WriteLine(" 17- MaxArray");
            Console.WriteLine(" 18- NumeroAprobados");
            Console.WriteLine(" 19- PorEncimaDe");
            Console.WriteLine(" 20- CuantosCeros");
            Console.WriteLine(" 21- CopiaArray");
            Console.WriteLine(" 22- CopiaArrayInvertido");
            Console.WriteLine(" 23- SumaArrays");
            Console.WriteLine(" 24- RestaArrays / MultiplicaArrays / DivideArrays");
            Console.WriteLine(" 25- InvierteArray");
            Console.WriteLine(" 26- ComparaArrays");
            Console.WriteLine(" 27- PonNotasArray");
            Console.WriteLine(" 28- ConcatenaArray55");
            Console.WriteLine(" 29- ConcatenaArrays");
            Console.WriteLine(" 30- Contiene");
            Console.WriteLine(" 31- ConcatenaArraysPro");
            Console.WriteLine(" 32- CopiaArrayPro");
            Console.WriteLine(" 33- InsertaEnArray");
            Console.WriteLine(" 34- BorraDeArray");
            Console.WriteLine(" 35- Elimina1ElementoArray");
            Console.WriteLine(" 36- EliminaElementosArray");
            Console.WriteLine(" 37- InsertaArrayEnArray");
            Console.WriteLine(" 38- SubArray");
            Console.WriteLine(" 39- RecortaArray");
            Console.WriteLine(" 40- OrdenaSeleccion");
            Console.WriteLine("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int[] a = new int[5] { 3, 7, 0, 1, 2 };
                        EscribeArray5(a);
                    }                    break;
                case 2:
                    {
                        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
                        EscribeArray(a);
                    }                    break;
                case 3:
                    {
                        int[] a;
                        a = new int[5];

                        LeeArray5(a);

                        Console.WriteLine("He creado un array con los valores que me has dado. Aquí lo tienes: ");
                        EscribeArray5(a);
                    }                    break;
                case 4:
                    {
                        int[] a;
                        a = new int[7];

                        LeeArray(a);

                        Console.WriteLine("He creado un array con los valores que me has dado. Aquí lo tienes: ");
                        EscribeArray(a);
                    }                    break;
                case 5:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        PonCeros5(a);

                        Console.WriteLine("He convertido tu array original en este otro tan divertido:");
                        EscribeArray5(a);
                    }                    break;
                case 6:
                    {
                        int[] a = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                        PonCeros(a);

                        Console.WriteLine("He convertido tu array original en este otro tan divertido:");
                        EscribeArray(a);
                    }                    break;
                case 7:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        Console.WriteLine(SumaArray5(a));
                    }                    break;
                case 8:
                    {
                        int[] a = new int[3] { 3, 4, 5 };
                        Console.WriteLine(SumaArray(a));
                    }                    break;
                case 9:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        Console.WriteLine("La media del array es " + MediaArray5(a) + ".");
                    }                    break;
                case 10:
                    {
                        int[] a = new int[3] { 3, 4, 5 };
                        Console.WriteLine("La media del array es " + MediaArray(a) + ".");
                    }                    break;
                case 11:
                    {
                        int[] a = new int[4];
                        RellenaEnOrden(a);
                        EscribeArray(a);
                    }                    break;
                case 12:
                    {
                        int[] a = new int[4];
                        RellenaEnOrdenDesc(a);
                        EscribeArray(a);
                    }                    break;
                case 13:
                    {
                        int[] a = new int[5];
                        RellenaAleatorio(a);
                        EscribeArray(a);
                    }                    break;
                case 14:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        Console.WriteLine("¿Está ordenado mi array? " + EstaOrdenado(a));
                    }                    break;
                case 15:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        Console.WriteLine(NumeroImpares(a));
                    }                    break;
                case 16:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        Console.WriteLine(MinArray(a));
                    }                    break;
                case 17:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        Console.WriteLine(MaxArray(a));
                    }                    break;
                case 18:
                    {
                        int[] a = new int[5] { 1, 0, 3, 4, 5 };

                        Console.WriteLine(NumeroAprobados(a));
                    }                    break;
                case 19:
                    {
                        int[] a = new int[5] { 1, 10, 13, 4, 5 };

                        Console.WriteLine(PorEncimaDe(a, 10));
                    }                    break;
                case 20:
                    {
                        int[] a = new int[5] { 3, 0, 7, 10, 0 };

                        Console.WriteLine(CuantosCeros(a));
                    }                    break;
                case 21:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int[] b = new int[5] { 0, 0, 0, 0, 0 };

                        CopiaArray(a, b);

                        EscribeArray(b);
                    }                    break;
                case 22:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int[] b = new int[5] { 0, 0, 0, 0, 0 };

                        CopiaArrayInvertido(a, b);

                        EscribeArray(b);
                    }                    break;
                case 23:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int[] b = new int[5] { 1, 1, 1, 1, 1 };
                        int[] c = new int[5];

                        SumaArrays(a, b, c);

                        EscribeArray(c);
                    }                    break;
                case 24:
                    {
                        int[] a = new int[5] { 2, 4, 6, 8, 10 };
                        int[] b = new int[5] { 2, 2, 2, 2, 2 };
                        int[] c = new int[5];

                        RestaMultiDiviArrays(a, b, c);

                        EscribeArray(c);
                    }                    break;
                case 25:
                    {
                        int[] a = new int[5] { 2, 4, 6, 8, 10 };

                        InvierteArray(a);

                        EscribeArray(a);
                    }                    break;
                case 26:
                    {
                        int[] a = new int[5] { 2, 4, 6, 7, 10 };
                        int[] b = new int[5] { 2, 4, 6, 8, 10 };

                        Console.WriteLine(ComparaArrays(a, b));
                    }                    break;
                case 27:
                    {
                        double[] a = new double[5] { 1.3, 7.1, 3.25, 4, 8.5 };
                        bool[] b = new bool[5];

                        PonNotasArray(a, b);

                        int i;

                        Console.Write("[ ");
                        for (i = 0; i < a.Length - 1; i++)
                        {
                            Console.Write(a[i] + ", ");
                        }
                        Console.Write(a[a.Length - 1]);
                        Console.WriteLine("]");
                        
                        Console.Write("[ ");
                        for (i = 0; i < a.Length - 1; i++)
                        {
                            Console.Write(b[i] + ", ");
                        }
                        Console.Write(b[a.Length - 1]);
                        Console.WriteLine("]");
                    }                    break;
                case 28:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int[] b = new int[5] { 6, 7, 8, 9, 10 };
                        int[] c = new int[10];

                        ConcatenaArray55(a, b, c);

                        EscribeArray(c);
                    }                    break;
                case 29:
                    {
                        int[] a = new int[3] { 1, 2, 3 };
                        int[] b = new int[7] { 4, 5, 6, 7, 8, 9, 10 };
                        int[] c = new int[10];

                        ConcatenaArrays(a, b, c);

                        EscribeArray(c);
                    }                    break;
                case 30:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int b = 8;

                        Console.WriteLine(Contiene(a, b));
                    }                    break;
                case 31:
                    {
                        int[] a = new int[4] { 1, 2, 3, 4 };
                        int[] b = new int[6] { 5, 6, 7, 8, 9, 10 };

                        EscribeArray(ConcatenaArraysPro(a, b));
                    }                    break;
                case 32:
                    {
                        int[] a = new int[4] { 1, 2, 3, 4 };

                        EscribeArray(CopiaArrayPro(a));
                    }                    break;
                case 33:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        InsertaEnArray(ref a, 26, 2);

                        EscribeArray(a);
                    }                    break;
                case 34:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        int posicion = 2;

                        BorraDeArray(ref a, posicion);

                        EscribeArray(a);
                    }                    break;
                case 35:
                    {
                        int elemento = 3;

                        int[] a = new int[5] { 1, 2, 3, 4, 5 };

                        Elimina1ElementoArray(ref a, elemento);

                        EscribeArray(a);
                    }                    break;
                case 36:
                    {
                        int[] a = new int[5] { 7, 9, 10, 8, 10 };

                        EliminaElementosArray(ref a, 10);

                        EscribeArray(a);
                    }                    break;
                case 37:
                    {
                        int[] a = new int[5] { 1, 2, 3, 4, 5 };
                        int[] b = new int[2] { 12, 13 };

                        InsertaArrayEnArray(ref a, 2, b);

                        EscribeArray(a);
                    }                    break;
                case 38:
                    {
                        int[] a = new int[5] { 6, 7, 8, 9, 10 };

                        EscribeArray(SubArray(a, 1, 3));
                    }                    break;
                case 39:
                    {
                        int[] a = new int[5] { 6, 7, 8, 9, 10 };

                        RecortaArray(ref a, 1, 3);

                        EscribeArray(a);
                    }                    break;
                case 40:
                    {
                        int[] a = new int[5] { 7, 9, 6, 8, 10 };

                        EscribeArray(OrdenaSeleccion(ref a));
                    }                    break;
                default: Console.WriteLine("Este ejercicio no está en la relación de ejercicios de arrays.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
