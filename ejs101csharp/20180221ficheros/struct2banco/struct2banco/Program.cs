using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace struct2banco
{
    class Program
    {
        struct CuentaCorriente
        {
            public string numero_cc;
            public string cliente;
            public decimal saldo;
        }

        /// <summary>
        /// Guarda una nueva cuenta en la lista banco.
        /// </summary>
        /// <param name="banco">Lista donde se guardan los datos de las listas</param>
        static void NuevaCuentaBanco(List<CuentaCorriente> banco) // Ejercicio 1
        {
            CuentaCorriente nueva;
            int i, contador;
            contador = 0;

            Console.WriteLine("¿Cuál es el número de la cuenta?");
            nueva.numero_cc = Console.ReadLine();
            Console.WriteLine("¿Cuál es el nombre del propietario?");
            nueva.cliente = Console.ReadLine();
            Console.WriteLine("¿Cuál es el saldo inicial?");
            nueva.saldo = decimal.Parse(Console.ReadLine());

            for(i = 0; i < banco.Count; i++)
            {
                if(banco[i].numero_cc == nueva.numero_cc)
                {
                    contador = contador + 1;
                }
            }

            if(contador == 0)
            {
                banco.Add(nueva); // guarda la nueva cuenta
            }
            else
            {
                Console.WriteLine("La cuenta ya existe.");
            }
        }

        /// <summary>
        /// Elimina la cuenta indicada.
        /// </summary>
        /// <param name="banco">Lista contenedora de las cuentas bancarias.</param>
        static void EliminarCuentaBanco(List<CuentaCorriente> banco) // Ejercicio 2
        {
            string cuenta;
            int i;

            Console.WriteLine("Dime el número de la cuenta que quieres eliminar.");
            cuenta = Console.ReadLine();

            for(i = 0; i < banco.Count; i++)
            {
                if(banco[i].numero_cc == cuenta)
                {
                    banco.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Modifica el saldo de una cuenta.
        /// </summary>
        /// <param name="banco">Lista de cuentas corrientes.</param>
        static void ActualizarSaldoBanco(List<CuentaCorriente> banco) // Ejercicio 3
        {
            int i;
            decimal modificacion;
            string cuenta;
            Console.WriteLine("¿Cuál es el número de cuenta?");
            cuenta = Console.ReadLine();
            Console.WriteLine("¿Cuánto dinero deseas añadir a la cuenta? (Pon un valor negativo si deseas retirar dinero.");
            modificacion = decimal.Parse(Console.ReadLine());

            for(i = 0; i < banco.Count; i++)
            {
                if(banco[i].numero_cc == cuenta) // cuando encuentre la cuenta
                {
                    CuentaCorriente temp = banco[i];
                    temp.saldo = temp.saldo + modificacion;
                    banco[i] = temp;

                    Console.WriteLine("El saldo actual de la cuenta (tras la operación) es de: " + temp.saldo);
                }
            }

        }

        /// <summary>
        /// Imprime por pantalla las cuentas con sus datos.
        /// </summary>
        /// <param name="banco">Lista de cuentas bancarias.</param>
        static void ImprimeCuentasBanco(List<CuentaCorriente> banco) // Ejercicio 4
        {
            int i;
            for (i = 0; i < banco.Count; i++)
            {
                Console.WriteLine("Número de cuenta: " + banco[i].numero_cc);
                Console.WriteLine("Nombre del cliente: " + banco[i].cliente);
                Console.WriteLine("Saldo: " + banco[i].saldo);
            }
        }

        /// <summary>
        /// Guarda las cuentas corrientes de la lista en un fichero binario.
        /// </summary>
        /// <param name="banco">Lista de cuentas corrientes.</param>
        /// <param name="datosbanco">Nombre del fichero donde se guardará el contenido de la lista.</param>
        static void GuardarFicheroBanco(List<CuentaCorriente> banco, string ficherobanco) // Ejercicio 5
        {
            int i;

            FileStream fs = new FileStream(ficherobanco, FileMode.Open);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(banco.Count);

            for (i = 0; i < banco.Count; i++)
            {
                bw.Write(banco[i].numero_cc);
                bw.Write(banco[i].cliente);
                bw.Write(banco[i].saldo);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Escribe la lista de cuentas corrientes en un fichero de texto.
        /// </summary>
        /// <param name="lista_alumno">Lista de cuentas corrientes (structs).</param>
        /// <param name="nombrefichero">Nombre del fichero.</param>
        static void GuardarFicheroBancoTXT(List<CuentaCorriente> banco, string nombrefichero) // Ejercicio 5.1
        {
            StreamWriter sw = new StreamWriter(nombrefichero); // abro en modo escritura
            int i;

            sw.WriteLine(banco.Count);

            for (i = 0; i < banco.Count; i++)
            {
                sw.WriteLine(banco[i].numero_cc);
                sw.WriteLine(banco[i].cliente);
                sw.WriteLine(banco[i].saldo);
            }

            sw.Close();
        }

        /// <summary>
        /// Escribe la lista de cuentas corrientes en un fichero csv.
        /// </summary>
        /// <param name="lista_alumno">Lista de cuentas (structs).</param>
        /// <param name="nombrefichero">Nombre del fichero.</param>
        static void GuardarFicheroBancoCSV(List<CuentaCorriente> banco, string nombrefichero) // Ejercicio 5.2
        {
            StreamWriter sw = new StreamWriter(nombrefichero);
            int i;
            for (i = 0; i < banco.Count; i++)
            {
                sw.Write(banco[i].numero_cc);
                sw.Write(";");
                sw.Write(banco[i].cliente);
                sw.Write(";");
                sw.WriteLine(banco[i].saldo);
            }

            sw.Close();
        }

        /// <summary>
        /// Guarda los datos del fichero en la lista.
        /// </summary>
        /// <param name="banco">Lista donde guardaremos los datos del fichero.</param>
        /// <param name="ficherobanco">Fichero de donde leeremos los datos.</param>
        static void LeerFicheroBanco(List<CuentaCorriente> banco, string ficherobanco) // Ejercicio 6
        {
            int i;
            CuentaCorriente nuevo;
            FileStream fs = new FileStream(ficherobanco, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            banco.Clear(); 

            int numero = br.ReadInt32(); 

            for (i = 0; i < numero; i++) 
            {
                nuevo.numero_cc = br.ReadString();
                nuevo.cliente = br.ReadString();
                nuevo.saldo = br.ReadDecimal();
                banco.Add(nuevo);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Guarda los datos de un fichero de texto en una lista.
        /// </summary>
        /// <param name="lista_alumno">Lista de datos donde se guardarán los datos de los ficheros.</param>
        /// <param name="nombrefichero">Fichero con datos.</param>
        static void LeeFicheroBancoTXT(List<CuentaCorriente> banco, string nombrefichero) // Ejercicio 6.1
        {
            StreamReader sr = new StreamReader(nombrefichero, Encoding.Default);
            banco.Clear();

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda los datos de un fichero csv en una lista.
        /// </summary>
        /// <param name="lista_alumno">Lista de datos donde se guardarán los datos de los ficheros.</param>
        /// <param name="nombrefichero">Fichero con datos.</param>
        static void LeeFicheroBancoCSV(List<CuentaCorriente> banco, string nombrefichero) // Ejercicio 6.2
        {
            StreamReader sr = new StreamReader(nombrefichero, Encoding.Default);
            banco.Clear();
            string linea;
            string[] palabras;
            CuentaCorriente nueva;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // guardo en una cadena la línea del archivo
                palabras = linea.Split(';'); // separo los elementos de la línea y los guardo en un array

                nueva.numero_cc = palabras[0];
                nueva.cliente = palabras[1];
                nueva.saldo = decimal.Parse(palabras[2]);

                banco.Add(nueva);
            }

            sr.Close();
        }

        static void Main(string[] args)
        {
            List<CuentaCorriente> banco = new List<CuentaCorriente>();
            int opcion = -1;


            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("MENÚ");
                Console.WriteLine("====");
                Console.WriteLine();
                Console.WriteLine("1.- NuevaCuentaBanco");
                Console.WriteLine("2.- EliminarCuentaBanco");
                Console.WriteLine("3.- ActualizarSaldoBanco");
                Console.WriteLine("4.- ImprimirCuentasBanco");
                Console.WriteLine("5.- GuardarFicheroBanco");
                Console.WriteLine("51.- GuardarFicheroBancoTXT");
                Console.WriteLine("52.- GuardarFicheroBancoCSV");
                Console.WriteLine("6.- LeerFicheroBanco");
                Console.WriteLine("61.- LeerFicheroBancoTXT");
                Console.WriteLine("62.- LeerFicheroBancoCSV");
                Console.WriteLine("0.- Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine(); Console.WriteLine("Has indicado que quieres introducir una nueva cuenta corriente.");
                            Console.WriteLine();
                            NuevaCuentaBanco(banco);
                            Console.WriteLine();
                            Console.WriteLine("Cuenta guardada.");
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {                            
                            Console.WriteLine();
                            EliminarCuentaBanco(banco);
                        }
                        break;
                    case 3:
                        {
                            ActualizarSaldoBanco(banco);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Aquí tienes la lista de cuentas corrientes contenidas en la BD:");
                            Console.WriteLine();
                            ImprimeCuentasBanco(banco);
                        }
                        break;
                    case 5:
                        {
                            string cuentascorrientes;
                            cuentascorrientes = "banco.cc";

                            GuardarFicheroBanco(banco, cuentascorrientes);
                        }                        
                        break;
                    case 51:
                        {
                            GuardarFicheroBancoTXT(banco, "banco.txt");
                        }
                        break;
                    case 52:
                        {
                            GuardarFicheroBancoCSV(banco, "bancocsv.txt");
                        }
                        break;
                    case 6:
                        {
                            string cuentascorrientes;
                            cuentascorrientes = "banco.cc";

                            LeerFicheroBanco(banco, cuentascorrientes);

                            Console.WriteLine("Este es el contenido de la lista tras la lectura del fichero:");
                            Console.WriteLine();

                            ImprimeCuentasBanco(banco);
                        }
                        break;
                    case 61:
                        {
                            LeeFicheroBancoTXT(banco, "banco.txt");
                        }
                        break;
                    case 62:
                        {
                            LeeFicheroBancoCSV(banco, "bancocsv.txt");
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Gracias por utilizar nuestro programa.");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Te has equivocado al pulsar los números. Vuelve a intentarlo.");
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
