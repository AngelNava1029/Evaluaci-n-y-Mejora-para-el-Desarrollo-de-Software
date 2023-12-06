
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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace WINFORM
{
    public partial class Caja : Form
    {

        public ProductoConsultas mProductoConsultas;
        public VentaConsultas mVentaConsultas;
        public Producto mProducto;
        public Venta mVenta;
        public VentaDetalle mVentaDetalle;
        public List<Producto> mProductos;
        public List<Venta> mVentas;
        public List<VentaDetalle> mVentaDetalles;
        public float monto;
        public float subtotal;
        public float cantidad;
        public Caja()
        {
            InitializeComponent();

            mProductoConsultas = new ProductoConsultas();
            mVentaConsultas = new VentaConsultas();
            mProducto = new Producto();
            mProductos = new List<Producto>();
            mVenta = new Venta();
            mVentas = new List<Venta>();
            mVentaDetalle = new VentaDetalle();
            mVentaDetalles = new List<VentaDetalle>();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductosCaja(txtProductID.Text.Trim());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int cantidad = Int32.Parse(txtPrice.Text) * Int32.Parse(txtAmount.Text);

            dataGridView1.Rows.Add(txtProductID.Text, txtName.Text, txtPrice.Text, txtAmount.Text, cantidad);
            subtotal = subtotal + cantidad;
            txtsubtotal.Text = subtotal.ToString();
            float total = float.Parse(txtsubtotal.Text) * .16f;
            txttotal.Text = subtotal.ToString();
            txtiva.Text = (subtotal * .16).ToString();
            txtsubtotal.Text = (subtotal - subtotal * .16).ToString();
            //mVentaDetalle.subtotal = (float)Convert.ToDouble(txtsubtotal.Text);
            //mVentaDetalle.Monto = (float)Convert.ToDouble(txttotal.Text);
            txtProductID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu menu = new Menu();

            menu.Show();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            mVenta.SaleID = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
            string valor = txtProductID.Text;
            for (int fila = 0; fila < dataGridView1.Rows.Count - 1; fila++)
            {
                for (int col = 0; col < dataGridView1.Rows[fila].Cells.Count; col++)
                {
                    valor = dataGridView1.Rows[fila].Cells[col].Value.ToString();

                    if (col == 0)
                    {
                        
                        mVenta.ProductID =Int16.Parse(valor);
                       
                    }


                    if (col == 3)
                    {
                         
                         mVenta.TotalAmount = float.Parse(txttotal.Text);
                    }
                    


                }
            }
            //se obtienen todos los registros del datagrus
            List<object[]> productosAVender = new List<object[]>();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                productosAVender.Add(new object[] { dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString() });
            }


            if (mVentaConsultas.agregarVenta(mVenta, productosAVender))
            {

                MessageBox.Show("Venta agregada");
                //CargarProductos();
                //LimpiarDatosProducto();
            }
            else
                MessageBox.Show("Error al agregar el producto");

           
        }

        private void CargarProductosCaja(string filtro = "")
        {


            mProductos.Clear();
            mProductos = mProductoConsultas.consultarProductosCaja(filtro);

            for (int i = 0; i < mProductos.Count(); i++)
            {
                txtName.Text = mProductos[i].Name.ToString();
                txtPrice.Text = mProductos[i].Price.ToString();
                txtAmount.Text = "1";



            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

