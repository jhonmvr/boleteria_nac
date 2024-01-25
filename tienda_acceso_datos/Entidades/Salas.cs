
namespace boleteria_acceso_datos.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salas
    {
        
        public Salas()
        {
            this.Asientos = new HashSet<Asientos>();
            this.Compras = new HashSet<Compras>();
            this.Programacion = new HashSet<Programacion>();
        }
    
        public int SalaID { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Capacidad { get; set; }
    
       
        public virtual ICollection<Asientos> Asientos { get; set; }
       
        public virtual ICollection<Compras> Compras { get; set; }
       
        public virtual ICollection<Programacion> Programacion { get; set; }
    }
}
