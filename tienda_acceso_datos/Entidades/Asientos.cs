//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tienda_acceso_datos.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asientos
    {
        public int AsientoID { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<bool> Ocupado { get; set; }
    
        public virtual Salas Salas { get; set; }
    }
}