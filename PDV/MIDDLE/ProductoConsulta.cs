using CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDDLE
{
    public class ProductoConsultas
    {
        public ConexionMySql mConexion;
        public List<Producto> mProductos;
        public ProductoConsultas()
        {
            mConexion = new ConexionMySql();
            mProductos = new List<Producto>();

        }

        public bool agregarProducto(Producto mProducto)
        {
            string INSERT = "INSERT INTO products (Name, Description, Price, QuantityInStock)" + " values (@Name, @Description, @Price, @QuantityInStock);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@ProductID", mProducto.ProductID));
            mCommand.Parameters.Add(new MySqlParameter("@Name", mProducto.Name));
            mCommand.Parameters.Add(new MySqlParameter("@Description", mProducto.Description));
            mCommand.Parameters.Add(new MySqlParameter("@Price", mProducto.Price));
            mCommand.Parameters.Add(new MySqlParameter("@QuantityInStock", mProducto.QuantityInStock));


            return mCommand.ExecuteNonQuery() > 0;
        }


        public bool actualizarCantidadEnStock(Producto mProducto)
        {
            string UPDATE = "UPDATE products SET QuantityInStock = @QuantityInStock WHERE ProductID = @ProductID;";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@ProductID", mProducto.ProductID));
            mCommand.Parameters.Add(new MySqlParameter("@NewQuantity", mProducto. QuantityInStock));

            return mCommand.ExecuteNonQuery() > 0;
        }



        public bool modificarProducto(Producto mProducto)
        {
            string UPDATE = " UPDATE products " +
                "SET Name = @Name, " +
                "Description = @Description, " +
                "Price = @Price, " +
                "QuantityInStock = @QuantityInStock " +

                "WHERE ProductID = @ProductID";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@ProductID", mProducto.ProductID));
            mCommand.Parameters.Add(new MySqlParameter("@Name", mProducto.Name));
            mCommand.Parameters.Add(new MySqlParameter("@Description", mProducto.Description));
            mCommand.Parameters.Add(new MySqlParameter("@Price", mProducto.Price));
            mCommand.Parameters.Add(new MySqlParameter("@QuantityInStock", mProducto.QuantityInStock));

            return mCommand.ExecuteNonQuery() > 0;
        }




        public bool eliminarProducto(Producto mProducto)
        {
            string DELETE = " DELETE FROM products WHERE ProductID=@ProductID";
            MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@ProductID", mProducto.ProductID));
            return mCommand.ExecuteNonQuery() > 0;
        }





        public List<Producto> consultarProductos(string filtro)
        {
            string CONSULTA = "SELECT * FROM products";

            MySqlDataReader mReader = null;
            Producto mProducto;
            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "ProductID LIKE '%" + filtro + "%' OR " +
                        "Name LIKE '%" + filtro + "%' OR " +
                        "Description LIKE '%" + filtro + "%' OR " +
                        "Price LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mProducto = new Producto();
                    mProducto.ProductID = mReader.GetInt16("ProductID");
                    mProducto.Name = mReader.GetString("Name");
                    mProducto.Description = mReader.GetString("Description");
                    mProducto.Price = mReader.GetFloat("Price");
                    mProducto.QuantityInStock = mReader.GetInt16("QuantityInStock");

                    mProductos.Add(mProducto);
                }
                mReader.Close();
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mConexion.closeConexion();
            }

            return mProductos;
        }





        public List<Producto> consultarProductosCaja(string filtro)
        {
            string CONSULTA = "SELECT * FROM products";

            MySqlDataReader mReader = null;
            Producto mProducto;
            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "ProductID LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mProducto = new Producto();
                    mProducto.ProductID = mReader.GetInt16("ProductID");
                    mProducto.Name = mReader.GetString("Name");
                    mProducto.Price = mReader.GetFloat("Price");
                    mProducto.Description = mReader.GetString("Description");
                    mProducto.QuantityInStock = mReader.GetInt32("QuantityInStock");

                    mProductos.Add(mProducto);
                }
                mReader.Close();
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mConexion.closeConexion();
            }

            return mProductos;
        }
    }
}