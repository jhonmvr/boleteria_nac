
using boleteria_acceso_datos.DAO;
using boleteria_acceso_datos.Entidades;
using System.Data;

namespace boleteria_logica_negocio
{


    public partial class AsientosLogica
    {
        private AsientosDAO asientosDao = new AsientosDAO();

        public int InsertarAsientos(Asientos asientos)
        {
            asientosDao.InsertarAsientos(asientos);
            DataTable resultado = asientosDao.BuscarAsientosId(asientos.AsientoID);
            return int.Parse(resultado.Rows[0]["AsientoID"].ToString());
        }
        public DataTable ListarAsientos()
        {
           
            return asientosDao.ListarAsientos();
        }
    }
}