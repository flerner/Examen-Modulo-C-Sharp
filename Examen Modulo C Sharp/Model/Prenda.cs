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

        public Calidad Calidad { get => calidad;  }
        public double PrecioUnitario { set => precioUnitario = value; }
        public int Stock { get => stock; }
        public string ToString()
        {
            return this.GetType().Name + ": Precio: $" + precioUnitario + " Stock: " + stock + " Calidad: " + calidad + "\n";
        }


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
        public Boolean VerificarStockDisponible(int cantidad)
        {
            return this.stock >= cantidad;
        }
        public abstract double ObtenerPrecioFinal();
        
    }
}
