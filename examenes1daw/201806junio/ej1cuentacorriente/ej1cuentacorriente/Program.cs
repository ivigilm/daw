using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1cuentacorriente
{
    class Program
    {

        /// <summary>
        /// Comprueba que el array introducido forma una cuenta corriente válida.
        /// </summary>
        /// <param name="cuenta">Número de cuenta para comprobar.</param>
        /// <returns>Dígitos de control.</returns>
        static int[] CalculaDigitosControl(int[] cuenta)
        {
            int i;
            int primerdigitodecontrol, segundodigitodecontrol, suma1, suma2;
            int[] resultado = new int[2];
            int[] factores = new int[10] { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            bool correcto = true;
            suma1 = 0;
            suma2 = 0;

            if(cuenta.Length == 20) // el array introducido debe tener 20 elementos
            {
                for(i = 0; i < cuenta.Length; i++) // ningún elemento puede estar fuera del rango 0-9
                {
                    if(cuenta[i] < 0 || cuenta[i] > 9)
                    {
                        correcto = false; // si hay alguno, cuenta incorrecta
                    }
                }                
            }
            else // el array introducido no tiene 20 elementos
            {
                correcto = false; // cuenta incorrecta
            }

            if(correcto == true) // 20 elementos 0-9
            {
                // CALCULAR LOS DOS DÍGITOS DE CONTROL
                
                // PRIMER DÍGITO

                for(i = 0; i < 8; i++) // recorro las 8 primeras posiciones del array
                {
                    suma1 = suma1 + cuenta[i] * factores[i + 2]; // producto de cada dígito (de los 8 primeros) por el factor correspondiente

                    primerdigitodecontrol = 11 - (suma1 % 11);

                    if(primerdigitodecontrol == 10)
                    {
                        primerdigitodecontrol = 1;
                    }
                    else
                    {
                        if(primerdigitodecontrol == 11)
                        {
                            primerdigitodecontrol = 0;
                        }
                    }

                    resultado[0] = primerdigitodecontrol;
                }

                // SEGUNDO DÍGITO

                for(i = 10; i < cuenta.Length; i++) // recorro las últimas 10 posiciones
                {
                    suma2 = suma2 + cuenta[i] * factores[i-10];

                    segundodigitodecontrol = 11 - (suma2 % 11);

                    if(segundodigitodecontrol == 10)
                    {
                        segundodigitodecontrol = 1;
                    }
                    else
                    {
                        if(segundodigitodecontrol == 11)
                        {
                            segundodigitodecontrol = 0;
                        }
                    }

                    resultado[1] = segundodigitodecontrol;
                }
            }
            else
            {
                throw new Exception("El array introducido debe tener 20 elementos entre 0 y 9.");
            }

            return resultado;
        }
        
        /// <summary>
        /// Comprueba si una cuenta corriente es válida.
        /// </summary>
        /// <param name="cuenta">Número de la cuenta para comprobar.</param>
        /// <returns>true si es válida, false si no</returns>
        static bool ValidaCuentaCorriente(int[] cuenta)
        {
            int i;
            int[] digitoscontrol;
            bool valida = true;

            if(cuenta.Length == 20) // comprobación 20 elementos
            {
                for(i = 0; i < cuenta.Length; i++)
                {
                    if(cuenta[i] < 0 || cuenta[i] > 9) // comprobación elementos de un dígito
                    {
                        valida = false;
                    }
                }

                if (valida) // compruebo que los dígitos de control son correctos
                {
                    digitoscontrol = CalculaDigitosControl(cuenta);

                    if(digitoscontrol[0] != cuenta[8] || digitoscontrol[1] != cuenta[9])
                    {
                        valida = false;
                    }
                }
            }
            else // no tiene 20 elementos
            {
                valida = false;
            }

            return valida;
        }
        
        static void Main(string[] args)
        {
            // 1,2,0,6,8,1,3,2,7,4,0,0,0,0,1,9,8,4,3,2
            // 9,5,4,1,0,0,0,1,9,3,0,0,0,0,3,1,5,4,9,8
            // 1,2,3,4,5,6,7,8,0,6,1,2,3,4,5,6,7,8,9,0
            // 1,1,1,1,1,1,1,1,3,0,1,1,1,1,1,1,1,1,1,1
            int[] prueba = new int[] { 9, 5, 4, 1, 0, 0, 0, 1, 9, 3, 0, 0, 0, 0, 3, 1, 5, 4, 9, 8 };

            Console.WriteLine(ValidaCuentaCorriente(prueba));

            Console.ReadKey();
        }
    }
}
