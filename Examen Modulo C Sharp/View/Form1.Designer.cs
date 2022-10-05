namespace Examen_Modulo_C_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.lblNyAVendedor = new System.Windows.Forms.Label();
            this.gboxPrenda = new System.Windows.Forms.GroupBox();
            this.rbtnPantalon = new System.Windows.Forms.RadioButton();
            this.rbtnCamisa = new System.Windows.Forms.RadioButton();
            this.cboxChupin = new System.Windows.Forms.CheckBox();
            this.cboxCuelloMao = new System.Windows.Forms.CheckBox();
            this.cboxMangaCorta = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPremium = new System.Windows.Forms.RadioButton();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gboxPrenda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(49, 24);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(80, 13);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Location = new System.Drawing.Point(450, 24);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(110, 13);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "Direccion de la tienda";
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Location = new System.Drawing.Point(211, 67);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoVendedor.TabIndex = 3;
            this.lblCodigoVendedor.Text = "Codigo vendedor";
            // 
            // lblNyAVendedor
            // 
            this.lblNyAVendedor.AutoSize = true;
            this.lblNyAVendedor.Location = new System.Drawing.Point(49, 67);
            this.lblNyAVendedor.Name = "lblNyAVendedor";
            this.lblNyAVendedor.Size = new System.Drawing.Size(156, 13);
            this.lblNyAVendedor.TabIndex = 2;
            this.lblNyAVendedor.Text = "Nombre y apellido del vendedor";
            // 
            // gboxPrenda
            // 
            this.gboxPrenda.Controls.Add(this.rbtnPantalon);
            this.gboxPrenda.Controls.Add(this.rbtnCamisa);
            this.gboxPrenda.Controls.Add(this.cboxChupin);
            this.gboxPrenda.Controls.Add(this.cboxCuelloMao);
            this.gboxPrenda.Controls.Add(this.cboxMangaCorta);
            this.gboxPrenda.Location = new System.Drawing.Point(52, 147);
            this.gboxPrenda.Name = "gboxPrenda";
            this.gboxPrenda.Size = new System.Drawing.Size(472, 168);
            this.gboxPrenda.TabIndex = 4;
            this.gboxPrenda.TabStop = false;
            this.gboxPrenda.Text = "Prenda";
            // 
            // rbtnPantalon
            // 
            this.rbtnPantalon.AutoSize = true;
            this.rbtnPantalon.Location = new System.Drawing.Point(34, 108);
            this.rbtnPantalon.Name = "rbtnPantalon";
            this.rbtnPantalon.Size = new System.Drawing.Size(67, 17);
            this.rbtnPantalon.TabIndex = 4;
            this.rbtnPantalon.TabStop = true;
            this.rbtnPantalon.Text = "Pantalón";
            this.rbtnPantalon.UseVisualStyleBackColor = true;
            this.rbtnPantalon.CheckedChanged += new System.EventHandler(this.rbtnPantalon_CheckedChanged);
            // 
            // rbtnCamisa
            // 
            this.rbtnCamisa.AutoSize = true;
            this.rbtnCamisa.FlatAppearance.BorderSize = 2;
            this.rbtnCamisa.Location = new System.Drawing.Point(34, 36);
            this.rbtnCamisa.Name = "rbtnCamisa";
            this.rbtnCamisa.Size = new System.Drawing.Size(59, 17);
            this.rbtnCamisa.TabIndex = 3;
            this.rbtnCamisa.TabStop = true;
            this.rbtnCamisa.Text = "Camisa";
            this.rbtnCamisa.UseVisualStyleBackColor = true;
            this.rbtnCamisa.CheckedChanged += new System.EventHandler(this.rbtnCamisa_CheckedChanged);
            // 
            // cboxChupin
            // 
            this.cboxChupin.AutoSize = true;
            this.cboxChupin.Location = new System.Drawing.Point(232, 108);
            this.cboxChupin.Name = "cboxChupin";
            this.cboxChupin.Size = new System.Drawing.Size(61, 17);
            this.cboxChupin.TabIndex = 2;
            this.cboxChupin.Text = "Chupín";
            this.cboxChupin.UseVisualStyleBackColor = true;
            this.cboxChupin.CheckedChanged += new System.EventHandler(this.cboxChupin_CheckedChanged);
            // 
            // cboxCuelloMao
            // 
            this.cboxCuelloMao.AutoSize = true;
            this.cboxCuelloMao.Location = new System.Drawing.Point(359, 36);
            this.cboxCuelloMao.Name = "cboxCuelloMao";
            this.cboxCuelloMao.Size = new System.Drawing.Size(78, 17);
            this.cboxCuelloMao.TabIndex = 1;
            this.cboxCuelloMao.Text = "Cuello mao";
            this.cboxCuelloMao.UseVisualStyleBackColor = true;
            this.cboxCuelloMao.CheckedChanged += new System.EventHandler(this.cboxCuelloMao_CheckedChanged);
            // 
            // cboxMangaCorta
            // 
            this.cboxMangaCorta.AutoSize = true;
            this.cboxMangaCorta.Location = new System.Drawing.Point(232, 36);
            this.cboxMangaCorta.Name = "cboxMangaCorta";
            this.cboxMangaCorta.Size = new System.Drawing.Size(86, 17);
            this.cboxMangaCorta.TabIndex = 0;
            this.cboxMangaCorta.Text = "Manga corta";
            this.cboxMangaCorta.UseVisualStyleBackColor = true;
            this.cboxMangaCorta.CheckedChanged += new System.EventHandler(this.cboxMangaCorta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Unidades de stock disponibles";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(211, 349);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "_______";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPremium);
            this.groupBox1.Controls.Add(this.rbtnStandard);
            this.groupBox1.Location = new System.Drawing.Point(57, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad de Prenda";
            // 
            // rbtnPremium
            // 
            this.rbtnPremium.AutoSize = true;
            this.rbtnPremium.Location = new System.Drawing.Point(101, 44);
            this.rbtnPremium.Name = "rbtnPremium";
            this.rbtnPremium.Size = new System.Drawing.Size(65, 17);
            this.rbtnPremium.TabIndex = 6;
            this.rbtnPremium.TabStop = true;
            this.rbtnPremium.Text = "Premium";
            this.rbtnPremium.UseVisualStyleBackColor = true;
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Location = new System.Drawing.Point(13, 44);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtnStandard.TabIndex = 5;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(324, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio unitario y Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(157, 44);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(37, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(22, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(37, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "$";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "$";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(444, 60);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(116, 26);
            this.btnHistorial.TabIndex = 11;
            this.btnHistorial.Text = "Historial Cotizaciones";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(360, 559);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(127, 13);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "____________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 614);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxPrenda);
            this.Controls.Add(this.lblCodigoVendedor);
            this.Controls.Add(this.lblNyAVendedor);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxPrenda.ResumeLayout(false);
            this.gboxPrenda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.Label lblNyAVendedor;
        private System.Windows.Forms.GroupBox gboxPrenda;
        private System.Windows.Forms.RadioButton rbtnPantalon;
        private System.Windows.Forms.RadioButton rbtnCamisa;
        private System.Windows.Forms.CheckBox cboxChupin;
        private System.Windows.Forms.CheckBox cboxCuelloMao;
        private System.Windows.Forms.CheckBox cboxMangaCorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnPremium;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Label lblResultado;
    }
}

