
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
    
public partial class Book
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Book()
    {

        this.BookEditorial = new HashSet<BookEditorial>();

        this.BookStore = new HashSet<BookStore>();

        this.OrderLine = new HashSet<OrderLine>();

        this.PurchaseLine = new HashSet<PurchaseLine>();

        this.ReceptionLine = new HashSet<ReceptionLine>();

        this.Reservation = new HashSet<Reservation>();

        this.ReturnSale = new HashSet<ReturnSale>();

        this.SaleLine = new HashSet<SaleLine>();

        this.ShippingLine = new HashSet<ShippingLine>();

        this.WareHouseBook = new HashSet<WareHouseBook>();

        this.Autor = new HashSet<Autor>();

        this.Gender = new HashSet<Gender>();

    }


    public string IdBook { get; set; }

    public string IdType { get; set; }

    public string IdEdition { get; set; }

    public string BookTittle { get; set; }

    public string Languages { get; set; }

    public System.DateTime PublicationDate { get; set; }

    public int Pags { get; set; }

    public string ISBM { get; set; }

    public int EditionNum { get; set; }

    public string Synopsis { get; set; }

    public double Price { get; set; }

    public System.DateTime CreateDate { get; set; }

    public System.DateTime LastUpdateDate { get; set; }

    public int StatusCode { get; set; }

    public int BindingType { get; set; }

    public string Url_Image { get; set; }



    public virtual Edition Edition { get; set; }

    public virtual BookType BookType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BookEditorial> BookEditorial { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<BookStore> BookStore { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<OrderLine> OrderLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PurchaseLine> PurchaseLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ReceptionLine> ReceptionLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Reservation> Reservation { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ReturnSale> ReturnSale { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SaleLine> SaleLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ShippingLine> ShippingLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<WareHouseBook> WareHouseBook { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Autor> Autor { get; set; }

    public virtual Discount Discount { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Gender> Gender { get; set; }

}

}
