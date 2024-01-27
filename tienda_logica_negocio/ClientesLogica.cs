namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class ClientesLogica
    {
        private ClientesDAO clientesDao = new ClientesDAO();

        public int InsertarCliente(Clientes cliente)
        {
            clientesDao.InsertarCliente(cliente);
            DataTable resultado = clientesDao.BuscarClienteId(cliente.ClienteID);
            return int.Parse(resultado.Rows[0]["ClienteID"].ToString());
        }

        public DataTable ListarClientes()
        {
            return clientesDao.ListarClientes();
        }

    }
}
