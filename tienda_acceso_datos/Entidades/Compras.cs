
namespace tienda_acceso_datos.Entidades
{

    public partial class Compras
    {
        public int CompraID { get; set; }
        public string CodigoCompra { get; set; }
        public string AsientosAsignados { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Peliculas Peliculas { get; set; }
        public virtual Salas Salas { get; set; }
    }
}
