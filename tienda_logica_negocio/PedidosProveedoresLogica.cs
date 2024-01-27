namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class PedidosProveedoresLogica
    {
        private PedidosProveedoresDAO pedidosProveedoresDao = new PedidosProveedoresDAO();

        public int InsertarPedidoProveedor(PedidosProveedores pedidoProveedor)
        {
            pedidosProveedoresDao.InsertarPedidoProveedor(pedidoProveedor);
            DataTable resultado = pedidosProveedoresDao.BuscarPedidoProveedorId(pedidoProveedor.PedidoID);
            return int.Parse(resultado.Rows[0]["PedidoID"].ToString());
        }

        public DataTable ListarPedidosProveedores()
        {
            return pedidosProveedoresDao.ListarPedidosProveedores();
        }

    }
}
