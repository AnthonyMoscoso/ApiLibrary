using Models.Dtos;
using Business.BookStoreServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services.Abstracts;
using Models.Ado.Library;
using Core.DBAccess.Ado;
using Ado.Library;

namespace Business.BookStoreServices.Specifics
{
    public class DirectionService : ServiceMapperBase<DirectionDto, Direction>, IDirectionService
    {
        public DirectionService(IDirectionRepository repository) : base(repository)
        {
        }
    }
}
