using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoventa
{
    class Coche
    {
        // Atributos (privados)

        private string matricula;
        private DateTime fechaMatriculacion;
        private string marca;
        private string modelo;
        private decimal precio;

        // Constructor
        
        public bool EsMatricula(string cadena) // DEBERÍA SER PRIVADO Y ESTÁTICO: private static bool EsMatricula(string matricula)
        {
            bool esmatricula = true; // 1234 ABC
            int i;
            string numeros = "0123456789";
            string abecedario = "abcdefghijklmnñopqrstuvwxyz";

            if(cadena.Length != 7)
            {
                esmatricula = false;
            }
            else
            {
                for (i = 0; i < 4; i++)
                {
                    if (!numeros.Contains(cadena[i])) // if (!char.IsDigit(cadena[i]))
                    {
                        esmatricula = false;
                    }
                }

                cadena = cadena.ToLower();

                for (i = 4; i < 7; i++)
                {
                    if (!abecedario.Contains(cadena[i])) // if (!char.IsLetter(cadena[i]))
                    {
                        esmatricula = false;
                    }
                }
            }        

            return esmatricula;
        }
        
        public Coche(string matricula, DateTime fechaMatriculacion, string marca, string modelo, decimal precio)
        {
            if (EsMatricula(matricula)) // matricula = 1111AAA
            {
                this.matricula = matricula;
            }
            else
            {
                throw new Exception("Formato de matrícula inválido.");
            }

            this.fechaMatriculacion = fechaMatriculacion; // el tipo de dato DateTime comprueba que la fecha introducida existe (no es el 40 de mayo)
            
            if(marca != "")
            {
                this.marca = marca;
            }
            else
            {
                throw new Exception("La marca no puede quedar vacía.");
            }

            if(modelo != "")
            {
                this.modelo = modelo;
            }
            else
            {
                throw new Exception("El modelo no puede quedar vacío.");
            }

            if(precio >= 500)
            {
                this.precio = precio;
            }
            else
            {
                throw new Exception("¡El precio debe ser al menos de 500€!");
            }
        }

        // Propiedades

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        public DateTime FechaMatriculacion
        {
            get
            {
                return this.fechaMatriculacion;
            }
        }

        public string Marca
        {
            get
            {
                return this.marca;
            }
        }

        public string Modelo
        {
            get
            {
                return this.modelo;
            }
        }

        public decimal Precio
        {
            get
            {
                return this.precio;
            }

            set
            {
                if(value >= 500)
                {
                    this.precio = value;
                }
                else
                {
                    throw new Exception("El precio debe ser de al menos 500€.");
                }
            }
        }
    }
}
