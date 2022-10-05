using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    class Camisa : Prenda
    {
        private Manga manga;
        private Cuello cuello;
        const int DESCUENTO_MANGA_CORTA = 10;
        const int AUMENTO_MAO = 3;

        internal Manga Manga { get => manga; set => manga = value; }
        internal Cuello Cuello { get => cuello; set => cuello = value; }

        public Camisa(int stock, Calidad calidad, Manga manga, Cuello cuello) : base(stock, calidad)
        {
            this.manga = manga;
            this.cuello = cuello;
        }

        public override double ObtenerPrecioFinal()
        {
            double final = this.precioUnitario;
            if (this.manga == Manga.CORTA)
            {
                final -= DESCUENTO_MANGA_CORTA * final / 100;
            }
            if (this.cuello == Cuello.MAO)
            {
                final += AUMENTO_MAO * final / 100;
            }
            final = base.AplicarAumentoCalidad(final);
            return final;
        }
    }
   
  
}
