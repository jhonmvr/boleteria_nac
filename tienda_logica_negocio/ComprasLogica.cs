namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class ComprasLogica
    {
        private ComprasDAO comprasDao = new ComprasDAO();

        public int InsertarCompra(Compras compra)
        {
            comprasDao.InsertarCompra(compra);
            DataTable resultado = comprasDao.BuscarCompraId(compra.CompraID);
            return int.Parse(resultado.Rows[0]["CompraID"].ToString());
        }

        public DataTable ListarCompras()
        {
            return comprasDao.ListarCompras();
        }

    }
}
