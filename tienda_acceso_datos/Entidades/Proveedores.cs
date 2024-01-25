
namespace boleteria_acceso_datos.Entidades
{
    
    using System.Collections.Generic;
    
    public partial class Proveedores
    {
        
        public Proveedores()
        {
            this.PedidosProveedores = new HashSet<PedidosProveedores>();
        }
    
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string OtrosDatos { get; set; }
    
        
        public virtual ICollection<PedidosProveedores> PedidosProveedores { get; set; }
    }
}
