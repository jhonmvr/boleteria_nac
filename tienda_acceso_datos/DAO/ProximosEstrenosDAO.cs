namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class ProximosEstrenosDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarProximoEstreno(ProximosEstrenos nuevoProximoEstreno)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO ProximosEstrenos (PeliculaID, FechaTentativa, TrailerURL, Sinopsis)'"+
                    " VALUES(" + nuevoProximoEstreno.EstrenoID + ", '" + nuevoProximoEstreno.FechaTentativa + "', '" + nuevoProximoEstreno.TrailerURL + "', '" + nuevoProximoEstreno.Sinopsis + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar ProximoEstreno: " + ex.Message);
            }
        }

        public DataTable ListarProximosEstrenos()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM ProximosEstrenos";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar ProximosEstrenos: " + ex.Message);
            }
        }

        public DataTable BuscarProximoEstrenoId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM ProximosEstrenos WHERE EstrenoID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar ProximoEstreno: " + ex.Message);
            }
        }
    }
}
