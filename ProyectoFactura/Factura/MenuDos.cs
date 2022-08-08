using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Factura
{
    public partial class MenuDos : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuDos()
        {
            InitializeComponent();
        }
        Usuarios formularioUsuarios;
        Productos formularioProductos;
        Facturacion formularionUevaFactura;

        private void UsuariosToolStripButton_Click(object sender, EventArgs e)
        {
            if (formularioUsuarios == null)
            {
                formularioUsuarios = new Usuarios();
                formularioUsuarios.MdiParent = this;
                formularioUsuarios.FormClosed += FormularioUsuarios_FormClosed;
                formularioUsuarios.Show();
            }
            else
            {
                formularioUsuarios.Activate();
            }
        }

        private void FormularioUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioUsuarios = null;
        }

        private void ProductosToolStripButton_Click(object sender, EventArgs e)
        {
            if (formularioProductos == null)
            {
                formularioProductos = new Productos();
                formularioProductos.MdiParent = this;
                formularioProductos.FormClosed += FormularioProductos_FormClosed;
                formularioProductos.Show();
            }
            else
            {
                formularioProductos.Activate();
            }
        }

        private void FormularioProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioProductos = null;
        }

        private void NuevaFacturaToolStripButton_Click(object sender, EventArgs e)
        {
            if (formularionUevaFactura == null)
            {
                formularionUevaFactura = new Facturacion();
                formularionUevaFactura.MdiParent = this;
                formularionUevaFactura.FormClosed += FormularionUevaFactura_FormClosed;
                formularionUevaFactura.Show();
            }
        }

        private void FormularionUevaFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularionUevaFactura = null;
        }
    }
}
