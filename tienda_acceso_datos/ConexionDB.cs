using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleteria_acceso_datos
{
    class ConexionDB
    {
        private SqlConnection connection = new SqlConnection("Server=LAPTOP-I6M1K45A\\SQLEXPRESSANYW;DataBase=master");
        public SqlConnection AbrirConexion()
        {
            if( connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
