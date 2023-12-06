using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{

    public class ConexionMySql 
    {
        private MySqlConnection conexion;
        private string cadenaConexion;
        protected string server = "localhost";
        protected string database = "pdvemd";
        protected string user = "root";
        protected string password = "";

        public ConexionMySql()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
            conexion = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConexion()
        {
            try
            {
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

            return conexion;
        }

        public void closeConexion()
        {
            conexion.Close();
        }
    }

}
