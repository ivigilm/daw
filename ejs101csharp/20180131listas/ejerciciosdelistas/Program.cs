using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosdelistas // Relaciones de ejercicios de listas 1 y 2
{
    class Program
    {
        /// <summary>
        /// Lee enteros introducidos por teclado y los mete en una lista. Deja de hacerlo cuando se introduce "-1" por teclado.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro para ser rellenada con los valores introducidos por teclado.</param>
        static void LeeLista(List<int> milista) // Ejercicio 1
        {
            int valor;
            valor = 0;
            Console.WriteLine("Introduzca valores en la lista, escriba -1 para acabar.");
            

            while (valor != -1)
            {
                valor = int.Parse(Console.ReadLine());
                milista.Add(valor);
                
            }

        }

        /// <summary>
        /// Lee enteros introducidos por teclado y los mete en una lista.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro para ser rellenada con los valores introducidos por teclado.</param>
        /// <param name="cantidadenteros">Número de valores que se quieren leer.</param>
        static void LeeListaN(List<int> milista, int cantidadenteros) // Ejercicio 2
        {
            int contador, valor;
            contador = 0;
            valor = 0;
            Console.WriteLine("Introduzca el número de valores deseados en la lista.");
            
            while (contador < cantidadenteros)
            {
                valor = int.Parse(Console.ReadLine());
                milista.Add(valor);                
                contador = contador + 1;
            }
        }

        /// <summary>
        /// Escribe el contenido de una lista de enteros por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<int> milista) // Ejercicio 3
        {
            int i;

            Console.Write("<");

            for(i = 0; i < milista.Count -1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count-1] + ">");
        }

        /// <summary>
        /// Escribe el contenido de una lista de doubles por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<double> milista)
        {
            int i;

            Console.Write("<");

            for (i = 0; i < milista.Count - 1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count - 1] + ">");
        }

        /// <summary>
        /// Escribe el contenido de una lista de caracteres por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<char> milista)
        {
            int i;

            Console.Write("<");

            for (i = 0; i < milista.Count - 1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count - 1] + ">");
        }

        /// <summary>
        /// Escribe el contenido de una lista de cadenas por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<string> milista)
        {
            int i;

            Console.Write("<");

            for (i = 0; i < milista.Count - 1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count - 1] + ">");
        }

        /// <summary>
        /// Elimina los valores negativos de una lista de enteros.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EliminaNegativos(List<int> milista) // Ejercicio 6
        {
            int i;

            for(i = 0; i < milista.Count; i++)
            {
                if(milista[i] < 0)
                {
                    milista.RemoveAt(i);
                    i = i - 1;
                }
            }
        }

        /// <summary>
        /// Dada una lista rellena de enteros y dos listas vacías, rellena estas dos últimas una con negativos y otra con positivos.
        /// </summary>
        /// <param name="numerosvariados">Lista introducida por parámetro contenedora de los valores.</param>
        /// <param name="negativos">Lista vacía introducida por parámetro donde irán los valores negativos.</param>
        /// <param name="positivosy0">Lista vacía introducida por parámetro donde irán los valores positivos.</param>
        static void ClasificaNumeros(List<int> numerosvariados, List<int> negativos, List<int> positivosy0) // Ejercicio 7
        {
            int i;
            for(i = 0; i < numerosvariados.Count; i++) 
            {
                if(numerosvariados[i] < 0)
                {
                    negativos.Add(numerosvariados[i]);
                }
                else // >= 0
                {
                    positivosy0.Add(numerosvariados[i]);
                }
            }

            negativos.Sort();
            positivosy0.Sort();


        }

        /// <summary>
        /// Hace una copia de una lista de enteros en la que cada valor solo aparece una vez.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        /// <returns>Copia de la lista en la que se han eliminado los valores repetidos.</returns>
        static List<int> EliminaRepetidos(List<int> milista) // Ejercicio 8, versión 1
        {
            int i;
            List<int> unaocurrenciadecada;
            unaocurrenciadecada = new List<int>();

            for(i = 0; i < milista.Count; i++) // recorro la lista original
            {
                if ( (unaocurrenciadecada.Contains(milista[i])) == false) // si la nueva lista no contiene todavía el elemento actual
                {
                    unaocurrenciadecada.Add(milista[i]); // lo añado
                }
            }
                        
            return unaocurrenciadecada;
            
        }

        /// <summary>
        /// Elimina los elementos repetidos de una lista.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EliminaRepetidos2(List<int> milista) // Ejercicio 8, versión 2
        {
            int i;
            List<int> unaocurrenciadecada;
            unaocurrenciadecada = new List<int>();

            for (i = 0; i < milista.Count; i++) // recorro la lista original
            {
                if ((unaocurrenciadecada.Contains(milista[i])) == false) // si la nueva lista no contiene todavía el elemento actual
                {
                    unaocurrenciadecada.Add(milista[i]); // lo añado
                }
            }

            milista.Clear(); // vacío la lista original

            milista.AddRange(unaocurrenciadecada); // copio la lista auxiliar en mi lista original

        }

        /// <summary>
        /// Elimina los espacios al principio y al final de una lista de caracteres.
        /// </summary>
        /// <param name="milista">Lista de caracteres introducida por parámetro.</param>
        static void TrimLista(List<char> milista) // Ejercicio 9 
        {
            int i;

            for(i = 0; i < milista.Count; i++)
            {
                while(milista[i] == ' ') // borro todos los espacios del principio
                {
                    milista.RemoveAt(i); // elimina el elemento
                    i = 0;
                }
            }

            for (i = milista.Count - 1; i >= 0; i--)
            {
                while(milista[i] == ' ')
                {
                    milista.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Ordena los elementos de una lista de enteros.
        /// </summary>
        /// <param name="milista">Lista de enteros introducida por parámetro.</param>
        static void OrdenaListaSeleccion(List<int> milista) // Ejercicio 10
        {            
            int min;
            List<int> copia = new List<int>();

            while (milista.Count > 0)
            {
            min = milista.Min();
            copia.Add(min);
            milista.Remove(min);
            }

            milista.AddRange(copia);            
        }

        /// <summary>
        /// Ordena los elementos de una lista de doubles.
        /// </summary>
        /// <param name="milista">Lista de doubles introducida por parámetro.</param>
        static void OrdenaListaSeleccion(List<double> milista)
        {
            double min;
            List<double> copia = new List<double>();

            while (milista.Count > 0)
            {
                min = milista.Min();
                copia.Add(min);
                milista.Remove(min);
            }

            milista.AddRange(copia);
        }

        /// <summary>
        /// Ordena alfabéticamente una lista de cadenas.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void OrdenaListaPalabras(List<string> milista) // Ejercicio 11
        {
            List<string> copia = new List<string>();
            string min;
            
            while(milista.Count > 0)
            {
                min = milista.Min();
                copia.Add(min);
                milista.Remove(min);
            }

            milista.AddRange(copia);    

        }
              
        /// <summary>
        /// Ordena una lista de cadenas por tamaño.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void OrdenaListaPalabras2(List<string> milista) // Ejercicio 12
        {
            List<string> copia = new List<string>();
            string menor;
            int i;


            while (milista.Count > 0)
            {
                menor = milista[0]; // valor inicial de la palabra "menor": primera palabra

                for (i = 0; i < milista.Count; i++)
                {
                    if( milista[i].Length < menor.Length) // si el elemento actual es menor que el q tengo guardado
                    {                       
                        menor = milista[i]; // guardo el elemento actual como "menor"                        
                    }
                }

                copia.Add(menor); // lo añado a la nueva lista
                milista.Remove(menor); // lo borro de la lista original
            }

            milista.AddRange(copia);
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
        /// Inserta un array en otro array.
        /// </summary>
        /// <param name="original">Primer array, donde introduciremos el segundo.</param>
        /// <param name="posicion">Posición del primer array donde se insertará el segundo.</param>
        /// <param name="parainsertar">Segundo array, que será introducido en el primero.</param>
        /// <returns>Array resultado.</returns>
        static int[] InsertaArrayEnArrayPro(int[]original, int posicion, int[] parainsertar) // Ejercicio 14
        {
            int[] resultado;
            resultado = new int[0];

            // Paso 1: Copio los arrays en listas

            int i;
            List<int> listaoriginal;
            listaoriginal = new List<int>();
            List<int> listainsertar;
            listainsertar = new List<int>();

            for (i = 0; i < original.Length; i++) // copio el array original en una nueva lista vacía
            {
                listaoriginal.Add(original[i]); // añado el elemento i del array a la lista
            }

            for(i = 0; i < parainsertar.Length; i++) // copio int[]parainsertar en List<int>listainsertar
            {
                listainsertar.Add(parainsertar[i]);
            }

            // Paso 2: inserto una lista en otra

            listaoriginal.InsertRange(posicion, listainsertar); // listaoriginal contiene ahora todos los datos

            // Paso 3: copio la lista resultante en un array que devuelvo

            for(i = 0; i < listaoriginal.Count; i++)
            {
                InsertaAlFinalArray(ref resultado, listaoriginal[i]);
            }
            
            return resultado;
        }

        /// <summary>
        /// Genera una combinación aleatoria para el sorteo de la Bonoloto (seis números del 1 al 49). 
        /// </summary>
        /// <returns>Lista contenedora de una combinación de 6 números aleatorios del 1 al 49.</returns>
        static List<int> SorteoBonoloto() // Ejercicio 15
        {
            List<int> boletopremiado = new List<int>();
            List<int> bombo = new List<int>();
            int i, bola;
            Random r = new Random();

            for(i = 1; i < 50; i++) // relleno el bombo con números del 1 al 49
            {
                bombo.Add(i);
            }

            for(i = 0; i < 6; i++) // elijo 6 números y los meto en el boleto premiado
            {
                bola = r.Next(0, bombo.Count); // posición aleatoria de la lista bombo
                boletopremiado.Add(bola); // guardo la bola en el boleto
                bombo.Remove(bola); // saco la bola del bombo
            }

            OrdenaListaSeleccion(boletopremiado);

            return boletopremiado;

        }

        /// <summary>
        /// Elimina los elementos repetidos de un array.
        /// </summary>
        /// <param name="origen">Array introducido por parámetro.</param>
        /// <returns>Array copia del original pero que no tiene elementos repetidos.</returns>
        static int[] EliminaRepetidosArray(int[] origen) // Ejercicio 16
        {
            int i;
            int[] sinrepetidos = new int[0];
            List<int> copiaarray;
            copiaarray = new List<int>();

            for (i = 0; i < origen.Length; i++) // copio el array en una lista
            {
                copiaarray.Add(origen[i]);
            }

            EliminaRepetidos2(copiaarray); // dejo un elemento de cada en la lista

            for(i = 0; i < copiaarray.Count; i++)
            {
                InsertaAlFinalArray(ref sinrepetidos, copiaarray[i]);
            }

            return sinrepetidos;
        }

        /// <summary>
        /// Une dos listas en una tercera.
        /// </summary>
        /// <param name="lista1">Primera lista introducida por parámetro.</param>
        /// <param name="lista2">Segunda lista introducida por parámetro.</param>
        /// <returns>Lista contenedora de los elementos de lista1 y lista2.</returns>
        static List<string> UnionListas(List<string> lista1, List<string> lista2) // Ejercicio 17
        {
            int i;
            List<string> union;
            union = new List<string>();

            for(i = 0; i < lista1.Count; i++)
            {
                union.Add(lista1[i]);
            }
            for(i = 0; i < lista2.Count; i++)
            {
                union.Add(lista2[i]);
            }

            return union;
        }

        /// <summary>
        /// Crea una lista que contiene los elementos que aparecen en lista1 y lista2.
        /// </summary>
        /// <param name="lista1">Primera lista introducida por parámetro.</param>
        /// <param name="lista2">Segunda lista introducida por parámetro.</param>
        /// <returns>Nueva lista que contiene los valores comunes de lista1 y lista2.</returns>
        static List<int> InterseccionListas(List<int> lista1, List<int> lista2) // Ejercicio 18
        {
            int i;
            List<int> interseccion;
            interseccion = new List<int>();

            for (i = 0; i < lista1.Count; i++)
            {
                if (lista2.Contains(lista1[i]))
                {
                    interseccion.Add(lista1[i]);
                }
            }

            return interseccion;

        }

        /// <summary>
        /// Desordena una lista de enteros.
        /// </summary>
        /// <param name="listaordenada">Lista ordenada de enteros introducida por parámetro.</param>
        /// <returns>Lista con los elementos de la introducida desordenados.</returns>
        static List<int> DesordenaLista(List<int> listaordenada) // Ejercicio 19
        {
            int posicionaleatoria;
            List<int> listadesordenada;
            listadesordenada = new List<int>();
            Random r = new Random();

            while(listaordenada.Count > 0)
            {
                posicionaleatoria = r.Next(0, listaordenada.Count);
                listadesordenada.Add(listaordenada[posicionaleatoria]);
                listaordenada.Remove(listaordenada[posicionaleatoria]);
            }

            return listadesordenada;

        }

        /// <summary>
        ///  Halla la moda de una lista de enteros.
        /// </summary>
        /// <param name="listainicial">Lista introducida por parámetro.</param>
        /// <returns>Número entero (moda) con más repeticiones en la lista.</returns>
        static int ModaLista(List<int> listainicial) // Ejercicio 20
        {
            int i, j, contador, repeticiones, moda;
            moda = 0;
            repeticiones = 0;

            for(i = 0; i < listainicial.Count; i++) // para cada posición, cuento cuántos elementos iguales hay
            {
                contador = 0;

                for (j = 0;  j < listainicial.Count; j++)
                {
                    if(listainicial[j] == listainicial[i])
                    {
                        contador = contador + 1;                        
                    }                    
                }       // aquí tengo el número total de repeticiones del elemento i                                

                if (contador >= repeticiones)
                {
                    moda = listainicial[i];
                    repeticiones = contador;
                }
            }

            return moda;
        }

        /// <summary>
        /// Calcula la puntuación de un saltador de trampolín basada en las 7 notas recibidas por este.
        /// </summary>
        /// <param name="puntuaciones">Lista de las 7 notas obtenidas por el saltador.</param>
        /// <returns>Puntuación final (suma de las 3 notas intermedias, tras eliminar las dos notas más altas y las dos más bajas).</returns>
        static double PuntuacionesTrampolin(List<double> puntuaciones) // Ejercicio 21
        {
            double nota;
            int i;
            nota = 0;

            OrdenaListaSeleccion(puntuaciones); // ordeno las puntuaciones de menor a mayor
            puntuaciones.RemoveRange(puntuaciones.Count - 2, 2); // elimino las dos mayores
            puntuaciones.RemoveRange(0, 2); // elimino las dos menores

            for (i = 0; i < puntuaciones.Count; i++)
            {
                nota = nota + puntuaciones[i];
            }

            return nota;
        }

        /// <summary>
        /// Ordena una lista de números en función del número de veces que se repiten sus elementos (los más repetidos al principio).
        /// </summary>
        /// <param name="numeros">Lista de números enteros</param>
        static void OrdenaRepetidos(List<int> numeros) // Ejercicio 1 relación adicional
        {
            // 1. Miro la moda -> me dice el número más repetido
            // 2. Saco todas las ocurrencias de ese número de la lista y las introduzco en la nueva lista
            // 3. Vuelvo a mirar la moda hasta q no haya elementos en la lista

            int moda;
            List<int> resultado = new List<int>();

            while(numeros.Count != 0) // mientras haya elementos en la lista original
            {
                moda = ModaLista(numeros); // guardo el valor más repetido

                while (numeros.Contains(moda)) // mientras quede algún valor de la moda
                {
                    resultado.Add(moda); // lo añado a la nueva lista
                    numeros.Remove(moda); // elimino una ocurrencia del valor de la lista original
                }
            }

            numeros.AddRange(resultado); // cuando la lista original queda vacía copio en ella el resultado
        }

        /// <summary>
        /// Dada una lista, devuelve otra con un elemento de cada valor contenido en la lista original.
        /// </summary>
        /// <param name="numeros">Lista de números enteros.</param>
        /// <returns>Lista con una ocurrencia de cada elemento contenido en "numeros".</returns>
        static List<int> ElementosUnicos(List<int> numeros) // Ejercicio 2.1 relación adicional
        {
            List<int> copianumeros = numeros; // hago una copia para no tocar la original
            List<int> resultado = new List<int> ();
            int i, n;

            for(i = 0; i < copianumeros.Count; i++) // recorro la lista elemento a elemento
            {
                n = i; // guardo el valor del elemento actual en "n"
                copianumeros.RemoveAt(i); // elimino el elemento actual

                if (!copianumeros.Contains(n) && !resultado.Contains(n)) // si ya no hay ocurrencias de "n" en "numeros" y todavía no está en "resultado"
                {
                    resultado.Add(n); // lo agrego a la lista de elementos únicos
                }                
            }

            return resultado;
        }

        /// <summary>
        /// Dada una lista, devuelve otra con los elementos de la primera que estaban repetidos (una ocurrencia de cada uno).
        /// </summary>
        /// <param name="numeros">Lista de números enteros.</param>
        /// <returns>Lista de valores repetidos en la lista original.</returns>
        static List<int> ElementosRepetidos(List<int> numeros)
        {
            int i;
            List<int> valoresrepetidos, valoresunicos;
            valoresrepetidos = new List<int>();
            valoresunicos = ElementosUnicos(numeros); // guardo los valores únicos de la lista

            for(i = 0; i < numeros.Count; i++)
            {
                if (!valoresunicos.Contains(i) && !valoresrepetidos.Contains(i)) // si el valor se repite y todavía no está en la lista de repetidos
                {
                    valoresrepetidos.Add(i); // lo agrego a la lista de valores repetidos
                }
            }

            return valoresrepetidos;
        }

        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- LeeLista");
            Console.WriteLine("2.- LeeListaN");
            Console.WriteLine("3.- EscribeLista");
            Console.WriteLine("6.- EliminaNegativos");
            Console.WriteLine("7.- ClasificaNumeros");
            Console.WriteLine("81.- EliminaRepetidos");
            Console.WriteLine("82.- EliminaRepetidos2");
            Console.WriteLine("9.- TrimLista");
            Console.WriteLine("10.- OrdenaListaSeleccion");
            Console.WriteLine("11.- OrdenaListaPalabras");
            Console.WriteLine("12.- OrdenaListaPalabras2");
            Console.WriteLine("14.- InsertaArrayEnArrayPro");
            Console.WriteLine("15.- Sorteo de la Bonoloto");
            Console.WriteLine("16.- Elimina repetidos array");
            Console.WriteLine("17.- Unión de listas");
            Console.WriteLine("18.- Intersección de listas");
            Console.WriteLine("19.- Desordena lista");
            Console.WriteLine("20.- Moda lista");
            Console.WriteLine("21.- Puntuaciones trampolín");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        List<int> ejemplodelista;
                        ejemplodelista = new List<int>();

                        LeeLista(ejemplodelista);
                    }
                    break;
                case 2:
                    {
                        int numerovalores;

                        Console.WriteLine("¿Cuántos valores deseas introducir? Escribe un entero. (Ejemplo: 2)");
                        numerovalores = int.Parse(Console.ReadLine());

                        List<int> ejemplodelista;
                        ejemplodelista = new List<int>();

                        LeeListaN(ejemplodelista, numerovalores);
                    }
                    break;
                case 3:
                    {
                        List<int> lista2 = new List<int>() { 1, 2, 3 };
                        EscribeLista(lista2);
                    }
                    break;
                case 6:
                    {
                        List<int> listaejemplo = new List<int>() { -5, -4, 0, 2, -7, 1 };
                        EscribeLista(listaejemplo);
                        EliminaNegativos(listaejemplo);
                        EscribeLista(listaejemplo);
                    }
                    break;
                case 7:
                    {
                        List<int> numpositivos;
                        numpositivos = new List<int>();
                        List<int> numnegativos;
                        numnegativos = new List<int>();

                        List<int> listaejemplo;
                        listaejemplo = new List<int>() { 0, 1, -3, 2, -5, 3, -7, 4, -9, 5 };
                        Console.Write("Lista original: ");
                        EscribeLista(listaejemplo);

                        ClasificaNumeros(listaejemplo, numnegativos, numpositivos);

                        Console.Write("Lista con números negativos ordenados:");
                        EscribeLista(numnegativos);
                        Console.Write("Lista con números positivos ordenados:");
                        EscribeLista(numpositivos);
                    }
                    break;
                case 81:
                    {
                        List<int> listaejemplo;
                        listaejemplo = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9, 9, 10 };
                        EscribeLista(listaejemplo);

                        EscribeLista(EliminaRepetidos(listaejemplo));
                    }
                    break;
                case 82:
                    {
                        List<int> listaejemplo2;
                        listaejemplo2 = new List<int>() { 1, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9, 9, 10 };
                        EscribeLista(listaejemplo2);

                        EliminaRepetidos2(listaejemplo2);
                        EscribeLista(listaejemplo2);
                    }
                    break;
                case 9:
                    {
                        List<char> ejemplo;
                        ejemplo = new List<char> { ' ', 'a', '8', ' ', ' ', ' ' };
                        EscribeLista(ejemplo);

                        TrimLista(ejemplo);
                        EscribeLista(ejemplo);
                    }
                    break;
                case 10:
                    {
                        List<int> milista;
                        milista = new List<int>() { 3, 6, 1, 5, 2, 4 };
                        EscribeLista(milista);

                        OrdenaListaSeleccion(milista);
                        EscribeLista(milista);
                    }
                    break;
                case 11:
                    {
                        List<string> milista;
                        milista = new List<string>() { "diccionario", "array", "lista", "cadena", "función" };
                        EscribeLista(milista);

                        OrdenaListaPalabras(milista);
                        EscribeLista(milista);
                    }
                    break;
                case 12:
                    {
                        List<string> milista;
                        milista = new List<string>() { "diccionario", "array", "lista", "cadena", "función" };
                        EscribeLista(milista);

                        OrdenaListaPalabras2(milista);
                        EscribeLista(milista);
                    }
                    break;
                case 14:
                    {
                        int[] uno = new int[] { 1, 2, 7, 8, 9, 10 };

                        int[] dos = new int[] { 3, 4, 5, 6 };

                        Console.Write("Array uno:");
                        EscribeArray(uno);
                        Console.WriteLine();

                        Console.Write("Array dos:");
                        EscribeArray(dos);
                        Console.WriteLine();

                        Console.Write("Resultado:");
                        EscribeArray(InsertaArrayEnArrayPro(uno, 2, dos));
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("El boleto premiado de la Bonoloto del día de ayer es el siguiente:");
                        EscribeLista(SorteoBonoloto());
                    }
                    break;
                case 16:
                    {
                        int[] array = new int[9] { 1, 2, 2, 3, 4, 4, 5, 6, 7 };

                        Console.Write("Array original:");
                        EscribeArray(array);

                        Console.Write("Array sin elementos repetidos:");
                        EscribeArray(EliminaRepetidosArray(array));
                    }
                    break;
                case 17:
                    {
                        List<string> animales;
                        animales = new List<string>() { "gaviota", "loro", "paloma" };

                        List<string> paises;
                        paises = new List<string>() { "España", "Francia", "Italia" };

                        Console.Write("Lista de animales: ");
                        EscribeLista(animales);
                        Console.Write("Lista de países: ");
                        EscribeLista(paises);
                        Console.Write("Lista de animales y sus países de origen (o no):");
                        EscribeLista(UnionListas(animales, paises));
                    }
                    break;
                case 18:
                    {
                        List<int> ceroalcinco;
                        ceroalcinco = new List<int>() { 0, 1, 2, 3, 4, 5 };
                        List<int> cincoimpares;
                        cincoimpares = new List<int>() { 1, 3, 5, 7, 9 };

                        Console.Write("Primera lista: ");
                        EscribeLista(ceroalcinco);
                        Console.Write("Segunda lista: ");
                        EscribeLista(cincoimpares);
                        Console.Write("Lista intersección de las dos primeras: ");
                        EscribeLista(InterseccionListas(ceroalcinco, cincoimpares));
                    }
                    break;
                case 19:
                    {
                        List<int> diez;
                        diez = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                        Console.Write("Lista ordenada: ");
                        EscribeLista(diez);
                        Console.Write("Lista desordenada: ");
                        EscribeLista(DesordenaLista(diez));
                    }
                    break;
                case 20:
                    {
                        List<int> notas;
                        notas = new List<int>() { 1, 2, 3, 3, 4, 5, 5, 5, 6, 7, 8, 8, 9, 7 };
                        Console.Write("Notas: ");
                        EscribeLista(notas);
                        Console.WriteLine("Moda: " + ModaLista(notas));
                    }
                    break;
                case 21:
                    {
                        List<double> puntos;
                        puntos = new List<double>() { 8.2, 10, 6.4, 5, 9.1, 7.5, 7 };
                        OrdenaListaSeleccion(puntos);
                        Console.Write("Lista de puntuaciones obtenidas: ");
                        EscribeLista(puntos);
                        Console.WriteLine("Nota final: " + PuntuacionesTrampolin(puntos));
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Este ejercicio no está en la relación de ejercicios de cadenas.");
                    }                    
                    break;
            }


            Console.ReadKey();
        }
    }
}
