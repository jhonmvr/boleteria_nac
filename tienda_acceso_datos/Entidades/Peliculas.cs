
namespace tienda_acceso_datos.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Peliculas
    {
        
        public Peliculas()
        {
            this.Compras = new HashSet<Compras>();
            this.PedidosProveedores = new HashSet<PedidosProveedores>();
            this.Programacion = new HashSet<Programacion>();
            this.ProximosEstrenos = new HashSet<ProximosEstrenos>();
        }
    
        public int PeliculaID { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> Duracion { get; set; }
        public string Sinopsis { get; set; }
        public string TrailerURL { get; set; }
        public string Reparto { get; set; }
    
        
        public virtual ICollection<Compras> Compras { get; set; }
        
        public virtual ICollection<PedidosProveedores> PedidosProveedores { get; set; }
        
        public virtual ICollection<Programacion> Programacion { get; set; }
        
        public virtual ICollection<ProximosEstrenos> ProximosEstrenos { get; set; }
    }
}
