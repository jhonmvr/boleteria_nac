namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class ClientesDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarCliente(Clientes nuevoCliente)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO Clientes (Nombre, Email, OtrosDatos) VALUES('" + nuevoCliente.Nombre + "','" + nuevoCliente.Email + "','" + nuevoCliente.OtrosDatos + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Cliente: " + ex.Message);
            }
        }

        public DataTable ListarClientes()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Clientes";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Clientes: " + ex.Message);
            }
        }

        public DataTable BuscarClienteId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Clientes WHERE ClienteID = '" + id + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Cliente: " + ex.Message);
            }
        }
    }
}

