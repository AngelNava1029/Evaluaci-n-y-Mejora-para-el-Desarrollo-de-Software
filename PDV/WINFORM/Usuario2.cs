using MIDDLE;
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
    public partial class Usuario2 : Form
    {

        public UsuariosConsultas mUsuarioConsultas;
        public Usuario mUsuario;
        public List<Usuario> mUsuarios;
        public Usuario2()
        {
            InitializeComponent();

            mUsuarioConsultas = new UsuariosConsultas();
            mUsuario = new Usuario();
            mUsuarios = new List<Usuario>();

            CargarUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosUsuario();

            if (mUsuarioConsultas.agregarUsuario(mUsuario))
            {
                MessageBox.Show("Usuario agregado");
                CargarUsuarios();
                LimpiarDatosUsuario();
            }
            else
                MessageBox.Show("Error al agregar el usuario");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosUsuario();

            if (mUsuarioConsultas.modificarUsuario(mUsuario))
            {
                MessageBox.Show("usuario modificado");
                CargarUsuarios();
                LimpiarDatosUsuario();
            }
            else
                MessageBox.Show("Error al modificar el usuario");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mUsuarioConsultas.eliminarUsuario(int.Parse(txtCustomerID.Text));

            LimpiarDatosUsuario();

            CargarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menu = new Menu();

            menu.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarUsuarios(textBox1.Text.Trim());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatosUsuario();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            txtCustomerID.Text = Convert.ToString(fila.Cells["CustomerID"].Value);
            txtName.Text = Convert.ToString(fila.Cells["Name"].Value);
            txtEmail.Text = Convert.ToString(fila.Cells["Email"].Value);
            txtPhone.Text = Convert.ToString(fila.Cells["Phone"].Value);
            txtAddress.Text = Convert.ToString(fila.Cells["Address"].Value);
        }
        private bool datosCorrectos()
        {

            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del usuario");
                return false;
            }

            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                return false;
            }


            if (txtPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }
            if (txtAddress.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese una contraseña");
                return false;
            }



            return true;
        }
        private void LimpiarDatosUsuario()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void CargarDatosUsuario()
        {
            mUsuario.CustomerID = getFolioIfExist();
            mUsuario.Name = txtName.Text.Trim();
            mUsuario.Email = txtEmail.Text.Trim();
            mUsuario.Phone = txtPhone.Text.Trim().ToString();
            mUsuario.Address = txtAddress.Text.Trim();

        }
        private void CargarUsuarios(string filtro = "")
        {

            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            mUsuarios.Clear();
            mUsuarios = mUsuarioConsultas.consultarUsuario(filtro);

            for (int i = 0; i < mUsuarios.Count(); i++)
            {

                //dgvUsuarios.RowTemplate.Height = Commun.ROW_HEIGTH;
                dgvUsuarios.Rows.Add(
                    mUsuarios[i].CustomerID,
                    mUsuarios[i].Name,
                    mUsuarios[i].Email,
                    mUsuarios[i].Phone,
                    mUsuarios[i].Address);

            }
        }
        private int getFolioIfExist()
        {
            if (!txtCustomerID.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtCustomerID.Text.Trim(), out int folio))
                    return folio;
                else
                    return -1;
            }
            else
                return -1;
        }
    }
}
