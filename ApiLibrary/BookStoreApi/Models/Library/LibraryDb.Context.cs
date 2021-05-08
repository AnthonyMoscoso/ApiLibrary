﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreApi.Models.Library
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookStoreEntities : DbContext
    {
        public BookStoreEntities()
            : base("name=BookStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Barcode> Barcode { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookEditorial> BookEditorial { get; set; }
        public virtual DbSet<BookStore> BookStore { get; set; }
        public virtual DbSet<BookType> BookType { get; set; }
        public virtual DbSet<Box> Box { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<Direction> Direction { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<DocumentFile> DocumentFile { get; set; }
        public virtual DbSet<Edition> Edition { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<ImageFile> ImageFile { get; set; }
        public virtual DbSet<Occupation> Occupation { get; set; }
        public virtual DbSet<OnlineSale> OnlineSale { get; set; }
        public virtual DbSet<OrderLine> OrderLine { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PaymentBonus> PaymentBonus { get; set; }
        public virtual DbSet<PaymentBonusEmployee> PaymentBonusEmployee { get; set; }
        public virtual DbSet<PayRoll> PayRoll { get; set; }
        public virtual DbSet<Permit> Permit { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseLine> PurchaseLine { get; set; }
        public virtual DbSet<Reception> Reception { get; set; }
        public virtual DbSet<ReceptionLine> ReceptionLine { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<RegisterLine> RegisterLine { get; set; }
        public virtual DbSet<Reservation> Reservation { get; set; }
        public virtual DbSet<ReservationOnline> ReservationOnline { get; set; }
        public virtual DbSet<ReservationStore> ReservationStore { get; set; }
        public virtual DbSet<ReturnLine> ReturnLine { get; set; }
        public virtual DbSet<ReturnSale> ReturnSale { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleLine> SaleLine { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleLine> ScheduleLine { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<ShippingLine> ShippingLine { get; set; }
        public virtual DbSet<SickLeave> SickLeave { get; set; }
        public virtual DbSet<Socie> Socie { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreSale> StoreSale { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Taxes> Taxes { get; set; }
        public virtual DbSet<WareHouse> WareHouse { get; set; }
        public virtual DbSet<WareHouseBook> WareHouseBook { get; set; }
    }
}
