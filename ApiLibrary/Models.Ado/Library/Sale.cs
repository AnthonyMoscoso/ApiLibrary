
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
    
public partial class Sale
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Sale()
    {

        this.ReturnSale = new HashSet<ReturnSale>();

        this.SaleLine = new HashSet<SaleLine>();

        this.Reservation = new HashSet<Reservation>();

    }


    public string IdSale { get; set; }

    public string IdBuyer { get; set; }

    public double Total { get; set; }

    public double Discount { get; set; }

    public int SaleStatus { get; set; }

    public int PayMethod { get; set; }

    public double TotalWithIva { get; set; }

    public double Iva { get; set; }

    public double MoneyPaid { get; set; }

    public double MoneyReturned { get; set; }

    public System.DateTime CreateDate { get; set; }

    public System.DateTime LastUpdateDate { get; set; }

    public int StatusCode { get; set; }



    public virtual OnlineSale OnlineSale { get; set; }

    public virtual Person Person { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ReturnSale> ReturnSale { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SaleLine> SaleLine { get; set; }

    public virtual StoreSale StoreSale { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Reservation> Reservation { get; set; }

    public virtual Coupon Coupon { get; set; }

}

}
