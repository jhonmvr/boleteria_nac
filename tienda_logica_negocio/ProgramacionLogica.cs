namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class ProgramacionLogica
    {
        private ProgramacionDAO programacionDao = new ProgramacionDAO();

        public int InsertarProgramacion(Programacion programacion)
        {
            programacionDao.InsertarProgramacion(programacion);
            DataTable resultado = programacionDao.BuscarProgramacionId(programacion.ProgramacionID);
            return int.Parse(resultado.Rows[0]["ProgramacionID"].ToString());
        }

        public DataTable ListarProgramaciones()
        {
            return programacionDao.ListarProgramaciones();
        }

    }
}
