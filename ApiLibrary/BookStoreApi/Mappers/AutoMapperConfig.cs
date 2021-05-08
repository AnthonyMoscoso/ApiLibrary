using AutoMapper;
using BookStoreApi.Dtos;
using BookStoreApi.Models.Dtos;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using System;

namespace Mappers.Models
{
    public static class AutoMapperConfig 
    {
        public static MapperConfiguration MapperConfiguration;
        public static void RegisterMappings()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
           {
               cfg.CreateMap<Autor, AutorDto>().ReverseMap();

               cfg.CreateMap<Barcode, BarCodeDto>().ReverseMap();

               cfg.CreateMap<Book, BookDto>().ReverseMap();
               cfg.CreateMap<BookEditorial, BookEditorialDto>().ReverseMap();
               cfg.CreateMap<BookType, BookTypeDto>().ReverseMap();
               cfg.CreateMap<BookStore, BookStoreDto>().ReverseMap();

               cfg.CreateMap<Coupon, CouponDto>().ReverseMap();

               cfg.CreateMap<Direction, DirectionDto>().ReverseMap();

               cfg.CreateMap<Discount, DiscountDto>().ReverseMap();

               cfg.CreateMap<DocumentFile, DocumentFileDto>().ReverseMap();

               cfg.CreateMap<Edition, EditionDto>().ReverseMap();

               cfg.CreateMap<Editorial, EditorialDto>().ReverseMap();

               cfg.CreateMap<Employee, EmployeeDto>()
                .IncludeMembers(m => m.Person).ReverseMap();

               

               cfg.CreateMap<Gender, GenderDto>().ReverseMap();

               cfg.CreateMap<ImageFile, ImageFileDto>().ReverseMap();

               cfg.CreateMap<Occupation, OccupationDto>().ReverseMap();


               cfg.CreateMap<Orders, OrderDto>().ReverseMap();


               cfg.CreateMap<OrderLine, OrderLineDto>().ReverseMap();

               cfg.CreateMap<PaymentBonus, PaymentBonusDto>().ReverseMap();

               cfg.CreateMap<PayRoll, PayRollDto>().ReverseMap();

               cfg.CreateMap<Permit, PermitDto>().ReverseMap();

               cfg.CreateMap<Person, PersonDto>().ReverseMap();

               cfg.CreateMap<Person, EmployeeDto>().ReverseMap();
               cfg.CreateMap<Person, SocieDto>().ReverseMap();

               cfg.CreateMap<Sale, StoreSaleDto>().ReverseMap();

               cfg.CreateMap<Providers, ProviderDto>().ReverseMap();

               cfg.CreateMap<Purchase, PurchaseDto>().ReverseMap();

               cfg.CreateMap<PurchaseLine, PurchaseLineDto>().ReverseMap();

               cfg.CreateMap<Reception, ReceptionDto>().ReverseMap();

               cfg.CreateMap<Reception, ReceptionOrderDto>()
               .IncludeMembers(m=> m.Orders)
               .ReverseMap();

               cfg.CreateMap<Reception, ReceptionPurchaseDto>()
               .IncludeMembers(m => m.Purchase)
               .ReverseMap();

               cfg.CreateMap<ReceptionLine, ReceptionLineDto>().ReverseMap();

               cfg.CreateMap<Register, RegisterDto>().ReverseMap();

               cfg.CreateMap<Register, RegisterStoreDto>()
               .IncludeMembers(m=> m.Store)
               .ReverseMap();

               cfg.CreateMap<Register, RegisterWareHouseDto>()
               .IncludeMembers(m => m.WareHouse)
               .ReverseMap();

               cfg.CreateMap<WareHouse, RegisterWareHouseDto>()
               .ReverseMap();

               cfg.CreateMap<Store, RegisterStoreDto>()
               .ReverseMap();

               cfg.CreateMap<RegisterLine, RegisterLineDto>().ReverseMap();

               cfg.CreateMap<Reservation, ReservationDto>().ReverseMap();

               cfg.CreateMap<Reservation, ReservationOnlineDto>().ReverseMap();
               cfg.CreateMap<Reservation, ReservationStoreDto>().ReverseMap();

               cfg.CreateMap<ReservationStore, ReservationStoreDto>()
               .IncludeMembers(r=>r.Reservation).ReverseMap();

               cfg.CreateMap<ReservationOnline, ReservationOnlineDto>()
               .IncludeMembers(r => r.Reservation).ReverseMap();

               cfg.CreateMap<ReturnLine, ReturnLineDto>().ReverseMap();

               cfg.CreateMap<ReturnSale, ReturnSaleDto>().ReverseMap();

               cfg.CreateMap<Rol, RolDto>().ReverseMap();

               cfg.CreateMap<Orders, ReceptionOrderDto>().ReverseMap();
               cfg.CreateMap<Purchase, ReceptionPurchaseDto>().ReverseMap();

               cfg.CreateMap<Sale, SaleDto>().ReverseMap();

               cfg.CreateMap<SaleLine, SaleLineDto>().ReverseMap();

               cfg.CreateMap<Schedule, ScheduleDto>().ReverseMap();

               cfg.CreateMap<ScheduleLine, ScheduleLineDto>().ReverseMap();

               cfg.CreateMap<Shipping, ShippingDto>().ReverseMap();

               cfg.CreateMap<ShippingLine, ShippingLineDto>().ReverseMap();

               cfg.CreateMap<Socie, SocieDto>().IncludeMembers(s => s.Person).ReverseMap();

               cfg.CreateMap<Store, StoreDto>().ReverseMap();

               cfg.CreateMap<StoreSale, StoreSaleDto>().IncludeMembers(s => s.Sale);

               cfg.CreateMap<Taxes, TaxesDto>().ReverseMap();
             
               cfg.CreateMap<WareHouseBook, WareHouseBookDto>().ReverseMap();
               cfg.CreateMap<WareHouse, WareHouseDto>().ReverseMap();
           
             

       


           });
            
        }
    }
}
