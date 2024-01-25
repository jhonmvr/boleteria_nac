namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class ProgramacionDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarProgramacion(Programacion nuevaProgramacion)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO Programacion (PeliculaID, SalaID, HoraInicio) VALUES(" + nuevaProgramacion.ProgramacionID + ", " + nuevaProgramacion.Peliculas + ", '" + nuevaProgramacion.HoraInicio + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Programacion: " + ex.Message);
            }
        }

        public DataTable ListarProgramaciones()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Programacion";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Programaciones: " + ex.Message);
            }
        }

        public DataTable BuscarProgramacionId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Programacion WHERE ProgramacionID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Programacion: " + ex.Message);
            }
        }
    }
}
