using AutoMapper;

using Negocios.AutoMapper;
using Nucleo.DBAccess.Ado;
using Nucleo.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Text;

namespace Nucleo.Services.Abstracts
{
    public abstract class ServiceMapperBase<TDtoEntity, TEntity> : IServices<TDtoEntity>
        where TDtoEntity : class, new()
    {
        public IRepository<TEntity> _repository;
        public IMapper mapper;
        public ICollection<MessageControl> messages;

        public string name;

        public ServiceMapperBase(IRepository<TEntity> repository)
        {
            _repository = repository;
            mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
            messages = new List<MessageControl>();
            name = typeof(TEntity).Name;

        }

        public int Count()
        {
            return _repository.Count();
        }

        public dynamic Delete(string id)
        {
            return _repository.Delete(id);
        }

        public dynamic Delete(IEnumerable<string> ids)
        {
            return _repository.Delete(ids as List<string>);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public TDtoEntity Get(string id)
        {
            return mapper.Map<TDtoEntity>(_repository.Get(id));
        }

        public IEnumerable<TDtoEntity> Get()
        {
            return mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get());
        }

        public IEnumerable<TDtoEntity> Get(int pag, int element)
        {
            return mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get(pag, element));
        }

        public IEnumerable<TDtoEntity> GetList(string ids)
        {
            return mapper.Map<IEnumerable<TDtoEntity>>(_repository.Get(ids));
        }

        public dynamic Insert(TDtoEntity dtoEntity)
        {
            TEntity entity = mapper.Map<TEntity>(dtoEntity);
            return _repository.Insert(entity);
        }

        public dynamic Insert(IEnumerable<TDtoEntity> list)
        {
            IEnumerable<TEntity> entities = mapper.Map<IEnumerable<TEntity>>(list);
            return _repository.Insert(entities);
        }

        public dynamic Update(TDtoEntity dtoEntity)
        {
            TEntity entity = mapper.Map<TEntity>(dtoEntity);
            return _repository.Update(entity);
        }

        public dynamic Update(IEnumerable<TDtoEntity> list)
        {
            IEnumerable<TEntity> entities = mapper.Map<IEnumerable<TEntity>>(list);
            return _repository.Update(entities);
        }

        public IEnumerable<TDtoEntity> Map(IEnumerable<TEntity> list)
        {
            return mapper.Map<IEnumerable<TDtoEntity>>(list);
        }
        public TDtoEntity Map(TEntity entity)
        {
            return mapper.Map<TDtoEntity>(entity);
        }
    }
}
