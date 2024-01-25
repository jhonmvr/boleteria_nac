
namespace boleteria_acceso_datos.Entidades
{
    using System;

    public partial class ProximosEstrenos
    {
        public int EstrenoID { get; set; }
        public Nullable<System.DateTime> FechaTentativa { get; set; }
        public string TrailerURL { get; set; }
        public string Sinopsis { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
    }
}
