using AutoMapper;
using Models.Ado.Library;
using Models.Dtos;
using Models.Models.Dtos;
using System;

namespace Business.AutoMapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration MapperConfiguration;
        public static void RegisterMappings()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Autor, AutorDto>().ReverseMap();


                cfg.CreateMap<Book, BookDto>().ReverseMap();
                cfg.CreateMap<BookEditorial, BookEditorialDto>().ReverseMap();
                cfg.CreateMap<BookType, BookTypeDto>().ReverseMap();
                cfg.CreateMap<BookStore, BookStoreDto>().ReverseMap();

                cfg.CreateMap<Coupon, CouponDto>().ReverseMap();

                cfg.CreateMap<Direction, DirectionDto>().ReverseMap();

                cfg.CreateMap<Discount, DiscountDto>().ReverseMap();



                cfg.CreateMap<Edition, EditionDto>().ReverseMap();

                cfg.CreateMap<Editorial, EditorialDto>().ReverseMap();

                cfg.CreateMap<Employee, EmployeeDto>()
                 .IncludeMembers(m => m.Person).ReverseMap();



                cfg.CreateMap<Gender, GenderDto>().ReverseMap();



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
                .ForMember(x => x.IdOrder, y => y.MapFrom(z => z.Orders.IdOrder))
                .ReverseMap();

                cfg.CreateMap<Reception, ReceptionPurchaseDto>()
                  .ForMember(x => x.IdPurchase, y => y.MapFrom(z => z.Purchase.IdPurchase))
                .ReverseMap();

                cfg.CreateMap<ReceptionLine, ReceptionLineDto>().ReverseMap();

                cfg.CreateMap<Register, RegisterDto>().ReverseMap();

                cfg.CreateMap<Register, RegisterStoreDto>()
                .ForMember(r => r.IdStore, s => s.MapFrom(n => n.Store.IdStore))
                .ReverseMap();

                cfg.CreateMap<Register, RegisterWareHouseDto>()
                 .ForMember(r => r.IdWareHouse, s => s.MapFrom(w => w.WareHouse.IdWareHouse))
                .ReverseMap();

                cfg.CreateMap<RegisterLine, RegisterLineDto>().ReverseMap();

                cfg.CreateMap<Reservation, ReservationDto>().ReverseMap();

                cfg.CreateMap<Reservation, ReservationOnlineDto>().ReverseMap();
                cfg.CreateMap<Reservation, ReservationStoreDto>().ReverseMap();

                cfg.CreateMap<ReservationStore, ReservationStoreDto>()
                .IncludeMembers(r => r.Reservation).ReverseMap();

                cfg.CreateMap<ReservationOnline, ReservationOnlineDto>()
                .IncludeMembers(r => r.Reservation).ReverseMap();



                cfg.CreateMap<ReturnSale, ReturnSaleDto>()
                   .ForMember(r => r.IdStore, s => s.MapFrom(n => n.Store.IdStore))
                   .ForMember(r => r.IdWareHouse, s => s.MapFrom(n => n.WareHouse.IdWareHouse)).ReverseMap();

                cfg.CreateMap<Rol, RolDto>().ReverseMap();

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
