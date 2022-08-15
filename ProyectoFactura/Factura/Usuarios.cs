using Datos;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        BindingList<Usuario> listaUsuarios = new BindingList<Usuario>();
        Usuario user;

        UsuarioDatos userDatos = new UsuarioDatos();


        private void ListarUsuarios()
        {
            UsuariosDataGridView.DataSource = null;
            //UsuariosDataGridView.DataSource = listaUsuarios;
            UsuariosDataGridView.DataSource = userDatos.DevolverTodos();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            ClaveTextBox.Enabled = true;
            CorreoTextBox.Enabled = true;
            TelefonoTextBox.Enabled = true;

            AdjuntarFotoButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            ClaveTextBox.Enabled = false;
            CorreoTextBox.Enabled = false;
            TelefonoTextBox.Enabled = false;
            AdjuntarFotoButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Text = "";
            ClaveTextBox.Text = string.Empty;
            CorreoTextBox.Clear();
            TelefonoTextBox.Clear();
            FotoPictureBox.Image = null;
        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (CodigoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                CodigoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                NombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //FotoPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            //Creamos un objeto de la clase Usuario

            user = new Usuario();
            user.Codigo = CodigoTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Clave = ClaveTextBox.Text;
            user.Correo = CorreoTextBox.Text;
            user.Telefono = TelefonoTextBox.Text;
            //user.Foto = ms.GetBuffer();


            if (operacion == "Nuevo")
            {
                //listaUsuarios.Add(user);

                bool inserto = userDatos.Nuevo(user);
                if (inserto)
                {
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("Usuario creado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el usuario");
                }

                
            }
            else if(operacion == "Modificar")
            {
                //foreach (Usuario item in listaUsuarios)
                //{
                //    if (item.Codigo == CodigoTextBox.Text)
                //    {
                //        item.Nombre = NombreTextBox.Text;
                //        item.Clave = ClaveTextBox.Text;
                //        item.Correo = CorreoTextBox.Text;
                //        item.Telefono = TelefonoTextBox.Text;
                        
                //    }
                //}

                bool modifico = userDatos.Actualizar(user);
                if (modifico)
                {
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                    MessageBox.Show("Usuario actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario");
                }
                
            }
            
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();
                CodigoTextBox.Enabled = false;

                CodigoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                NombreTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                ClaveTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Clave"].Value.ToString();
                CorreoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Email"].Value.ToString();
                //TelefonoTextBox.Text = UsuariosDataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                //FotoPictureBox.Image = (byte[])UsuariosDataGridView.CurrentRow.Cells["Foto"].Value;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Alarte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedRows.Count > 0)
            {
                bool elimino = userDatos.Eliminar(UsuariosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    ListarUsuarios();
                    MessageBox.Show("Usuario eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("Usuario no se pudo eliminar");
                }

                //foreach (var user in listaUsuarios)
                //{
                //    if (user.Codigo == UsuariosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString())
                //    {
                //        listaUsuarios.Remove(user);
                //        break;
                //    }
                //}
            }
            
        }

        private void AdjuntarFotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                FotoPictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
