//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Ado.Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookStore
    {
        public string IdBookStore { get; set; }
        public string IdBook { get; set; }
        public string IdStore { get; set; }
        public double BookPrice { get; set; }
        public int Stock { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Store Store { get; set; }
    }
}