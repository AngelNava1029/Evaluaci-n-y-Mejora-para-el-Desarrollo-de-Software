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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnUsuarioM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario2 usuarios = new Usuario2();

            usuarios.Show();
        }

        private void btnMotosM_Click(object sender, EventArgs e)
        {
            this.Hide();

            Moto productos = new Moto();

            productos.Show();
        }

        private void btnCajasM_Click(object sender, EventArgs e)
        {
            this.Hide();

            Caja caja = new Caja();

            caja.Show();
        }

        private void btnVentasM_Click(object sender, EventArgs e)
        {
            this.Hide();

            Venta2 v = new Venta2();

            v.Show();
        }

        private void btnSalirM_Click(object sender, EventArgs e)
        {

        }
    }
}
