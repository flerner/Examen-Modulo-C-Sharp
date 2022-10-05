using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Presenter
{
    interface ICotizador
    {
        Boolean GetInputCamisa();
        Boolean GetInputPantalon();
        Boolean GetInputMangaCorta();
        Boolean GetInputCuelloMao();
        Boolean GetInputChupin();
        Boolean GetInputStandard();
        Boolean GetInputPremium();
        int GetInputPrecioUnitario();
        int GetInputCantidad();
        void PrecioTotal(string precioTotal);
        void StockDisponible(string stockDisponible);
        void MensajeErrorStock(string mensaje);
        void DatosTienda(string nombreTienda, string direccionTienda);
        void DatosVendedor(string nombre, string apellido, int codigo);
        void MostrarHistorial(string mensaje);
       
        
    }
}
