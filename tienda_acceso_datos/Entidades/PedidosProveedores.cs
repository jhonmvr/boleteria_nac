
namespace boleteria_acceso_datos.Entidades
{

    
    public partial class PedidosProveedores
    {
        public int PedidoID { get; set; }
        public string EstadoPedido { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
