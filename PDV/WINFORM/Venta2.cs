using CRUD;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WINFORM
{
    public partial class Venta2 : Form
    {
        private VentaConsultas mVentaConsultas;
        private Venta mVenta;
        private ConexionMySql mConexion;
        private List<Venta> mVentas;
        private VentaDetalle mVentaDetalle;
        private List<VentaDetalle> mVentaDetalles;
        public Venta2()
        {
            InitializeComponent();

            mConexion = new ConexionMySql();
            mVentaConsultas = new VentaConsultas();
            mVenta = new Venta();
            mVentas = new List<Venta>();
            mVentaDetalle = new VentaDetalle();
            mVentaDetalles = new List<VentaDetalle>();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string f1 = txtIdVenta.Text;
            CargarReporteVentas(f1);

        }
        private void CargarReporteVentas(string f1)
        {

            dGventadetalle.Rows.Clear();
            dGventadetalle.Refresh();
            mVentaDetalles.Clear();
            mVentaDetalles = mVentaConsultas.consultarReporteVentas(f1);

            for (int i = 0; i < mVentaDetalles.Count(); i++)
            {

                //dGventadetalle.RowTemplate.Height = Commun.ROW_HEIGTH;
                dGventadetalle.Rows.Add(
                    mVentaDetalles[i].IdVenta,
                    mVentaDetalles[i].ProductID,
                    mVentaDetalles[i].cantidad);


            }

        }



    }
}
