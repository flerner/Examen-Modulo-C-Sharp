using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    class Cotizacion
    {
        private int id;
        private DateTime fechaYHora;
        private Prenda prendaCotizada;
        private int idVendedor;
        private int cantUnidades;
        private double resultado;

        public Cotizacion(int id, DateTime fechaYHora, int idVendedor, int cantUnidades, Prenda prendaCotizada)
        {
            this.id = id;
            this.fechaYHora = fechaYHora;
            this.idVendedor = idVendedor;
            this.cantUnidades = cantUnidades;
            this.prendaCotizada = prendaCotizada;
        }

        public double Resultado { get => resultado;  }

        public void Cotizar()
        {
            this.resultado = prendaCotizada.ObtenerPrecioFinal() * cantUnidades;
 
        }

       public string ToString()
        {
            return "Id de la cotizacion: " + id + ". Fecha y hora: " + fechaYHora + "\nPrenda Cotizada: " + prendaCotizada.ToString() + "Id Vendedor: " + idVendedor + " cantidad de unidades " + cantUnidades + " Total: $" + resultado + " \n\n";
        }

    }
}
