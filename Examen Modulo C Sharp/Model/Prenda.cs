using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    abstract class Prenda
    {
        protected double precioUnitario;
        protected int stock;
        protected Calidad calidad;

        public Calidad Calidad { get => calidad; set => calidad = value; }
        public double PrecioUnitario { set => precioUnitario = value; }
        public int Stock { get => stock; }
        public string ToString()
        {
            return "Precio: " + precioUnitario + " Stock: " + stock + " Calidad " + calidad;
        }

        /* public int Stock { get => stock;}
         public Calidad Calidad { get => calidad;  }
         public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }*/

        public Prenda(int stock, Calidad calidad)
        {
            this.stock = stock;
            this.calidad = calidad;
        }
        protected double AplicarAumentoCalidad(double precio)
        {
            if (this.calidad == Calidad.PREMIUM)
            {
                precio += precio * 30 / 100;
                
            }
            return precio;
        }
        public abstract double ObtenerPrecioFinal();
        
    }
}
