using Examen_Modulo_C_Sharp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Modulo_C_Sharp
{
    public partial class Form1 : Form, ICotizador
    {
        CotizadorPresenter presenter;
        public Form1()
        {
            InitializeComponent();
        }
        //implement de interfaz
        #region
        public bool GetInputStandard()
        {
            return rbtnStandard.Checked;
        }
        public bool GetInputPremium()
        {
            return rbtnPremium.Checked;
        }
        public bool GetInputCamisa()
        {
            return rbtnCamisa.Checked;
        }

        public int GetInputCantidad()
        {
            return int.Parse(txtCantidad.Text);
        }

        public bool GetInputChupin()
        {
            return cboxChupin.Checked;
        }

        public bool GetInputCuelloMao()
        {
            return cboxCuelloMao.Checked;
        }

        public bool GetInputMangaCorta()
        {
            return cboxMangaCorta.Checked;
        }

        public bool GetInputPantalon()
        {
            return rbtnPantalon.Checked;
        }

        public int GetInputPrecioUnitario()
        {
            return int.Parse(txtPrecio.Text);
        }

        public void PrecioTotal(string precioTotal)
        {
            lblResultado.Text = precioTotal;
        }

        public void StockDisponible(string stockDisponible)
        {
            lblStock.Text = stockDisponible;
        }

        public void DatosTienda(string nombre, string direccion)
        {
            lblNombreTienda.Text = nombre;
            lblDireccionTienda.Text = direccion;
        }
        public void DatosVendedor(string nombre, string apellido, int codigo)
        {
            lblCodigoVendedor.Text = "ID: " + codigo.ToString();
            lblNyAVendedor.Text = nombre + " " + apellido;
        }
        public void MensajeErrorStock(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        public void MostrarHistorial(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            presenter = new CotizadorPresenter(this);
        }

        private void rbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked)
            {
                cboxChupin.Enabled = false;
                cboxCuelloMao.Enabled = true;
                cboxMangaCorta.Enabled = true;
            }
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Checked)
            {
                cboxChupin.Enabled = true;
                cboxCuelloMao.Enabled = false;
                cboxMangaCorta.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidarIngresoInvalido())
            {
                
                    presenter.Cotizar();
                
            }
            else
            {
                MessageBox.Show("Ingresaste mal algun dato");
            }

        }

        private Boolean ValidarIngresoInvalido()
        {
            Boolean esValido = true;
            int precio;
            int cantidad;
            try
            {
                precio = int.Parse(txtPrecio.Text);
                cantidad = int.Parse(txtCantidad.Text);
            }
            catch (FormatException e)
            {
                esValido = false;
                return esValido;
            }
            esValido = precio > 0 && cantidad > 0;

            if (esValido)
            {

                if (!rbtnPantalon.Checked && !rbtnCamisa.Checked)
                {
                    esValido = false;
                }
                if (esValido)
                {
                    if(!rbtnStandard.Checked && !rbtnPremium.Checked)
                    {
                        esValido = false;
                    }
                }               
            }
            return esValido;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            presenter.MostrarHistorial();
        }
    }
}
