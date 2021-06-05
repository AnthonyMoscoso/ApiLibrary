using Models.Dtos;
using Negocios.BookStoreServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.BookStoreServices.Specifics
{
    public class DirectionService : IDirectionService
    {
        public DbContext _Context { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public dynamic Delete(string id)
        {
            throw new NotImplementedException();
        }

        public dynamic Delete(IEnumerable<string> ids)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DirectionDto Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DirectionDto> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DirectionDto> Get(int pag, int element)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DirectionDto> GetList(string ids)
        {
            throw new NotImplementedException();
        }

        public dynamic Insert(DirectionDto entity)
        {
            throw new NotImplementedException();
        }

        public dynamic Insert(IEnumerable<DirectionDto> list)
        {
            throw new NotImplementedException();
        }

        public dynamic Update(DirectionDto entity)
        {
            throw new NotImplementedException();
        }

        public dynamic Update(IEnumerable<DirectionDto> list)
        {
            throw new NotImplementedException();
        }
    }
}
