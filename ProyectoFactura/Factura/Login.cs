using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades;

namespace Factura
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Usuario user;
        string _codigoUsuario = "NCASCO";
        string _Clave = "1234";
        int contador = 0;

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            contador++;
            //contador = contador + 1;

            if (contador == 3)
            {
                MessageBox.Show("Tiene 3 intentos fallidos, la aplicación se cerrará", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (CodigoTextBox.Text == "")
            {
                errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
                CodigoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClaveTextBox, "Ingrese una clave");
                ClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //user = new Usuario(CodigoTextBox.Text, ClaveTextBox.Text);

            UsuarioDatos userDatos = new UsuarioDatos();

            bool usuarioValido = userDatos.ValidarLogin(CodigoTextBox.Text, ClaveTextBox.Text);


            if (usuarioValido)
            {
                MenuDos menu = new MenuDos();
                this.Hide();
                menu.Show();
                //Menu miMenu = new Menu();
                //this.Hide();
                //miMenu.Show();

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }
    }
}
