namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class SalasDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarSala(Salas nuevaSala)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO Salas (Nombre, Capacidad) VALUES('" + nuevaSala.Nombre + "', " + nuevaSala.Capacidad + ")";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Sala: " + ex.Message);
            }
        }

        public DataTable ListarSalas()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Salas";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Salas: " + ex.Message);
            }
        }

        public DataTable BuscarSalaId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Salas WHERE SalaID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Sala: " + ex.Message);
            }
        }
    }
}
