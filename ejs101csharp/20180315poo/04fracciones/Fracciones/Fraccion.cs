using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Fraccion // Fracción
    {
        // Atributos: numerador y denominador (enteros)

        private int numerador;
        private int denominador;

        // Constructores

        /// <summary>
        /// Crea una fracción, dados numerador y denominador.
        /// </summary>
        /// <param name="numerador">Numerador de la fracción que se va a crear.</param>
        /// <param name="denominador">Denominador de la fracción que se va a crear.</param>
        public Fraccion(int numerador, int denominador)
        {
            if(denominador == 0)
            {
                throw new Exception("¡El denominador no puede ser 0!");
            }
            else
            {
                this.numerador = numerador;
                this.denominador = denominador;
            }
        }

        /// <summary>
        /// Crea una fracción, dado el cociente.
        /// </summary>
        /// <param name="cociente">Cociente resultado de didivir numerador entre denominador.</param>
        public Fraccion(int cociente)
        {
            this.numerador = cociente;
            this.denominador = 1;
        }

        /// <summary>
        /// Crea una fracción dado el número real que sería su cociente.
        /// </summary>
        /// <param name="cociente">Resultado decimal de la división numerador/denominador.</param>
        public Fraccion(double cociente)
        {
            double numeradorauxiliar = cociente;
            double denominadorauxiliar = 1;
            // this.denominador = 1;

            while (numeradorauxiliar != Math.Truncate(numeradorauxiliar)) // mientras el numerador tenga decimales
            {
                numeradorauxiliar = numeradorauxiliar * 10;
                denominadorauxiliar = denominadorauxiliar * 10;
                // this.denominador = this.denominador * 10;
            }

            this.numerador = Convert.ToInt32(numeradorauxiliar);
            this.denominador = Convert.ToInt32(denominadorauxiliar);
        }

        // Métodos

        /// <summary>
        /// Halla el máximo común divisor de dos números dados.
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Máximo común divisor de n1 y n2.</returns>
        private int MaximoComunDivisor(int n1, int n2)
        {
            int  menor, i, mcd;
            mcd = -1;
            
            if (n1 >= n2)
            {
                menor = n2;
            }
            else
            {
                menor = n1;
            }

            for (i = menor; i > 0; i--)
            {
                if ((n1 % i == 0) && (n2 % i == 0))
                {
                    mcd = i;
                    break;
                }
            }

            return mcd;
        }

        /// <summary>
        /// Halla el mínimo común múltiplo de dos números dados.
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Mínimo común múltiplo de n1 y n2.</returns>
        private int MinimoComunMultiplo(int n1, int n2)
        {
            int mayor, i;
            
            if (n1 >= n2)
            {
                mayor = n1;
            }
            else
            {
                mayor = n2;
            }

            i = mayor;            

            while ((i % n1 != 0) || (i % n2 != 0))
            {
                i = i + 1;
            }

            return i;
        }

        /// <summary>
        /// Simplifica una fracción (divide numerador y denominador entre el máximo común divisor).
        /// </summary>
        public void Simplificar()
        {
            int mcd = MaximoComunDivisor(this.numerador, this.denominador);
            this.numerador = this.numerador / mcd;
            this.denominador = this.denominador / mcd;
        }

        /// <summary>
        /// Transforma numerador y denominador en una cadena del tipo "n/d".
        /// </summary>
        /// <returns>Cadena del tipo "n/d", donde "n" será el numerador y "d" el denominador.</returns>
        public override string ToString()
        {
            string nombre;

            nombre = this.numerador + "/" + this.denominador;

            return nombre;
        }

        // Propiedades

        /// <summary>
        /// Devuelve el double correspondiente al valor de la fracción.
        /// </summary>
        public double ValorDouble
        {
            get
            {
                return Convert.ToDouble(this.numerador) / Convert.ToDouble(this.denominador);
            }
        }

        /// <summary>
        /// Devuelve o modifica el numerador.
        /// </summary>
        public int Numerador
        {
            get
            {
                return this.numerador;
            }
            set
            {
                this.numerador = value;
            }
        }

        /// <summary>
        /// Devuelve o modifica el denominador.
        /// </summary>
        public int Denominador
        {
            get
            {
                return this.denominador;
            }
            set
            {
                if(value != 0)
                {
                    this.denominador = value;
                }
                else
                {
                    throw new Exception("¡El denominador no puede ser 0!");
                }

            }
        }


        // Operadores

        /// <summary>
        /// Suma dos fracciones.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>Fracción resultado de la suma.</returns>
        public static Fraccion operator +(Fraccion n1, Fraccion n2)
        {
            Fraccion solucion;
            int numeradorsolucion, denominadorsolucion;

            if (n1.denominador == n2.denominador)
            {
                numeradorsolucion = n1.numerador + n2.numerador;
                denominadorsolucion = n1.denominador;
            }
            else
            {
                numeradorsolucion = n1.numerador * n2.denominador + n1.denominador * n2.numerador;
                denominadorsolucion = n1.denominador * n2.denominador;
            }

            solucion = new Fraccion(numeradorsolucion, denominadorsolucion);
            // solucion.Simplificar();

            return solucion;
        }

        /// <summary>
        /// Resta dos fracciones.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>Fracción resultado de la resta.</returns>
        public static Fraccion operator -(Fraccion n1, Fraccion n2)
        {
            Fraccion solucion;
            int numeradorsolucion, denominadorsolucion;

            if (n1.denominador == n2.denominador)
            {
                numeradorsolucion = n1.numerador - n2.numerador;
                denominadorsolucion = n1.denominador;
            }
            else
            {
                numeradorsolucion = n1.numerador * n2.denominador - n1.denominador * n2.numerador;
                denominadorsolucion = n1.denominador * n2.denominador;
            }

            solucion = new Fraccion(numeradorsolucion, denominadorsolucion);
            // solucion.Simplificar();

            return solucion;
        }

        /// <summary>
        /// Producto de dos fracciones.
        /// </summary>
        /// <param name="n1">Primera fracción</param>
        /// <param name="n2">Segunda fracción</param>
        /// <returns>Fracción resultado del producto.</returns>
        public static Fraccion operator *(Fraccion n1, Fraccion n2)
        {
            Fraccion solucion;
            int numeradorsolucion, denominadorsolucion;

            numeradorsolucion = n1.numerador*n2.numerador;
            denominadorsolucion = n1.denominador * n2.denominador;

            solucion = new Fraccion(numeradorsolucion, denominadorsolucion);
            // solucion.Simplificar();

            return solucion;
        }

        /// <summary>
        /// División de dos fracciones.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>Fracción resultado de la división.</returns>
        public static Fraccion operator /(Fraccion n1, Fraccion n2)
        {
            Fraccion solucion;
            int numeradorsolucion, denominadorsolucion;

            numeradorsolucion = n1.numerador * n2.denominador;
            denominadorsolucion = n1.denominador * n2.numerador;

            solucion = new Fraccion(numeradorsolucion, denominadorsolucion);
            // solucion.Simplificar();

            return solucion;
        }

        /// <summary>
        /// Comprueba si una fracción es menor que otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si la primera fracción es menor, "false" si no</returns>
        public static bool operator <(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble < n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si una fracción es mayor que otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si la primera fracción es mayor, "false" si no</returns>
        public static bool operator >(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble > n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si una fracción es igual que otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si ambas fracciones son iguales (si tienen igual valor), "false" si no</returns>
        public static bool operator ==(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble == n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si una fracción es menor o igual que otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si la primera fracción es menor o igual, "false" si no</returns>
        public static bool operator <=(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble <= n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si una fracción es mayor o igual que otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si la primera fracción es mayor o igual que la segunda, "false" si no</returns>
        public static bool operator >=(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble >= n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comprueba si una fracción es distinta a la otra.
        /// </summary>
        /// <param name="n1">Primera fracción.</param>
        /// <param name="n2">Segunda fracción.</param>
        /// <returns>"true" si ambas fracciones son distintas, "false" si no</returns>
        public static bool operator !=(Fraccion n1, Fraccion n2)
        {
            if (n1.ValorDouble != n2.ValorDouble)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Convierte un número entero en fraccionario.
        /// </summary>
        /// <param name="n">Número entero introducido para conversión.</param>
        public static implicit operator Fraccion(int n)
        {
            Fraccion nueva = new Fraccion(n, 1);
            return nueva;
        }

        
    }
}
