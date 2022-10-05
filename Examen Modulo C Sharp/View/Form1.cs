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
            presenter.ActualizarStockView();
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Checked)
            {
                cboxChupin.Enabled = true;
                cboxCuelloMao.Enabled = false;
                cboxMangaCorta.Enabled = false;
            }
            presenter.ActualizarStockView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ValidarIngreso())
            {

                presenter.Cotizar();

            }


        }

        private Boolean ValidarIngreso()
        {
            Boolean esValido = true;        

            if (!rbtnPantalon.Checked && !rbtnCamisa.Checked)
            {
                esValido = false;
                MessageBox.Show("Ingrese un tipo de prenda...");
            }
            if (esValido)
            {
                if (!rbtnStandard.Checked && !rbtnPremium.Checked)
                {
                    esValido = false;
                    MessageBox.Show("Ingrese una calidad...");
                }
            }
            //valido entradas de texto formato correcto mayor a 0
            if (Utiles.Validar(txtCantidad.Text, "int") && int.Parse(txtCantidad.Text) > 0)
            {
                txtCantidad.BackColor = System.Drawing.Color.White;
            }
            else
            {
                esValido = false;
                txtCantidad.BackColor = System.Drawing.Color.Red;
            }
            if (Utiles.Validar(txtPrecio.Text, "int") && int.Parse(txtPrecio.Text) > 0)
            {
                txtPrecio.BackColor = System.Drawing.Color.White;
            }
            else
            {
                esValido = false;
                txtPrecio.BackColor = System.Drawing.Color.Red;
            }


            return esValido;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            presenter.MostrarHistorial();
        }

        //actualizo lbl de stock cada vez que cambia algo
        #region
        private void cboxMangaCorta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked)
            {
                presenter.ActualizarStockView();
            }
        }

        private void cboxCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked)
            {
                presenter.ActualizarStockView();
            }
        }

        private void cboxChupin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Checked)
            {
                presenter.ActualizarStockView();
            }
        }


        #endregion
    }
}
