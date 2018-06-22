using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej3pokemon
{
    class Pokemon
    {
        // Atributos

        private int id;
        private string nombre;
        private string tipo;
        private int ataque;
        private int defensa;
        private int vida;
        private int ataqueespecial;
        private int defensaespecial;
        private int velocidad;
        private string habilidad;
        private bool capturado;

        // Constructor
        
        public Pokemon(int id, string nombre, string tipo, int ataque, int defensa, int vida, int ataqueespecial, int defensaespecial, int velocidad, string habilidad, bool capturado)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.ataque = ataque;
            this.defensa = defensa;
            this.vida = vida;
            this.ataqueespecial = ataqueespecial;
            this.defensaespecial = defensaespecial;
            this.velocidad = velocidad;
            this.habilidad = habilidad;
            this.capturado = capturado;
        }

        // Propiedades

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
        }

        public int Ataque
        {
            get
            {
                return ataque;
            }
        }

        public int Defensa
        {
            get
            {
                return defensa;
            }
        }

        public int Vida
        {
            get
            {
                return vida;
            }
        }

        public int Ataqueespecial
        {
            get
            {
                return ataqueespecial;
            }
        }

        public int Defensaespecial
        {
            get
            {
                return defensaespecial;
            }
        }

        public int Velocidad
        {
            get
            {
                return velocidad;
            }
        }

        public string Habilidad
        {
            get
            {
                return habilidad;
            }
        }

        public bool Capturado
        {
            get
            {
                return capturado;
            }

            set
            {
                capturado = value;
            }
        }

        // Métodos

        public override string ToString()
        {
            string ficha = "";

            ficha = "Id:".PadRight(20) + this.id.ToString();
            ficha = ficha + "\n" + "Nombre:".PadRight(20) + this.nombre.ToString();
            ficha = ficha + "\n" + "Tipo:".PadRight(20) + this.tipo.ToString();
            ficha = ficha + "\n" + "Ataque:".PadRight(20) + this.ataque.ToString();
            ficha = ficha + "\n" + "Defensa:".PadRight(20) + this.defensa.ToString();
            ficha = ficha + "\n" + "Vida:".PadRight(20) + this.vida.ToString();
            ficha = ficha + "\n" + "Ataque especial:".PadRight(20) + this.ataqueespecial.ToString();
            ficha = ficha + "\n" + "Defensa especial:".PadRight(20) + this.defensaespecial.ToString();
            ficha = ficha + "\n" + "Velocidad:".PadRight(20) + this.velocidad.ToString();
            ficha = ficha + "\n" + "Habilidad:".PadRight(20) + this.habilidad.ToString();
            ficha = ficha + "\n" + "Capturado:".PadRight(20) + this.capturado.ToString();

            return ficha;
        }

        //
    }
}
