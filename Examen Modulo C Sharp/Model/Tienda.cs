using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> prendas;
        private Vendedor vendedor;

        public Tienda(string nombre, string direccion, Vendedor vendedor, List<Prenda> prendas)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.vendedor = vendedor;
            this.prendas = prendas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }

        public Prenda BuscarCamisa(Manga manga, Cuello cuello, Calidad calidad)
        {
            int i = 0;
            Prenda prenda = null;
            while (i < prendas.Count && prenda == null)
            {
                if (prendas[i].GetType() == typeof(Camisa) &&
                    ((Camisa)prendas[i]).Cuello == cuello &&
                    ((Camisa)prendas[i]).Manga == manga &&
                    prendas[i].Calidad == calidad)
                {
                    prenda = prendas[i];
                }
                else
                {
                    i++;
                }
            }
            return prenda;
        }
        public Prenda BuscarPantalon(Tipo tipo, Calidad calidad)
        {
            int i = 0;
            Prenda prenda = null;
            while (i < prendas.Count && prenda == null)
            {
                if (prendas[i].GetType() == typeof(Pantalon) &&
                    ((Pantalon)prendas[i]).Tipo == tipo &&
                    prendas[i].Calidad == calidad)
                {
                    prenda = prendas[i];
                }
                else
                {
                    i++;
                }
            }
            return prenda;
        }
    }
}
