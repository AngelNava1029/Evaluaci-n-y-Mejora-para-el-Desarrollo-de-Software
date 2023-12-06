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
using static System.Net.Mime.MediaTypeNames;

namespace WINFORM
{
    public partial class Moto : Form
    {
        private ProductoConsultas mProductoConsultas;
        private Producto mProducto;
        private List<Producto> mProductos;
        public Moto()
        {
            InitializeComponent();
            mProductoConsultas = new ProductoConsultas();
            mProducto = new Producto();
            mProductos = new List<Producto>();

            CargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!datosCorrectos())
                return;

            CargarDatosProducto();

            if (mProductoConsultas.agregarProducto(mProducto))
            {
                MessageBox.Show("Producto agregado");
                CargarProductos();
                LimpiarDatosProducto();
            }
            else
                MessageBox.Show("Error al agregar el producto");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (!datosCorrectos())
                return;

            CargarDatosProducto();

            if (mProductoConsultas.modificarProducto(mProducto))
            {
                MessageBox.Show("Producto modificado");
                CargarProductos();
                LimpiarDatosProducto();
            }
            else
                MessageBox.Show("Error al modificar el producto");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatosProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (getFolioIfExist() == -1)
                return;

            if (MessageBox.Show("¿Desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                CargarDatosProducto();
                if (mProductoConsultas.eliminarProducto(mProducto))
                {
                    MessageBox.Show("Producto eliminado con éxito.");
                    CargarProductos();
                    LimpiarDatosProducto();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.");
                }



            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menu = new Menu();

            menu.Show();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBusqueda.Text.Trim());
        }
        private bool datosCorrectos()
        {

            if (txtName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return false;
            }


            if (txtDescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el precio del producto");
                return false;
            }

            if (!float.TryParse(txtPrice.Text.Trim(), out float precio))
            {
                MessageBox.Show("Ingrese un precio correcto");
                return false;
            }


            if (txtPrice.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese la cantidad");
                return false;
            }


            if (txtQuantityInStock.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese el tipo");
                return false;
            }

            return true;
        }

        private void CargarDatosProducto()
        {
            mProducto.ProductID = getFolioIfExist();
            mProducto.Name = txtName.Text.Trim();
            mProducto.Price = float.Parse(txtPrice.Text.Trim());
            mProducto.QuantityInStock = int.Parse(txtQuantityInStock.Text.Trim());
            mProducto.Description = txtDescription.Text.Trim();
            
            
        }

        private void LimpiarDatosProducto()
        {
            txtProductID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtQuantityInStock.Text = "";
            
        }
        private void CargarProductos(string filtro = "")
        {

            dgvProductos.Rows.Clear();
            dgvProductos.Refresh();
            mProductos.Clear();
            mProductos = mProductoConsultas.consultarProductos(filtro);

            for (int i = 0; i < mProductos.Count(); i++)
            {

             
                dgvProductos.Rows.Add(
                    mProductos[i].ProductID,
                    mProductos[i].Name,
                    mProductos[i].Description,
                    mProductos[i].Price,
                    mProductos[i].QuantityInStock);
                
            }
        }
        private int getFolioIfExist()
        {
            if (!txtProductID.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtProductID.Text.Trim(), out int folio))
                    return folio;
                else
                    return -1;
            }
            else
                return -1;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
            txtProductID.Text = Convert.ToString(fila.Cells["PRODUCTID"].Value);
            txtName.Text = Convert.ToString(fila.Cells["NAME"].Value);
            txtDescription.Text = Convert.ToString(fila.Cells["DESCRIPTION"].Value);
            txtPrice.Text = Convert.ToString(fila.Cells["PRICE"].Value);
            txtQuantityInStock.Text = Convert.ToString(fila.Cells["STOCK"].Value);
            
        }
    }
}
