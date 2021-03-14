using AutoMapper;
using BookStoreApi.Models.Library;
using BookStoreApi.Models.Request;
using System;

namespace Mappers.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<EmployeeRequest, Employee>(); 
            CreateMap<PersonRequest,Person> ();
            CreateMap<SocieRequest, Socie>();


         /*   CreateMap<EmployeeRequest,Employee>()
                .IncludeBase<PersonRequest,Person>();*/
           /* CreateMap<Socie, SocieRequest>()
                .IncludeBase<Socie,SocieRequest>();*/
        }
    }
}
