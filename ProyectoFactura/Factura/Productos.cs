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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        string operacion = "";
        Producto producto;
        BindingList<Producto> listaProductos = new BindingList<Producto>();

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            ExistenciaTextBox.Clear();
            PrecioTextBox.Clear();
        }

        private void LlenarDataGrid()
        {
            ProductosDataGridView.DataSource = null;
            ProductosDataGridView.DataSource = listaProductos;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (CodigoTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CodigoTextBox, "Ingrese el codigo");
                CodigoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (NombreTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese el nombre");
                NombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //Instanciamos el objeto de Producto

            producto = new Producto(CodigoTextBox.Text, NombreTextBox.Text, 
                                Convert.ToInt32(ExistenciaTextBox.Text), Convert.ToDecimal(PrecioTextBox.Text));

            if (operacion == "Nuevo")
            {
                listaProductos.Add(producto);
                LlenarDataGrid();

                DesabilitarControles();
                LimpiarControles();
            }
            else if(operacion == "Modificar")
            {
                foreach (Producto prod in listaProductos)
                {
                    if (CodigoTextBox.Text == prod.Codigo)
                    {
                        prod.Nombre = NombreTextBox.Text;
                        prod.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);
                        prod.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                        break;
                    }
                }
                LlenarDataGrid();
                LimpiarControles();
                DesabilitarControles();
            }

        }

        private void Productos_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();
                CodigoTextBox.Enabled = false;

                CodigoTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                NombreTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ExistenciaTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();
                PrecioTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            DesabilitarControles();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                foreach (Producto prod in listaProductos)
                {
                    if (prod.Codigo == ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString())
                    {
                        listaProductos.Remove(prod);
                        break;
                    }
                }
                LlenarDataGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
