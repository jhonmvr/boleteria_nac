
namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public partial class AsientosDAO
    {
        private ConexionDB conexion = new ConexionDB();

        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;
        public void InsertarAsientos(Asientos nuevoAsientos)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "insert into asientos (asientoid, numero, ocupado)" + 
                    " values('"+ nuevoAsientos.AsientoID + "','" + nuevoAsientos.Numero + "','" + nuevoAsientos.Ocupado + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Asientos: " + ex.Message);
            }
        }


        public DataTable ListarAsientos()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "Select * from Asientos";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Asientos: " + ex.Message);
            }
        }
        public DataTable BuscarAsientosId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "Select * from Asientos where AsientoID = '" + id + "'";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Asientos: " + ex.Message);
            }
        }


    }
}
