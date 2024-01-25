namespace boleteria_acceso_datos.DAO
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using boleteria_acceso_datos.Entidades;

    public class PeliculasDAO
    {
        private ConexionDB conexion = new ConexionDB();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlDataReader transaccion;

        public void InsertarPelicula(Peliculas nuevaPelicula)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            try
            {
                ejecutarSql.CommandText = "INSERT INTO Peliculas (Titulo, Duracion, Sinopsis, TrailerURL, Reparto) VALUES('" + nuevaPelicula.Titulo + "'," + nuevaPelicula.Duracion + ",'" + nuevaPelicula.Sinopsis + "','" + nuevaPelicula.TrailerURL + "','" + nuevaPelicula.Reparto + "')";
                transaccion = ejecutarSql.ExecuteReader();
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar Pelicula: " + ex.Message);
            }
        }

        public DataTable ListarPeliculas()
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Peliculas";
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Peliculas: " + ex.Message);
            }
        }

        public DataTable BuscarPeliculaId(int id)
        {
            ejecutarSql.Connection = conexion.AbrirConexion();
            DataTable dt = new DataTable();
            try
            {
                ejecutarSql.CommandText = "SELECT * FROM Peliculas WHERE PeliculaID = " + id;
                transaccion = ejecutarSql.ExecuteReader();
                dt.Load(transaccion);
                conexion.CerrarConexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar Pelicula: " + ex.Message);
            }
        }
    }
}

