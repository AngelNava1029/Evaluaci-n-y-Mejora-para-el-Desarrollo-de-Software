using CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDDLE

{

    public class Venta
    {
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public double subtotal { get; set; }
        public string Date { get; set; }
        public float TotalAmount { get; set; }
        
        public int id_producto { get; set; }
        public double precio { get; set; }
       
     
    }

    public class VentaDetalle
    {
         public int IdVenta { get; set; }
        public int ProductID { get; set; }
        public int cantidad { get; set; }

    }
}