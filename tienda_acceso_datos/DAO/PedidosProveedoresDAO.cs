namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class PedidosProveedoresDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarPedidoProveedor(PedidosProveedores nuevoPedidoProveedor)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO PedidosProveedores (PeliculaID, ProveedorID, EstadoPedido) VALUES(" + nuevoPedidoProveedor.PedidoID + ", " + nuevoPedidoProveedor.Proveedores.ProveedorID + ", '" + nuevoPedidoProveedor.EstadoPedido + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar PedidoProveedor: " + ex.Message);
            }
        }

        public DataTable ListarPedidosProveedores()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM PedidosProveedores";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar PedidosProveedores: " + ex.Message);
            }
        }

        public DataTable BuscarPedidoProveedorId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM PedidosProveedores WHERE PedidoID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar PedidoProveedor: " + ex.Message);
            }
        }
    }
}
