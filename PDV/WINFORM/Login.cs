using MIDDLE;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORM
{
    public partial class Login : Form
    {

        public UsuariosConsultas mUsuarioConsultas;
        public Producto mProducto;
        public List<Producto> mProductos;
        public Usuario mUsuario;
        public List<Usuario> mUsuarios;
        public Login()
        {
            mUsuarioConsultas = new UsuariosConsultas();
            mUsuario = new Usuario();
            mUsuarios = new List<Usuario>();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CargarUser(txtUsuario.Text.Trim());
        }
        private void CargarUser(string filtro = "")
        {

            mUsuarios.Clear();
            mUsuarios = mUsuarioConsultas.consultarUser(filtro);

            txtUsuario.Text = mUsuarios[0].Name;

            if (txtUsuario.Text == mUsuarios[0].Name && txtContrasena.Text == mUsuarios[0].Email)
            {
                MessageBox.Show("Usuario valido");
                this.Hide();

                Menu menu = new Menu();

                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario no  valido");
            }


        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
           // txtContrasena.UseSystemPasswordChar = true;
        }
    }
}
