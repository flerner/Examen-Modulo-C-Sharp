using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Model
{
    class Pantalon: Prenda
    {
        const int DESCUENTO_CHUPIN = 12;
        private Tipo tipo;

        public Pantalon(int stock, Calidad calidad, Tipo tipo) : base(stock, calidad)
        {
            this.tipo = tipo;
        }

        public Tipo Tipo { get => tipo; }

        public override double ObtenerPrecioFinal()
        {
            double final = this.precioUnitario;
            if(this.tipo == Tipo.CHUPIN)
            {
                final -= DESCUENTO_CHUPIN * final / 100;
            }
            final = base.AplicarAumentoCalidad(final);
            return final;
        }
    }
    
}
