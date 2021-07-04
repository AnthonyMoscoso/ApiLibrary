
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
    
public partial class Employee
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Employee()
    {

        this.Employee1 = new HashSet<Employee>();

        this.Orders = new HashSet<Orders>();

        this.PayRoll = new HashSet<PayRoll>();

        this.Purchase = new HashSet<Purchase>();

        this.Reception = new HashSet<Reception>();

        this.RegisterLine = new HashSet<RegisterLine>();

        this.ReservationStore = new HashSet<ReservationStore>();

        this.Schedule = new HashSet<Schedule>();

        this.SickLeave = new HashSet<SickLeave>();

        this.StoreSale = new HashSet<StoreSale>();

        this.Rol = new HashSet<Rol>();

    }


    public string IdPerson { get; set; }

    public string IdBoss { get; set; }

    public string IdOccupation { get; set; }

    public System.DateTime StartDate { get; set; }

    public System.DateTime HireDate { get; set; }

    public Nullable<System.DateTime> DischargeDate { get; set; }

    public Nullable<int> TypeStatus { get; set; }

    public double Discount { get; set; }

    public System.DateTime CreateDate { get; set; }

    public System.DateTime LastUpdateDate { get; set; }

    public int StatusCode { get; set; }

    public string Url_Image { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Employee> Employee1 { get; set; }

    public virtual Employee Employee2 { get; set; }

    public virtual Occupation Occupation { get; set; }

    public virtual Person Person { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Orders> Orders { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PayRoll> PayRoll { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Purchase> Purchase { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Reception> Reception { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<RegisterLine> RegisterLine { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ReservationStore> ReservationStore { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Schedule> Schedule { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<SickLeave> SickLeave { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<StoreSale> StoreSale { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Rol> Rol { get; set; }

    public virtual Store Store { get; set; }

    public virtual WareHouse WareHouse { get; set; }

}

}
