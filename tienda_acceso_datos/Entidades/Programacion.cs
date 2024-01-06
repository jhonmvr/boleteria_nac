
namespace tienda_acceso_datos.Entidades
{
    using System;

    
    public partial class Programacion
    {
        public int ProgramacionID { get; set; }
        public Nullable<System.DateTime> HoraInicio { get; set; }
    
        public virtual Peliculas Peliculas { get; set; }
        public virtual Salas Salas { get; set; }
    }
}
