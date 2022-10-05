using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int idVendedor;
        private Tienda tienda;
        private List<Cotizacion> cotizaciones;
        int generadorID;
        public Vendedor(string nombre, string apellido, int idVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.idVendedor = idVendedor;
            this.cotizaciones = new List<Cotizacion>();
            generadorID = 0;
        }

        public string Nombre { get => nombre; }
        public string Apellido { get => apellido;  }
        public int IdVendedor { get => idVendedor;  }
        public List<Cotizacion> Cotizaciones { get => cotizaciones; }

        public void AgregarTienda(Tienda tienda)
        {
            if (this.tienda == null)
            {
                this.tienda = tienda;
            }
        }
        public double Cotizar(int cantidad, Prenda prenda)
        {
            Cotizacion cotizacion = new Cotizacion(generadorID, DateTime.UtcNow, this.idVendedor, cantidad, prenda);
            cotizacion.Cotizar();
            cotizaciones.Add(cotizacion);
            generadorID++;
            return cotizacion.Resultado;
        }
    }
}
