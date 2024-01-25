namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class ProveedoresDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarProveedor(Proveedores nuevoProveedor)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO Proveedores (Nombre, OtrosDatos) VALUES('" + nuevoProveedor.Nombre + "', '" + nuevoProveedor.OtrosDatos + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Proveedor: " + ex.Message);
            }
        }

        public DataTable ListarProveedores()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Proveedores";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Proveedores: " + ex.Message);
            }
        }

        public DataTable BuscarProveedorId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Proveedores WHERE ProveedorID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Proveedor: " + ex.Message);
            }
        }
    }
}
