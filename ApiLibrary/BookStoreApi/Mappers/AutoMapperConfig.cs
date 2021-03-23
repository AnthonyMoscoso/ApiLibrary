using AutoMapper;
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
               cfg.CreateMap<EmployeeRequest, Employee>().ReverseMap();
               cfg.CreateMap<PersonRequest, Person>().ReverseMap();
               cfg.CreateMap<SocieRequest, Socie>().ReverseMap();

               cfg.CreateMap<EmployeeRequest, Person>();
               cfg.CreateMap<SocieRequest, Person>();


               cfg.CreateMap<Permit, PermitDto>().ReverseMap();
           });
            
        }
    }
}
