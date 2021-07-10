
using AutoMapper;
using Business.AutoMapper;
using Core.DBAccess.Ado;
using Core.Models.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services.Abstracts
{
    public abstract class ServiceMapperBase<TDtoEntity, TEntity> : IServices<TDtoEntity>
        where TDtoEntity : class, IEntity, new()
    {
        public IRepository<TEntity> _repository;
        public IMapper mapper;

        public string name;
        public ServiceMapperBase(IRepository<TEntity> repository)
        {
            _repository = repository;
            mapper = AutoMapperConfig.MapperConfiguration.CreateMapper();
            name = typeof(TEntity).Name;
        }

        public int Count()
        {
    
            int count = _repository.Count();
            return count;
        }

        public dynamic Delete(string id)
        {
            return _repository.Delete(id);
        }

        public dynamic Delete(IEnumerable<string> ids)
        {
            return _repository.Delete(ids as List<string>);
        }

        public TDtoEntity Get(string id)
        {
            TEntity result = _repository.GetSingle(id);
            if (result == null)
            {
                throw new System.Exception($"{name} with {id} was not found");
            }
            return mapper.Map<TDtoEntity>(result);
            
            
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
            IEnumerable<string> list = ids.Split(',').ToList();
            foreach (string id in list)
            {

                TEntity search = _repository.GetSingle(id);
                if (search != null)
                {
                    TDtoEntity dtoEntity = mapper.Map<TDtoEntity>(search);
                    yield return dtoEntity;
                }
            }
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
            return  _repository.Update(entities);
        }

     
    }
}
