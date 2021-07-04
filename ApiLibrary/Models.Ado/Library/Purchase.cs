
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
    
public partial class Purchase
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Purchase()
    {

        this.PurchaseLine = new HashSet<PurchaseLine>();

        this.Reception = new HashSet<Reception>();

    }


    public string IdPurchase { get; set; }

    public string IdEditorial { get; set; }

    public string IdEmployee { get; set; }

    public int PurchaseStatus { get; set; }

    public double Total { get; set; }

    public Nullable<System.DateTime> ExpectArrivalDate { get; set; }

    public Nullable<System.DateTime> ArrivalDate { get; set; }

    public System.DateTime CreateDate { get; set; }

    public System.DateTime LastUpdateDate { get; set; }

    public int StatusCode { get; set; }



    public virtual Editorial Editorial { get; set; }

    public virtual Employee Employee { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PurchaseLine> PurchaseLine { get; set; }

    public virtual Store Store { get; set; }

    public virtual WareHouse WareHouse { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Reception> Reception { get; set; }

}

}
