
namespace boleteria_acceso_datos.Entidades
{
    
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        
        public Clientes()
        {
            this.Compras = new HashSet<Compras>();
        }
    
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string OtrosDatos { get; set; }
    
        
        public virtual ICollection<Compras> Compras { get; set; }
    }
}
