
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
    
public partial class Reception
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Reception()
    {

        this.ReceptionLine = new HashSet<ReceptionLine>();

    }


    public string IdReception { get; set; }

    public string IdEmployee { get; set; }

    public string IdStore { get; set; }

    public System.DateTime CreateDate { get; set; }

    public System.DateTime LastUpdateDate { get; set; }

    public int StatusCode { get; set; }



    public virtual Employee Employee { get; set; }

    public virtual Store Store { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ReceptionLine> ReceptionLine { get; set; }

    public virtual Orders Orders { get; set; }

    public virtual Purchase Purchase { get; set; }

}

}
