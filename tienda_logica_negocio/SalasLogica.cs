namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class SalasLogica
    {
        private SalasDAO salasDao = new SalasDAO();

        public int InsertarSala(Salas sala)
        {
            salasDao.InsertarSala(sala);
            DataTable resultado = salasDao.BuscarSalaId(sala.SalaID);
            return int.Parse(resultado.Rows[0]["SalaID"].ToString());
        }

        public DataTable ListarSalas()
        {
            return salasDao.ListarSalas();
        }

        // Métodos adicionales como BuscarSala, etc., pueden ser agregados aquí.
    }
}
