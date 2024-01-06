
namespace tienda_acceso_datos.Entidades
{
    using System;
    
    
    public partial class Asientos
    {
        public int AsientoID { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<bool> Ocupado { get; set; }
    
        public virtual Salas Salas { get; set; }
    }
}
