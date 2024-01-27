namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class ProximosEstrenosLogica
    {
        private ProximosEstrenosDAO proximosEstrenosDao = new ProximosEstrenosDAO();

        public int InsertarProximoEstreno(ProximosEstrenos proximoEstreno)
        {
            proximosEstrenosDao.InsertarProximoEstreno(proximoEstreno);
            DataTable resultado = proximosEstrenosDao.BuscarProximoEstrenoId(proximoEstreno.EstrenoID);
            return int.Parse(resultado.Rows[0]["EstrenoID"].ToString());
        }

        public DataTable ListarProximosEstrenos()
        {
            return proximosEstrenosDao.ListarProximosEstrenos();
        }

    }
}
