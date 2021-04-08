using AutoMapper;
using BookStoreApi.Dtos;
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
               cfg.CreateMap<Book, BookDto>().ReverseMap();
               cfg.CreateMap<BookType, BookTypeDto>().ReverseMap();
               cfg.CreateMap<BookStore, BookStoreDto>().ReverseMap();
               cfg.CreateMap<Person, PersonDto>().ReverseMap();
               cfg.CreateMap<Occupation, OccupationDto>().ReverseMap();
               cfg.CreateMap<Coupon, CouponDto>().ReverseMap();
               cfg.CreateMap<Direction, DirectionDto>().ReverseMap();
               cfg.CreateMap<PersonDto, Person>().ReverseMap();
               cfg.CreateMap<Store, StoreDto>().ReverseMap();
               cfg.CreateMap<Sale, SaleDto>().ReverseMap();
               cfg.CreateMap<Sale, StoreSaleDto>().ReverseMap();
               
               cfg.CreateMap<BookEditorial, BookEditorialDto>().ReverseMap();
               cfg.CreateMap<StoreSale, StoreSaleDto>()
               .IncludeMembers(s=> s.Sale).ReverseMap();
               cfg.CreateMap<Socie, SocieDto>()
               .IncludeMembers(s=> s.Person).ReverseMap();
               cfg.CreateMap<Employee, EmployeeDto>()
               .IncludeMembers(m=> m.Person).ReverseMap();                    
               cfg.CreateMap<Person,EmployeeDto>().ReverseMap();
               cfg.CreateMap<SocieDto, Person>().ReverseMap();
               cfg.CreateMap<Permit, PermitDto>().ReverseMap();
               cfg.CreateMap<Reception, ReceptionDto>().ReverseMap();
               cfg.CreateMap<WareHouseBook, WareHouseBookDto>().ReverseMap();
               cfg.CreateMap<WareHouse, WareHouseDto>().ReverseMap();
               cfg.CreateMap<Shipping, ShippingDto>().ReverseMap();
               cfg.CreateMap<ShippingLine, ShippingLineDto>().ReverseMap();
             
               cfg.CreateMap<Gender, GenderDto>().ReverseMap();
               cfg.CreateMap<BookEditorial, BookEditorialDto>().ReverseMap();

               cfg.CreateMap<Orders, OrderDto>().ReverseMap();

               cfg.CreateMap<OrderLine, OrderLineDto>().ReverseMap();
           });
            
        }
    }
}
