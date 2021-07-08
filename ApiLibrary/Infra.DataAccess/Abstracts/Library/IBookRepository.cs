using Models.Ado.Library;
using Models.Dtos;
using System.Collections.Generic;
using Core.DBAccess.Ado;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Ado.Library
{
    public interface IBookRepository : IRepository<Book>
    {
        new dynamic Insert(Book entity);
        new dynamic Update(Book entity);
    }
}
