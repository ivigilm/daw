using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longitud
{
    enum UnidadLongitud
    {
        metros, pulgadas, pies, yardas
    }

    class Longitud
    {
        // Atributos

        private double cantidad;
        private UnidadLongitud unidad;
        
        // Constructores

        public Longitud(int cantidad, UnidadLongitud unidad)
        {
            this.cantidad = Convert.ToDouble(cantidad);
            this.unidad = unidad;
        }

        public Longitud(double cantidad, UnidadLongitud unidad)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
        }

        // Propiedades

        public double Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public UnidadLongitud Unidad
        {
            get
            {
                return this.unidad;
            }
        }
        
        public double ValorEnMetros
        {
            get
            {
                double unidadenmetros;
                
                switch (this.unidad)
                {
                    case UnidadLongitud.metros:
                        {
                            unidadenmetros = this.cantidad;
                        }
                        break;
                    case UnidadLongitud.pies:
                        {
                            unidadenmetros = this.cantidad * 0.3048;
                        }
                        break;
                    case UnidadLongitud.pulgadas:
                        {
                            unidadenmetros = this.cantidad * 0.0254;
                        }
                        break;
                    case UnidadLongitud.yardas:
                        {
                            unidadenmetros = this.cantidad * 0.9144;
                        }
                        break;
                    default:
                        throw new Exception("Unidad no contemplada.");
                }

                return unidadenmetros;
            }
        }

        // Métodos
        
        public override string ToString()
        {
            string longitudformateada, unidades;
            unidades = "";

            switch (this.unidad)
            {
                case UnidadLongitud.metros:
                    unidades = "m";
                    break;
                case UnidadLongitud.pies:
                    unidades = "ft";
                    break;
                case UnidadLongitud.pulgadas:
                    unidades = "in";
                    break;
                case UnidadLongitud.yardas:
                    unidades = "yd";
                    break;
                default:
                    throw new Exception("No existe la unidad");
            }

            longitudformateada = Convert.ToString(this.cantidad) + unidades;

            return longitudformateada;
        }

        /* Otra forma de hacer el ToSTring()
         
            string resultado = this.cantidad.ToString() + " ";
            int indice = (int)this.unidad;
            string[] unidades = { "m", "in", "ft", "yd" };
            resultado = resultado + unidades[indice];
            return resultado;
        */

        // Operadores

        public static Longitud operator +(Longitud l1, Longitud l2)
        {
            Longitud suma;
            double cant;
            UnidadLongitud ud;

            if(l1.unidad == l2.unidad)
            {
                cant = l1.cantidad + l2.cantidad;
                ud = l1.unidad;
            }
            else
            {
                cant = l1.ValorEnMetros + l2.ValorEnMetros;
                ud = UnidadLongitud.metros;
            }

            suma = new Longitud(cant, ud);

            return suma;
        }

        public static Longitud operator -(Longitud l1, Longitud l2)
        {
            Longitud resta;
            double cant;
            UnidadLongitud ud;

            if (l1.unidad == l2.unidad)
            {
                cant = l1.cantidad - l2.cantidad;
                ud = l1.unidad;
            }
            else
            {
                cant = l1.ValorEnMetros - l2.ValorEnMetros;
                ud = UnidadLongitud.metros;
            }

            resta = new Longitud(cant, ud);

            return resta;
        }

        /*
        
            public static Longitud operator -(Longitud l1, Longitud l2)
            {
            Longitud l2neg = new Longitud(-l2.cantidad, l2.unidad);
            return l1 + l2neg;
            }
             
        */

        // Para que funcionen * y / hay que crear dos operadores: (Longitud, double) y (double, Longitud)

        public static Longitud operator *(Longitud l1, double n)
        {
            Longitud producto;
            double cant;
            UnidadLongitud ud;

            cant = l1.cantidad * n;
            ud = l1.unidad;

            producto = new Longitud(cant, ud);

            return producto;
        }
        
        public static Longitud operator /(Longitud l1, double n)
        {
            Longitud cociente;
            double cant;
            UnidadLongitud ud;

            cant = l1.cantidad / n;
            ud = l1.unidad;

            cociente = new Longitud(cant, ud);

            return cociente;
        }

        public static bool operator ==(Longitud l1, Longitud l2)
        {
            bool igual = false;

            if(l1.ValorEnMetros == l2.ValorEnMetros)
            {
                igual = true;
            }

            return igual;
        }

        public static bool operator !=(Longitud l1, Longitud l2)
        {
            bool distinto = false;

            if (l1.ValorEnMetros != l2.ValorEnMetros)
            {
                distinto = true;
            }

            return distinto;
        }

        public static bool operator <(Longitud l1, Longitud l2)
        {
            bool menor = false;

            if(l1.ValorEnMetros < l2.ValorEnMetros)
            {
                menor = true;
            }

            return menor; // return (! l1 >= l2)
        }

        public static bool operator >(Longitud l1, Longitud l2)
        {
            bool mayor = false;

            if(l1.ValorEnMetros > l2.ValorEnMetros)
            {
                mayor = true;
            }

            return mayor; // return (l1.ValorEnMetros > l2.ValorEnMetros); ESTA ES LA ÚNICA LÍNEA QUE HACE FALTA
        }
        
        public static bool operator <=(Longitud l1, Longitud l2)
        {
            bool menoroigual = false;

            if (l1.ValorEnMetros <= l2.ValorEnMetros)
            {
                menoroigual = true;
            }

            return menoroigual;
        }

        public static bool operator >=(Longitud l1, Longitud l2)
        {
            bool mayoroigual = false;

            if (l1.ValorEnMetros >= l2.ValorEnMetros)
            {
                mayoroigual = true;
            }

            return mayoroigual; // return (l1 > l2) || (l1 == l2) ESTA ES LA ÚNICA LÍNEA QUE HACE FALTA
        }
        
        public static implicit operator Longitud(int n)
        {
            Longitud nueva = new Longitud(Convert.ToDouble(n), UnidadLongitud.metros);
            return nueva;
            // también se podría poner directamente
            // return new Longitud(Convert.ToDouble(n), UnidadLongitud.metros);
        }

        public static implicit operator Longitud(double n)
        {
            Longitud nueva = new Longitud(n, UnidadLongitud.metros);
            return nueva;
        }
                
    }
}
