using CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MIDDLE;

public class VentaConsultas
{
    public ConexionMySql mConexion;
    public List<Venta> mVentas;
    public List<VentaDetalle> mVentaDetalles;
    
    
    

    public VentaConsultas()
    {
        mConexion = new ConexionMySql();
        mVentas = new List<Venta>();
        mVentaDetalles = new List<VentaDetalle>();
        
    }

public bool agregarVenta(Venta mVenta, List<object[]> prodVender)
    {
        int res = 0;
        string INSERT = "INSERT INTO sales(ProductID,Date,TotalAmount)" + " values (@ProductID,CURRENT_DATE,@TotalAmount);";

        MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
        mCommand.Parameters.Add(new MySqlParameter("@TotalAmount", mVenta.TotalAmount));
        mCommand.Parameters.Add(new MySqlParameter("@ProductID", mVenta.ProductID));


        mCommand.ExecuteNonQuery();
        //obtener el id de esta ultima venta
        string CONSULTA = "SELECT SaleID FROM sales ORDER BY SaleID DESC limit 1;";
        //otro query
       // mCommand.Parameters.Add(new MySqlParameter("@id", mVenta.id));
        mCommand= new MySqlCommand(CONSULTA, mConexion.getConexion());
        int IdVenta= int.Parse(mCommand.ExecuteScalar().ToString());

        //recorrer el datagrid en todos sus renglones

        foreach (object[] row in prodVender)
        {
            //INSET INTO ventas_detalles (id_venta, producto_id, cantidad) VALUES (@id_venta...)
            string insert = "INSERT INTO salesdetails(IdVenta,ProductID,cantidad)" + " values (@IdVenta,@ProductID,@cantidad);";
            MySqlCommand insertCommand = new MySqlCommand(insert, mConexion.getConexion());
            //por cada ROW viene [id, cantidad]
            insertCommand.Parameters.Add(new MySqlParameter("@IdVenta", IdVenta));//id
            insertCommand.Parameters.Add(new MySqlParameter("@ProductID", mVenta.ProductID)); //ProductoId
            insertCommand.Parameters.Add(new MySqlParameter("@cantidad", row[2].ToString()));//cantidad

            //de cada renglon obtener los valores de la celda o (id) y 3 (cantidad)
             res=  insertCommand.ExecuteNonQuery();


        }



        //termina el recorrido del datagrid
        if (res == 0) return false;
        else
        return true;
    }
    

    public bool agregarVentaDet(VentaDetalle mVentaDetalle, Venta mVenta)
    {
        string INSERT = "INSERT INTO `salesdetails`(`ProductID`, `TotalAmount`) " + " values (@SaleID,@TotalAmount);";

        MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());

        mCommand.Parameters.Add(new MySqlParameter("@ProductID", mVenta.ProductID));
        mCommand.Parameters.Add(new MySqlParameter("@SalesID", mVenta.SaleID));
        mCommand.Parameters.Add(new MySqlParameter("@TotalAmount", mVentaDetalle.cantidad));

        return mCommand.ExecuteNonQuery() > 0;
    }

    public List<VentaDetalle> consultarReporteVentas(string filtro)
    {
        string CONSULTA = "SELECT * FROM salesdetails ";

        MySqlDataReader mReader = null;
        VentaDetalle mVentaDetalle;
        try
        {
            if (filtro != "")
            {
                CONSULTA += " WHERE " +
                    "IdVenta =  '" + filtro + "';";
            }

            MySqlCommand mCommand = new MySqlCommand(CONSULTA);
            mCommand.Connection = mConexion.getConexion();
            mReader = mCommand.ExecuteReader();

            while (mReader.Read())
            {
                mVentaDetalle = new VentaDetalle();
                mVentaDetalle.IdVenta = mReader.GetInt16("IdVenta");
                mVentaDetalle.ProductID = mReader.GetInt16("ProductID");
                mVentaDetalle.cantidad = mReader.GetInt16("cantidad");


                mVentaDetalles.Add(mVentaDetalle);
            }
            mReader.Close();
        }
        catch (MySqlException )
        {
            //Message.Show(ex.Message);
        }
        finally
        {
            mConexion.closeConexion();
        }

        return mVentaDetalles;
    }
    
}