using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        Producto producto;
        BindingList<DetalleFactura> detalles = new BindingList<DetalleFactura>();
        Entidades.Factura factura = new Entidades.Factura();

        decimal isv = 0;
        decimal subTotal = 0;
        decimal descuento = 0;
        decimal total = 0;


        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto(ProductoTextBox.Text, NombreProductoTextBox.Text, 15, 250);

                DetalleFactura detalle = new DetalleFactura();
                detalle.CodigoProducto = producto.Codigo;
                detalle.Descripcion = producto.Nombre;
                detalle.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                detalle.Precio = producto.Precio;
                detalle.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);

                subTotal += detalle.Total;
                isv = subTotal * 0.15M;
                total = subTotal + isv - descuento;

                detalles.Add(detalle);

                DetallesDataGridView.DataSource = null;
                DetallesDataGridView.DataSource = detalles;

                SubTotalTextBox.Text = subTotal.ToString("N2");
                ISVTextBox.Text = isv.ToString("N2");
                TotalTextBox.Text = total.ToString("N2");


                ProductoTextBox.Clear();
                NombreProductoTextBox.Clear();
                CantidadTextBox.Clear();
                ProductoTextBox.Focus();
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            DetallesDataGridView.DataSource = detalles;
        }
    }
}
