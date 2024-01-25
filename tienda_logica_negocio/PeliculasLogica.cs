namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class PeliculasLogica
    {
        private PeliculasDAO peliculasDao = new PeliculasDAO();

        public int InsertarPelicula(Peliculas pelicula)
        {
            peliculasDao.InsertarPelicula(pelicula);
            DataTable resultado = peliculasDao.BuscarPeliculaId(pelicula.PeliculaID);
            return int.Parse(resultado.Rows[0]["PeliculaID"].ToString());
        }

        public DataTable ListarPeliculas()
        {
            return peliculasDao.ListarPeliculas();
        }

    }
}
