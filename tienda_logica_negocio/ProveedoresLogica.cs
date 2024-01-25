namespace boleteria_logica_negocio
{
    using boleteria_acceso_datos.DAO;
    using boleteria_acceso_datos.Entidades;
    using System.Data;

    public class ProveedoresLogica
    {
        private ProveedoresDAO proveedoresDao = new ProveedoresDAO();

        public int InsertarProveedor(Proveedores proveedor)
        {
            proveedoresDao.InsertarProveedor(proveedor);
            DataTable resultado = proveedoresDao.BuscarProveedorId(proveedor.ProveedorID);
            return int.Parse(resultado.Rows[0]["ProveedorID"].ToString());
        }

        public DataTable ListarProveedores()
        {
            return proveedoresDao.ListarProveedores();
        }

        // Métodos adicionales como BuscarProveedor, etc., pueden ser agregados aquí.
    }
}
