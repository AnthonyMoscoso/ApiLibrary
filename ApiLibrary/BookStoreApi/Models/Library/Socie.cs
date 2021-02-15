//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreApi.Models.Library
{
    using LibraryApiRest.Models.Abstract;
    using System;
    using System.Collections.Generic;
    
    public partial class Socie : IEntidad
    {
        public string IdSocie { get; set; }
        public string IdPerson { get; set; }
        public double Discount { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public Nullable<System.DateTime> DesactivateDate { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
        public int StatusCode { get; set; }
    
        public virtual Person Person { get; set; }
        public string Id { get => IdSocie; set => IdSocie=value; }
    }
}
