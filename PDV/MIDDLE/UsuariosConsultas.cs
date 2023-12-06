using CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDDLE
{

    public class UsuariosConsultas
    {
        public ConexionMySql mConexion;
        public Usuario mUsuario;
        public List<Usuario> mUsuarios;

        public UsuariosConsultas()
        {
            mConexion = new ConexionMySql();
            mUsuarios = new List<Usuario>();
        }

        public bool agregarUsuario(Usuario mUsuarios)
        {
            string INSERT = "INSERT INTO customers (Name, Email, Phone,Address)" + " values (@Name, @Email, @Phone,@Address);";

            MySqlCommand mCommand = new MySqlCommand(INSERT, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@CustomerID", mUsuarios.CustomerID));
            mCommand.Parameters.Add(new MySqlParameter("@Name", mUsuarios.Name));
            mCommand.Parameters.Add(new MySqlParameter("@Email", mUsuarios.Email));
            mCommand.Parameters.Add(new MySqlParameter("@Phone", mUsuarios.Phone));
            mCommand.Parameters.Add(new MySqlParameter("@Address", mUsuarios.Address));


            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool modificarUsuario(Usuario mUsuario)
        {
            string UPDATE = " UPDATE customers " +
                "SET Name = @Name, " +
                "Email = @Email, " +
                "Phone = @Phone, " +
                "Address = @Address " +
                "WHERE CustomerID = @CustomerID";

            MySqlCommand mCommand = new MySqlCommand(UPDATE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@Name", mUsuario.Name));
            mCommand.Parameters.Add(new MySqlParameter("@Email", mUsuario.Email));
            mCommand.Parameters.Add(new MySqlParameter("@Phone", mUsuario.Phone));
            mCommand.Parameters.Add(new MySqlParameter("@Address", mUsuario.Address));
            mCommand.Parameters.Add(new MySqlParameter("@CustomerID", mUsuario.CustomerID));

            return mCommand.ExecuteNonQuery() > 0;
        }

        public bool eliminarUsuario(int CustomerID)
        {
            string DELETE = " DELETE FROM customers WHERE CustomerID=@CustomerID";
            MySqlCommand mCommand = new MySqlCommand(DELETE, mConexion.getConexion());
            mCommand.Parameters.Add(new MySqlParameter("@CustomerID", CustomerID));
            return mCommand.ExecuteNonQuery() > 0;
        }

        public List<Usuario> consultarUser(string filtro)
        {
            string CONSULTA = "SELECT * FROM customers";

            MySqlDataReader mReader = null;
            Usuario mUsuario;
            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "Name = '" + filtro + "';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mUsuario = new Usuario();
                    mUsuario.Email = mReader.GetString("Email");
                    mUsuario.Phone = mReader.GetString("Name");
                    mUsuarios.Add(mUsuario);
                }
                mReader.Close();
            }
            catch (MySqlException)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                mConexion.closeConexion();
            }

            return mUsuarios;
        }



        public List<Usuario> consultarUsuario(string filtro)
        {
            string CONSULTA = "SELECT * FROM customers";

            MySqlDataReader mReader = null;
            Usuario mUsuario;
            try
            {
                if (filtro != "")
                {
                    CONSULTA += " WHERE " +
                        "CustomerID LIKE '%" + filtro + "%' OR " +
                        "Name LIKE '%" + filtro + "%' OR " +
                        "Email LIKE '%" + filtro + "%' OR " +
                        "Phone LIKE '%" + filtro + "%' OR " +
                        "Address LIKE '%" + filtro + "%';";
                }

                MySqlCommand mCommand = new MySqlCommand(CONSULTA);
                mCommand.Connection = mConexion.getConexion();
                mReader = mCommand.ExecuteReader();

                while (mReader.Read())
                {
                    mUsuario = new Usuario();

                    mUsuario.Name = mReader.GetString("Name");
                    mUsuario.Email = mReader.GetString("Email");
                    mUsuario.Phone = mReader.GetString("Phone");
                    mUsuario.Address = mReader.GetString("Address");
                    mUsuario.CustomerID = mReader.GetInt32("CustomerID");
                    mUsuarios.Add(mUsuario);
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

            return mUsuarios;
        }
    }
}
