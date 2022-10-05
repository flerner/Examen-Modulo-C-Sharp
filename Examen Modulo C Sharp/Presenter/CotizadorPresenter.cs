using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Modulo_C_Sharp.Presenter
{
    class CotizadorPresenter
    {
        ICotizador icotizador;
        Model.Tienda tienda;
        Model.Vendedor vendedor;
        const string MENSAJE_ERROR = "La cantidad deseada supera al stock con el que contamos... \nNuestro stock para esta prenda es de ";
        public CotizadorPresenter(ICotizador icotizador)
        {
            this.icotizador = icotizador;

            InstanciarObjetos();
            EstablecerTitulos();
        }
        private void EstablecerTitulos()
        {
            icotizador.DatosTienda(tienda.Nombre, tienda.Direccion);
            icotizador.DatosVendedor(vendedor.Nombre, vendedor.Apellido, vendedor.IdVendedor);
        }
        private void InstanciarObjetos()
        {
            this.vendedor = new Model.Vendedor("Juan", "Carlos", 23);
            List<Model.Prenda> prendas = new List<Model.Prenda>();
            //CAMISAS
            //500 MANGA CORTA
            prendas.Add(new Model.Camisa(100, Model.Calidad.STANDARD, Model.Manga.CORTA, Model.Cuello.MAO));
            prendas.Add(new Model.Camisa(100, Model.Calidad.PREMIUM, Model.Manga.CORTA, Model.Cuello.MAO));
            prendas.Add(new Model.Camisa(150, Model.Calidad.STANDARD, Model.Manga.CORTA, Model.Cuello.COMUN));
            prendas.Add(new Model.Camisa(150, Model.Calidad.PREMIUM, Model.Manga.CORTA, Model.Cuello.COMUN));
            //500 MANGA LARGA
            prendas.Add(new Model.Camisa(75, Model.Calidad.PREMIUM, Model.Manga.LARGA, Model.Cuello.MAO));
            prendas.Add(new Model.Camisa(75, Model.Calidad.STANDARD, Model.Manga.LARGA, Model.Cuello.MAO));
            prendas.Add(new Model.Camisa(175, Model.Calidad.PREMIUM, Model.Manga.LARGA, Model.Cuello.COMUN));
            prendas.Add(new Model.Camisa(175, Model.Calidad.STANDARD, Model.Manga.LARGA, Model.Cuello.COMUN));

            //PANTALONES
            //chupines
            prendas.Add(new Model.Pantalon(750, Model.Calidad.STANDARD, Model.Tipo.CHUPIN));
            prendas.Add(new Model.Pantalon(750, Model.Calidad.PREMIUM, Model.Tipo.CHUPIN));
            //comunes
            prendas.Add(new Model.Pantalon(250, Model.Calidad.PREMIUM, Model.Tipo.COMUN));
            prendas.Add(new Model.Pantalon(250, Model.Calidad.STANDARD, Model.Tipo.COMUN));


            this.tienda = new Model.Tienda("Armando Lio", "Cabildo 100", vendedor, prendas);
            vendedor.AgregarTienda(tienda);
        }
        public Boolean VerificarInputCantidad(Model.Prenda prenda)
        {
           return prenda.VerificarStockDisponible(icotizador.GetInputCantidad());
        }
        public void Cotizar()
        {
            Model.Prenda prenda = BuscarPrenda();
          
            if (VerificarInputCantidad(prenda))
            {
                prenda.PrecioUnitario = icotizador.GetInputPrecioUnitario();
                double total = vendedor.Cotizar(icotizador.GetInputPrecioUnitario(), icotizador.GetInputCantidad(), prenda);
                icotizador.PrecioTotal(total.ToString());
            }
            else
            {
                icotizador.MensajeErrorStock(MENSAJE_ERROR + prenda.Stock.ToString());
            }
        }
        public void ActualizarStockView()
        {
            Model.Prenda prenda = BuscarPrenda();
            icotizador.StockDisponible(prenda.Stock.ToString());
        }

        //devuelve referencia a la instancia actual de la prenda
        private Model.Prenda BuscarPrenda()
        {
            Model.Prenda prenda = null;
            Model.Calidad calidad;         
            if (icotizador.GetInputPremium())
            {
                calidad = Model.Calidad.PREMIUM;
            }
            else calidad = Model.Calidad.STANDARD;
            if (icotizador.GetInputCamisa())
            {
                Model.Cuello cuello;
                Model.Manga manga;
                if (icotizador.GetInputCuelloMao())
                {
                    cuello = Model.Cuello.MAO;
                }
                else cuello = Model.Cuello.COMUN;
                if (icotizador.GetInputMangaCorta())
                {
                    manga = Model.Manga.CORTA;
                }
                else manga = Model.Manga.LARGA;
                prenda = tienda.BuscarCamisa(manga, cuello, calidad);
            }
            if (icotizador.GetInputPantalon())
            {
                Model.Tipo tipo;
                if (icotizador.GetInputChupin())
                {
                    tipo = Model.Tipo.CHUPIN;
                }
                else tipo = Model.Tipo.COMUN;
                prenda = tienda.BuscarPantalon(tipo, calidad);
            }
            return prenda;
        }
        public void MostrarHistorial()
        {
            string mensaje = "";
            foreach(Model.Cotizacion c in vendedor.Cotizaciones)
            {
                mensaje += c.ToString()+"\n";
            }
            icotizador.MostrarHistorial(mensaje);
        }

    }
}
